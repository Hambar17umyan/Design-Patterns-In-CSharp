using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    internal class ChristmasPresentBox : ICopyEmmitter<ChristmasPresentBox>
    {
        public decimal Price;
        public int Weight;
        public KnownColor CoverColor;
        public Qr Qr;

        private int ProductID;
        private DateTime ProductionTime;

        private IEnumerable<Candy> Candies;
        private LittleStars Stars;
        private Lights Lights;

        public ChristmasPresentBox GetCopy()
        {
            return new ChristmasPresentBox()
            {
                Price = Price,
                Weight = Weight,
                CoverColor = CoverColor,
                Qr = Qr.GetCopy(),
                ProductID = ProductID,
                ProductionTime = ProductionTime,
                Stars = Stars.GetCopy(),
                Lights = Lights.GetCopy(),
                Candies = Candies.GetCopy()
            };
        }
    }

    static class Extensions
    {
        public static IEnumerable<T> GetCopy<T>(this IEnumerable<T> coll) where T : ICopyEmmitter<T>
        {
            return coll.Select(x => x.GetCopy());
        }
    }
}

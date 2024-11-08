using System.Drawing;

namespace Prototype_Pattern
{
    internal class Candy : ICopyEmmitter<Candy>
    {
        public KnownColor CoverColor;
        public string Name;
        public string[] Ingredients;
        public DateTime ProductionDate;

        public Candy GetCopy()
        {
            string[] newIngr = new string[Ingredients.Length];
            Ingredients.CopyTo(newIngr, Ingredients.Length);
            return new Candy()
            {
                CoverColor = CoverColor,
                Name = Name,
                Ingredients = newIngr,
                ProductionDate = ProductionDate
            };
        }
    }
}
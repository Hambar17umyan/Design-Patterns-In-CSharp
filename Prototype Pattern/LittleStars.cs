namespace Prototype_Pattern
{
    internal class LittleStars : ICopyEmmitter<LittleStars>
    {
        public int Quantity;

        public LittleStars GetCopy()
        {
            return new LittleStars() { Quantity = Quantity };
        }

        public void MakeSound()
        {
            Console.WriteLine("Meeeerry Christmas!!!");
        }
    }
}
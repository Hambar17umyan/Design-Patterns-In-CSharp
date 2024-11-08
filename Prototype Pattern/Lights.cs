namespace Prototype_Pattern
{
    internal class Lights : ICopyEmmitter<Lights>
    {
        public Lights GetCopy()
        {
            return new Lights();
        }

        public void Shine()
        {
            Console.WriteLine(
@"***   *** ********* ***       ***       *********
***   *** ***       ***       ***       *********
********* ********* ***       ***       ***   ***
********* ********* ***       ***       ***   ***
***   *** ***       ********* ********* *********
***   *** ********* ********* ********* *********            ");
        }
    }
}
namespace Builder_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new FilterBuilder();
            var filter = builder.SortByLastName().FilterWithAgeLessThan(27).FilterWithGender(Gender.Male).BuildFilter();
        }
    }
}

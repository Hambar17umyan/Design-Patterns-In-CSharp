using System.Diagnostics;

namespace Singleton_Pattern
{
    internal class Program
    {
        public class Pet
        {
            public int ID;
        }
        static void Main(string[] args)
        {
            Government government = Government.GetGovernmentInstance();
            Government government1 = Government.GetGovernmentInstance();

            if (government1.GovernmentMoney13Percent() == government.GovernmentMoney13Percent())
                Console.WriteLine("Singleton works!!!!!");
            else Console.WriteLine("Singleton does not work!");
        }

        
    }
}

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    interface IPizzaFactory
    {
        IPepperoniPizza MakePepperoni();
        ICheesePizza MakeCheesePizza();
        IMargarithaPizza MakeMargarithaPizza();
    }

    interface IPepperoniPizza
    {

    }

    interface ICheesePizza
    {

    }

    interface IMargarithaPizza
    {

    }


}

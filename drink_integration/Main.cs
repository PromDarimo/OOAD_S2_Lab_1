using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace drink_integration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractDrink drink = new Drink("MyDrink");
            Console.WriteLine(drink.Descr);
            Console.WriteLine("\n>Milk decorated");
            drink = new MilkMixing("My Boy", 3, drink);
            Console.WriteLine(drink.Descr);
            Console.WriteLine("\n>Then Coffee decorated");
            drink = new CoffeeMixing("Arabica", 2, drink);
            Console.WriteLine(drink.Descr);
            Console.WriteLine("\n>Then Sugar decorated");
            //drink = new SugarMixing("Mitaphon", 1, drink);
            //Console.WriteLine(drink.Descr);
            //Console.WriteLine("\n>Then Water decorated");
            //drink = new WaterMixing("Eviant", 10, drink);
            //Console.WriteLine(drink.Descr);
        }
    }
}

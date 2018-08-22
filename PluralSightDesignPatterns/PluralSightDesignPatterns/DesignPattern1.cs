using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluralSightDesignPatterns.DesignPattern;

namespace PluralSightDesignPatterns
{
    class DesignPattern1
    {
        static void Main(string[] args)
        {

            //Non-adapted
            Meat unknown = new Meat("Beef");
            unknown.LoadData();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            //promenne
            string jablkoString, hrozenString;
            double jablka, hrozen, jableMost, vino,celkem;

            //zadavani hodnot
            Console.WriteLine("pro vynechani ovoce zadej 0\nzadej pocet jablek v kg: ");
            jablkoString = Console.ReadLine();
            double.TryParse(jablkoString, out jablka);

            Console.WriteLine("zadej pocet hroznu v kg: ");
            hrozenString = Console.ReadLine();
            double.TryParse(hrozenString, out hrozen);

            //pocitani hodnot
            jableMost= jablka*0.6;
            vino = hrozen * 0.85;
            celkem = hrozen + jablka;

            //vypis vypocitanych hodnot
            Console.WriteLine("\nPocet hroznu v kg: "+ hrozenString);
            Console.WriteLine("Pocet jablek v kg: "+ jablkoString);
            Console.WriteLine("\nLitru jablecneho mostu: "+ jableMost);
            Console.WriteLine("Litru vina: "+ vino);
            Console.WriteLine("\nCelkem bylo " + celkem + "kg ovoce");
            celkem = jableMost + vino;
            Console.WriteLine("\nCelkem bylo " + celkem + "l stavy");

            Console.Read();
        }
    }
}

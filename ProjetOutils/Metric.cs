using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOutils
{
    internal class Metric
    {
        public Metric()
        {
            double grams;
            double mètre;
            double litres;
            double yards;
            double ounces;
            double gallons;

            Console.WriteLine("\n\t\t\t\tBienvenue au programme de " +
                "conertisseur de Metric et de Imperial");
            Console.WriteLine("\t\t\t\t Entre mètre pour la convertire en yards ");
            Console.WriteLine("\t\t\t\t Entre yards pour la convertire en mètre ");
            Console.WriteLine("\t\t\t\t Entre grams pour la convertire en ounces ");
            Console.WriteLine("\t\t\t\t Entre ounces pour la convertire en grams ");
            Console.WriteLine("\t\t\t\t Entre litre pour la convertire en gallons ");
            Console.WriteLine("\t\t\t\t Entre gallons pour la convertire en litre ");

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "metre" || line.ToLower() == "Metre" ||
                    line.ToLower() == "mètre" || line.ToLower() == "Métre")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de mètre en yards.");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");

                    mètre = Convert.ToDouble(Console.ReadLine());
                    yards = mètre * 1.0936;
                    Console.WriteLine($"La conversion en years est: {yards} yd");
                    Console.ReadKey();
                }
                else if (line.ToLower() == "yards" || line.ToLower() == "Yards")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de " +
                        "Yards en mètre");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");


                    yards = Convert.ToDouble(Console.ReadLine());
                    mètre = yards * 1.09144; 
                    Console.WriteLine($"La conversion en mètre est: {yards} CAN");
                    Console.ReadKey();

                }
            }
        }


    }
}

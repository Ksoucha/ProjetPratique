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
                string? line = Console.ReadLine()?.ToLower();

                if (line == "mètre")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de mètre en yards.");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");

                    mètre = Convert.ToDouble(Console.ReadLine());
                    yards = mètre * 1.09361;
                    Console.WriteLine($"La conversion en years est: {yards} yd");
                  
                }
                else if (line == "yards")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de " +
                        "Yards en Mètre");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");


                    yards = Convert.ToDouble(Console.ReadLine());
                    mètre = yards * 0.9144;
                    Console.WriteLine($"La conversion en mètre est: {mètre} mètre");
                    
                }
                else if (line == "grams")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de " +
                        "Grams en Ounces");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");


                    grams = Convert.ToDouble(Console.ReadLine());
                    ounces = grams * 0.035274;
                    Console.WriteLine($"La conversion en Grams est: {ounces} Ounces");
                   
                }
                else if (line == "ounces")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de " +
                        "Ounces en Grams");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");


                    ounces = Convert.ToDouble(Console.ReadLine());
                    grams = ounces * 28.3495;
                    Console.WriteLine($"La conversion en Grams est: {grams} Grams");
                   
                }

                else if (line == "litre")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de " +
                        "Litre en Gallons");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");


                    litres = Convert.ToDouble(Console.ReadLine());
                    gallons = litres * 0.2641720524;
                    Console.WriteLine($"La conversion en Litres est: {gallons} Gallons");
                   
                }
                else if (line == "gallons")
                {
                    Console.WriteLine("Bienvenuau au convertisseur de " +
                        "Litre en Gallons");
                    Console.WriteLine("Qu'elle est la convertission que vous voulez faire ?");


                    gallons = Convert.ToDouble(Console.ReadLine());
                    litres = gallons * 3.785411785;
                    Console.WriteLine($"La conversion en Gallons est: {litres} Litres");
                   
                }
               
                Console.WriteLine("\nMerci d'avoir utilisé l'outil Metric!");
                
                
            }
        }
    }
}


              
      
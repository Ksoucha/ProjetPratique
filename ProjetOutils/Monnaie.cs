using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOutils
{
    internal class Monnaie
    {
        public Monnaie()
        {
            Console.WriteLine("Bienvenue à l'outil Monnaie.\n");
            Console.WriteLine("Entrez C pour le mode en dollars Canadiens, U pour le mode en dollars US, ou E pour le mode en dollars Euro.");

            // Taux de conversion en date du 25 septembre 2023
            double USDtoCADRate = 1.35; // 1 USD = 1.35 CAD
            double USDtoEuroRate = 0.94; // 1 USD = 0.94 Euro
            double CADtoUSDRate = 0.74; // 1 CAD = 0.74 USD
            double CADtoEuroRate = 0.70; // 1 CAD = 0.70 Euro
            double EurotoCADRate = 1.44; // 1 Euro = 1.44 CAD
            double EurotoUSDRate = 1.06; // 1 Euro = 1.06 USD

            double montant = 0.0;
            string? monnaiedesiree = "";
            string? montantline;
            // double resultat = 0.0;
            // double resultat2 = Math.Round(resultat, 2);

            while (true)
            {
                string? Line = Console.ReadLine();
                if (Line == "c" || Line == "C")
                {
                    Console.WriteLine("Bienvenue en mode dollars Canadiens.");
                    Console.WriteLine("\n \n Entrez le montant en CAD: \n \n");
                    montantline = Console.ReadLine();
                    montant = Convert.ToDouble(montantline);
                    Console.WriteLine("\n \n Entrez la monnaie désirée (U ou E): \n \n");
                    monnaiedesiree = Console.ReadLine();

                    if (monnaiedesiree == "U" || monnaiedesiree == "u")
                    {
                        montant = montant * CADtoUSDRate;
                        montant = Math.Round(montant, 2);
                        Console.WriteLine($"Le montant en dollars US: {montant}");
                    }
                    else if (monnaiedesiree == "e" || monnaiedesiree == "E")
                    {
                        montant = montant * CADtoEuroRate;
                        montant = Math.Round(montant, 2);
                        Console.WriteLine($"Le montant en dollars Euro: {montant}");
                    }
                    break;
                }
                else if (Line == "u" || Line == "U")
                {
                    Console.WriteLine("Bienvenue en mode dollars US.");
                    Console.WriteLine("\n \n Entrez le montant en USD: \n \n");
                    montantline = Console.ReadLine();
                    montant = Convert.ToDouble(montantline);
                    Console.WriteLine("\n \n Entrez la monnaie désirée (C ou E): \n \n");
                    monnaiedesiree = Console.ReadLine();

                    if (monnaiedesiree == "c" || monnaiedesiree == "C")
                    {
                        montant = montant * USDtoCADRate;
                        montant = Math.Round(montant, 2);
                        Console.WriteLine($"Le montant en dollars Canadiens: {montant}");
                    }
                    else if (monnaiedesiree == "e" || monnaiedesiree == "E")
                    {
                        montant = montant * USDtoEuroRate;
                        montant = Math.Round(montant, 2);
                        Console.WriteLine($"Le montant en dollars Euro: {montant}");
                    }

                    break;
                }
                else if (Line == "E" || Line == "e")
                {
                    Console.WriteLine("Bienvenue en mode dollars Euro.");
                    Console.WriteLine("\n \n Entrez le montant en Euro: \n \n");
                    montantline = Console.ReadLine();
                    montant = Convert.ToDouble(montantline);
                    Console.WriteLine("\n \n Entrez la monnaie désirée (U ou C): \n \n");
                    monnaiedesiree = Console.ReadLine();

                    if (monnaiedesiree == "c" || monnaiedesiree == "C")
                    {
                        montant = montant * EurotoCADRate;
                        montant = Math.Round(montant, 2);
                        Console.WriteLine($"Le montant en dollars Canadiens: {montant}");
                    }
                    else if (monnaiedesiree == "u" || monnaiedesiree == "U")
                    {
                        montant = montant * EurotoUSDRate;
                        montant = Math.Round(montant, 2);
                        Console.WriteLine($"Le montant en dollars US: {montant}");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Assurez-vous de taper soit C, U ou E");
                }
            }

            Console.WriteLine("Merci d'avoir utilisé l'outil Monnaie!");

        }

    }
}

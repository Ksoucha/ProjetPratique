// See https://aka.ms/new-console-template for more information
using ProjetOutils;
using System.ComponentModel.Design;

Console.WriteLine("\t\t\t\t\t\tVous aimeriez accéder à l'option " +
    "\n\t\t\t\t\t\t\t Monnaie ou Metric ou bien, Quiz");

while (true)
{
    string line = Console.ReadLine();
    if (line.ToLower() == "monnaie" || line.ToLower() == "monnais")
    {
        new Monnaie();
    }
    else if (line.ToLower() == "Quiz" || line.ToLower() == "quiz")
    {
        new Quiz();
    }
    else if (line.ToLower() == "metric" || line.ToLower() == "Metric")
    {
        new Metric();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("S'il vous plait écriver la bonne chose");
        Console.ResetColor();
    }
}
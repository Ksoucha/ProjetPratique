using ProjetOutils;
using System.ComponentModel.Design;

Console.WriteLine("\t\t\t\t\t\tBonjours vous aimeriez accéder à l'option " +
    "\n\t\t\t\t\t\t\t Monnaie ou Metric ou bien, Quiz");

while (true)
{
    string line = Console.ReadLine();
    if (line == "monnaie")
    {
        new Monnaie();
    }
    else if (line == "quiz")
    {
        new Quiz();
    }
    else if (line == "metric")
    {
        new Metric();
    }
    else
        Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("S'il vous plait écriver la bonne chose");
    Console.ResetColor();
}
  
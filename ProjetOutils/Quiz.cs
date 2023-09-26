using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOutils
{
    internal class Quiz
    {

        string[] capitales = {
            "Amsterdam", "Taipei", "Rome", "London",
            "Beijing", "Cairo", "Brasília"
        };

        string[] pays = {
            "Netherlands", "Taiwan", "Italy", "United Kingdom",
            "China", "Egypt", "Brazil"
        };

        int totalQuestions = 4; // Dépendamment du nombre de questions de l'on veut avoir
        int correctAnswers = 0;
        Random random = new Random();

        public Quiz()
        {
            Console.WriteLine("Bienvenue à l'outil Quiz.\n");
            Console.WriteLine("Vous aurez 4 questions sur 4 capitales du monde au hasard.\n");


            string? userAnswer;
            int n = random.Next(10);
            Console.WriteLine($"n = {n}");

            int  randomIndex = random.Next(capitales.Length);

            Console.WriteLine($"Question {n + 1}: Quelle est la capitale de {pays[randomIndex]}?");
            userAnswer = Console.ReadLine();

            if (userAnswer.Equals(capitales[randomIndex], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Bonne réponse!\n");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"C'est incorrect. La bonne réponse est {capitales[randomIndex]}.\n");
            }
        }
        
        
    }


}
        
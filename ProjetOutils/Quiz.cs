using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOutils
{
    internal class Quiz
    {
        string[] capitales = {
            "Berlin", "Paris", "Rome", "Tokyo", "London",
            "Beijing", "Moscow", "Cairo", "Ottawa", "Brasília"
        };

        string[] pays = {
            "Germany", "France", "Italy", "Japan", "United Kingdom",
            "China", "Russia", "Egypt", "Canada", "Brazil"
        };

        int totalQuestions = 4; // Dépendamment du nombre de questions de l'on veut avoir
        int correctAnswers = 0;
        Random random = new Random();

        public Quiz()
        {
            int n = random.Next(10);
        }
        
        
    }


}
        
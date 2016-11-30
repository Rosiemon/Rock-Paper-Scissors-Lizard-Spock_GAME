using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public int score;
        public int choice;

        public void MakeChoice()
        {
                Random random = new Random();
                int number = random.Next(1, 4);
                Console.WriteLine("\nPlease choose between these options: \n");
                Console.WriteLine("SELECT [1] ROCK");
                Console.WriteLine("SELECT [2] PAPER");
                Console.WriteLine("SELECT [3] SCISSORS");
                Console.WriteLine("SELECT [4] LIZARD");
                Console.WriteLine("SELECT [5] SPOCK");
                string userInput = Console.ReadLine();
                choice = int.Parse(userInput);
          }

        public int GetScore()
        {
            return score;
        }

        public int AddPoint()
        {
            score ++;
            return score;

        }
    }
}

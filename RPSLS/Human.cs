using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public int MakeUserChoice()
        {
            Console.WriteLine("PLEASE SELECT AN OPTION:");
            Console.WriteLine("");
                Console.WriteLine("SELECT [1] ROCK");
                Console.WriteLine("SELECT [2] PAPER");
                Console.WriteLine("SELECT [3] SCISSORS");
                Console.WriteLine("SELECT [4] LIZARD");
                Console.WriteLine("SELECT [5] SPOCK");
            int userChoice = int.Parse( Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    choice = userChoice;
                        break;
                default: Console.WriteLine("/nINVALID INPUT \n");
                    break;
            }
            return userChoice;
        }
    }
}

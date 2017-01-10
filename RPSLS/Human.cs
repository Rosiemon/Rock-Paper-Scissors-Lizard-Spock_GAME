using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        
        public override void GetName()
        {
            Console.WriteLine("\nPLEASE ENTER YOUR NAME \n");
            name = Console.ReadLine().ToUpper();
            if (name.Equals(""))
            {
                Console.WriteLine("\nINVALID INPUT \n");
                GetName();
            }
        }
        public override void MakeChoice()
        {
            Console.WriteLine("\nPlease choose between these options:");
            Console.WriteLine("SELECT [1] ROCK");
            Console.WriteLine("SELECT [2] PAPER");
            Console.WriteLine("SELECT [3] SCISSORS");
            Console.WriteLine("SELECT [4] LIZARD");
            Console.WriteLine("SELECT [5] SPOCK \n");
            string userInput = Console.ReadLine();
            if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5")
            {
                choice = int.Parse(userInput);
            }
            else 
            {
                Console.WriteLine("/nINVALID INPUT \n");
                MakeChoice();
            }
        }
    }
}
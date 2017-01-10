using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        List<string> Rules = new List<string>();
        List<int> choices = new List<int> { 1, 2, 3, 4, 5};
        Player playerOne;
        Player playerTwo;
        public void StartGame()
        {
            AskForRules();
            PlayGame();
        }
        public void PlayGame()
        {
            GetPlayers();
            ChoosePlayerNames();
            while ((playerOne.GetScore() < 2 && (playerTwo.GetScore() < 2)))
            {
                playerOne.MakeChoice();
                EvaluateChoice();
            }
            EndGame();
        }
        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("\n||| WELCOME TO ROCK PAPER SCISSORS LIZARD SPOCK |||");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n"); Console.ResetColor();
        }
        public void AskForRules()
        {
            Console.WriteLine("WOULD YOU LIKE TO SEE THE RULES?");
            Console.WriteLine("SELECT [1] YES");
            Console.WriteLine("SELECT [2] NO \n");
            string input = Console.ReadLine().ToLower();
            if (input == "1" || input == "y")
            {
                DisplayRules();
            }
            else if (input == "2" || input == "n")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \nSELECT [1] YES \nSELECT [2] NO\n");
                Console.WriteLine("");
                GetPlayers();
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("\nPLEASE SEE THE RULES BELOW: \n>>>>>>>>>>");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("SCISSORS CUTS PAPER \nPAPER COVERS ROCK \nROCK CRUSHES LIZARD \nLIZARD POISONS SPOCK \nSPOCK SMASHES SCISSORS \nSCISSORS DECAPITES LIZARD \nLIZARD EATS PAPER \nPAPER DISPROVES SPOCK \nSPOCK VAPORIZES ROCK \nROCK CRUSHES SCISSORS \n");
            Console.ResetColor();
        }

        public void GetPlayers()
        {
            Console.WriteLine("PLEASE SELECT NUMBER OF PLAYERS:");
            Console.WriteLine("SELECT [1] ONE PLAYER");
            Console.WriteLine("SELECT [2] TWO PLAYERS \n");
            string input = Console.ReadLine();
            if (input == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
                Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("You selected SINGLE PLAYER \n"); Console.ResetColor();
            }
            else if (input == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
                Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("You selected MULTI-PLAYER \n"); Console.ResetColor();
            }
            else 
            {
                Console.WriteLine("\nINVALID INPUT \nPlease Select [1] or [2] players \n");
                GetPlayers();
            }
        }
        public void ChoosePlayerNames()
        {
            playerOne.GetName();
            playerTwo.GetName();
            
        }
        public void EvaluateChoice()
        {
            if (playerOne.choice == 1)
            {
                RunRock();
            }
            else if (playerOne.choice == 2)
            {
                RunPaper();
            }
            else if (playerOne.choice == 3)
            {
                RunScissors();
            }
            else if (playerOne.choice == 4)
            {
                RunLizard();
            }
            else if (playerOne.choice == 5)
            {
                RunSpock();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                playerOne.MakeChoice();
            }
        }
        public void RunRock()
        {
            playerTwo.MakeChoice();
            if (playerTwo.choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: ROCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: ROCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nIT'S A DRAW!!!!\n"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: ROCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: PAPER", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: ROCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SCISSORS", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: ROCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: LIZARD", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: ROCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SPOCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                RunRock();
            }
        }
        public void RunPaper()
        {
            playerTwo.MakeChoice();
            if (playerTwo.choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: PAPER", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: ROCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: PAPER", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: PAPER", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nIT'S A DRAW!!!! \n"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: PAPER", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SCISSORS", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: PAPER", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: LIZARD", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: PAPER", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SPOCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                RunPaper();
            }
        }
        public void RunScissors()
        {
            playerTwo.MakeChoice();
            if (playerTwo.choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SCISSORS", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: ROCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 2) 
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SCISSORS", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: PAPER", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor(); ;
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SCISSORS", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SCISSORS", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nIT'S A DRAW!!!! \n"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SCISSORS", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: LIZARD", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SCISSORS", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SPOCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                RunScissors();
            }
        }
        public void RunLizard()
        {
            playerTwo.MakeChoice();
            if (playerTwo.choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: LIZARD", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: ROCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: LIZARD", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: PAPER", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: LIZARD", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SCISSORS", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: LIZARD", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: LIZARD", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nIT'S A DRAW!!!! \n"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: LIZARD", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SPOCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                RunLizard();
            }
        }

        public void RunSpock()
        {
            playerTwo.MakeChoice();
            if (playerTwo.choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SPOCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: ROCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SPOCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: PAPER", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SPOCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SCISSORS", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} WON! \n{1} LOST! \n", playerOne.name, playerTwo.name); playerOne.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SPOCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: LIZARD", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\n{0} LOST! \n{1} WON! \n", playerOne.name, playerTwo.name); playerTwo.AddPoint(); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else if (playerTwo.choice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: SPOCK", playerOne.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: SPOCK", playerTwo.name); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nIT'S A DRAW!!!! \n"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("\n{0}: {1}", playerOne.name, playerOne.GetScore()); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("{0}: {1}", playerTwo.name, playerTwo.GetScore()); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                RunSpock();
            }
        }
        public void EndGame()
        {
            Console.WriteLine("\nWould you like to play again? \nSELECT [Y] YES \nSELECT [N] NO \n");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y" || userInput == "yes")
            {
                StartGame();
            }
            else if (userInput == "N" || userInput == "no")
            {
                Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\nTHANK YOU FOR PLAYING \npress any key to close the game . . . . . . . . . . \n"); Console.ResetColor();
                Console.ReadKey();  Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                EndGame();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        List<string> Rules = new List<string>();
        Player playerOne;
        Player playerTwo;

        public void PlayGame()
        {
            DisplayWelcomeMessage();
            DisplayRules();
            GetPlayers();

            while ((playerOne.GetScore() < 2 && (playerTwo.GetScore() < 2)))
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                EvaluateChoice();
            }
            EndGame();
        }


        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("||| WELCOME TO ROCK PAPER SCISSORS LIZARD SPOCK |||");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
        }


        public void DisplayRules()
        {
            Rules.Add("PLEASE SEE THE RULES BELOW:");
            Rules.Add(">>>>>>>>>>");
            Rules.Add("SCISSORS CUTS PAPER");
            Rules.Add("PAPER COVERS ROCK");
            Rules.Add("ROCK CRUSHES LIZARD");
            Rules.Add("LIZARD POISONS SPOCK");
            Rules.Add("SPOCK SMASHES SCISSORS");
            Rules.Add("SCISSORS DECAPITES LIZARD");
            Rules.Add("LIZARD EATS PAPER");
            Rules.Add("PAPER DISPROVES SPOCK");
            Rules.Add("SPOCK VAPORIZES ROCK");
            Rules.Add("ROCK CRUSHES SCISSORS");
            Rules.Add("<<<<<<<<<<");
            Rules.Add("");

            foreach (string Rule in Rules)
            {
                Console.WriteLine(Rule);
            }
        }

        public void GetPlayers()
        {
            Console.WriteLine("PLEASE SELECT NUMBER OF PLAYERS:");
            Console.WriteLine("SELECT [1] ONE PLAYER");
            Console.WriteLine("SELECT [2] TWO PLAYERS");
            string input = Console.ReadLine();

            if (input == ("1"))
            {
                playerOne = new Human();
                playerTwo = new Computer();
                Console.WriteLine("");
                Console.WriteLine("You selected SINGLE PLAYER");
            }
            else if (input == ("2"))
            {
                playerOne = new Human();
                playerTwo = new Human();
                Console.WriteLine("");
                Console.WriteLine("You selected MULTI-PLAYER");
            }
            else 
            {
                Console.WriteLine("Please Select [1] or [2] players");
                Console.WriteLine("");
                GetPlayers();
            }

        }

        public void EvaluateChoice()
        {

            switch (playerOne.choice)
            {
                case 1: RunRock();
                    break;
                case 2: RunPaper();
                    break;
                case 3: RunScissors();
                    break;
                case 4: RunLizard();
                    break;
                case 5: RunSpock();
                    break;
                default: Console.WriteLine("\nINVALID INPUT \n");
                    playerOne.MakeChoice();
                    break;
            } 
        }

                public void RunRock()
        {
            switch (playerTwo.choice)
            {
                        case 1: // computer choose paper
                            Console.WriteLine("\nPlayer One: ROCK \nPlayer Two: PAPER \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 2: // computer choose rock
                            Console.WriteLine("\nPlayer One: ROCK \nPlayer Two: ROCK \n>>> IT'S A DRAW!!!! <<< \n");
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 3: // computer choose scissors
                            Console.WriteLine("\nPlayer One: ROCK \nPlayer Two: SCISSORS \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 4: // computer choose lizard
                            Console.WriteLine("\nPlayer One: ROCK \nPlayer Two: LIZARD \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 5: // computer choose spock
                            Console.WriteLine("\nPlayer One: ROCK \nPlayer Two: SPOCK \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                    default: Console.WriteLine("\nINVALID INPUT \n");
                    RunRock();
                    break;
            }
        }

        public void RunPaper()
        {
            switch (playerTwo.choice)
            {
                        case 1: // computer choose paper
                            Console.WriteLine("\nPlayer One: PAPER \nPlayer Two: PAPER \n>>> IT'S A DRAW!!!! <<< \n");
                            break;
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                case 2: // computer choose rock
                            Console.WriteLine("\nPlayer One: PAPER \nPlayer Two: ROCK \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 3: // computer choose scissors
                            Console.WriteLine("\nPlayer One: PAPER \nPlayer Two: SCISSORS \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 4: // computer choose lizard
                            Console.WriteLine("\nPlayer One: PAPER \nPlayer Two: LIZARD \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 5: // computer choose spock
                            Console.WriteLine("\nPlayer One: PAPER \nPlayer Two: SPOCK \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                    default: Console.WriteLine("\nINVALID INPUT \n");
                    RunPaper();
                    break;
            }
        }

        public void RunScissors()
        {
            switch (playerTwo.choice)
            {
                        case 1: // computer choose paper
                            Console.WriteLine("\nPlayer One: SCISSORS \nPlayer Two: PAPER \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 2: // computer choose rock
                            Console.WriteLine("\nPlayer One: SCISSORS \nPlayer Two: ROCK \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 3: // computer choose scissors
                            Console.WriteLine("\nPlayer One: SCISSORS \nPlayer Two: SCISSORS \n>>> IT'S A DRAW!!!! <<< \n");
                            break;
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                case 4: // computer choose lizard
                            Console.WriteLine("\nPlayer One: SCISSORS \nPlayer Two: LIZARD \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 5: // computer choose spock
                            Console.WriteLine("\nPlayer One: SCISSORS \nPlayer Two: SPOCK \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                    default: Console.WriteLine("\nINVALID INPUT \n");
                    RunScissors();
                    break;
            }
        }

        public void RunLizard()
        {
            switch (playerTwo.choice)
            {
                        case 1: // computer choose paper
                            Console.WriteLine("\nPlayer One: LIZARD \nPlayer Two: PAPER \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 2: // computer choose rock
                            Console.WriteLine("\nPlayer One: LIZARD \nPlayer Two: ROCK \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 3: // computer choose scissors
                            Console.WriteLine("\nPlayer One: LIZARD \nPlayer Two: SCISSORS \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 4: // computer choose lizard
                            Console.WriteLine("\nPlayer One: LIZARD \nPlayer Two: LIZARD \n>>> IT'S A DRAW!!!! <<< \n");
                            break;
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                case 5: // computer choose spock
                            Console.WriteLine("\nPlayer One: LIZARD \nPlayer Two: SPOCK \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                    default: Console.WriteLine("\nINVALID INPUT \n");
                    RunLizard();
                    break;
            }
        }

        public void RunSpock()
        { 
            switch (playerTwo.choice)
            { 
                        case 1: // computer choose paper
                                Console.WriteLine("\nPlayer One: SPOCK \nPlayer Two: PAPER \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 2: // computer choose rock
                                Console.WriteLine("\nPlayer One: SPOCK \nPlayer Two: ROCK \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 3: // computer choose scissors
                                Console.WriteLine("\nPlayer One: SPOCK \nPlayer Two: SCISSORS \n>>> PLAYER ONE WON! <<< \n>>> PLAYER TWO LOST! <<< \n>>>");
                    playerOne.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 4: // computer choose lizard
                                Console.WriteLine("\nPlayer One: SPOCK \nPlayer Two: LIZARD \n>>> PLAYER ONE LOST! <<< \n >>> PLAYER TWO WON! <<< \n");
                    playerTwo.AddPoint();
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                    break;
                        case 5: // computer choose spock
                                Console.WriteLine("\nPlayer One: SPOCK \nPlayer Two: SPOCK \n>>> IT'S A DRAW!!!! <<< \n");
                                break;
                    Console.WriteLine("Player One: {0}", playerOne.GetScore());
                    Console.WriteLine("Player Two: {0}", playerTwo.GetScore());
                default: Console.WriteLine("\nINVALID INPUT \n");
                    RunSpock();
                    break;
                }
            }

        public void EndGame()
        {
            Console.WriteLine("\nWould you like to play again? \nSelect [Y] Yes \nSelect [N] No \n");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                PlayGame();
            }
            else if (userInput == "N" || userInput == "n")
            {
                Console.WriteLine("THANK YOU FOR PLAYING \npress any key to close the game.......... \n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                EndGame();
            }
        }
        }

    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables
        int totalRounds;
        int winsNeeded;

        //constructor
        public Game()
        {

        }

        //methods
        public void RunGame()
        {
            //Introduction & Base Menu
            DisplayWelcome();
            BaseMenu();

        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Siccors, Lizard, Spock!");
        }

        public void DisplayRules()
        {
            Console.Clear();
            Console.WriteLine("RPSLS is a Head to Head Game played either between two players");
            Console.WriteLine("A game can be played as a single player vs. the computer or two player head to head");
            Console.WriteLine("Each game consists of multiple rounds in a 'best of' format");
            Console.WriteLine("Prior to each game, the total number of rounds will be determined");
        }

        public void BaseMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. See Rules");
            Console.WriteLine("2. Play Single Player Game vs. Computer");
            Console.WriteLine("3. Play Two Player Game vs. an Opponent");
            Console.WriteLine("4. Quit Game");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Response, Please try again");
                    Console.WriteLine();
                    BaseMenu();
                    break;
            }


        }

        public void DetermineRounds()
        {
            Console.Clear();
            Console.WriteLine("How many rounds would you like to play?");
            Console.WriteLine("Minimum 3 Rounds.  Must be an odd number!");
            string userInput;
            userInput = Console.ReadLine();
            if (IsInteger(userInput) == true && ValidateRounds(int.Parse(userInput)) == true)
            {
                totalRounds = int.Parse(userInput);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Response.");
                Console.WriteLine("Please enter an odd number 3 or higher.");
                DetermineRounds();
            }


        }

        public bool ValidateRounds(int rounds)
        {
            if (rounds >= 3 && rounds % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsInteger(string input)
        {
            int response;
            if(int.TryParse(input, out response))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

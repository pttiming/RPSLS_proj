using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("");
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
    }
}

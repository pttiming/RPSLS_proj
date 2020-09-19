using System;
using System.Collections.Generic;
using System.Data;
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
        double winsNeeded;
        int roundCount = 1;
        Players playerOne;
        Players playerTwo;

        //constructor
        public Game()
        {
            playerOne = new Human();
        }

        //methods
        public void RunGame()
        {
            //Introduction & Base Menu
            DisplayWelcome();
            BaseMenu();

            //Basic Setup
            GetPlayerNames();
            DetermineRounds();
            WinsNeeded(totalRounds);

            //GamePlay
            while (playerOne.playerScore < winsNeeded && playerTwo.playerScore < winsNeeded)
            {
                PlayRound();
                DisplayScore();
            }
            //End Game
            DisplayWinner();
            PlayAgain();
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        }

        public void DisplayRules()
        {
            Console.Clear();
            Console.WriteLine("RPSLS is a Head to Head Game very similar to Rock,Paper,Scissors");
            Console.WriteLine("A game can be played as a single player vs. the computer or two player head to head");
            Console.WriteLine("Each game consists of multiple rounds in a 'best of' format");
            Console.WriteLine("Prior to each game, the total number of rounds will be determined");
            Console.WriteLine("If a round ends in a 'Draw' that round is replayed");
            Console.WriteLine("Each Player will select a gesture, which will then be compared.");
            Console.WriteLine("");
            Console.WriteLine("The winner of the round will be determined by the following rules:");
            Console.WriteLine("Rock Crushes Scissors");
            Console.WriteLine("Scissors Cuts Paper");
            Console.WriteLine("Paper Covers Rock");
            Console.WriteLine("Rock Crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            BaseMenu();
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
                    DisplayRules();
                    break;
                case "2":
                    playerTwo = new AI();
                    break;
                case "3":
                    playerTwo = new Human();
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
            Console.WriteLine("How many rounds would you like to play?");
            Console.WriteLine("Minimum 3 Rounds.  Must be an odd number!");
            string userInput;
            userInput = Console.ReadLine();
            if (Validations.IsInteger(userInput) == true && ValidateRounds(int.Parse(userInput)) == true)
            {
                totalRounds = int.Parse(userInput);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Response.");
                Console.WriteLine("Please enter an odd number with a value of 3 or higher.");
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


        public void WinsNeeded(double rounds)
        {
            double result = (rounds / 2);
            winsNeeded = Math.Ceiling(result);
        }

        public void DisplayWinner()
        {
            if (playerOne.playerScore >= winsNeeded)
            {
                Console.WriteLine($"{playerOne.playerName} Wins!");
            }
            else
            {
                Console.WriteLine($"{playerTwo.playerName} Wins!");
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Would you like to play again?  Y or N");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "y":
                case "Y":
                    Game game = new Game();
                    game.RunGame();
                    break;
                case "n":
                case "N":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Response, try again");
                    PlayAgain();
                    break;

            }

        }

        public void GetPlayerNames()
        {
            Console.WriteLine("Player 1: Please Enter your name:");
            string userInput1 = Console.ReadLine();
            playerOne.playerName = userInput1;
            Console.WriteLine($"Welcome {playerOne.playerName}!");

            if(playerTwo.type == "Human")
            {
                Console.WriteLine("Player 2: Please Enter your name:");
                string userInput2 = Console.ReadLine();
                playerTwo.playerName = userInput2; 
                Console.WriteLine($"Welcome {userInput2}!");
            }
            else
            {
                Console.WriteLine($"Today you will be playing {playerTwo.playerName}");
            }
        }

        public void PlayRound()
        {
            Console.WriteLine($"Round {roundCount}:");
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            DisplayCountdown();
            DisplayPlayerDecisions();
            CompareGestures(playerOne.chosenGestureIndex, playerTwo.chosenGestureIndex);
            
        }
        public void IncreaseScore(Players player)
        {
            player.playerScore = +1;
        }
        public void CompareGestures(int playerOneIndex, int playerTwoIndex)
        {
            if (playerOne.gestures[playerOneIndex].GestureWins(playerTwo.gestures[playerTwoIndex]) == true && playerTwo.gestures[playerTwoIndex].GestureWins(playerOne.gestures[playerOneIndex]) == false)
            {
                Console.WriteLine($"{playerOne.playerName} Wins the Round!");
                roundCount += 1;
                playerOne.playerScore += 1;
            }
            else if (playerOne.gestures[playerOneIndex].GestureWins(playerTwo.gestures[playerTwoIndex]) == false && playerTwo.gestures[playerTwoIndex].GestureWins(playerOne.gestures[playerOneIndex]) == true)
            {
                Console.WriteLine($"{playerTwo.playerName} Wins the Round!");
                roundCount += 1;
                playerTwo.playerScore += 1;
            }
            else
            {
                Console.WriteLine("DRAW!  Replay Round");
            }
        }
        public void DisplayScore()
        {
            Console.WriteLine("Current Score:");
            Console.WriteLine($"{playerOne.playerName}: {playerOne.playerScore} | {playerTwo.playerName}: {playerTwo.playerScore}");
        }
        public void DisplayCountdown()
        {
            Console.WriteLine("Ready!");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Set!");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Rock");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Paper");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Lizard");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Scissors");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine("Spock");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine();
        }
        public void DisplayPlayerDecisions()
        {
            Console.WriteLine($"{playerOne.playerName} shows {playerOne.gestures[playerOne.chosenGestureIndex].gestureName} while {playerTwo.playerName} shows {playerTwo.gestures[playerTwo.chosenGestureIndex].gestureName}");
            Console.WriteLine();
        }
    }
}

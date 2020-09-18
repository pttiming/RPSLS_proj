using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Players
    {
        //member variables

        //constructor
        public Human(string playerName)
        {
            this.playerName = playerName;
            playerScore = 0;
        }

        //methods

        public override int ChooseGesture()
        {
            int gestureLength = gestures.Count;
            int gestureId;

            Console.WriteLine("Please Select your Gesture.");
            for(int i = 0; i < gestureLength; i++)
            {
                Console.WriteLine($"{i}. {gestures[i].gestureName}");
            }
            string userInput;
            userInput = Console.ReadLine();
            gestureId = int.Parse(userInput); 
            return gestureId;
        }

    }
}

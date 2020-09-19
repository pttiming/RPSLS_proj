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
        public Human()
        {
            type = "Human";
        }

        //methods

        public override void ChooseGesture()
        {
            int gestureLength = gestures.Count;

            Console.WriteLine("Please Select your Gesture.");
            for(int i = 0; i < gestureLength; i++)
            {
                Console.WriteLine($"{i}. {gestures[i].gestureName}");
            }
            string userInput;
            userInput = Console.ReadLine();
            
            if (Validations.IsInteger(userInput) == true && int.Parse(userInput) >= 0 && int.Parse(userInput) <= gestureLength)
            {
               chosenGestureIndex = int.Parse(userInput);
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Response, Try Again!");
                ChooseGesture();
            }
            
        }

    }
}

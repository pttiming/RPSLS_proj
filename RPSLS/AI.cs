using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Players
    {
        //member variables

        //constructor

        //methods
        public override void ChooseGesture()
        {
            Random rand;
            rand = new Random();
            int listLength = gestures.Count;
            chosenGestureIndex = rand.Next(0,listLength -1);
            
        }
    }
}

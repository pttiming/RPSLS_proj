using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Players
    {
        //member variables
        public string playerName;
        public int playerScore;
        public string type;
        public List<Gestures> gestures;
        public int chosenGestureIndex;

        //constructor
        public Players()
        {
            playerScore = 0;

            Gestures rock = new Rock();
            Gestures paper = new Paper();
            Gestures scissors = new Scissors();
            Gestures lizard = new Lizard();
            Gestures spock = new Spock();

            gestures = new List<Gestures>();

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }


        //methods
        public abstract void ChooseGesture();


    }
}

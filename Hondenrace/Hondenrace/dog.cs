using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hondenrace
{
    class dog
    {
        public Random Randomizer = new Random();
        public int Location = 0;
        public bool Winner = false;
        public PictureBox MyPictureBox = null;
        public string Name;
        public int StartingPosition = 0;

        
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
        public bool Run()
        {
        int raceTrackLength = 772;

        int move = Randomizer.Next(0, 6);
            Location = Location + move;
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= raceTrackLength)
            {
                Winner = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

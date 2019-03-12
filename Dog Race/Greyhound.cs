using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dog_Race
{
    class Greyhound
    {
         int Race_start;
         public int Racer;
         public PictureBox MyPictureBox = null;
         
        static Random Rnd = new Random();

       

       
        public void Position()//this function move the dog forward
        {
            Point pos = MyPictureBox.Location;
            pos.X = this.Race_start;
            MyPictureBox.Location = pos;
        }
        public bool Race()//this function gernates a random number and then moves the dog forward 
        {
            int MovingLength = Rnd.Next(0, 5);

            Point pos = MyPictureBox.Location;
            pos.X += MovingLength;
            MyPictureBox.Location = pos;
            if (pos.X >= Racer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void StartPos()//this function sets the starting position
        {
            Point start = MyPictureBox.Location;
            Race_start = start.X;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race
{
    class Bet
    {
        public Punter Players;//this calling the variable of punter class


        public int Dollars;
        public int racers;
       

        
        public int prize(int First)//this function checks if the the racer is the winner
        {
            if (racers == First)
            {
                return Dollars;
            }
            else
            {
                return -1 * Dollars;
            }
        }
        public string ViewBord()//this function updates the label
        {
            return Players.bettor_Name + " Places" + Dollars + " Dollars on Racer NO=" + racers;
        }

    }
}

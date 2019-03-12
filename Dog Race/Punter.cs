using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dog_Race
{
    class Punter
    {
        public int money;
        public string bettor_Name;
        public string busted="";
        public Bet Bet;// this is calling bet variable of bet class
        

        public RadioButton RadioBTN;
        public Label Label;

      
        public void Reset() {
            Bet = null;
        }

      
        public void Winner(int Winner)//this function updates the money for the winner
        {
            if (Bet != null)
            {
                money += Bet.prize(Winner); 
            }
        }
        public bool Bet_here(int money, int Racer)//this function places the bet
        {
            if (money <= this.money)
            {
                if (Bet == null)
                {
                    Bet = new Bet()
                    {
                        Dollars = money,
                        racers = Racer,
                        Players = this
                    };
                    return true;
                }
                else
                {
                    MessageBox.Show("You Have alredy Placed A bet ", "Message");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("BUSTED You Dont Have Enough Money", "Message");
                return false;
            }
        }


      
        public void ChangeLabels()//this function updates the lable 
        {
            if (Bet != null)
            {
                Label.Text = Bet.ViewBord();
            }
            else
            {
                Label.Text = bettor_Name + " Need to Place a Bet";
            }
            RadioBTN.Text = bettor_Name + " has " + money + " $";
            if (money == 0)
            {
                Label.Text = bettor_Name + " BUSTED";
                RadioBTN.Enabled = false;








            }

        }
    }
}

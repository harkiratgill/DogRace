using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{
    public partial class MainGame : Form
    {
        Punter[] bettors = new Punter[3];
        Greyhound[] racers = new Greyhound[4];
        welcome obj = new welcome();
       

        public string bettor1="Gill";
        public string bettor2="Askaran";
        public string bettor3="Sumi";
        int Busted =0;
        int Busted2 = 0;
        int Busted3 = 0;


        public MainGame()
        {
            InitializeComponent();


            racers[0] = new Greyhound()
            {
                MyPictureBox = racerpb1,
                Racer = tp_pb5.Width
            };
            racers[1] = new Greyhound()
            {
                MyPictureBox = racerpb2,
                Racer = tp_pb5.Width
            };
            racers[2] = new Greyhound()
            {
                MyPictureBox = racerpb3,
                Racer = tp_pb5.Width
            };
            racers[3] = new Greyhound()
            {
                MyPictureBox = racerpb4,
                Racer = tp_pb5.Width
            };
            bettors[0] = new Punter() {
                bettor_Name = bettor1, RadioBTN = betrd1, Label = labelBettor1, money = 50, Bet = null
                  };
            bettors[1] = new Punter() {
                bettor_Name = bettor2, RadioBTN = Betrd2, Label = labelbettor2, money = 50, Bet = null
                 };
            bettors[2] = new Punter() {
                bettor_Name = bettor3, RadioBTN = betrd3, Label = labelbettor3, money = 50, Bet = null
                 };

           

            labelMinBet.Text = "THE Minimum bet is " + Bettorselect.Minimum + "$";

            for (int i = 0; i <= 2; i++) {
                bettors[i].ChangeLabels();
            }
            for (int i = 0; i <= 3; i++) { 
                    racers[i].StartPos();
            }

            Bettor_name.Text = bettor1;
            labelMinBet.Text = "THE Minimum bet is " + Bettorselect.Minimum;
        }
        private void dograce_Load(object sender, EventArgs e)
        {

            racerpb1.Parent = tp_pb5;
            racerpb2.Parent = tp_pb5;
            racerpb3.Parent = tp_pb5;
            racerpb4.Parent = tp_pb5;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < racers.Length; i++)
            {
                if (racers[i].Race())
                {
                    i += 1;
                    timer.Stop();
                    MessageBox.Show("Winning Racer is #" + i, "test");
                    for (int k = 0; k < bettors.Length; k++)
                    {
                        bettors[k].Winner(i);
                        bettors[k].Reset();
                        bettors[k].ChangeLabels();
                    }
                    for (int m = 0; m < racers.Length; m++)
                    {
                        racers[m].Position();
                    }
                    Race_btn.Enabled = true;



                    break;
                }
            }
        }
        private void Bet_btn_Click(object sender, EventArgs e)
        {
            if (betrd1.Checked)
            {
                bettors[0].Bet_here((int)Bettorselect.Value, (int)moneyselect.Value);
                bettors[0].ChangeLabels();
            }
            else if (Betrd2.Checked)
            {
                bettors[1].Bet_here((int)Bettorselect.Value, (int)moneyselect.Value);
                bettors[1].ChangeLabels();
            }
            else if (betrd3.Checked)
            {
                bettors[2].Bet_here((int)Bettorselect.Value, (int)moneyselect.Value);
                bettors[2].ChangeLabels();
            }
        }

        private void bet_rb1_CheckedChanged(object sender, EventArgs e)
        {
            Bettor_name.Text = bettor1;
        }

        private void bet_rb2_CheckedChanged(object sender, EventArgs e)
        {
            Bettor_name.Text = bettor2;
        }

        private void bet_rb3_CheckedChanged(object sender, EventArgs e)
        {
            Bettor_name.Text = bettor3;
        }

       

        private void racebtn_Click(object sender, EventArgs e)
        {
            Race_btn.Enabled = false;
            timer.Start();
            if(betrd1.Enabled==false)
            {
                Busted =  1;
            }
            if (Betrd2.Enabled == false)
            {
                Busted2 =  + 1;
            }
            if (betrd3.Enabled == false)
            {
                Busted3 = + 1;
            }
            if( Busted==1&&Busted2 ==1)
            {
                MessageBox.Show("Game Over ", "Message");
                (new MainGame()).Show();
                this.Hide();
            }
            if (Busted2 == 1 && Busted3 == 1)
            {
                MessageBox.Show("Game Over ", "Message");
                (new MainGame()).Show();
                this.Hide();
            }
            if (Busted == 1 && Busted3 == 1)
            {
                MessageBox.Show("Game Over ", "Message");
                (new MainGame()).Show();
                this.Hide();
            }

        }

       

       

        private void bettorselect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelGuy2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tp_pb5_Click(object sender, EventArgs e)
        {

        }

        private void racerpb1_Click(object sender, EventArgs e)
        {

        }
    }
}

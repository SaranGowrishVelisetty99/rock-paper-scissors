using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock__paper_sissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Enemyscore, Playerscore = 0 ;

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //rock
            PlayRound(1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //paper
            PlayRound(2);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //sissors
            PlayRound(3);
        }

        private void PlayRound(int selection)
        {
           Random rnd = new Random();
            int enemyselection = rnd.Next(1, 4);

            setImage(PlayerPicture, selection);
            setImage(EnemyPicture, enemyselection);

            if(enemyselection == selection)
            {
                label6.Text = "Draw";
                return;
            }
            switch (selection)
            {
                case 1:
                    if (enemyselection == 2) 
                     
                    UpdateScore(true);

                  else 
                        UpdateScore(false);
                                          
                    break;
                case 2:
                    if (enemyselection == 3) 
                    UpdateScore(true);
                else
                    UpdateScore(false);
                    break;
                case 3:
                    if (enemyselection == 1)
                    UpdateScore(true);
                else
                    UpdateScore(false);
                    break;

            }
        }
        private void UpdateScore(bool PlayerWon)
        {
            if(PlayerWon)
            {
                Playerscore++;
                label6.Text = "Win";
                ourscore.Text = Playerscore.ToString();
            }
            else
            {
                Enemyscore++;
                label6.Text = "Lose";
                enemyscorelabel.Text = Enemyscore.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset
            Playerscore = 0;
            Enemyscore=0;
            PlayerPicture.Image = null;
            EnemyPicture.Image = null;
            label6.Text = "Game Reseted";
            ourscore.Text = "0";
            enemyscorelabel.Text = "0";
        }

        private void setImage (PictureBox pb , int img)
        {
            if (img == 1)
                pb.Image = global::rock__paper_sissors.Properties.Resources.sissors;
            else if (img == 2)
                pb.Image = global::rock__paper_sissors.Properties.Resources.paper;
            else if (img == 3)
                pb.Image = global::rock__paper_sissors.Properties.Resources.rock;
        }
    }
}

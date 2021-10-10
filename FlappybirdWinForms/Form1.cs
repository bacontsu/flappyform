using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappybirdWinForms
{
    public partial class Form1 : Form
    {
        bool isJumping = false;
        bool lose = false;
        bool generationSeed = false;
        public int seed;
        public int seedOld;

        public Form1()
        {
            InitializeComponent();
            bird.Top = 150;
            bird.Left = 270;
            gameover.Hide();
            this.MaximumSize = new Size(640, 480);
            this.MinimumSize = new Size(640, 480);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lose)
            {
                if (e.KeyCode == Keys.Space)
                {
                    timer1.Start();
                    isJumping = true;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //move the obstacles
            if(!lose)
            {
                wallBot.Left -=2 ;
                wallUp.Left -= 2;
            }



            //jumping handler
            if(isJumping)
            {   if(bird.Top !=0)
                bird.Top -= 2;
            }
            else
            {
                bird.Top += 2;
            }

            if(bird.Top > 367)
            {
                GameOver();
            }

            //teleport the obstacles and generate new shape
            if(wallBot.Left < 12 && wallUp.Left < 12)
            {
                wallBot.Left = 524;
                wallUp.Left = 524;

                int seed = new Random().Next(-100, 100);

                if (wallUp.Height - seed >= 50 && wallBot.Height + seed >= 50)
                {
                    wallUp.Height -= seed;
                    wallBot.Top -= seed;
                    wallBot.Height += seed;
                }




            }

            //collision handler
            if(184 <= wallBot.Left && wallBot.Left <= 350)
            {
                if ((bird.Top+80) >= (wallBot.Top))
                {
                    GameOver();
                }
            }

            if (184 <= wallUp.Left && wallUp.Left <= 350)
            {
                if((bird.Top) <= (12+wallUp.Height))
                {
                    GameOver();
                }
            }




        }


        void GameOver()
        {
            timer1.Stop();
            lose = true;
            gameover.Show();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isJumping = false;
        }

        private void gameover_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }
    }
}

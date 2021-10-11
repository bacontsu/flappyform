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

        bool lose = false;
        int speed = 2;
        int score = 0;
        float rotation = 0;
        bool once = true;
        int velocity = 0;
        bool started = false;

        public Form1()
        {
            InitializeComponent();
            bird.Top = 160;
            bird.Left = 288;
            gameover.Hide();
            this.MaximumSize = new Size(640, 480);
            this.MinimumSize = new Size(640, 480);
            wallBot2.Hide();
            wallUp2.Hide();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lose)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (once)
                    {
                        once = false;
                        rotation = -45;
                        velocity = 5;
                    }
                    gameTimer.Start();
                    physicsTimer.Start();
                    

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //animation
            if(!physicsHandler.IsBusy)
            { physicsHandler.RunWorkerAsync(); }

            //move the obstacles
            if (!lose)
            {
                wallBot.Left -= speed;
                wallUp.Left -= speed;
                wallBot2.Left -= speed;
                wallUp2.Left -= speed;
            }

            //physics
            bird.Top -= velocity;

            //if touched ground
            if (bird.Top > 367)
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

                score++;
                scoreLabel.Text = Convert.ToString(score);


            }

            //collision handler
            if(228 <= wallBot.Left && wallBot.Left <= 338)
            {
                if ((bird.Top+bird.Height-8) >= (wallBot.Top))
                {
                  GameOver();
                }
            }

            if (228 <= wallUp.Left && wallUp.Left <= 338)
            {
                if((bird.Top+8) <= (wallUp.Top+wallUp.Height))
                {
                  GameOver();
                }
            }


            //for the second obstacles
            //teleport the obstacles and generate new shape
            if (wallBot2.Left < 12 && wallUp2.Left < 12)
            {
                started = true;
                wallUp2.Show();
                wallBot2.Show();
                wallBot2.Left = 524;
                wallUp2.Left = 524;

                int seed = new Random().Next(-100, 100);

                if (wallUp2.Height - seed >= 50 && wallBot2.Height + seed >= 50)
                {
                    wallUp2.Height -= seed;
                    wallBot2.Top -= seed;
                    wallBot2.Height += seed;
                }

                score++;
                scoreLabel.Text = Convert.ToString(score);


            }

            //collision handler
            if (228 <= wallBot2.Left && wallBot2.Left <= 338)
            {
                if ((bird.Top + bird.Height - 8) >= (wallBot2.Top))
                {
                    if(started)
                    GameOver();
                }
            }

            if (228 <= wallUp2.Left && wallUp2.Left <= 338)
            {
                if ((bird.Top + 8) <= (wallUp2.Top + wallUp2.Height))
                {
                    if (started)
                        GameOver();
                }
            }




        }


        void GameOver()
        {
            gameTimer.Stop();
            physicsTimer.Stop();
            lose = true;
            gameover.Show();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
            once = true;
        }

        private void gameover_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }

        
        // accelerate/deccelerate 
        private void timer3_Tick(object sender, EventArgs e)
        {
            velocity -= 2;
            // once = true;

    
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            //gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        //image stuff
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (rotation < 45)
                rotation+=2;
            var img = new Bitmap(FlappybirdWinForms.Properties.Resources.sprite1);

            var img2 = RotateImage(img, rotation);

            bird.BackgroundImage = img2;
        }
    }
}

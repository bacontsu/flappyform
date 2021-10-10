
namespace FlappybirdWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bird = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.wallBot = new System.Windows.Forms.Panel();
            this.wallUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackgroundImage = global::FlappybirdWinForms.Properties.Resources.toppng_com_flappy_bird_sprite_315x223;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Cursor = System.Windows.Forms.Cursors.Default;
            this.bird.Enabled = false;
            this.bird.FlatAppearance.BorderSize = 0;
            this.bird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bird.Location = new System.Drawing.Point(270, 53);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(80, 80);
            this.bird.TabIndex = 0;
            this.bird.UseVisualStyleBackColor = true;
            this.bird.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Black;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.White;
            this.gameover.Location = new System.Drawing.Point(148, 173);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(323, 55);
            this.gameover.TabIndex = 1;
            this.gameover.Text = "GAME OVER";
            this.gameover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameover_MouseDown);
            // 
            // wallBot
            // 
            this.wallBot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wallBot.BackColor = System.Drawing.Color.ForestGreen;
            this.wallBot.Location = new System.Drawing.Point(524, 283);
            this.wallBot.Name = "wallBot";
            this.wallBot.Size = new System.Drawing.Size(88, 146);
            this.wallBot.TabIndex = 2;
            // 
            // wallUp
            // 
            this.wallUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wallUp.BackColor = System.Drawing.Color.ForestGreen;
            this.wallUp.Location = new System.Drawing.Point(524, 12);
            this.wallUp.Name = "wallUp";
            this.wallUp.Size = new System.Drawing.Size(88, 146);
            this.wallUp.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(94, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 38);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(524, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 442);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 442);
            this.panel4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(99, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 38);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wallUp);
            this.Controls.Add(this.wallBot);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Panel wallBot;
        private System.Windows.Forms.Panel wallUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}


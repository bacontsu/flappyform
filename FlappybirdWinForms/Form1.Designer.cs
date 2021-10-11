
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.wallBot = new System.Windows.Forms.Panel();
            this.wallUp = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.physicsTimer = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.physicsHandler = new System.ComponentModel.BackgroundWorker();
            this.obstaclesHandler = new System.ComponentModel.BackgroundWorker();
            this.wallBot2 = new System.Windows.Forms.Panel();
            this.wallUp2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Black;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.White;
            this.gameover.Location = new System.Drawing.Point(148, 190);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Controls.Add(this.scoreLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(524, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 442);
            this.panel3.TabIndex = 6;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(22, 113);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(52, 55);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCORE";
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
            // physicsTimer
            // 
            this.physicsTimer.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // bird
            // 
            this.bird.BackgroundImage = global::FlappybirdWinForms.Properties.Resources.sprite1;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bird.Location = new System.Drawing.Point(309, 120);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(50, 50);
            this.bird.TabIndex = 8;
            this.bird.TabStop = false;
            // 
            // physicsHandler
            // 
            this.physicsHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // wallBot2
            // 
            this.wallBot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wallBot2.BackColor = System.Drawing.Color.ForestGreen;
            this.wallBot2.Location = new System.Drawing.Point(234, 283);
            this.wallBot2.Name = "wallBot2";
            this.wallBot2.Size = new System.Drawing.Size(88, 146);
            this.wallBot2.TabIndex = 3;
            // 
            // wallUp2
            // 
            this.wallUp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wallUp2.BackColor = System.Drawing.Color.ForestGreen;
            this.wallUp2.Location = new System.Drawing.Point(234, 12);
            this.wallUp2.Name = "wallUp2";
            this.wallUp2.Size = new System.Drawing.Size(88, 146);
            this.wallUp2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 38);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.wallUp2);
            this.Controls.Add(this.wallBot2);
            this.Controls.Add(this.wallUp);
            this.Controls.Add(this.wallBot);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Panel wallBot;
        private System.Windows.Forms.Panel wallUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer physicsTimer;
        private System.Windows.Forms.PictureBox bird;
        private System.ComponentModel.BackgroundWorker physicsHandler;
        private System.ComponentModel.BackgroundWorker obstaclesHandler;
        private System.Windows.Forms.Panel wallBot2;
        private System.Windows.Forms.Panel wallUp2;
        private System.Windows.Forms.Panel panel1;
    }
}


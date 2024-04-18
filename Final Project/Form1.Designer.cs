namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timerPlayer = new System.Windows.Forms.Timer(components);
            picBottom = new PictureBox();
            lblLives = new Label();
            lblWave = new Label();
            timerAliens = new System.Windows.Forms.Timer(components);
            picBunk1 = new PictureBox();
            picBunk3 = new PictureBox();
            picBunk2 = new PictureBox();
            picBunk4 = new PictureBox();
            timerShoot = new System.Windows.Forms.Timer(components);
            lblBunk1 = new Label();
            lblBunk2 = new Label();
            lblBunk3 = new Label();
            lblBunk4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBunk1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBunk3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBunk2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBunk4).BeginInit();
            SuspendLayout();
            // 
            // timerPlayer
            // 
            timerPlayer.Enabled = true;
            timerPlayer.Interval = 10;
            timerPlayer.Tick += timer1_Tick;
            // 
            // picBottom
            // 
            picBottom.BackColor = Color.WhiteSmoke;
            picBottom.Location = new Point(12, 900);
            picBottom.Name = "picBottom";
            picBottom.Size = new Size(960, 50);
            picBottom.TabIndex = 0;
            picBottom.TabStop = false;
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.BackColor = Color.WhiteSmoke;
            lblLives.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLives.Location = new Point(280, 926);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(63, 24);
            lblLives.TabIndex = 1;
            lblLives.Text = "Lives: ";
            lblLives.Click += lblLives_Click;
            // 
            // lblWave
            // 
            lblWave.AutoSize = true;
            lblWave.BackColor = Color.WhiteSmoke;
            lblWave.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWave.Location = new Point(680, 926);
            lblWave.Name = "lblWave";
            lblWave.Size = new Size(64, 24);
            lblWave.TabIndex = 2;
            lblWave.Text = "Wave: ";
            lblWave.Click += label1_Click;
            // 
            // timerAliens
            // 
            timerAliens.Enabled = true;
            timerAliens.Interval = 1000;
            timerAliens.Tick += timerAliens_Tick;
            // 
            // picBunk1
            // 
            picBunk1.BackColor = Color.Transparent;
            picBunk1.BackgroundImage = (Image)resources.GetObject("picBunk1.BackgroundImage");
            picBunk1.BackgroundImageLayout = ImageLayout.Stretch;
            picBunk1.Location = new Point(100, 700);
            picBunk1.Name = "picBunk1";
            picBunk1.Size = new Size(125, 100);
            picBunk1.TabIndex = 4;
            picBunk1.TabStop = false;
            picBunk1.Click += picBunk1_Click;
            // 
            // picBunk3
            // 
            picBunk3.BackColor = Color.Transparent;
            picBunk3.BackgroundImage = (Image)resources.GetObject("picBunk3.BackgroundImage");
            picBunk3.BackgroundImageLayout = ImageLayout.Stretch;
            picBunk3.Location = new Point(550, 700);
            picBunk3.Name = "picBunk3";
            picBunk3.Size = new Size(125, 100);
            picBunk3.TabIndex = 5;
            picBunk3.TabStop = false;
            picBunk3.Click += picBunk3_Click;
            // 
            // picBunk2
            // 
            picBunk2.BackColor = Color.Transparent;
            picBunk2.BackgroundImage = (Image)resources.GetObject("picBunk2.BackgroundImage");
            picBunk2.BackgroundImageLayout = ImageLayout.Stretch;
            picBunk2.Location = new Point(325, 700);
            picBunk2.Name = "picBunk2";
            picBunk2.Size = new Size(125, 100);
            picBunk2.TabIndex = 6;
            picBunk2.TabStop = false;
            picBunk2.Click += picBunk2_Click;
            // 
            // picBunk4
            // 
            picBunk4.BackColor = Color.Transparent;
            picBunk4.BackgroundImage = (Image)resources.GetObject("picBunk4.BackgroundImage");
            picBunk4.BackgroundImageLayout = ImageLayout.Stretch;
            picBunk4.Location = new Point(775, 700);
            picBunk4.Name = "picBunk4";
            picBunk4.Size = new Size(125, 100);
            picBunk4.TabIndex = 7;
            picBunk4.TabStop = false;
            picBunk4.Click += picBunk4_Click;
            // 
            // timerShoot
            // 
            timerShoot.Enabled = true;
            timerShoot.Interval = 1000;
            timerShoot.Tick += timerShooting_Tick;
            // 
            // lblBunk1
            // 
            lblBunk1.AutoSize = true;
            lblBunk1.Location = new Point(150, 709);
            lblBunk1.Name = "lblBunk1";
            lblBunk1.Size = new Size(19, 15);
            lblBunk1.TabIndex = 8;
            lblBunk1.Text = "50";
            // 
            // lblBunk2
            // 
            lblBunk2.AutoSize = true;
            lblBunk2.Location = new Point(377, 709);
            lblBunk2.Name = "lblBunk2";
            lblBunk2.Size = new Size(19, 15);
            lblBunk2.TabIndex = 9;
            lblBunk2.Text = "50";
            // 
            // lblBunk3
            // 
            lblBunk3.AutoSize = true;
            lblBunk3.Location = new Point(602, 709);
            lblBunk3.Name = "lblBunk3";
            lblBunk3.Size = new Size(19, 15);
            lblBunk3.TabIndex = 10;
            lblBunk3.Text = "50";
            // 
            // lblBunk4
            // 
            lblBunk4.AutoSize = true;
            lblBunk4.Location = new Point(828, 709);
            lblBunk4.Name = "lblBunk4";
            lblBunk4.Size = new Size(19, 15);
            lblBunk4.TabIndex = 11;
            lblBunk4.Text = "50";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(984, 961);
            Controls.Add(lblBunk4);
            Controls.Add(lblBunk3);
            Controls.Add(lblBunk2);
            Controls.Add(lblBunk1);
            Controls.Add(lblWave);
            Controls.Add(lblLives);
            Controls.Add(picBottom);
            Controls.Add(picBunk1);
            Controls.Add(picBunk2);
            Controls.Add(picBunk3);
            Controls.Add(picBunk4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBunk1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBunk3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBunk2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBunk4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerPlayer;
        private PictureBox picBottom;
        private Label lblLives;
        private Label lblWave;
        private System.Windows.Forms.Timer timerAliens;
        private PictureBox picBunk1;
        private PictureBox picBunk3;
        private PictureBox picBunk2;
        private PictureBox picBunk4;
        private System.Windows.Forms.Timer timerShoot;
        private Label lblBunk1;
        private Label lblBunk2;
        private Label lblBunk3;
        private Label lblBunk4;
    }
}
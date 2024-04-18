using System;
using System.Data.Common;
using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        //declare variables
        private player Tank;
        private aliens Enemy;

        PictureBox picLaser = new PictureBox();
        PictureBox picShot = new PictureBox();

        private int yBullet = 3;
        //private int w;
        //private int h;

        bool shooting = false;
        bool Right = true;

        private enum KeyMove { none, left, right }
        KeyMove PlayerMove = KeyMove.none;

        private enum KeyShoot { none, shoot }
        KeyShoot PlayerShoot = KeyShoot.none;

        int wave = 0;

        int lives = 1;
        int spawn = 0;

        int bunk1 = 50;
        int bunk2 = 50;
        int bunk3 = 50;
        int bunk4 = 50;


        List<aliens> lstAliens = new List<aliens>(39);


        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            this.Width = 1000;
            this.Height = 1000;

            picLaser.BackColor = Color.DarkCyan;
            picLaser.Visible = false;
            picLaser.Width = 5;
            picLaser.Height = 25;

            picShot.BackColor = Color.DarkRed;
            picShot.Visible = false;
            picShot.Width = 5;
            picShot.Height = 25;

            Tank = new player(450, 800, 100, 100, this);


            lblLives.Text = "Lives: " + lives;

            NewWave();

        }




        private void NewWave()
        {

            timerShoot.Interval = 1000;
            wave += 1;


            if (lstAliens.Count > 0)
            {
                lstAliens.Clear();
            }

            if (spawn < 5) { spawn += 1; }

            lives++;
            lblWave.Text = ("Wave: ") + wave;
            lblLives.Text = "Lives: " + lives;

            int spacing = 20; // 20px Space between each alien in a row

            int edgeSpace = 210; // Space between the form and the aliens on the outermost columns
            int waveOffset = 60; // extra space for every new wave


            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 10; c++)
                {


                    int xPos = edgeSpace + c * (40 + spacing);
                    int yPos = edgeSpace + r * (40 + spacing) + spawn * waveOffset;
                    Enemy = new aliens(xPos, yPos - 200, this);
                    lstAliens.Add(Enemy);

                }
            }




        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //  Invalidate();



            //Movement code for player
            if (PlayerMove == KeyMove.right)
            {

                Tank.MoveRight();
            }

            if (PlayerMove == KeyMove.left)
            {

                Tank.MoveLeft();
            }



            if (PlayerShoot == KeyShoot.shoot)
            {


                TankShoot();

            }

            if (picLaser.Visible == true)
            {

                picLaser.Top -= 10;

                CheckBunkers(picLaser);

                foreach (var enmy in lstAliens)
                {
                    enmy.LaserIntersect(picLaser);




                }
            }

        }

        private void TankShoot()
        {

            if (picLaser.Visible == false)
            {
                SoundPlayer pew = new SoundPlayer(Properties.Resources._05___MegaBuster);
                pew.Play();
                this.Controls.Add(picLaser);



                picLaser.Left = Tank.X + 48;
                picLaser.Top = Tank.Y;

                picLaser.Visible = true;


            }


            if (picLaser.Top < 0 - picLaser.Height)

            {

                //this.Controls.Remove(picLaser);
                picLaser.Visible = false;


            }


        }








        private void CheckBunkers(PictureBox pic)
        {
            if (pic.Bounds.IntersectsWith(picBunk1.Bounds))
            {
                pic.Top = 0;
                bunk1--;
                lblBunk1.Text = bunk1.ToString();
                pic.Visible = false;


                if (bunk1 <= 0)
                {

                    picBunk1.Left = -500;
                    Controls.Remove(lblBunk1);
                }

            }

            if (pic.Bounds.IntersectsWith(picBunk2.Bounds))
            {
                bunk2--;
                lblBunk2.Text = bunk2.ToString();
                pic.Visible = false;



                if (bunk2 <= 0)
                {
                    picBunk2.Left = -500;
                    Controls.Remove(lblBunk2);
                }

            }


            if (pic.Bounds.IntersectsWith(picBunk3.Bounds))
            {
                bunk3--;
                lblBunk3.Text = bunk3.ToString();
                pic.Visible = false;

                if (bunk3 <= 0)
                {
                    picBunk3.Left = -500;
                    Controls.Remove(lblBunk3);
                }
            }

            if (pic.Bounds.IntersectsWith(picBunk4.Bounds))
            {
                bunk4--;
                lblBunk4.Text = bunk4.ToString();
                pic.Visible = false;

                if (bunk4 <= 0)
                {
                    picBunk4.Left = -500;
                    Controls.Remove(lblBunk4);
                }
            }


        }

        private void timerAliens_Tick(object sender, EventArgs e)
        {

            bool moveAllDown = false;



            if (Right == true)
            {
                foreach (var enmy in lstAliens)
                {
                    enmy.MoveRight();


                    if (enmy.IsAtBoundary(this.Width))
                    {
                        moveAllDown = true;


                    }
                }

                if (moveAllDown)
                {

                    MoveAllEnemiesDown(lstAliens);

                    Right = false;

                    moveAllDown = false;

                }

            }

            if (Right == false)
            {
                foreach (var enmy in lstAliens)
                {
                    enmy.MoveLeft();


                    if (enmy.IsAtBoundary(this.Width))
                    {
                        moveAllDown = true;


                    }
                }

                if (moveAllDown)
                {


                    MoveAllEnemiesDown(lstAliens);
                    Right = true;

                    moveAllDown = false;

                }


            }

            if (lstAliens.All(alns => alns.Y > 1000))
            {
                NewWave();
            }

        }


        private void MoveAllEnemiesDown(List<aliens> lstAliens)
        {

            if (timerAliens.Interval > 100) { timerAliens.Interval -= 10; }




            if (Right == true)
            {
                foreach (var enemy in lstAliens)
                {
                    enemy.MoveDown();
                    enemy.MoveLeft();


                }

            }

            if (Right == false)
            {
                foreach (var enemy in lstAliens)
                {
                    enemy.MoveDown();
                    enemy.MoveRight();


                }

            }

            foreach (var enemy in lstAliens)
            {
                if (enemy.Y > 760 && enemy.Y < 1000)
                {
                    GameOver();
                }
            }
        }



        private void timerShooting_Tick(object sender, EventArgs e)
        {
            Random shotRNG = new Random();






           
                if (picShot.Visible == false)
                {
                    int randAlien = shotRNG.Next(lstAliens.Count);
                    aliens selAlien = lstAliens[randAlien];

                    if (selAlien.Y < this.Height)
                    {

                        SoundPlayer enemyshoot = new SoundPlayer(Properties.Resources._10___EnemyShoot);
                        enemyshoot.Play();
                        this.Controls.Add(picShot);
                        picShot.Visible = true;


                        picShot.Left = selAlien.X + 20;
                        picShot.Top = selAlien.Y;
                    }

                }


                if (picShot.Visible == true)
                {

                    timerShoot.Interval = 10;

                    picShot.Top += 10;

                    CheckBunkers(picShot);

                    Tank.ShotIntersect(picShot);

                }


                if (picShot.Top > this.Height - picShot.Height)

                {


                    picShot.Visible = false;


                }
            


            if (Tank.Y > this.Height)
            {

                Respawn();
            }


        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //Gives the player the ability to move horizontally using arrow keys
            if (e.KeyCode == Keys.Right) PlayerMove = KeyMove.right;
            if (e.KeyCode == Keys.Left) PlayerMove = KeyMove.left;

            if (e.KeyCode == Keys.Space) PlayerShoot = KeyShoot.shoot;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            //Stops the player from moving when the key is released
            if (e.KeyCode == Keys.Right) PlayerMove = KeyMove.none;
            if (e.KeyCode == Keys.Left) PlayerMove = KeyMove.none;

            if (e.KeyCode == Keys.Space) PlayerShoot = KeyShoot.none;
        }



        private void Respawn()
        {


            if (lives > 0)
            {
                lives--;
                lblLives.Text = ("Lives: ") + lives;

                Tank = new player(450, 800, 100, 100, this);
            }

            else
            {
                GameOver();
            }

        }




        public void GameOver()
        {
            timerAliens.Enabled = false;
            timerShoot.Enabled = false;


            DialogResult result = MessageBox.Show("Game Over! You have lost the game ;)", "Game Over", MessageBoxButtons.RetryCancel);


            if (result == DialogResult.Retry)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else if (result == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }



        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBunk1_Click(object sender, EventArgs e)
        {



        }

        private void picBunk2_Click(object sender, EventArgs e)
        {

        }

        private void picBunk3_Click(object sender, EventArgs e)
        {

        }

        private void picBunk4_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLives_Click(object sender, EventArgs e)
        {

        }


    }
}
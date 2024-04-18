using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Final_Project
{
    internal class player
    {

        private Form form;
        private int xLoc;
        private int yLoc;
        private int width, height;
        
        private int xSpeed = 3;
      

        
       

        private PictureBox picTank;



        public int X { get { return xLoc; } }
        public int Y { get { return yLoc; } }
        public int W { get { return width; } }
        public int H { get { return height; } }


        public player(int x, int y, int w, int h, Form mainform)
        {
            picTank = new PictureBox();
            picTank.Image = Properties.Resources.Cannon;
            picTank.SizeMode = PictureBoxSizeMode.StretchImage;
          picTank.BackColor = Color.Transparent;
            picTank.Width = w;
            picTank.Height = h;

            xLoc = x;
            yLoc = y;

           picTank.Left = xLoc;
            picTank.Top = yLoc;
            mainform.Controls.Add(picTank);
            
            form = mainform;

           
        }




        public void MoveRight()
        {
           
            picTank.Left += xSpeed;

            xLoc = picTank.Left;

           if (picTank.Left + picTank.Width > form.ClientSize.Width)
                picTank.Left = form.ClientSize.Width - picTank.Width;

        }

        public void MoveLeft()
        {
            
            picTank.Left -= xSpeed;
            xLoc = picTank.Left;
             
            if (picTank.Left < 0) 
                picTank.Left = 0; 

        }

        public void ShotIntersect(PictureBox pic)
        {
            
            SoundPlayer death = new SoundPlayer(Properties.Resources._08___MegamanDefeat);

            if (pic.Bounds.IntersectsWith(picTank.Bounds) && pic.Visible == true)
            {
                

                death.Play();
                pic.Visible = false;

                
                picTank.Top = 2000;
                yLoc = picTank.Top;

                Thread.Sleep(2000);

                

                
            }
        }

    }
}

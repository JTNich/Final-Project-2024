using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class aliens
    {

        private int xSpeed = 20;
        
        private int yLoc, xLoc;
        private int Height, Width;

        private PictureBox picAliens;
        private Form form;


        public int X { get { return xLoc; } }
        public int Y { get { return yLoc; } }

     


        public aliens(int x, int y, Form mainform)
        {
            picAliens = new PictureBox();
            picAliens.Image = Properties.Resources.Crab;
            picAliens.SizeMode = PictureBoxSizeMode.StretchImage;
            picAliens.BackColor = Color.Transparent;


            picAliens.Width = 40;
            picAliens.Height = 40;
            picAliens.Left = x;
            picAliens.Top = y;

            mainform.Controls.Add(picAliens);
            form = mainform;

        }







        public void MoveRight()
        {
            picAliens.Left += 20;
            xLoc = picAliens.Left;
            yLoc = picAliens.Top;
            
            if (picAliens.Top > form.Height)
            {
                picAliens.Left = 500;
            }

        }

        public void MoveLeft()
        {

            picAliens.Left -= 20;  
            xLoc = picAliens.Left;
            yLoc = picAliens.Top;

            if (picAliens.Top > form.Height)
            {
                picAliens.Left = 500;
            }

            
        }

        public void MoveDown()
        {
            picAliens.Top += 60;
           
            yLoc = picAliens.Top;
        }


        public bool IsAtBoundary(int formWidth)
        {

            return picAliens.Left <= 0 || picAliens.Right  >= formWidth ;

        }

        public void LaserIntersect(PictureBox pic)
        {
            if (pic.Bounds.IntersectsWith(picAliens.Bounds) && pic.Visible == true)
                {

                pic.Visible = false;
                
                picAliens.Top = 2000;
                yLoc = picAliens.Top;
                
            }
        }

        







    }
}

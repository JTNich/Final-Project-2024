using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class laser
    {

        private int lSpeed = 3;
        private PictureBox picLaser;
        private int lWidth, lHeight;
        private int lX, lY;
        private Form form;


        public int X { get { return lX; } }
        public int Y { get { return lY; } }

        public int W { get { return lWidth; } }
        public int H { get { return lHeight; } }


        public laser(int x, int y, Form mainform)
        {
            picLaser = new PictureBox();
            picLaser.BackColor = Color.DarkCyan;

            picLaser.Width = 10;
            picLaser.Height = 10;

            picLaser.Top = y;
            picLaser.Left = x;

            picLaser.Top += 10;

            mainform.Controls.Add(picLaser);
            form = mainform;

        }

        public void Shoot()
        {
            
        }

    }
}

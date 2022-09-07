using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Corner
{
    class Display
    {
        private int width;
        private int height;
        private Logo logo;
        private int maxCorners;

        public int Width {
            get => width;
            set => width = value;
        }
        public int Height {
            get => height;
            set => height = value;
        }
        internal Logo Logo {
            get => logo;
            set => logo = value;
        }
        public int MaxCorners {
            get => maxCorners;
            set => maxCorners = value;
        }

        public Display(int width, int height, Logo logo)
        {
            this.Width = width;
            this.Height = height;
            this.Logo = logo;
        }

        public int Simulate(int maxCollisions)
        {
            int curCollisions = 0;
            int curCorners = 0;
            maxCorners = 0;
            int i = 0;
            while (curCollisions < maxCollisions)
            {
                Logo.Move();
                CheckForCollision(Logo, ref curCollisions, ref curCorners);
                i++;
            }

            //Console.WriteLine("Corners: " + curCorners + " Iterations: " + i);

            if (curCorners > maxCorners)
            {
                maxCorners = curCorners;
            }

            return curCorners;
        }

        private void CheckForCollision(Logo l, ref int curCollisions, ref int curCorners)
        {
            int numOfCollisions = 0;

            if (l.X <= 0)
            {
                l.X = 0;
                l.XSpeed = -l.XSpeed;
                numOfCollisions++;
            }

            if (l.Y <= 0)
            {
                l.Y = 0;
                l.YSpeed = -l.YSpeed;
                numOfCollisions++;
            }

            if (l.X + l.Width >= Width)
            {
                l.X = Width - l.Width;
                l.XSpeed = -l.XSpeed;
                numOfCollisions++;
            }

            if (l.Y + l.Height >= Height)
            {
                l.Y = Height - l.Height;
                l.YSpeed = -l.YSpeed;
                numOfCollisions++;
            }

            curCollisions += numOfCollisions;

            //Console.WriteLine("NUMOFCOLLISIONS: " + numOfCollisions);

            if (numOfCollisions == 2)
            {
                curCorners++;
            }
        }
    }
}

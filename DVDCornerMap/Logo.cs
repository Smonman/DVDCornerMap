namespace DVD_Corner
{
    internal class Logo
    {
        private int width;
        private int height;
        private int x;
        private int y;
        private int xSpeed;
        private int ySpeed;

        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        public int XSpeed
        {
            get => xSpeed;
            set => xSpeed = value;
        }
        public int YSpeed
        {
            get => ySpeed;
            set => ySpeed = value;
        }

        public Logo(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void SetPos(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void SetSpeed(int xs, int ys)
        {
            this.XSpeed = xs;
            this.YSpeed = ys;
        }

        public void Move()
        {
            X += XSpeed;
            Y += YSpeed;
        }
    }
}
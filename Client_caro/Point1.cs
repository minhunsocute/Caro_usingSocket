using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_caro
{
    public class Point1
    {
        public Point1(int x,int y,int check)
        {
            this.X = x;
            this.Y = y;
            this.Check = check;
        }
        private int x;
        private int y;
        private int check;

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
        public int Check { get => check; set => check = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_caro
{
    public class ListPoint
    {
        private static ListPoint _instance;
        public static ListPoint Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListPoint();
                return _instance;
            }
        }

        public List<Point1> LoadPointList()
        {
            List<Point1> temp = new List<Point1>();
            int x = 0; int y = 0;
            while (x <= 22)
            {
                Point1 te = new Point1(x, y, 0);
                temp.Add(te);
                if (y == 22)
                {
                    x++;
                    y = -1;
                }
                y++;
            }
            return temp;
        }
    }
}

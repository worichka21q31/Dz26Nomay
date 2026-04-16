using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz26Nomay
{
    public class Point
    {
        public int x, y, z;
        public Point(int x_, int y_, int z_)
        {
            x = x_;
            y = y_;
            z = z_;
        }

        public void MoveBy(int dx, int dy, int dz) 
        {
            x += dx;
            y += dy;
            z += dz;
            //x = dx;
            //y = dy;
            //z = dz;
            // Если он должен не двигать, а переставить
        }
    }
}

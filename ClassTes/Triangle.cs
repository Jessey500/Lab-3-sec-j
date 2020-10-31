using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTes
{
    class Triangle
    {
        int x;
        int y;
        int z;
        public void setX(int X)
        {
            x = X;
        }
        public int getX()
        {
            return x;
        }
        public void setY(int Y)
        {
            y = Y;
        }
        public int getY()
        {
            return y;
        }
        public void setZ(int Z)
        {
            z = Z;
        }
        public int getZ()
        {
            return z;
        }

        public void ShowInfo()
        {
            Console.WriteLine("X : " + x);
            Console.WriteLine("Y : " + y);
            Console.WriteLine("Z : " + z);
        }
        public void TestTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("The traingle is equilateral");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("The traingle is isosceles");
            }
            else
            {
                Console.WriteLine("The traingle is scalene");
            }
        }
    }
}

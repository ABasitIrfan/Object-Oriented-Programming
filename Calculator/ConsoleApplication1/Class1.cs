using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Box
    {
        public double height;
        public double width;
        public Box()
        {

        }
        public Box(double h, double w)
        {
            height = h;
            width = w;
        }
        public void display()
        {
            Console.WriteLine("Height={0}\nWidth={1}\n", height, width);
        }
        public static Box operator +(Box b1, Box b2)
        {
            Box box = new Box();
            box.height = b1.height + b2.height;
            box.width = b1.width + b2.width;
            return box;
        }
        public static Box operator -(Box b2, Box b1)
        {
            Box box = new Box();
            box.height = b2.height - b1.height;
            box.width = b2.width - b1.width;
            return box;
        }
        public static bool operator <(Box b2, Box b1)
        {
            bool check;
            if ((b1.height < b2.height) && (b1.width < b2.width))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        public static bool operator >(Box b2, Box b1)
        {
            bool check;
            if ((b1.height < b2.height) && (b1.width < b2.width))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        public static Box operator ++(Box b)
        {
            Box box = new Box();
            box.height = b.height + 1;
            box.width = b.width + 1;
            return box;
        }










        
    }
}


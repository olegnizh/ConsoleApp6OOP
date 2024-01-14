using System;

namespace ConsoleApp628
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();

            int square = rectangle.Square();

            Console.WriteLine("Площадь = {0}", square);

        }




    }

    class Rectangle
    {
        public int a = 0;
        public int b = 0;

        public Rectangle()
        {
            a = 6;
            b = 4;

        }

        public Rectangle(int s)
        {
            a = s;
            b = s;

        }

        public Rectangle(int s1, int s2)
        {
            a = s1;
            b = s2;

        }

        public int Square()
        {
            return a * b;
        }




    }


}


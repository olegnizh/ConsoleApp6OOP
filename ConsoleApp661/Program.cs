using System;

namespace ConsoleApp661
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class TrafficLight
    {
        string color = "";

        private void ChangeColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

    }

}

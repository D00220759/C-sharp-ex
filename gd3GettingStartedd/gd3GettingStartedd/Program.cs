using System;
using GDLibrary.Utility;

namespace GDLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        void Start() // non static or instance method
        {
            #region Print Demo
            // value types(passed by copy)
            int x = 10;
            double y = 20;
            Print(x, y);
            Console.WriteLine($"{x}and{y}");

            #endregion 

            for (int i = 1; i <= 30; i++)
            {
                int randNum = MathUtility.RandInRange(5, 10);
                Console.WriteLine(randNum);
            }
        }

        void Print(int a, double b)
        {
            // Console.WriteLine(a + "and" + b);
            a = -10;
            b = 1E6;

            Console.WriteLine($"{a}and{b}");
        }

    }
}
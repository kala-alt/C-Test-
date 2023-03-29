using System;
using System.IO;

namespace MyApplication
{

    class Car {
        string model = "Ford";
        string color = "red";
        Car() { 
        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string a = Convert.ToString(x);
            double f = 5.6;
            int y = (int) Math.Round(f);
            Console.WriteLine("Nice! Hello world!");
            Console.WriteLine(y);
        }
    }
}
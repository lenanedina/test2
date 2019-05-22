using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {


            task21(x: 1);
            task12();
            task17();
            task19();
            task26();
            task28();
            //task2();

            //Console.WriteLine($"задание 21: {task3(0.1)}");
        }

        private static void task21(Double x)
        {
            Double result = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x))) / Math.Log(1 + x * x);
            //Console.WriteLine("задание 21: "+result);
            Console.WriteLine($"задание 21: {result}");

        }
        /*
        private static void task2()
        {
            Double result, x;
            x = 1;
             result = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x))) / Math.Log(1 + x * x);
            Console.WriteLine($"задание 21: {result}");
        }
        private static Double task3(Double x)
        {
            Double result = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x))) / Math.Log(1 + x * x);
            return result;
        }
        */

        private static void task12()
        {
            Double result, x;
            x = 1;
            result = (x * x - 7 * x + 10) / (x * x - 8 * x + 12);
            Console.WriteLine($"задание 12: {result}");


        }
        private static void task17()
        {
            Double result, x, y;
            x = 5; y = 1;
            result = x * (Math.Log(x))  + (y / (Math.Cos(x) - x / 3));
            Console.WriteLine($"задание 17: {result}");
        }
        private static void task19()

        {
            Double result, x, y, e;
            e = 1; x = 2; y = 1;
            result = (Math.Pow(e, x) - ((Math.Pow(y, 2)) + 12 * x * y - 3 * (Math.Pow(x, 2))) / 18 * y - 1);
            Console.WriteLine($"задание 19: {result}");
        }
        private static void task26()
        {
             Double result, x, y;
             x = 2; y = 1;
            result = (1+Math.Pow(Math.Sin(x+y),2)) / (2+Math.Abs(x-2*x/(1+x*x*y*y))) + x;
            Console.WriteLine($"задание 26: {result}");
        }
        private static void task28()
        {
            Double result,a,b,c,d,y,f,x,z;
            a = 1; b = 1.1; c = 1.2;d = 1.3;f = 1.4; x = 1.5; z = 2; y=1.6;
            result = (Math.Cos(x) * Math.Cos(x) / Math.Sin(x)) - x * y * z + ((a * Math.Pow(x, 2) + b * x + c) / d * Math.Pow(x, 3) - f);
            Console.WriteLine($"задание 28: {result}");
        }

    }



}

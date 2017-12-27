using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Exercises 1.1 -----");
            Number();
            Console.WriteLine("----- Exercises 1.2 -----");
            NumberMax();
            Console.WriteLine("----- Exercises 1.3 -----");
            Image();
            Console.WriteLine("----- Exercises 1.4 -----");
            SpeedLimit();
        }

        static void Number()
        {
            Console.WriteLine("Number between 1 to 10 : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void NumberMax()
        {
            Console.WriteLine("Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int numMax = (num1 >= num2) ? num1 : num2;

            Console.WriteLine("Maximum = " + numMax);
        }

        static void Image()
        {
            string image = "square";
            Console.WriteLine("Width : ");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height : ");
            int Height = Convert.ToInt32(Console.ReadLine());
            if (Width != Height)
            {
                image = (Width > Height) ? "landscape" : "portrait";
            }
            
            Console.WriteLine("The image is  " + image);
        }

        static void SpeedLimit()
        {
            Console.WriteLine("Speed Limit : ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed of a car : ");
            int speedCar = Convert.ToInt32(Console.ReadLine());
            if (speedLimit < speedCar)
            {
                int dem = (speedCar - speedLimit) / 5;
                string dem1 = (dem > 12) ? "License Suspended" : dem + " demerit points ";
                Console.WriteLine(dem1);
            }
            else
            {
                Console.WriteLine("OK");
            }
        }

    }
}

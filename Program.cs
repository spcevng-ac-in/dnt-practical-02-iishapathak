using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter distance = ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter weight = ");
            double weight = Convert.ToDouble(Console.ReadLine());

            int rate = 0;
            if (distance < 100)
                rate = 50;
            else if (distance < 200)
                rate = 65;
            else if (distance < 300)
                rate = 90;
            else
                rate = 120;

            double totalCost = weight * rate;

            Console.WriteLine("Total cost = " + totalCost);

            Console.Read();
        }
    }
}

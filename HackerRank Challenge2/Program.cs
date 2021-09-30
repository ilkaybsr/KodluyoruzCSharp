using System;

namespace HackerRank_Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Double.Parse(Console.ReadLine());
            int tip_percent = Int32.Parse(Console.ReadLine());
            int tax_percent = Int32.Parse(Console.ReadLine());

            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;

            double total = meal_cost + tip + tax;
           

            Console.WriteLine(Math.Round(total));

           
              

            

        }
    }
}
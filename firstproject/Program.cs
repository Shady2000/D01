using System;
namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam 's carapet cleaning service");
            Console.WriteLine("charges:");
            Console.WriteLine("$25 per small");
            Console.WriteLine("$35 per large");
            Console.WriteLine("sales tex rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");
            int small = 25;
            int large = 35;

            Console.Write("Enter Number of Small carpets : ");
            int numberOfsmallcarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Large carpets : ");
            int numberOflargecarpets = Convert.ToInt32(Console.ReadLine());

            double tax = 0.06;

            int cost = (numberOfsmallcarpets * small) + (numberOflargecarpets * large);
            Console.WriteLine($"Cost : {cost.ToString("c")}");

            Console.WriteLine($"Tax : {(cost*tax).ToString("c")}");
            Console.WriteLine($"Total estimate:{((cost) + (cost * tax)).ToString("c")}");


        }
    }
}

using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount, amount2, amount3;
            double average, total;

            Console.WriteLine("Yo! Enter 3 different dollar amounts without the dollar sign.");
            amount = Convert.ToDouble(Console.ReadLine());
            amount2 = Convert.ToDouble(Console.ReadLine());
            amount3 = Convert.ToDouble(Console.ReadLine());
            average = (amount + amount2 + amount3) / 3;
            total = amount + amount2 + amount3;
           

            Console.WriteLine("\n");
            Console.WriteLine("average: {0:C}", Math.Round(average,2));

            // if else to find smallest dollar amount
            if (amount < amount2 && amount < amount3)
            {
                Console.WriteLine("the smallest is: {0:C}", amount);
            }
            else if (amount2 < amount && amount2 < amount3)
            {
                Console.WriteLine("the smallest is: {0:C}", amount2);
            }
            else
            {
                Console.WriteLine("the smallest is: {0:C}", amount3);
            }

            // if else to find largest dollar amount
            if (amount > amount2 && amount > amount3)
            {
                Console.WriteLine("the largest is: {0:C}", amount);
            }
            else if(amount2 > amount && amount2 > amount3)
            {
                Console.WriteLine("the largest is: {0:C}", amount2);
            }
            else
            {
                Console.WriteLine("the largest is: {0:C}", amount3);
            }
            Console.WriteLine("\n");

            //total: currency format & conversion
            Console.WriteLine("----Total----");
            Console.WriteLine("US: {0:C}", total);
            Console.WriteLine("Swedish: " + total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Japanese: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH"))); // outputs a '?' instead of currency sign
        }
    }
}

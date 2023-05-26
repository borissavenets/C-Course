using System;
using System.Transactions;

namespace ConsoleApp1___HM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            decimal solaryCompany;

            solaryCompany = Decimal.One;
            Console.WriteLine(solaryCompany);
            var test = Console.ReadLine();

            Console.WriteLine(test);
            Console.WriteLine (test+1);

            const double pi = 3.14;
            
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine (number); 
        }
    }
}
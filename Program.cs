﻿namespace Economics;

class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine($"Please, What is your name?");
          string? name = Console.ReadLine();

          Console.WriteLine($"Good morning! {name}, You are welcome to our bank \n");

          Console.WriteLine("Kindly input your capital data?");
          double capital = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Kindly enter your deficit data");
          double deficit = Convert.ToDouble(Console.ReadLine());

          double summary = CashAccount(capital, deficit);
            
            // ! Condition to check for low and high cash
            if (summary < 5000)
            {
            Console.WriteLine($"Your cash account balance in our bank is {summary} and is very low.");
            }
            else
            {
            Console.WriteLine($"Your cash account balance in our bank of {summary} is very impressive.");
            }
    }

    // * Initial accounting calculation of (CashAccount & FundAccount)
        private static double CashAccount(double capital, double deficit)
        {
            double account = capital / deficit;
            return account;
        }
        private static double FundAccount(double demand, double supply)
        {
            double price = demand * supply;
            return price;
        }
}

namespace Economics;

class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine($"Please, What is your name?");
          string? name = Console.ReadLine();

          Console.WriteLine($"Good Evening! {name}, You are welcome to our bank. Let check your data. \n");

          Console.WriteLine("Kindly input your demand data?");
          double demand = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Kindly enter your deficit data");
          double supply = Convert.ToDouble(Console.ReadLine());

          double summary = FundAccount(demand, supply);
            
            // * Condition to check for low and high cash
            if (summary < 10000)
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

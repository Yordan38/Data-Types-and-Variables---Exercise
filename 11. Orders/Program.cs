using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double orderPrice = 0;
            double total = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                for (int j = countOfOrders; j <= countOfOrders; j++)
                {
                    double price = double.Parse(Console.ReadLine());
                    int daysOfMonth = int.Parse(Console.ReadLine());
                    int countCapsules = int.Parse(Console.ReadLine());
                     orderPrice = (daysOfMonth * countCapsules) * price;
                    total += orderPrice;
                    Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                }
                
            }
           
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}

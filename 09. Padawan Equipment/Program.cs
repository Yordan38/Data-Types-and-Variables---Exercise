using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int countBelt = 0;
            int sumCountBelt = 0;
            double totalPriceLightSabers = (Math.Ceiling(countStudents * 1.1)) * priceLightSabers;
            double totalPriceRobe = countStudents  * priceRobe;
            double totalPriceBelt = countStudents  * priceBelt;

            if (countStudents >= 6)
            {
                while (countStudents >= sumCountBelt)
                {
                    countBelt++;
                    if (countBelt >= 6)
                    {
                        totalPriceBelt = (countStudents - 1) * priceBelt;
                        sumCountBelt += countBelt;
                        countBelt = 0;
                        countStudents--;
                    }

                }
            }

           
            double total = totalPriceLightSabers + totalPriceRobe + totalPriceBelt;



            if (budget < total)
            {
                Console.WriteLine($"John will need {total - budget:f2}lv more.");
            }
            else if(budget >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
           
        }
    }
}

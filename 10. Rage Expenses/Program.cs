using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGameLost = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMause = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            int countHeadset = 0;
            int countMause = 0;
            int countKeyboard = 0;
            int countDisplay = 0;
            while (countGameLost >= 2)
            {
                if (countGameLost % 2 == 0)
                {
                    countHeadset++;
                }
                if (countGameLost % 3 == 0)
                {
                    countMause++;
                }
                if (countGameLost % 6 == 0)
                {

                    countKeyboard++;
                    if (countKeyboard % 2 == 0)
                    {
                        countDisplay++;
                    }
                }
                //if (countGameLost % 12 == 0)
                //{
                  
                    

                    
                //}
                countGameLost--;
            }
            double totalPrice = countHeadset * priceHeadset + countMause
                * priceMause + countKeyboard * priceKeyboard + countDisplay * priceDisplay;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}

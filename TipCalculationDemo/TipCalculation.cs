using System;
using System.Globalization;

namespace TipCalculationDemo
{
    class TipCalculation
    {
        static void Main(string[] args)
        {
            double price = 30.00;
            double tipRate = 0.20;
            int tipInDollars = 6;

            DisplayTipInfo(price, tipRate);
            DisplayTipInfo(price, tipInDollars);
        }

        public static void DisplayTipInfo(double price, double tipRate)
        {
            double tipInDollars = price * tipRate;
            double totalBill = price + tipInDollars;
            Console.WriteLine("Meal price: {0}. Tip percent: {1:n2}\n" +
                "Tip in dollars: {2}.  Total bill {3}", 
                price.ToString("C", CultureInfo.GetCultureInfo("en-US")), 
                tipRate, tipInDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")), 
                totalBill.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }
        public static void DisplayTipInfo(double price, int tipInDollars)
        {
            double tipRate = tipInDollars / price;
            double totalBill = price + tipInDollars;
            Console.WriteLine("Meal price: {0}. Tip percent: {1:n2}\n" +
                "Tip in dollars: {2}.  Total bill {3}",
                price.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                tipRate, tipInDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                totalBill.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }
    }
}

using System;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        }


        public int MaxProfit(int[] prices)
        {

            int profit = 0;

            for (int i = 1; i< prices.Length ; i++)
            {

                if (prices[i-1] < prices[i])
                {
                    profit =profit + prices[i] - prices[i - 1];
                }
            }

            return profit;
        }
    }
}

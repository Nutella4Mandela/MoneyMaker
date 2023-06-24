using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount to convert to coins:");
            string coinString = Console.ReadLine();

            double coinDouble = Convert.ToDouble(coinString);

            double goldValue = 10;
            double silverValue = 5;

            double goldCoins = Math.Floor(coinDouble / goldValue);
            double bronzeCoins = coinDouble % goldValue;

            double silverCoins = Math.Floor(bronzeCoins / silverValue);
            bronzeCoins = coinDouble % silverValue;

            Console.WriteLine($"{coinDouble} cents is equal to...");
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {bronzeCoins}");


        }
    }
}

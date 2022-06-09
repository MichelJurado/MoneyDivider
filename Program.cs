//Michel Jurado

using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount to convert to coins");

            //convert a string to a number 
            int price = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Your amount is equal to...");

            double goldCoin = 10;
            double silverCoin = 5;

            //amount of gold coins that can fit into the user entered price
            double goldsInPrice = Math.Floor(price / goldCoin);

            //amount left after gold coins
            double leftOver = price % goldCoin;

            //amount of silver coins in leftover
            double silversInPrice = Math.Floor(leftOver / silverCoin);

            leftOver = leftOver % silverCoin;

            Console.WriteLine($"Gold coins: {goldsInPrice}");
            Console.WriteLine($"Silver coins: {silversInPrice}");
            Console.WriteLine($"Bronze coins: {leftOver}");

        }
    }
}

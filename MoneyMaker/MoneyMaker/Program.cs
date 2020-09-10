    using System;

    namespace MoneyMaker
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Money Maker!");
                Input();
            }

            public static void Input()
            {
                Console.WriteLine("How much do you want to Convert?");
                string amount = Console.ReadLine();

                double amountTwo = Convert.ToDouble(amount);

                Console.WriteLine($"{amount} is equal to... ");

                int Gold = 10;
                int silver = 5;

                double goldCoins = Math.Floor(amountTwo / Gold);
                double leftOver = goldCoins % Gold;
                double silverCoins = Math.Floor(leftOver / silver);
                leftOver = leftOver % silverCoins;

                Console.WriteLine($" Gold coins: {goldCoins}");
                Console.WriteLine($" Silver coins: {silverCoins}");
                Console.WriteLine($" Bronze coins: {leftOver}");

            }
        }
    }

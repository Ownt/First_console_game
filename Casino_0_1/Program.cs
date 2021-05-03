using System;

namespace Casino_0_1
{
    class Player
    {
        public string name;
        public int money = 100;
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("You want to play?(y - yes, n - no): ");
            string selection = Console.ReadLine();
            switch (selection)
            {        
                case "y":   
                    Game();
                    break;    
                case "n":  
                    break;
            }
        }

        public static void Game()
        {
            Player player = new Player();
            player.name = "Olham";

            string selection = "y";
            while (selection == "y")
            {

                Console.WriteLine(player.name);
                Balance(ref player.money);

                int number_bet = 0;
                Number_Bet(ref number_bet);

                int bet = 0;
                Bet(ref bet);

                int random_number = 0;
                Randomizer(ref random_number);

                if (number_bet == random_number)
                {
                    Win(ref player.money, ref bet);
                }
                else
                {
                    Lose(ref player.money, ref bet);
                }

                Console.Write("\nYou want to play?(y - yes, n - no): ");
                selection = Console.ReadLine();
            }
        }

        public static int Bet(ref int bet)
        {
            Console.Write("Place your bet: ");
            bet = Convert.ToInt32(Console.ReadLine());
            return bet;
        }

        public static int Number_Bet(ref int number_bet)
        {
            Console.Write("Select the number you want to bet on (from 0 to 10): ");
            number_bet = Convert.ToInt32(Console.ReadLine());
            return number_bet;
        }

        public static int Randomizer(ref int number)
        {
            Random random = new Random();
            number = random.Next(0, 10);
            Console.WriteLine("Number dropped: " + number);
            return number;
        }

        public static void Balance(ref int money)
        {
            Console.WriteLine("Your balance: " + money);
        }

        public static int Win(ref int money, ref int bet)
        {
            Console.WriteLine("You won, your winnings amounted to: " + bet * 2);
            money += bet * 2;
            Console.WriteLine("On balance: " + money);
            return money;
        }

        public static int Lose(ref int money, ref int bet)
        {
            Console.WriteLine("You lost, bet: " + bet);
            money -= bet;
            Console.WriteLine("On balance: " + money);
            return money;
        }

    }

}
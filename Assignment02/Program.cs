/*
 * Student ID : 1690700404
 * Name       : Sukruethai Noppakao
 * Section    : 129A
 * No.        : 22
 * Course     : GI113 Computer Programming (GI)
 */


namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"                 **            ");
            Console.WriteLine($"     ========================== ");
            Console.WriteLine($"    ++ the LiLy da ruby FORGE ++ ");
            Console.WriteLine($"     ========================== ");
            Console.WriteLine($"                 ##          ");

            const string ore = "RUBY";
            const string ingot = "GEMSTONE";
            const double smelting = 0.4;
            const double salvage = 0.5;
            const int maxBatch = 800;

            Console.WriteLine();
            Console.WriteLine($"=> {ore} Smelting {smelting} / Salvage {salvage}");
            Console.WriteLine();
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"|               MENU               |");
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"| 'S' for Smelt (Ore -> Ingot)     |");
            Console.WriteLine($"| 'B' for Breakdown (Ingot -> Ore) |");
            Console.WriteLine($"------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to do today!(s&B): ");
            bool userInput = char.TryParse(Console.ReadLine(), out char ToDo);

            Console.WriteLine();
            Console.WriteLine($"Enter the amount of {ore} or {ingot}!: ");
            bool amountInput = double.TryParse(Console.ReadLine(), out double amount);

            if (!amountInput || (amount <= 0))
            {
                Console.WriteLine();
                Console.WriteLine($"ERROR (AMOUNT): Invalid input, Please try again with some {ore} and more than zero!");
            }
            else if (!amountInput || (amount > maxBatch))
            {
                Console.WriteLine();
                Console.WriteLine($"ERROR (AMOUNT): Too much {ore}! Please try again with an amount that less than or equal to {maxBatch}!");
            }
            else if (amountInput && amount > 0 && amount <= maxBatch)
            {
                if (ToDo == 'S' || ToDo == 's')
                {
                    double ingotAmount = amount * smelting;
                    Console.WriteLine();
                    Console.WriteLine($"You'll get {ingotAmount} {ingot}s from {amount} {ore}s ");
                }
                else if (ToDo == 'B' || ToDo == 'b')
                {
                    double oreAmount = amount / salvage;
                    Console.WriteLine();
                    Console.WriteLine($"You'll get {oreAmount} {ore}s from {amount} {ingot}s ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"ERROR (MENU): Invalid input, Please try again Choose your menu between 'S' or 'B'");
                }
            }
        }
    }
}

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

            if (!userInput || (ToDo != 'S' && ToDo != 's' && ToDo != 'B' && ToDo != 'b'))
            {
                Console.WriteLine();
                Console.WriteLine($"Invalid input, Please try again Choose your menu between 'S' or 'B'");
            }
            else if (ToDo == 'S' || ToDo == 's')
            {
                Console.WriteLine();
                Console.WriteLine($"How much {ore} you want to smelt?: ");
                bool oreInput = double.TryParse(Console.ReadLine(), out double oreAmount);
                if ( oreAmount > 0 && oreAmount <= maxBatch )
                {
                    double ingotAmount = oreAmount * smelting;
                    Console.WriteLine();
                    Console.WriteLine($"You'll get {ingotAmount} {ingot}s from {oreAmount} {ore}s ");
                }
                else if (oreAmount > maxBatch)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Too much {ore}! Please try again ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Invalid input, Please try again with some {ore}!");
                }
            }
            else if (ToDo == 'B' || ToDo == 'b')
            {
                Console.WriteLine();
                Console.WriteLine($"How much {ingot} you want to breakdown?: ");
                bool ingotInput = double.TryParse(Console.ReadLine(), out double ingotAmount);
                if (ingotAmount > 0 && ingotAmount <= maxBatch )
                {
                    double oreAmount = ingotAmount / salvage;
                    Console.WriteLine();
                    Console.WriteLine($"You'll get {oreAmount} {ore}s from {ingotAmount} {ingot}s ");
                }
                else if (ingotAmount > maxBatch)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Too much {ingot}! Please try again ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Invalid input, Please try again with some {ingot}!");
                }
            }
        }
    }
}

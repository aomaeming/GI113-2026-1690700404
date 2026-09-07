/*
 * Student ID : 1690700404
 * Name       : Sukruethai Noppkaao
 * Section    : 129A
 * No.        : 22
 * Course     : GI113 Computer Programming (GI)
 */


namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("+------------------------+");
            //Console.WriteLine("       NEW ADVENTURE      "); // Print ธรรมดา Title
            //Console.WriteLine("+------------------------+");

            //Console.Write("Name your hero : "); // WriteLine พิมพ์บรรทัดใหม่, Write พิมพ์ต่อยาวบรรทัดเดิม

            //string playerName = Console.ReadLine(); // เมื่อผู้เล่นกรอกชื่อ จากนั้นชื่อจะเข้าไปเก็บใน playerName

            //Console.WriteLine($"\n\"Welcome!, Glad to see you {playerName} Your journey begins now!...\"");

            //Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Console.Write("Choose difficulty you want {playerName} (1-3): ");
            //Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            //string choice = Console.ReadLine(); // รับ input และเก็บใส่ choice
            //int difficulty = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Difficulty set to {difficulty}.");

            //Console.WriteLine("+------------------------+");
            //Console.WriteLine("        ITEM SHOP         ");
            //Console.WriteLine("+------------------------+");
            //Console.Write("How many potions? ");

            //bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            //Console.WriteLine($"Valid input: {isValid}");
            //Console.WriteLine($"Quantity: {quantity} potions");

            //Console.WriteLine("+|||||||||||||||||||||||||||||+");
            //Console.WriteLine("        RATE THIS LEVEL        ");
            //Console.WriteLine("+|||||||||||||||||||||||||||||+");
            //Console.Write("Rate this level (0.0-5.0): ");

            //bool isValid = double.TryParse(Console.ReadLine(), out double rating);
            //Console.WriteLine($"Valid input: {isValid}");
            //Console.WriteLine($"Rating: {rating} potions");

            Console.WriteLine("+---------------------------------+");
            Console.WriteLine("        CHARACTER CREATION         ");
            Console.WriteLine("+---------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} the class-{classNum} adventure enters the dungeon your luck is {luck}");
        }
    }
}

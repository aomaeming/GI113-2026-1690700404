/*
 * Student ID : 1690700404
 * Name       : Sukruethai Noppakao
 * Section    : 129A
 * No.        : 22
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int lives = 0;

            if (lives <= 0) // ด้านในวงเล็บ ต้องมีค่าเป็น Boolean
            {
                Console.WriteLine("Game Over!"); // โค้ดจะรันเมื่อ if เป็นจริงเท่านั้น
            }

            Console.WriteLine("Continue Running");

            // 2
            int coins = 80;
            int price = 100;

            if (coins >= price)
            {
                Console.WriteLine("Purchased"); // รันเมื่อเป็นจริง
            }
            else
            {
                Console.WriteLine("Not enough coins"); // รันเมื่อเป็นเท็จ
            }

            // 3
            int score = 75;

            if (score >= 90) // ลำดับ 1 เช็ค = เท็จ
            {
                Console.WriteLine("Rank S"); // โค้ดไม่รัน ไม่อ่าน
            }
            else if (score >= 60) // ลำดับ 2 เช็ค = จริง
            {
                Console.WriteLine("Rank A"); // โค้ดรัน
            }
            else // เป็นกรณีที่ไม่ตรงกับทั้งสองลำดับด้านบน มีเป็นจริงแล้วส่วนนี้ไม่รัน
            {
                Console.WriteLine("Rank B");
            }

            // 4
            bool hasKey = true; // ผู้เล่นมีกุญแจหรือไม่
            Console.Write("Your level (1-99): ");
            bool putlevel = int.TryParse(Console.ReadLine(), out int level);

            if (!putlevel || level < 1 || level > 99) // เช็คกรณี user ใส่ผิด
            {
                Console.WriteLine("Invalid Level, Please try again");
            }
            else if ( level >= 10 && hasKey) // ใส่เงื่อนไขกุญแจ
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door opens");
            }
            else 
            {
                Console.WriteLine("The door stays shut");
            }
            */

            int playerHP = 100;
            int fishHP = 50;
            int rod = 50;

            Console.WriteLine("VALLI Valley");
            Console.WriteLine(">=== Fishing ===<");
            Console.WriteLine("ACTION A: SWING");
            Console.WriteLine("ACTION B: PULL\n");

            // รับ input ผู้เล่น
            Console.Write("Choose your action: ");
            bool inputOk = char.TryParse(Console.ReadLine(), out char choice);

            // เช็คว่าผู้เล่นพิมพ์มาภูกมั้ย 1 ตัวอักษร A a หรือ b B
            if (!inputOk || (choice != 'a' && choice != 'A' && choice != 'b' && choice != 'B'))
            {
                Console.WriteLine("Invalid input, Please choose between a & b");
            }
            else if (choice == 'a' || choice == 'A')
            {
                // ให้ทำอะไรเมื่อเลือก1
                fishHP -= rod;
                // ผู้เล่นโจมตีปลา n หน่วย เลือดเหลือ...
                if (fishHP <= 0)
                {
                    Console.WriteLine($"The rod took {rod} damage, You caught the fish!"); // output เมื่อ HP เหลือ 0
                }
                else
                {
                    Console.WriteLine($"The rod took {rod} damage, the fish has {fishHP} HP left"); // output เมื่อ HP เหลือมากกว่า 0
                }
            }
            else if (choice == 'b' || choice == 'B')
            {
                // ให้ทำอะไรเมื่อเลือก2
                playerHP -= rod;
                // ผู้เล่นวิ่งหนีมอน โดนโจมตี n หน่วย เลือดผู้เล่นเหลือ...
                Console.WriteLine($"Player pull rog so hard lose {playerHP} HP");
            }
            else
            { 
                Console.WriteLine("Timeout: You ran out of time, The fish ran away!");
            }
        }      
    }
}

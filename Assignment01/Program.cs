/*
 * Student ID : 1690700404
 * Name       : Sukruethai Noppakao
 * Section    : 129A
 * No.        : 22
 * Course     : GI113 Computer Programming (GI)
 */


namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Game = "Silent Hill f";

            var weaponName = "KAiKen";
            var availability = 'C'; // S = Legendary, A = Epic, B = Rare, C = Uncommon, D = Common, E = Abundant
            string weaponCategorie = "Light"; // Light = อาวุธเบา, Medium = อาวุธกลาง, Heavy = อาวุธหนัก
            int damage = 30; // ดาเมจ(เบา)ต่อฮิต
            int durability = 18; // ความทนทาน (กี่ฮิตพัง)
            int stamina = 5; // สตามิน่าที่ใช้ในการตี1ครั้ง
            float range = 0.6f; // ระยะทางในการฮิต (เมตร)
            double speed = 2.6; // ความเร็วการฮิตต่อวิ
            bool isSpecialWeapon = false;

            Console.WriteLine($"                ╔════════════════════════════════════════╗ \r\n               *║             {Game}              ║*\r\n                ╚════════════════════════════════════════╝\r\n");
            Console.WriteLine($"Look what you've got in your inventory! (2)");
            Console.WriteLine();
            Console.WriteLine($"____________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"                              * * * * * *\r\n                            * * {weaponName}  * *\r\n                              * * * * * * ");
            Console.WriteLine();
            Console.WriteLine($"{weaponName} is a tier {availability} {weaponCategorie} weapon");
            Console.WriteLine($"It deals {damage} damage to the enemy per hit! , The range is {range} m be careful!");
            Console.WriteLine($"Durability == {durability}");
            Console.WriteLine($"Speed == {speed}");
            Console.WriteLine($"Stamina required per hit : {stamina} strength");
            Console.WriteLine($"Is this a special weapon? --> No, {isSpecialWeapon}");
            Console.WriteLine();

            double damageAsDouble = damage;
            Console.WriteLine($"Damage as double (implicit): {damageAsDouble}");

            int speedTruncated = (int)speed;
            int speedRounded = Convert.ToInt32(speed);
            Console.WriteLine($"Speed cast (truncates)    : {speedTruncated}");
            Console.WriteLine($"Speed Convert (rounds)  : {speedRounded}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |");
            Console.WriteLine();


            var weaponName2 = "NaGiNaTA";
            char availability2 = 'A'; // S = Legendary, A = Epic, B = Rare, C = Uncommon, D = Common, E = Abundant
            var weaponCategorie2 = "Heavy"; // Light = อาวุธเบา, Medium = อาวุธกลาง, Heavy = อาวุธหนัก
            int damage2 = 45; // ดาเมจ(เบา)ต่อฮิต
            int durability2 = 50; // ความทนทาน (กี่ฮิตพัง)
            int stamina2 = 30; // สตามิน่าที่ใช้ในการตี1ครั้ง
            float range2 = 2.1f; // ระยะทางในการฮิต (เมตร)
            double speed2 = 0.55; // ความเร็วการฮิตต่อวิ
            bool isSpecialWeapon2 = false;

            Console.WriteLine();
            Console.WriteLine($"                              * * * * * *\r\n                            * * {weaponName2} * *\r\n                              * * * * * * ");
            Console.WriteLine();
            Console.WriteLine($"{weaponName2} is a tier {availability2} {weaponCategorie2} weapon");
            Console.WriteLine($"It deals {damage2} damage to the enemy per hit! , The range is {range2} m great!");
            Console.WriteLine($"Durability == {durability2}");
            Console.WriteLine($"Speed == {speed2}");
            Console.WriteLine($"Stamina required per hit : {stamina2} strength");
            Console.WriteLine($"Is this a special weapon? --> No, {isSpecialWeapon2}");
            Console.WriteLine();

            double damageAsDouble2 = damage2;
            Console.WriteLine($"Damage as double (implicit): {damageAsDouble2}");

            int speedTruncated2 = (int)speed2;
            int speedRounded2 = Convert.ToInt32(speed2);
            Console.WriteLine($"Speed cast (truncates)    : {speedTruncated2}");
            Console.WriteLine($"Speed Convert (rounds)  : {speedRounded2}");
            Console.WriteLine();
            Console.WriteLine($"____________________________________________________________________________");
        }
    }
}

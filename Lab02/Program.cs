/*
 * Student ID : 1690700404
 * Name       : Sukruethai Noppakao
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            int damage = 60;
            int newHp = currentHp - damage;
            int newHpPercent = newHp * 100 / maxHp;
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {newHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {newHpPercent}%");

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("=**= VALLEY VILLAGE =**=");                           // ธีมเกม : เกมสร้างหมู่บ้านในหุบเขา ปลูกผักทำฟาร์ม
            Console.WriteLine();
            Console.WriteLine("AICHAN*");
            Console.WriteLine();
            string aiVillager = "Aichan";                                            // ชื่อ
            char aiTier = 'S';                                                       // ความหายาก
            int aiMaxStamina = 80;                                                   // พลังงานที่ตัวละครใช้ได้ทั้งหมดต่อวัน
            int aiCurrentStamina = 50;
            int aiSpeed = 120;                                                       // ความเร็วของตัวละคร
            float aiStrength = 38.6f;                                                // ความแข็งแกร่งของตัวละคร
            double aiHavestMultiplier = 0.45;                                        // อัตราการเพิ่มผลผลิตจากการเก็บเกี่ยวของตัวละคร
            bool isFarmer = false;                                                   // ตัวละครนี้เป็นชาวนาไหม : ไอจังเป็นหมอ
            Console.WriteLine($"Tier: {aiTier}");
            Console.WriteLine($"Stamina: {aiCurrentStamina} / {aiMaxStamina}");
            Console.WriteLine($"Speed: {aiSpeed}");
            Console.WriteLine($"Strength: {aiStrength}");
            Console.WriteLine($"Farmer?: {isFarmer}");
            Console.WriteLine();

            Console.WriteLine("LILAC*");
            Console.WriteLine();
            string liVillager = "Lilac";
            char liTier = 'A';
            int liMaxStamina = 130;
            int liCurrentStamina = 100;
            int liSpeed = 95;
            float liStrength = 68.3f;
            double liHavestMultiplier = 3.88;
            bool isFarmerL = true;
            Console.WriteLine($"Tier: {liTier}");
            Console.WriteLine($"Stamina: {liCurrentStamina} / {liMaxStamina}");
            Console.WriteLine($"Speed: {liSpeed}");
            Console.WriteLine($"Strength: {liStrength}");
            Console.WriteLine($"Harvest Multiplier: {liHavestMultiplier}");
            Console.WriteLine();

            Console.WriteLine("AMETIS*");
            Console.WriteLine();
            string aVillager = "Ametis";
            char aTier = 'S';
            int aMaxStamina = 210;
            int aCurrentStamina = 180;
            int aSpeed = 80;
            float aStrength = 109.4f;
            double aHavestMultiplier = 8.52;
            bool isFarmerA = true;
            Console.WriteLine($"Tier: {aTier}");
            Console.WriteLine($"Stamina: {aCurrentStamina} / {aMaxStamina}");
            Console.WriteLine($"Strength: {aStrength}");
            Console.WriteLine($"Harvest Multiplier: {aHavestMultiplier}");
            Console.WriteLine($"Farmer?: {isFarmerA}");
            Console.WriteLine();

            Console.WriteLine("LARA*");
            Console.WriteLine();
            string laVillager = "Lara";
            char laTier = 'B';
            int laMaxStamina = 100;
            int laCurrentStamina = 98;
            int laSpeed = 75;
            float laStrength = 42.7f;
            double laHavestMultiplier = 1.46;
            bool isFarmerR = false;                                                        // ลาร่าเป็นชาวประมง
            Console.WriteLine($"Tier: {laTier}");
            Console.WriteLine($"Stamina: {laCurrentStamina} / {laMaxStamina}");
            Console.WriteLine($"Speed: {laSpeed}");
            Console.WriteLine($"Strength: {laStrength}");
            Console.WriteLine($"Farmer?: {isFarmerR}");
            Console.WriteLine();
        }
    }
}

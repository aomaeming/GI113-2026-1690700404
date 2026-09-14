/*
 * Student ID : 1690700404
 * Name       : Sukruethai Noppakao
 * Section    : 129A
 * No.        : 22 
 * Course     : GI113 Computer Programming (GI)
 */


namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===> BATTLE MAGE <=== ");
            Console.WriteLine("Hero vs. Monster -- Fight Calculator ");

            // user input of hero stats
            Console.WriteLine("Hero Health:  ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack:  ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defence:  ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);


            // user input of monster stats
            Console.WriteLine("Monster Health:  "); 
            bool isMonHp = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack:  ");
            bool isMonAtk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defence:  ");
            bool isMonDef = int.TryParse(Console.ReadLine(), out int monDef);

            // Check if player input is vaild
            bool allHeroVaild = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonVaild = isMonHp && isMonAtk && isMonDef;
            Console.WriteLine($"Stats Validation : HERO : {allHeroVaild} , MONSTER: {allMonVaild}");
            Console.WriteLine($"[HERO] HP: {heroHp} , ATK: {heroAtk} , DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monHp} , ATK: {monAtk} , DEF: {monDef}");

            // Before fighting : Hero drinks a potion (compound assignment)
            int potionHeal = 8;

            // 1  heroHp = heroHp + potionHeal;

            // 2     
            heroHp += potionHeal; // แนะนำแบบนี้ คำนวณเหมือนกัน 1 = 1+2
            Console.WriteLine($"\nHero drinks a potion, Healing {potionHeal}HP. Health is now: {heroHp}");

            // คำนวณ damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, heroAtk - monDef); // ATK 10 DEF 5 หลังคำนวณ ATK จะไม่ได้ลดเหลือ 5
            Console.WriteLine($"Normal Attack deal : {normalDamage} DMG");

            // คำนวณ power attack (Predence ลำดับการคำนวณ คูณ ก่อนที่จะ ลบ)
            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef); // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี ()
            Console.WriteLine($"Power Attack deal : {powerDamage} DMG");

            // คำนวณ Monster Attack
            int counterDamage = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster counter attack deal : {counterDamage} DMG");

            // คำนวณ Cri chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // สุ่ม Cri 1-100
            bool isCrit = roll <= 10; // 10%
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริเลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"Critical Hit Roll : {roll} (Critical : {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical : {criDamage} DMG");
        }
}

/*
 * Student ID : 1690700784
 * Name       : ธนกฤต อินทุย
 * Section    : 129 A
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===> BATTLE MAGE <=== ");
            Console.WriteLine("Hero vs. Monsters -- Fight Calculator ");

            // User input of Hero stats
            Console.Write("Hero Health: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defence: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            // User input of Monster stats
            Console.Write("Monster Health: ");
            bool isMonHp = int.TryParse(Console.ReadLine(), out int monHp);
            int monMaxHp = monHp;
            Console.Write("Monster Attack: ");
            bool isMonAtk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defence: ");
            bool isMonDef = int.TryParse(Console.ReadLine(), out int monDef);

            // Check if player input is valid
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonValid = isMonHp && isMonAtk && isMonDef;
            Console.WriteLine($"Stats Validation: HERO: {allHeroValid}, MONSTER: {allMonValid}");
            Console.WriteLine($"[HERO]      HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: {monHp} ATK: {monAtk} DEF: {monDef}");
            // Before fighting: Hero drinks a potion (Compound Assignment: +=)
            int potionHeal = 8;
            heroHp += potionHeal;
            Console.WriteLine($"\n=> Hero drinks a potion, Healing {potionHeal}HP. health is now {heroHp}.");

            // คำนวณ damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max (0, heroAtk - monDef);  // ATK 10 DEF 5 หลังคำนวณ ATK จะไม่ได้ลดเหลือ 5
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

            // คำนวณ power attack (Predence ลำดับการคำนวณ คูณ ก่อนที่จะ ลบ)
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef); // เรียบลำดับ * มาก่อน - ไม่จำเป็นต้องมี ( )
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            // คำนวณ Monster Attack
            int counterDamge = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamge} DMG");

            // คำนวณ Cri Chance
            Random rng = new Random(14);
            int roll = rng.Next(1, 101);    // สุ่ม Cri 1-100
            bool isCrit = roll <= 10; // 10%
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} DMG");

            // สรุปรายงานสอดแนม (comparison + logical operators)
            bool heroHitsHarder = heroAtk > monAtk;
            bool canOneShotWithNormal = normalDamage >= monHp;
            bool monsterCanOneShotHero = counterDamge >= heroHp;
            bool safeTrade = normalDamage > counterDamge && !monsterCanOneShotHero;
            bool luckyOrLethal = isCrit || canOneShotWithNormal;
            Console.WriteLine($"Hero hits harder than Monster: {heroHitsHarder}");
            Console.WriteLine($"Normal Attack can defeat Monster in one hit: {canOneShotWithNormal}");
            Console.WriteLine($"Monster could defeat Hero in one hit back: {monsterCanOneShotHero}");
            Console.WriteLine($"This is a safe trade for Hero: {safeTrade}");
            Console.WriteLine($"This attack is lucky or lethal: {luckyOrLethal}");

            // Hero ลงมือจริง แล้วสรุปผล + รางวัล
            // Hero commits to the Normal Attack (compound assignment: -=)
            monHp -= normalDamage;
            Console.WriteLine($"Hero attacks! Monster HP: {monHp}/{monMaxHp}");

            // Result + reward
            bool monsterDefeated = monHp <= 0;
            int goldEarned = (monMaxHp - monHp) * 2;
            Console.WriteLine($"Monster defeated: {monsterDefeated}");
            Console.WriteLine($"Gold earned: {goldEarned}");
        }
    }
}

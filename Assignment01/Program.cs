/*
 * Student ID : 1690700784
 * Name       : ธนกฤต อินทุย
 * Section    : 129 A
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Theme changed to "Blue Archive" — Unit / Student profile

            const string GameTitle = "Blue Archive";

            var unitName = "Sorasaki Hina";
            var unitRank = 'S';

            int unitLevel = 42;
            const int maxLevel = 100;
            float skillProcChance = 0.27f;
            double affection = 88.6;
            const int maxAffection = 100;
            bool isLimited = false;

            Console.WriteLine($"+----------------------------------------------+");
            Console.WriteLine($"|          {GameTitle} - Unit Profile         |");
            Console.WriteLine($"+----------------------------------------------+");
            Console.WriteLine($"| Name     : {unitName}");
            Console.WriteLine($"| Rank     : {unitRank}");
            Console.WriteLine($"| Level    : {unitLevel} / {maxLevel}");
            Console.WriteLine($"| Skill %  : {skillProcChance}");
            Console.WriteLine($"| Affection: {affection} / {maxAffection}");
            Console.WriteLine($"| Limited  : {isLimited}");
            Console.WriteLine($"+----------------------------------------------+");

            // Implicit conversion (int -> double)
            double levelAsDouble = unitLevel;
            Console.WriteLine($"Level as double (implicit) : {levelAsDouble}");

            // Explicit cast vs Convert.ToInt32 on the same double value
            int affectionTruncated = (int)affection;
            int affectionRounded = Convert.ToInt32(affection);
            Console.WriteLine($"Affection cast : {affectionTruncated}");
            Console.WriteLine($"Affection Convert : {affectionRounded}");
        }
    }
}

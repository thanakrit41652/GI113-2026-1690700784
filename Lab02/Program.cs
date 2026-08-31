/*
 * Student ID : 1690700784
 * Name       : ธนกฤต อินทุย
 * Section    : 129 A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A — Kirin's Status Report

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

            int hpPercentage = (currentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent: {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            int newhpPercentage = (currentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent: {newhpPercentage}%");

            // Part B — เกมของคุณเอง


            Console.WriteLine("\n===== Student Status =====");

            string studentName = "Hoshino";
            char rare = 'S';
            int age = 17;
            float highSchoolYear = 3;
            double height = 145;
            bool isAlive = true;

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Rare: {rare}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"High School Year: {highSchoolYear}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Is Alive: {isAlive}\n");

            studentName = "Shiroko";
            rare = 'A';
            age = 16;
            highSchoolYear = 2;
            height = 156;
            isAlive = true;

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Rare: {rare}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"High School Year: {highSchoolYear}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Is Alive: {isAlive}\n");

            studentName = "Nonomi";
            rare = 'B';
            age = 16;
            highSchoolYear = 2;
            height = 160;
            isAlive = true;

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Rare: {rare}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"High School Year: {highSchoolYear}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Is Alive: {isAlive}\n");

            studentName = "Serika";
            rare = 'B';
            age = 15;
            highSchoolYear = 1;
            height = 153;
            isAlive = true;

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Rare: {rare}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"High School Year: {highSchoolYear}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Is Alive: {isAlive}\n");

        }
    }
}

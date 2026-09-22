/*
 * Student ID : 1690700784
 * Name       : ธนกฤต อินทุย
 * Section    : 129 A
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentAffection = 0;
            int targetAffection = 200;

            Console.WriteLine("=== Secret Heartbeat: Royal Academy ===");
            Console.WriteLine($"Current Affection: {currentAffection} | Target: {targetAffection}\n");

            // Chapter 1: The Library
            Console.WriteLine("--- Chapter 1: The Library ---");
            Console.WriteLine("You meet Kira, the Student Council President. He asks to read a magic book with you.");
            Console.WriteLine("[1] \"Yes, I'd love to!\"");
            Console.WriteLine("[2] \"You can borrow it later.\"");
            Console.WriteLine("[3] \"No, find your own copy.\"");
            Console.Write("Choice (1-3): ");

            string input1 = Console.ReadLine();
            bool isValid1 = int.TryParse(input1, out int choice1);

            if (!isValid1 || choice1 < 1 || choice1 > 3)
            {
                Console.WriteLine("\n[Invalid] You stutter. Kira walks away.");
            }
            else if (choice1 == 1)
            {
                currentAffection += 80;
                Console.WriteLine("\nKira smiles. \"Thank you. Follow me.\" (+80)");
            }
            else if (choice1 == 2)
            {
                currentAffection += 30;
                Console.WriteLine("\nKira nods politely. \"I understand.\" (+30)");
            }
            else
            {
                currentAffection -= 20;
                Console.WriteLine("\nKira looks cold. \"How selfish.\" (-20)");
            }

            // Chapter 2: The Garden
            Console.WriteLine("\n--- Chapter 2: The Garden ---");
            Console.WriteLine("You find Kira sleeping under a tree. He looks tired.");
            Console.WriteLine("[1] Sit quietly beside him.");
            Console.WriteLine("[2] Wake him up with some tea.");
            Console.WriteLine("[3] Yell at him for sleeping outside.");
            Console.Write("Choice (1-3): ");

            string input2 = Console.ReadLine();
            bool isValid2 = int.TryParse(input2, out int choice2);

            if (!isValid2 || choice2 < 1 || choice2 > 3)
            {
                Console.WriteLine("\n[Invalid] You trip and scare him away!");
            }
            else if (choice2 == 1)
            {
                currentAffection += 70;
                Console.WriteLine("\nHe wakes up gently. \"Stay with me.\" (+70)");
            }
            else if (choice2 == 2)
            {
                currentAffection += 50;
                Console.WriteLine("\nHe takes the tea. \"Thank you.\" (+50)");
            }
            else
            {
                currentAffection -= 30;
                Console.WriteLine("\nHe jolts awake. \"Leave me alone.\" (-30)");
            }

            // Chapter 3: The Ball
            Console.WriteLine("\n--- Chapter 3: The Ball ---");
            Console.WriteLine("Kira approaches you at the Winter Ball and asks for the opening dance.");
            Console.WriteLine("[1] Take his hand enthusiastically.");
            Console.WriteLine("[2] Tease him playfully.");
            Console.WriteLine("[3] Reject him.");
            Console.Write("Choice (1-3): ");

            string input3 = Console.ReadLine();
            bool isValid3 = int.TryParse(input3, out int choice3);

            if (!isValid3 || choice3 < 1 || choice3 > 3)
            {
                Console.WriteLine("\n[Invalid] You freeze. He walks away.");
            }
            else if (choice3 == 1)
            {
                currentAffection += 100;
                Console.WriteLine("\nHe pulls you close. \"Trust me.\" (+100)");
            }
            else if (choice3 == 2)
            {
                currentAffection += 60;
                Console.WriteLine("\nHe chuckles. \"I will guide you.\" (+60)");
            }
            else
            {
                currentAffection -= 100;
                Console.WriteLine("\nHis eyes widen in heartbreak. (-100)");
            }

            // Final Ending Calculation
            Console.WriteLine("\n==========================================");
            Console.WriteLine($"FINAL SCORE: {currentAffection} / {targetAffection}");
            Console.WriteLine("==========================================");

            if (currentAffection >= targetAffection)
            {
                Console.WriteLine("🌟 TRUE HAPPY ENDING 🌟");
                Console.WriteLine("\"You stole my heart. Please, be mine forever.\"");
            }
            else if (currentAffection >= 100)
            {
                Console.WriteLine("✨ NORMAL ENDING ✨");
                Console.WriteLine("You and Kira become very close friends.");
            }
            else
            {
                Console.WriteLine("💔 BAD ENDING 💔");
                Console.WriteLine("You two barely speak again.");
            }
        }
    }
}
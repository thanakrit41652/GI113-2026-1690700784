/*
 * Student ID : 1690700784
 * Name       : ธนกฤต อินทุย
 * Section    : 129 A
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants for smelting and salvage rates

            const string MysteriousWhiteLiquid = "Mysterious White Liquid";
            const double SmeltRate = 0.45;
            const double SalvageRate = 0.65;
            const double MaxBatch = 500;

            // Game title

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;97m \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;97m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;96m▐▓▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;96m▐▓▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0m\r\n" +
                "\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;97m \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓\u001b[0;36m▌\u001b[0;97m \u001b[0;96m▐▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m       \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m       \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0m\r\n" +
                "\u001b[0;96m▐▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓\u001b[0;36m▌\u001b[0;37m \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓\u001b[0;36m▌\u001b[0;37m     \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓\u001b[0;36m▌\u001b[0;37m     \u001b[0;96m▐▓▓▓\u001b[0;36m▌\u001b[0;37m \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓\u001b[0;36m▌\u001b[0;37m \u001b[0m\r\n" +
                "\u001b[0;96m▐▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m       \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m       \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;96;46m▐\u001b[0;96m▓\u001b[0;36m▌\u001b[0;37m \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m ▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0m\r\n" +
                "\u001b[0;96m▐▓▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;97m   \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;97m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m  \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;37m    \u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;37m   \u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓▓\u001b[0;36m▌\u001b[0;96m▐▓▓▓▓\u001b[0;36m▌\u001b[0m\n");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");

            Console.WriteLine($"🌌 {MysteriousWhiteLiquid} : Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}\n");
            Console.WriteLine("🏭 Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("🔨 Key 'B' for Breakdown (Ingot -> Ore)\n");

            Console.Write("Choose Menu For Smelting or Breakdown (S/B): ");
            char.TryParse(Console.ReadLine(), out char menuChoice);

            // Validate menu choice and amount

            Console.Write("How much... Huhhh? (MaxBatch = 500): ");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0 && amount <= MaxBatch){
                if (menuChoice == 'S' || menuChoice == 's')
                {
                    double result = amount * SmeltRate;
                    Console.WriteLine($"{amount:F2} {MysteriousWhiteLiquid} Ore = {result:F2} {MysteriousWhiteLiquid} Ingot 🌌 ");
                }
                else if (menuChoice == 'B' || menuChoice == 'b')
                {
                    double result = amount / SalvageRate;
                    Console.WriteLine($"{amount:F2} {MysteriousWhiteLiquid} Ingot = {result:F2} {MysteriousWhiteLiquid} Ore 🌌 ");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select 'S' for Smelt or 'B' for Breakdown. Bruh...!");
                }
            }
            else{
                Console.WriteLine("Bro, Invalid amount. Please enter a number between 1 and 500.");
            }
        }
    }
}

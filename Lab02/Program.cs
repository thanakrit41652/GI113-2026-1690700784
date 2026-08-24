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
            int CurrentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {CurrentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent: {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            CurrentHp = CurrentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {CurrentHp} / {maxHp}");
            int newhpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent: {newhpPercentage}%");
        }
    }
}

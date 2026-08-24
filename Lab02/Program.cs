/*
 * Student ID :1690700446
 * Name       :Nathanon Boonkongkird
 * Section    :129A
 * No.        :N/A
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

            int hePercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent:{hePercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damge!");
        }
    }
}

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
            Console.WriteLine();
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Hp percent: 47%");

            //Part B

            Console.WriteLine("=====  MOB 1 !!!SPAWN =====");
            string enemy1 = "Batman";
            char rank1 = 'B';
            int level1 = 4;
            int maxHp1 = 60;
            int currentHp1 = 10;
            float attackPower1 = 30.78f;
            double critMultiplier1 = 1.25;
            bool isEnemy1 = true;

            Console.WriteLine($"Name: {enemy1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"HP: {currentHp1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier1}");
            Console.WriteLine($"Is Enemy: {isEnemy1}");

            Console.WriteLine("=====  MOB 2 !!!SPAWN =====");
            string enemy2 = "Alfred";
            char rank2 = 'B';
            int level2 = 4;
            int maxHp2 = 70;
            int currentHp2 = 70;
            float attackPower2 = 30.5f;
            double critMultiplier2 = 1.5;
            bool is2 = true;
            bool isEnemy2 = true;

            Console.WriteLine($"Name: {enemy2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"HP: {currentHp2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Enemy: {isEnemy2}");

            Console.WriteLine("=====  MOB 3 !!!SPAWN =====");
            string enemy3 = "Jason";
            char rank3 = 'A';
            int level3 = 6;
            int maxHp3 = 150;
            int currentHp3 = 130;
            float attackPower3 = 30.25f;
            double critMultiplier3 = 0.25;
            bool isEnemy3 = true;

            Console.WriteLine($"Name: {enemy3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"HP: {currentHp3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier3}");
            Console.WriteLine($"Is Enemy: {isEnemy3}");

            Console.WriteLine("=====  MOB 4 !!!SPAWN =====");
            string enemy4 = "Tim";
            char rank4 = 'C';
            int level4 = 2;
            int maxHp4 = 80;
            int currentHp4 = 40;
            float attackPower4 = 15.50f;
            double critMultiplier4 = 1;
            bool isEnemy4 = true;

            Console.WriteLine($"Name: {enemy4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"HP: {currentHp4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier4}");
            Console.WriteLine($"Is Enemy: {isEnemy4}");

            Console.WriteLine("=====  MOB 5 !!!SPAWN =====");
            string enemy5 = "Damian";
            char rank5 = 'F';
            int level5 = 1;
            int maxHp5 = 80;
            int currentHp5 = 40;
            float attackPower5 = 10.50f;
            double critMultiplier5 = 2;
            bool isEnemy5 = true;

            Console.WriteLine($"Name: {enemy5}");
            Console.WriteLine($"Rank: {rank5}");
            Console.WriteLine($"HP: {currentHp5}");
            Console.WriteLine($"Attack Power: {attackPower5}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier5}");
            Console.WriteLine($"Is Enemy: {isEnemy5}");
        }
    }
}

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Persona 3 Reload";

            var characterName = "Makoto Yuki";
            var ArcanaRank = '0';
            int characterLevel = 75;
            float criticalRate = 0.25f;
            double spPercentagePrecise = 88.6;
            bool isWildCardUser = true;

            Console.WriteLine("==================================================");
            Console.WriteLine($"               {GameTitle} STATUS                 ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"NAME     : {characterName}");
            Console.WriteLine($"Arcana Rank : {ArcanaRank}");
            Console.WriteLine($"Current level : {characterLevel}");
            Console.WriteLine($"Critical Rate : {criticalRate}");
            Console.WriteLine($"spPercentagePrecise : {spPercentagePrecise}");
            Console.WriteLine($"isWildCardUser : {isWildCardUser}");
            Console.WriteLine("--------------------------------------------------");

            double levelAsDouble = characterLevel;
            Console.WriteLine($"[Implicit] Level as double : {levelAsDouble}");

            int spTruncated = (int)spPercentagePrecise;

            int spRounded = Convert.ToInt32(spPercentagePrecise);

            Console.WriteLine($"[Explicit cast ] SP(Truncate) : {spTruncated}%");
            Console.WriteLine($"[Convert] SP Percentage : {spRounded}%");
            Console.WriteLine("==================================================");
        }
    }
}
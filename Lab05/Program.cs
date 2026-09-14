using System.Runtime.ConstrainedExecution;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===> MARVEL RIVAL <===");
            Console.WriteLine("Hero vs. Villain -- Fight Calculator ");

            //user input of hero stats
            Console.WriteLine("Hero HP: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero ATK: ");
            bool isHeroATK = int.TryParse(Console.ReadLine(), out int heroATK);
            Console.WriteLine("Hero DEF: ");
            bool isHeroDEF = int.TryParse(Console.ReadLine(), out int heroDEF);

            //user input of monster stats
            Console.WriteLine("Monster HP: ");
            bool isMonsterHp = int.TryParse(Console.ReadLine(), out int MonsterHp);
            Console.WriteLine("Monster ATK: ");
            bool isMonsterATK = int.TryParse(Console.ReadLine(), out int MonsterATK);
            Console.WriteLine("Monster DEF: ");
            bool isMonsterDEF = int.TryParse(Console.ReadLine(), out int MonsterDEF);

            // check if input player is valid
            bool allHeroValid = isHeroHp && isHeroATK && isHeroDEF;
            bool allMonsterValid = isMonsterHp && isMonsterATK && isMonsterDEF;
            Console.WriteLine($"Stats Validation: HERO: {allHeroValid}, MONSTER: {allMonsterValid}");
            Console.WriteLine($"[HERO]     HP: {heroHp}  ATK: {heroATK} DEF: {heroDEF}");
            Console.WriteLine($"[MONSTER]  HP: {MonsterHp}  ATK: {MonsterATK} DEF: {MonsterDEF}");

            //Before Fighting :Hero drink a potion(compond Assigment)
            int potionheal = 8;
            //1. 1=1+2
            //heroHp = heroHp + potionheal;
            //2.
            heroHp += potionheal;
            Console.WriteLine(@"\n=> Hero drinks a potion, Healing {potionheal}. health is now {heroHp}.");

            //คำนวณ damage noramal attack (Arithmetic + Math) 
            int normalDamge = Math.Max(0, heroATK - MonsterDEF);
            Console.WriteLine($"Normal Attack deal : {normalDamge} DMG ");

            //คำนวณ power attack (Predence ลำดับการคำนวณ คูณ ก่อนที่จะลบ)
            int powerDamage = Math.Max(0, heroATK * 2 - MonsterDEF); // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี  ()
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            //คำนวณ Monster Attack
            int counterDamage = Math.Max(0, MonsterATK - heroDEF);
            Console.WriteLine($"Monster COunter Attack Deal : {counterDamage} DMG ");

            //คำนวณ Cri Chance
            Random Rng = new Random();
            int roll = Rng.Next(1, 101);
            bool isCrit = roll <= 10; // 10%
            int criDamage = normalDamge + Convert.ToInt32(isCrit) * normalDamge; //โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"Critical hit roll: {roll} (critical : {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical : {criDamage} DMG");
        }
    }
}

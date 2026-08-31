using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            //output แสดงค่าตัวแปร
            Console.WriteLine("\n===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}\nRank: {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}\nCritical Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            // ทำ Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp; // Implicit ->> Double แปลงแบบไม่ cast ใส่ค่าได้เลย
            Console.WriteLine($"HP (double): {currentHpAsDouble}");

            // ทำ Implicit หลังการคำนวณเปอร์เซ็นต์ ที่ผลลัพธ์มีทศนิยม
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = (double)currentHp / maxHp * 100; // Implicit หาร int จากนั้นแปรงผลลัพธ์การคำนวณเป็น double เพื่อเก็บทศนิยม
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");

            // ทำ Explicit โดยการ Casting (float) AttackPower ->> int
            Console.WriteLine("-----Explicit Cast: Attack Power->Display Int-----");
            int attackInt = (int)attackPower; // แปลงข้อมูลโดยการ Cast Syntax: (ชนิดที่ต้องการแปลง)ชื่อตัวแปรที่อยากแปลง
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            // ส่วนสุดท้ายลองทำ cast + Convert
            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (intcast): {critCast}");
            Console.WriteLine($"Critical Multiplier (convert rounded): {critConvert}");
        }
    }
}

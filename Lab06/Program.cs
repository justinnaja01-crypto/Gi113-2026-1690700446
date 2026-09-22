/*
Student ID :1690700446
Name       :Nathanon Boonkongkird
Section    :129A
No.        :N/A
Course     :GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;

            //if (lives <= 0) // ด้านในวงเล็บ ต้องค่าเป็น boolean 
            //{
            //Console.WriteLine("Game over"); // โค้ดจะรันเมื่อโค้ดเป็นจิง
            //}

            //Console.WriteLine("Continue Running");

            //2
            //int coins = 80;
            //int price = 100;

            //if (coins >= price)
            //{
            //Console.WriteLine("Purchase"); // รันเมื่อเป็นจิง
            //}
            //else
            //{
            // Console.WriteLine("Not enough coins"); // รันเมื่อเป็นเท็จ
            //}

            //3
            //int score = 75;

            //if (score >= 90) // ลำดับ1เช็ค = เท็จ
            //{
            //Console.WriteLine("Rank S"); // โค้ดไม่รันไม่อ่าน
            //}
            //else if (score >= 60) // ลำดับ2เช็ค = จิง
            //{
            //Console.WriteLine("Rank A"); // โค้ดรัน
            //}
            //else // เปนกรณีที่ไม่ต้องทั้ง2 ลำดับด้านบน มีเป็นจิงแล้ว ส่วนนี้ไม่รัน
            //{
            //Console.WriteLine("Rank B");
            //}

            //4
            //Console.WriteLine("your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok  level < 1  level > 99) // เช็กกรณี user ใส่ผิด
            //{
            //Console.WriteLine("Invalid Level, please try again.");
            //}
            //else if (level >= 10)
            //{
            //Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5)
            //{
            //Console.WriteLine("The door is open.");
            //}
            //else
            //{
            //Console.WriteLine("The door stay closed.");
            //} 
            int currentSp = 80;
            int shadowsHp = 200;
            int slashDamage = 35;
            int agiDamage = 75;
            int spRecovery = 30;

            Console.WriteLine("====================================");
            Console.WriteLine("        PERSONA 3 RELOAD           ");
            Console.WriteLine("     Makoto Yuki vs Shadow         ");
            Console.WriteLine("====================================");
            Console.WriteLine("Action 1: Slash Attack (0 SP)");
            Console.WriteLine("Action 2: Agi - Fire Skill (20 SP)");
            Console.WriteLine("Action 3: Cadenza - SP Focus");
            Console.WriteLine();

            Console.Write("Choose your action (1-3): ");
            bool validInput = int.TryParse(Console.ReadLine(), out int choice);

            if (validInput == false || choice < 1 || choice > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid command. Please enter a valid action choice (1, 2, or 3).");
            }
            else if (choice == 1)
            {
                shadowsHp -= slashDamage;

                Console.WriteLine();
                Console.WriteLine("Makoto Yuki executed Slash Attack!");
                Console.WriteLine($"Shadow took {slashDamage} physical damage. Target HP is now {shadowsHp}.");
            }
            else if (choice == 2)
            {
                shadowsHp -= agiDamage;
                currentSp -= 20;

                Console.WriteLine();
                Console.WriteLine("Makoto Yuki cast Agi!");
                Console.WriteLine($"Shadow took {agiDamage} fire damage. Target HP is now {shadowsHp}.");
                Console.WriteLine($"Your remaining SP is {currentSp}.");
            }
            else
            {
                currentSp += spRecovery;

                Console.WriteLine();
                Console.WriteLine("Makoto Yuki used Cadenza SP Focus!");
                Console.WriteLine($"Recovered SP! Your current SP is now {currentSp}.");
            }

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("             TURN END               ");
            Console.WriteLine("====================================");
            Console.WriteLine($"Current SP  : {currentSp}");
            Console.WriteLine($"Shadow HP   : {shadowsHp}");
            Console.WriteLine("====================================");

        }
    }
}

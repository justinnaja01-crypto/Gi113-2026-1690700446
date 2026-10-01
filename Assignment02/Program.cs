/*
* Student ID : 1690700446
* Name       : Nathanon Boonkongkird
* Section    : 129A
* No.        : 24
* Course     : GI113 Computer Programming (GI)
*/
using System.ComponentModel;
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String name = "Titanium";
            const double smeltRate = 0.2500;
            const double salvageRate = 0.4000;
            const double maxBatch = 1000.00;
            var inGot = 0.0;
            var ore = 0.0;
            Console.WriteLine("=======The Forge=======");
            Console.WriteLine("---Special ore today---");
            Console.WriteLine($"{name} ore Smelting 0.25 / Salvage 0.40");
            Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");
            Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvv");
            Console.Write("What you want to do : ");
            bool iskeychar = char.TryParse(Console.ReadLine(), out char key);

            if (!iskeychar || (key != 's' && key != 'S' && key != 'b' && key != 'B'))
            {
                Console.WriteLine("error : plese text (s , S , B ,b)");
            }

            else if (key == 'S' || key == 's')
            {
                Console.Write("How much do you want to Smelt (1-1000): ");
                bool isamountnum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isamountnum || (amount > maxBatch && amount <= 0))
                {
                    if (amount > maxBatch && amount <= 0)
                    {
                        Console.WriteLine("error : plese text (1-1000)");
                    }
                    else
                    {
                        Console.WriteLine("error : plese text (1-1000)");
                    }
                }
                else if (amount <= maxBatch && (amount > 0))
                {
                    inGot = amount * smeltRate;
                    Console.WriteLine($"{amount:f2} {name} ore = {inGot:f2} {name} ingot");
                }
                else
                {
                    Console.WriteLine("error : plese text (1-1000)  ");
                }

            }
            else if (key == 'B' || key == 'b')
            {
                Console.Write("How much do you want to Breakdown ( 1-1000 ): ");
                bool isamountnum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isamountnum)
                {
                    if (amount > maxBatch && amount <= 0)
                    {
                        Console.WriteLine("error : plese text (1-1000)");
                    }
                    else
                    {
                        Console.WriteLine("error : plese text (1-1000)");
                    }
                }
                else if (amount <= maxBatch && (amount > 0))
                {
                    ore = amount / salvageRate;
                    Console.WriteLine($"{amount:f2} {name} ingot = {ore:f2} {name} ore");
                }
                else
                {
                    Console.WriteLine("error : plese text (1-1000)  ");
                }
            }
        }
    }
}
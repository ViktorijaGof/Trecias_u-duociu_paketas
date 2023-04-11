using System;
using System.Linq;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[]args)
        {
            // Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.

            Console.WriteLine("Įveskite pirmą skaičių:");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite antrą skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite trečią skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius3 = Convert.ToInt32(ivedimas);

            int[] anArray = { skaicius1, skaicius2, skaicius3 };
            // Finding max
            int m = anArray.Max();

            Console.WriteLine($"Didžiausias jūsų įvestas skaičius yra: {m}");
            Console.WriteLine();

            /*Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
            ar gautas rezultatas yra[8 - 10];
            ar gautas rezultatas yra[5 - 8);
            ar gautas rezultatas yra< 5.
            */
            Console.WriteLine("Įveskite egzamino rezultatą:");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius >= 8)
            {
                Console.WriteLine("Jūsų egzamino rezultatas patenka į 8 - 10 grupę");
            }
            else if (skaicius > 5 & skaicius < 8)
            {
                Console.WriteLine("Jūsų egzamino rezultatas patenka į 5 - 8 grupę");
            }
            else if (skaicius <= 5)
            {
                Console.WriteLine("Jūsų egzamino rezultatas patenka į 0 - 5 grupę");
            }
             Console.WriteLine();

            /*Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
            ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
            */
            Console.WriteLine("Įveskite pirmą skaičių:");
            int skaicius5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());
                       
            if (skaicius5 > skaicius4 || skaicius5 == 0)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
            }
            if (skaicius4 > skaicius5 || skaicius4 == 5)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį, arba yra lygus 5");
            }
            if (skaicius5 > skaicius4 & skaicius5 == 20)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
            }
            if (skaicius4 > skaicius5 & skaicius4 < 100)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }
                Console.WriteLine();

           
        }
    }
}

using System;


namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raskite visų skaičių nuo 1 iki 100 sumą.
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("Visų skaičių nuo 1 iki 100 suma: " + sum);
            Console.WriteLine();

            //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
            int suma = 0;

            for (int i = 20; i <= 40; i+=2)
            {
                suma += i;
            }

            Console.WriteLine("Visų lyginių skaičių nuo 20 iki 40 suma: " + suma);
            Console.WriteLine();

            //Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.
            int sumaa = 0;

            for (int i = 31; i <= 60; i += 2)
            {
                sumaa += i;
            }

            Console.WriteLine("Visų nelyginių skaičių nuo 30 iki 60 suma: " + sumaa);
            Console.WriteLine();

            /*Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, sumą.
            Pavyzdys: Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.Šių skaičių suma yra 23. Turite gauti 233168 atsakymą.
            */
            int suma1 = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma1 += i;
                }
            }

            Console.WriteLine("Visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, suma: " + suma1);                   

        }
    }
}
 
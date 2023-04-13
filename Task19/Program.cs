using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale [0 – 1000) dalinasi iš 16.

            int dalijasiIs16 = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                 dalijasiIs16++;
                }
            }
            Console.WriteLine("Skaičių intervale [0 - 1000) dalijasi iš 16: " + dalijasiIs16);
            Console.WriteLine();

            //Liepkite vartotojui įvesti teigiamą skaičių.While ciklo viduje skaičių kelkite vis didesniu laipsniu ir jį išveskite į ekraną, kol skaičius netaps didesnis už 1500.
        
            Console.WriteLine("Įveskite teigiamą skaičių:");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius <= 1500) 
            {
                Console.WriteLine(skaicius);
                skaicius *= 2;
            }
        }
    }
}

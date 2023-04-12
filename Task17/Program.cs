using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Liepkite vartotojui įvesti teigiamą skaičių. Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.

            Console.WriteLine("Įveskite teigiamą skaičių:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūsų skaičius mažėjimo tvarka iki 0: ");

            for (int i = skaicius; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0.
            //Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.

            Console.WriteLine("Įveskite neigiamą skaičių:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūsų skaičius didėjimo tvarka iki 0: ");

            for (int i = number; i <= 0; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            /* Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus. Pvz.:
            5 + 4 = 9
            5 - 4 = 1
            Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
            TESTI DALIS PADARYTA SU CHATGBT PAGALBA
            */    
            bool testi = true;
            while (testi)
            {
                Console.WriteLine("Įveskite skaičių:");
                int pirmas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Įveskite dar vieną skaičių:");
                int antras = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine($"Įvestų skaičių suma: {pirmas} + {antras} = {pirmas + antras}");
                Console.WriteLine($"Įvestų skaičių skirtumas:{pirmas} - {antras} = {pirmas - antras}");
                Console.WriteLine($"Įvestų skaičių sandauga:{pirmas} * {antras} = {pirmas * antras}");
                Console.WriteLine($"Įvestų skaičių dalmuo:{pirmas} / {antras} = {pirmas / antras}");

                Console.Write("Ar norite testi? (Taip/Ne): ");
                string atsakymas = Console.ReadLine();
                if (atsakymas.ToLower() == "ne")
                {
                    testi = false;
                }



            }
        }
    }
}

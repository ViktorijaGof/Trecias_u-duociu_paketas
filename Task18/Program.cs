using System;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
            Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
            Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
            Iš anksto žinoma informacija:
            Darbo valandų per dieną - 8 val.
            Vartotojo įvedama informacija:
            Kiek darbuotojas gali iškepti kepalų per valandą.
            Kiek darbuotojų turi kepykla.
            Vieno kepalo savikaina.
            Vieno kepalo pardavimo kaina.
            Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).
            */

            Console.WriteLine("Įveskite,kiek darbuotojas gali iškepti kepalų per valandą:");
            double kepalaiPerValana = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite,kiek darbuotų dirba kepykloje:");
            double darbuotojuSkaicius = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Įveskite kepalo savikainą:");
            double savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite kepalo pardavimo kainą:");
            double pardavimoKaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite, kiek kepykla turi tą dieną iškepti kepalų:");
            double uzsakymas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Kepykla per dieną gali iškepti {kepalaiPerValana * 8} duonos kepalų");

            // NEPADARIAU. Palieku vėliau įsirašyti ats, kad pasianalizuočiau: Ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti. 
          
            Console.WriteLine($"Kepyklos šiandienos pelno suma: {uzsakymas * (pardavimoKaina - savikaina)}");


        }
    }
}

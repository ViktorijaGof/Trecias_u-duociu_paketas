using System;


namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* UZKOMENTAVAU, PAANALIZUOSIU SPRENDIMA, KA BLOGAI PADARIAU
             * Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
             ar jis lygus 1: išveskite visų trijų skaičių sumą;
             ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
            
            Console.WriteLine("Įveskite pirmą skaičių:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečią skaičių:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            switch (skaicius1)
            {
                case skaicius1 == 1:
                    Console.WriteLine($"Visų trijų skaičių suma yra: {skaicius1 + skaicius2 + skaicius3}");
                    break;
                case skaicius1 == 2:
                    Console.WriteLine($"Pirmo ir trečio skaičių skirtumas yra: {skaicius1 - skaicius3}");
                    break;
                case skaicius1 == 3:
                    Console.WriteLine($"Antro ir trečio skaičių sandauga yra: {skaicius2 * skaicius3}");
                    break;
            */

            /*Liepkite vartotojui įvesti gyvūno rūšį.Su switch patikrinkite:
            ar įvestas gyvūnas yra šuo;
            ar įvestas gyvūnas yra katė;
            ar įvestas gyvūnas yra žiurkėnas.
            */
           
           Console.WriteLine("Įveskite gyvūno pavadinimą: ");
           string ivedimas = Console.ReadLine();
           
            switch (ivedimas)
            {
                case "šuo":
                    Console.WriteLine("Gyvūnas yra šuo");
                    break;
                case "katė":
                    Console.WriteLine("Gyvūnas yra katė");
                    break;
                case "žiurkėnas":
                    Console.WriteLine("Gyvūnas yra žiurkėnas");
                    break;
            }
            Console.WriteLine();
                     
           
        }
    }
    
}

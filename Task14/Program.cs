﻿using System;


namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Į ekraną išveskite kelis sunumeruotus pasirinkimus
            1 - stacionarus kompiuteris
            2 - nešiojamas kompiuteris
            3 - planšetė
            Liepkite vartotojui įvesti pasirinkimo numerį.
            Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
            nešiojamuoju kompiuteriu galite naudotis visur
            stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
            planšete galite naudotis visur
            Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.
            */
            Console.WriteLine("1 - stacionarus kompiuteris; 2 - nešiojamas kompiuteris; 3 - planšetė; Įveskite pasirinkimo numerį: ");
            string ivedimas = Console.ReadLine();

            switch (ivedimas)
            {
                case "1":
                    Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                    break;
                case "2":
                    Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case "3":
                    Console.WriteLine("Planšete galite naudotis visur");
                    break;
                default:
                    Console.WriteLine("Nėra tinkamo pasirinkimo");
                    break;
            }
     
            }
    }
}

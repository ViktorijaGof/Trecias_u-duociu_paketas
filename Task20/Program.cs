using System;


namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
            //Suraskite įžambinę ir ją išveskite į ekraną.
            
            Console.WriteLine("Įveskite a statinio ilgį:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite b statinio ilgį:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b)); 
            Console.WriteLine("Įžambinė: " + c);

        }
    }
}
 
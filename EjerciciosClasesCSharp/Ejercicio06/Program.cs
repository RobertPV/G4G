using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string [] args)
        {
            Coche coche1 = new Coche("Volkswagen", "Jetta", 120, 210000, true);
            Coche coche2 = new Coche("Chevrolet", "Beat", 100, 190000, true);
            Moto moto1 = new Moto("Harley Davidson", "Chopper", 130, 150000, true);

            Console.WriteLine(coche1);
            Console.WriteLine(coche2);
            Console.WriteLine(moto1);

        }
    }
}
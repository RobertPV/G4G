using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string [] args)
        {
            string numero = "";

            do {
                Console.WriteLine("Ingresa un numero de dos digitos: ");
                numero = Console.ReadLine();
                if(numero.Length > 2 || numero.Length < 2)
                {
                    numero = "";
                    Console.WriteLine("Debe ser un numero de dos digitos");
                }
            } while (numero == "");

            string invertido = "";
            
            for(int i = numero.Length-1; i >= 0; i--)
            {
                invertido += numero[i];
            }

            Console.WriteLine(int.Parse(invertido));

        }
    }
}
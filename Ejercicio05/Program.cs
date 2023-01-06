using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string [] args)
        {
            Aleatorios aleatorios = new Aleatorios();

            Console.WriteLine(aleatorios.numeroRandom(0,100));
            Console.WriteLine();

            int [] lista = aleatorios.listaNumerosAleatorios(10,0,25);

            Array.Sort(lista);
            
            for(int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
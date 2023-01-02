using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string [] args)
        {
            Camioneta camioneta = new Camioneta("Rojo", 4, 120, 5000, 450);
            Motocicleta motocicleta = new Motocicleta("Azul Marino", 2, "Urbana", 110, 4500);

            List <Camioneta> listaVehiculo = new List <Camioneta>();
            listaVehiculo.Add(camioneta);

            List <Motocicleta> listaMotocicleta = new List<Motocicleta>();
            listaMotocicleta.Add(motocicleta);
            
            listaVehiculo[0].mostrarCaminoneta();
            Console.WriteLine();
            listaMotocicleta[0].mostrarMotocicleta();
        }
    }
}
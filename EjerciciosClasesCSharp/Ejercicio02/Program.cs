using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string [] args)
        {
            Coche obj = new Coche();
            obj.mostrar();
            Console.WriteLine("\n");
            Coche obj1 = new Coche("Rojo", 4, 100, 6000);
            obj1.mostrar();
            Console.WriteLine("\n");
            Coche [] arrObj = new Coche [3];
            arrObj[0] = new Coche();
            arrObj[0].mostrar();

            Vehiculo vehiculo = new Vehiculo("Azul", 2);
            Coche vehiculo2 = new Coche(vehiculo.color,vehiculo.ruedas,120,5000);
            vehiculo2.mostrar();
        }
    }
}
using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string [] args)
        {
            Concesionaria concesionaria = new Concesionaria(5);

            Coche coche1 = new Coche(1,"KIA","Rio",110,250000);
            Coche coche2 = new Coche(2,"Chevrolet","Beat",100,200000);
            Coche coche3 = new Coche(3,"JAC","e10x",90,450000);
            Coche coche4 = new Coche(4,"Nissan","March",100,280000);
            Coche coche5 = new Coche(5,"Volkswagen","Jetta",120,350000);

            concesionaria.añadirCoche(coche1);
            concesionaria.añadirCoche(coche2);
            concesionaria.añadirCoche(coche3);
            concesionaria.añadirCoche(coche4);
            concesionaria.añadirCoche(coche5);

            concesionaria.mostrarCoches();
        }
    }
}
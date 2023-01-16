using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string [] args)
        {
            Autor autor = new Autor();
            Libros libro = new Libros("Sherlock Holmes" , "Inglaterra", 150, "Detectives", "Editorial de Detectives", 1960, 2);
            Libros libro1 = new Libros("Las Aventuras de Sherlock Holmes", "Inglaterra", 200, "Detectives", "Editorial de Detectives", 1961, 1);
            Libros libro2 = new Libros("La banda de Lunares", "Inglaterra", 175, "Detectives", "Editorial de Detectives", 1962, 4);
            Libros [] listaLibros = new Libros [3];
            listaLibros[0] = libro;
            listaLibros[1] = libro1;
            listaLibros[2] = libro2;

            autor.nombre = "Arthur";
            autor.apellido = "Conan Doyle";
            autor.libros = listaLibros;

            Console.WriteLine(autor);
            Console.WriteLine("================================================");
            foreach (Libros l in autor.libros)
            {
                Console.WriteLine(l);
                Console.WriteLine("============================================");
            }
        }
    }
}
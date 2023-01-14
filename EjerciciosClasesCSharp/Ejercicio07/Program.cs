using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string [] args)
        {
            Autor autor = new Autor();
            Libros libro = new Libros("Sherlock Holmes" , "Inglaterra", 150, "Detectives");
            Libros libro1 = new Libros("Las Aventuras de Sherlock Holmes", "Inglaterra", 200, "Detectives");
            Libros [] listaLibros = new Libros [2];
            listaLibros[0] = libro;
            listaLibros[1] = libro1;

            autor.nombre = "Arthur";
            autor.apellido = "Doyle";
            autor.libros = listaLibros;

            Console.WriteLine(autor);
            Console.WriteLine(autor.libros[0]);
            Console.WriteLine(autor.libros[1]);
        }
    }
}
using System;

namespace Ejercicio07
{
    class Autor
    {
        private Libros[] _libros;
        private string _nombre;
        private string _apellido;

        public Autor()
        {
            _libros = new Libros [0];
            _nombre = "";
            _apellido = "";
        }

        public Autor(string nombre, string apellido, Libros [] listaLibros)
        {
            _libros = listaLibros;
            _nombre = nombre;
            _apellido = apellido;
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        public Libros [] libros
        {
            get
            {
                return _libros;
            }
            set
            {
                _libros = value;
            }
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nApellido: " + apellido;
        }
    }
}
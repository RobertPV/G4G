using System;

namespace Ejercicio07
{
    class Libros
    {
        private string _nombreLibro;
        private string _editorial;
        private int _noPaginas;
        private string _genero;

        public Libros()
        {
            _nombreLibro = "";
            _editorial = "";
            _noPaginas = 0;
            _genero = "";
        }
        
        public Libros(string nombreLibro, string editorial, int noPaginas, string genero)
        {
            _nombreLibro = nombreLibro;
            _editorial = editorial;
            _noPaginas = noPaginas;
            _genero = genero;
        }

        public string nombreLibro
        {
            get
            {
                return _nombreLibro;
            }
            set
            {
                nombreLibro = _nombreLibro;
            }
        }

        public string editorial
        {
            get
            {
                return _editorial;
            }
            set
            {
                editorial = _editorial;
            }
        }

        public int noPaginas
        {
            get
            {
                return _noPaginas;
            }
            set
            {
                noPaginas = _noPaginas;
            }
        }

        public string genero
        {
            get
            {
                return _genero;
            }
            set
            {
                genero = _genero;
            }
        }

        public override string ToString()
        {
            return "Nombre del Libro: " + nombreLibro + "\nEditorial: " + editorial + "\nNumero de Paginas: " + noPaginas + "\nGenero: " + genero;
        }
    }
}
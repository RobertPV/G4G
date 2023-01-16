using System;

namespace Ejercicio07
{
    class Libros : Editorial
    {
        private string _nombreLibro;
        private string _genero;
        private int _noPaginas;

        public Libros() : base ()
        {
            _nombreLibro = "";
            _genero = "";
            _noPaginas = 0;
        }
        
        public Libros(string nombreLibro, string pais, int noPaginas, string genero, string nombreEditorial, int añoPublicacion, int noRevision) : base(nombreEditorial, pais, añoPublicacion, noRevision)
        {
            _nombreLibro = nombreLibro;
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
                _nombreLibro = value;
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
                _genero = value;
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
                _noPaginas = value;
            }
        }

        public override string ToString()
        {
            return  "Nombre del Libro: " + nombreLibro + "\nGenero: " + genero + "\nNumero de Paginas: " + noPaginas + base.ToString();
        }
    }
}
using System;

namespace Ejercicio07
{
    class Editorial
    {
        private string _nombreEditorial;
        private string _pais;
        private int _añoPublicacion;
        private int _noRevision;

        public Editorial()
        {
            _nombreEditorial = "";
            _añoPublicacion = 0;
            _noRevision = 0;
            _pais = "";
        }
        public Editorial(string nombreEditorial, string pais, int añoPublicacion, int noRevision)
        {
            _nombreEditorial = nombreEditorial;
            _pais = pais;
            _añoPublicacion = añoPublicacion;
            _noRevision = noRevision;
        }

        public string nombreEditorial
        {
            get
            {
                return _nombreEditorial;
            }
            set
            {
                _nombreEditorial = value;
            }
        }

        public string pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
            }
        }

        public int añoPublicacion
        {
            get
            {
                return _añoPublicacion;
            }
            set
            {
                _añoPublicacion = value;
            }
        }

        public int noRevision
        {
            get
            {
                return _noRevision;
            }
            set
            {
                _noRevision = value;
            }
        }

        public override string ToString()
        {
            return "\nNombre de la Editorial: " + nombreEditorial + "\nPais de la Editorial: " + pais + "\nAño de Publicación: " + añoPublicacion + "\nNumero de Revision: " + noRevision;
        }
    }
}
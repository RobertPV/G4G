using System;

namespace Ejercicio06
{
    class Vehiculo
    {
        private int id;
        private static int contador = 0;
        private string _marca;
        private string _modelo;
        private int _km;
        private int _precio;

        public Vehiculo(string marca, string modelo, int km, int precio)
        {
            contador++;
            id = contador;
            _marca = marca;
            _modelo = modelo;
            _km = km;
            _precio = precio;
        }

        // Getter y Setters

        public string marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }
        
        public string modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }

        public int km
        {
            get
            {
                return _km;
            }
            set
            {
                _km = value;
            }
        }

        public virtual int precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public override string ToString()
        {
            return "\nId: " + id + "\nMarca: " + marca + "\nModelo: " + modelo + "\nKm: " + km + "\nPrecio: " + precio;
        }
    }
}
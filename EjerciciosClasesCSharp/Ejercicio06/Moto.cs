using System;

namespace Ejercicio06
{
    class Moto : Vehiculo
    {
        private bool _sidecar;

        public Moto (string marca, string modelo, int km, int precio, bool sidecar) : base (marca, modelo, km, precio)
        {
            _sidecar = sidecar;
        }

        //Getter y Setter
        public bool sidecar
        {
            get
            {
                return _sidecar;
            }
            set
            {
                _sidecar = value;
            }
        }

        //Modificando metodos padre
        public override int precio 
        { 
            get
            {
                if(sidecar == true)
                {
                    return base.precio += 50;
                }
                else
                {
                    return base.precio;
                }
            }
        }

        public override string ToString()
        {
            if(sidecar == true)
            {
                return base.ToString() + "\nSi tiene un Sidecar";
            }
            else
            {
                return base.ToString() + "\nNo tiene un sidecar";
            }
        }
    }
}
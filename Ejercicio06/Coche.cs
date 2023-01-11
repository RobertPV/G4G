using System;

namespace Ejercicio06
{
    class Coche : Vehiculo
    {
        private bool _airbag;

        public Coche (string marca, string modelo, int km, int precio, bool airbag) : base(marca, modelo, km, precio)
        {
            _airbag = airbag;
        }

        //Getter - Setter de airbag
        public bool airbag
        {
            get
            {
                return _airbag;
            }
            set
            {
                _airbag = airbag;
            }
        }
        //Modificación del metodo precio
        public override int precio 
        { 
            get
            {
                if(airbag == true)
                {
                    return base.precio += 200;
                }
                else
                {
                    return base.precio;
                }
            }
        }
        
        //Modificando metodos padre
        public override string ToString()
        {
            if(airbag == true)
            {
                return base.ToString() + "\nSi tiene Airbags";
            }
            else
            {
                return base.ToString() + "\nNo tiene Airbags";
            }
        }
        
    }
}
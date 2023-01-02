class Bicicleta : Vehiculo
{
    public string tipo;

    public Bicicleta() : base()
    {
        tipo = "Null";
    }

    public Bicicleta(string color, int ruedas, string tipo) : base(color, ruedas)
    {
        this.tipo = tipo;
    }

    public void mostrarBicicleta()
    {
        mostrarVehiculo();
        Console.WriteLine("El tipo es: " + tipo);
    }
}
class Coche : Vehiculo
{
    public int velocidad;
    public int cilindrada;

    public Coche() : base()
    {
        velocidad = 0;
        cilindrada = 0;
    }

    public Coche(String color, int ruedas, int velocidad, int cilindrada) : base(color, ruedas)
    {
        this.velocidad = velocidad;
        this.cilindrada = cilindrada;
    }

    public void mostrarCoche()
    {
        mostrarVehiculo();
        Console.WriteLine("Su velocidad es de: " + velocidad + " km/h" +
                        "\nSu cilindrada es de: " + cilindrada + " cc");
    }
}
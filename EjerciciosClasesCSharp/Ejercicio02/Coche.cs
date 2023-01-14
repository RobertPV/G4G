class Coche : Vehiculo
{
    public int velocidad;
    public int cilindrada;

    public Coche()
    {
        velocidad = 0;
        cilindrada = 0;
    }

    public Coche(string color,int ruedas, int velocidad, int cilindrada)
    {
        this.color = color;
        this.ruedas = ruedas;
        this.velocidad = velocidad;
        this.cilindrada = cilindrada;
    }

    public void mostrar()
    {
        mostrarVehiculo();
        Console.WriteLine("Su velocidad es de: " + velocidad + " km/h" +
                        "\nSu cilindrada es de: " + cilindrada + " cc");
    }
}
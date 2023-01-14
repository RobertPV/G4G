class Vehiculo
{
    public string color;
    public int ruedas;

    public Vehiculo()
    {
        color = "Null";
        ruedas = 0;
    }

    public Vehiculo(string color, int ruedas)
    {
        this.color = color;
        this.ruedas = ruedas;
    }

    public void mostrarVehiculo()
    {
        Console.WriteLine("El color es: " + color +
                        "\nTiene: " + ruedas + " ruedas");
    }
}
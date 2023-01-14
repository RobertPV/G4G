class Motocicleta : Bicicleta
{
    public int velocidad;
    public int cilindrada;

    public Motocicleta() : base()
    {
        velocidad = 0;
        cilindrada = 0;
    }

    public Motocicleta(string color, int ruedas, string tipo, int velocidad, int cilindrada) : base(color, ruedas, tipo)
    {
        this.velocidad = velocidad;
        this.cilindrada = cilindrada;
    }

    public void mostrarMotocicleta()
    {
        mostrarBicicleta();
        Console.WriteLine("Su velocidad es de: " + velocidad + " km/h" +
                        "\nSu cilindrada es de: " + cilindrada + " cc");
    }
}
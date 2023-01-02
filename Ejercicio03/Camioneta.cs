class Camioneta : Coche
{
    public int carga;

    public Camioneta() : base()
    {
        carga = 0;
    }

    public Camioneta(string color, int ruedas, int velocidad, int cilindrada, int carga) : base(color, ruedas, velocidad, cilindrada)
    {
        this.carga = carga;
    }

    public void mostrarCaminoneta()
    {
        mostrarCoche();
        Console.WriteLine("Carga: " + carga + " kg");
    }
}
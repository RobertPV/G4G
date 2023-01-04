class Coche
{
    private int id;
    private string marca;
    private string modelo;
    private int km;
    private int precio;

    public Coche()
    {
        id = 0;
        marca = "Null";
        modelo = "Null";
        km = 0;
        precio = 0;
    }

    public Coche(int id, string marca, string modelo, int km, int precio)
    {
        this.id = id;
        this.marca = marca;
        this.modelo = modelo;
        this.km = km;
        this.precio = precio;
    }

    public void setId(int id)
    {
        this.id = id;
    }
    public void setMarca(string marca)
    {
        this.marca = marca;
    }
    public void setModelo(string modelo)
    {
        this.modelo = modelo;
    }
    public void setKm(int km)
    {
        this.km = km;
    }
    public void setPrecio(int precio)
    {
        this.precio = precio;
    }

    public int getId()
    {
        return id;
    }
    public string getMarca()
    {
        return marca;
    }
    public string getModelo()
    {
        return modelo;
    }
    public int getKm()
    {
        return km;
    }
    public int getPrecio()
    {
        return precio;
    }

    public override string ToString()
    {
        return "Marca: " + marca +
        "\nModelo: " + modelo +
        "\nPrecio: " + precio;
    }
}
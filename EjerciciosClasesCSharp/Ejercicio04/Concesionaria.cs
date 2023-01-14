class Concesionaria
{
    private List<Coche> listaCoches = new List<Coche>();
    private int limite;
    private int contadorCoches = 0;

    public Concesionaria(int limite)
    {
        this.limite = limite;
    }
    public void añadirCoche(Coche coche)
    {
        if(coche != null)
        {
            if(contadorCoches < limite)
            {
                this.listaCoches.Add(coche);
                contadorCoches++;
            }
            else
            {
                Console.WriteLine("Se ha alcanzado el limite de coches para la Concesionaria");
            }
        }
        else
        {
            Console.WriteLine("Es necesario ingresar información valida");
        }
    }
    public void mostrarCoches()
    {
        if(listaCoches.Count != 0)
        {
            for(int i = 0; i<listaCoches.Count; i++)
            {
                Console.WriteLine(listaCoches[i].ToString());
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No hay coches en la lista");
        }
    }
    public void vaciarCoches()
    {
        if(listaCoches.Count == 0)
        {
            Console.WriteLine("Se vacio la lista");
        }
        else
        {
            listaCoches.Clear();
            Console.WriteLine("Se vacio la lista");
        }
    }
    public void eliminarCoche(Coche coche)
    {
        if(listaCoches.Contains(coche))
        {
            listaCoches.Remove(coche);
            contadorCoches--;
        }
        else
        {
            Console.WriteLine("No existe el coche");
        }
    }
}
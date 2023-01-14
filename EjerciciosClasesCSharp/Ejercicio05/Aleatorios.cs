class Aleatorios
{
    private Random r;

    public Aleatorios()
    {
        r = new Random();
    }
    
    public int numeroRandom(int n1, int n2)
    {

        if(n1>n2)
        {
            return r.Next(n2,n1);
        }
        else
        {
            return r.Next(n1,n2);
        }
    }

    public int [] listaNumerosAleatorios(int tamaño, int n1, int n2)
    {
        int [] lista = new int [tamaño];
        if(tamaño > 0)
        {
            if(n1>n2)
            {
                for(int i = 0; i < tamaño; i ++)
                {
                    lista[i] = r.Next(n2,n1);
                }
            }
            else
            {
                for(int i = 0; i < tamaño; i ++)
                {
                    lista[i] = r.Next(n1,n2); //Se intercambia las posiciones del n1 y n2
                }
            }
        }
        else
        {
            Console.WriteLine("El tamaño del arreglo debe ser mayor que 0");
        }
        return lista;
    }

    public int [] listaNumerosNoAleatorios(int tamaño, int n1, int n2)
    {
        int [] lista = new int [tamaño];
        if(Math.Abs(n1-n2) == tamaño-1)
        {
            for(int i = 0; i<tamaño; i++)
            {
                lista[i] = i;
            }
        }
        else if(Math.Abs(n1-n2) > tamaño-1)
        {
            if(n1>n2)
            {
                for(int i = 0; i < tamaño; i ++)
                {
                    int j = r.Next(n2,n1);
                    if(lista.Contains(j) == false)
                    {
                        lista[i] = j;
                    }
                }
                return lista;
            }
            else
            {
                for(int i = 0; i < tamaño; i ++)
                {
                    int j = r.Next(n1,n2);
                    if(lista.Contains(j) == false)
                    {
                        lista[i] = j;
                    }
                    else
                    {
                        i--;
                    }
                }
                return lista;
            }
        }
        else
        {
            Console.WriteLine("No hay manera de llenar un arreglo de tamaño: " + tamaño + " sin repetir numeros entre: " + n1 + " y " + n2 +
                            "\nse devulve un arreglo lleno de ceros\n");
        }

        return lista;
    }

}

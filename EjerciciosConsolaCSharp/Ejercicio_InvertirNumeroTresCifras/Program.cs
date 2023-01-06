using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string [] args)
        {
            string numero = "", auxiliar = "";
            bool cumple = true;
            do
            {
                Console.WriteLine("Ingresa un numero de 3 cifras: ");
                numero = Console.ReadLine();
                if(numero.Length == 3)
                {
                    for(int i = 0; i < numero.Length; i++)
                    {
                        switch(numero[i])
                        {
                            case '0':
                                break;
                            case '1':
                                break;
                            case '2':
                                break;
                            case '3':
                                break;
                            case '4':
                                break;
                            case '5':
                                break;
                            case '6':
                                break;
                            case '7':
                                break;
                            case '8':
                                break;
                            case '9':
                                break;
                            default:
                                cumple = false;
                                break;
                        }
                    }
                    if(cumple == false)
                    {
                        numero = "";
                        cumple = true;
                        Console.WriteLine("Solo se pueden ingresar numeros");
                    }
                }
                else
                {
                    numero = "";
                    Console.WriteLine("Debe ser un numero de 3 cifras");
                }
                
            }while(numero == "");

            for(int i = numero.Length - 1 ; i >= 0; i--)
            {
                auxiliar += numero[i];
            }
            Console.WriteLine(auxiliar);
        }
    }
}
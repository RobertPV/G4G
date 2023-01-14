using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string [] args)
        {
            int [] ar1 = {1,2,4,6,10};
            int [] ar2 = {4,5,6,9,12};
            List <int> arr = new List<int>();
            for(int i = 0; i<ar1.Length;i++)
            {
                arr.Add(ar1[i]);
                arr.Add(ar2[i]);
            }
            arr.Sort();
            int mid = arr.Count()/2;
            Console.WriteLine(arr[mid-1]+arr[mid]);
        }
    }
}
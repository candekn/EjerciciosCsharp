using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar dos numeros y decir si son iguales, mayores o menores*/
            int n1, n2;
            Console.WriteLine("Ingrese numero 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("{0} es mayor a {1}", n1, n2); //Impresion de indices
            }else if (n1 < n2)
                {
                    Console.WriteLine("{0} es menor a {1}", n1, n2);
                }else
                    {
                        Console.WriteLine("{0} es igual a {1}", n1, n2);
                    }
            Console.ReadKey();
        }
    }
}

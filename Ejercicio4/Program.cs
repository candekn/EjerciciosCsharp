using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 Variables(a,b,c,d) 
             Promedio de las 4
             Porcentaje de a con respecto a b
             Porcentaje de a con respecto al total 
             */
            double a, b, c, d, suma, promedio, p2, p3;
            Console.WriteLine("Ingrese a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese d: ");
            d = double.Parse(Console.ReadLine());
            suma = (a + b + c + d);
            promedio = suma / 4;
            p2 = (a * 100) / b;
            p3 = (a * 100) / suma;
            Console.WriteLine("Promedio de 4: " + promedio +"\nPorcentaje de a con respecto a b: "+p2
                +"\nPorcentaje de a con respecto al total: "+p3);
            Console.ReadKey();
        }
    }
}

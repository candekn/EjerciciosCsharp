using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*perimetro y superficie de un rectangulo*/
            Console.WriteLine("Ingrese base: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            double h = double.Parse(Console.ReadLine());
            double perimetro = b * 2 + h * 2;
            double superficie = b * h;
            Console.WriteLine("El perimetro es: " + perimetro.ToString());
            Console.WriteLine("La superficie es: " + superficie.ToString());
            Console.ReadKey();
        }
    }
}

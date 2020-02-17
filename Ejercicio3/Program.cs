using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar 3 notas y mostrar suma y promedio*/
            Console.WriteLine("Ingrese nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());
            double suma = nota1 + nota2 + nota3;
            double promedio = suma / 3;
            Console.WriteLine("La sumatoria es: " + suma + " Y el promedio es: " + promedio);
            Console.ReadKey();

        }
    }
}

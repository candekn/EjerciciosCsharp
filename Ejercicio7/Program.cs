using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciclo whiles
            /*nro de empleado, sueldo y categoria (a,b,c,d)
             Mostrar:
             1.cantidad de registros
             2. empleados por categoria
             3.sueldos totales
             4.sueldos promedios
             rompe el while el 0*/
            int contador=0, empA=0, empB=0, empC=0, empD=0, nroemp=0;
            char categoria;
            double sueldo=0.0, sueldototal=0.0, sueldopromedio=0.0, sueldoA=0.0, 
                sueldoB = 0.0, sueldoC = 0.0, sueldoD = 0.0;
            Console.WriteLine("Ingrese numero de empleado: ");
            nroemp = int.Parse(Console.ReadLine());
            while (nroemp != 0)
            {
               eti1:
                Console.WriteLine("Ingrese categoria de empleado: ");
                categoria = char.ToUpper(char.Parse(Console.ReadLine()));
                contador++;
                switch (categoria)
                {
                    case 'A': empA++;
                        Console.WriteLine("Ingrese sueldo: ");
                        sueldo = double.Parse(Console.ReadLine());
                        sueldoA = sueldoA + sueldo;
                        break;
                    case 'B': empB++;
                        Console.WriteLine("Ingrese sueldo: ");
                        sueldo = double.Parse(Console.ReadLine());
                        sueldoB = sueldoB + sueldo;
                        break;
                    case 'C': empC++;
                        Console.WriteLine("Ingrese sueldo: ");
                        sueldo = double.Parse(Console.ReadLine());
                        sueldoC = sueldoC + sueldo;
                        break;
                    case 'D': empD++;
                        Console.WriteLine("Ingrese sueldo: ");
                        sueldo = double.Parse(Console.ReadLine());
                        sueldoD = sueldoD + sueldo;
                        break;
                    default: Console.WriteLine("Categoria incorrecta. Seleccione entre A, B C ó D");
                        goto eti1;
                }
                sueldototal = sueldototal + sueldo;
                Console.WriteLine("Ingrese numero de empleado: ");
                nroemp = int.Parse(Console.ReadLine());
            }
            sueldopromedio = sueldototal / contador;
            Console.WriteLine("La cantidad total de empleados es: " + contador);
            Console.WriteLine("La cantidad de empleados de categoria A es: " + empA);
            Console.WriteLine("Y su sueldo total es de: " + sueldoA);
            Console.WriteLine("La cantidad de empleados de categoria B es: " + empB);
            Console.WriteLine("Y su sueldo total es de: " + sueldoB);
            Console.WriteLine("La cantidad de empleados de categoria C es: " + empC);
            Console.WriteLine("Y su sueldo total es de: " + sueldoC);
            Console.WriteLine("La cantidad de empleados de categoria D es: " + empD);
            Console.WriteLine("Y su sueldo total es de: " + sueldoD);
            Console.WriteLine("La suma total de todos los sueldos es: " + sueldototal);
            Console.WriteLine("El promedio de los sueldos es de: " + sueldopromedio);
            Console.ReadLine();
        }
    }
}

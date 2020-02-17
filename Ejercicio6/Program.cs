using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar nro de dia y nro de mes
             nombre del dia y nombre del mes*/
            int dia, mes;
            string nombredia;
        eti1:
            Console.WriteLine("Ingrese numero de dia: ");
            dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    nombredia = "Lunes";
                    break;
                case 2:
                    nombredia = "Martes";
                    break;
                case 3:
                    nombredia = "Miercoles";
                    break;
                case 4:
                    nombredia = "Jueves";
                    break;
                case 5:
                    nombredia = "Viernes";
                    break;
                case 6:
                    nombredia = "Sabado";
                    break;
                case 7:
                    nombredia = "Domingo";
                    break;
                default: Console.WriteLine("Numero de dia incorrecto");
                    goto eti1;
            }
            Console.WriteLine("El dia numero {0} corresponde a {1}", dia, nombredia);

         eti2:
            Console.WriteLine("Ingrese numero de mes: ");
            mes = int.Parse(Console.ReadLine());
            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.WriteLine("Corresponde al trimestre 1");
            }else if (mes == 4 || mes == 5 || mes == 6)
            {
                Console.WriteLine("Corresponde al trimestre 2");
            }
            else if (mes == 7 || mes == 8 || mes == 9)
            {
                Console.WriteLine("Corresponde al trimestre 3");
            }
            else if (mes == 10 || mes == 11 || mes == 12)
            {
                Console.WriteLine("Corresponde al trimestre 4");
            }
            else
            {
                Console.WriteLine("Numero de mes incorrecto. Ingrese un numero entre 1 y 12");
                goto eti2;
            }

            Console.ReadKey();   
        }
    }
}

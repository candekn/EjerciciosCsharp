using System; //librerias que se instancian para poder trabajar
using System.Collections.Generic;
using System.Linq;
using System.Text; //Elementos de texto
using System.Threading.Tasks;

namespace Ejercicio1 //Estructura principal lleva el nombre del proyecto
{
    class Program
    {
        static void Main(string[] args) //Cuerpo del programa
        {
            /*Ingresar nombre apellido sueldo y mostrar*/
            String nombre, apellido;
            Double sueldo;
            nombre = "Cande";
            apellido = "Delgado";
            sueldo = 34000.50;
            Console.WriteLine("Tu nombre: " + nombre); //WriteLine hace salto de linea, write no
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Sueldo: " + sueldo);
            Console.ReadKey(); //Para que no se cierre automaticamente
        }
    }
}

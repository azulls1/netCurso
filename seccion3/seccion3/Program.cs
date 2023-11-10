using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Informacion de funciones, metodos o caractersiticas al final del codigo.

namespace seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejemplo de como pedir datos al usuario con el metodo ReadLine*/
            string nombre;
            /*preguntamos al  nombre del usuario*/
            Console.Write("Cual es tu nombre");
            /*con el metodo ReadLine lee lo que el usuario introduce y lo guarda en la variable nombre*/
            nombre = Console.ReadLine();
            /*saludo al usuario*/
            Console.WriteLine("Hola  como te ecnuentras " + nombre);
        }
    }
}

/*El método Write es similar al método WriteLine , excepto que el método Write  *
 * no inserta automáticamente una combinación de caracteres de retorno de carro *
 * o de avance de línea.                                                         */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion_7._4_var_local_con_asig_implicita // cariables locales con asignacion implcita de tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Al declarar una variable local, puede permitir que el compilador infiera el tipo de la variable a partir de la expresión de inicialización. Para ello, use la palabra clave var en lugar del nombre de un tipo

            //Nota: al poner var no se declara el tipo de dato si no que tomara el que mas es adecuado dependiendo el valor que se asigne en este caso  como los siguientes ejemplos
            var nombre = "luis";  //string
            var calle = "av 5"; //string
            var numero = 10; //int
            var calificacion = 8.5; //double
            var letra = 'A';  //char
            var NUMERO2 = 6; //int
            var campo = true; //bolean


            // tuplas

            /* https: //learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/value-tuples 
            Cuando nos referimos a una Tupla nos estamos refiriendo a una estructura de datos la cual puede contener múltiples tipos.
            La característica de tuplas proporciona una sintaxis concisa para agrupar varios elementos de datos en una estructura de datos ligera*/


            //forma de declarar una tupla
            //(Tipo) Identificador = (valor);

            string nombre1 = "ashm";
            int edad = 28;
            long numeroTel = 4499999999;
            double direccion = 2743.2;

               (string, int, long, double) persona1 = ("ashm",28,4499999999,2743.2);//esta es la forma de declarar una tupla de una forma larga
                var persona2 = ("ashm", 28, 4499999999, 2743.2);//version simplificada de una tupla
            var persona3 = (nombre3 : "ashm", edad3 : 28, numero3 :  4499999999, dirrecion3 : 2743.2);//version simplificada de una tupla
            Console.WriteLine(persona1);//imprimer la tupla

            //imprimimos los items de la tupla

            Console.WriteLine(persona2.Item1+ " (impresion por item) ");

            //imprimimos los identificadores de la tupla
            Console.WriteLine(persona3.nombre3+" "+ persona3.edad3 +" (impresion por identificador en tupla mas barios elementos de la tupla) ");






        }
    }
}

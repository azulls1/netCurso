using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//Informacion de funciones, metodos o caractersiticas al final del codigo.

namespace seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejemplo 1. como pedir datos al usuario con el metodo ReadLinee*/

            string nombre;
            /*preguntamos al  nombre del usuario*/
            Console.Write("Cual es tu nombre ");
            /*con el metodo ReadLine lee lo que el usuario introduce y lo guarda en la variable nombre*/
            nombre = Console.ReadLine();
            /*saludo al usuario*/
            Console.WriteLine("Hola  como te ecnuentras " + nombre);


            /*Ejempl 2. Convertir cadenas en tipo numerico*/

            /*declaramos las varibales que vamos usar*/
            string entrada1, entrada2, entrada3, entrada4;
            int numero1, numero2, resultado;
            double numero3, numero4, resultado1;
           
            /*conversion de string a numeros enteros*/
            Console.WriteLine("suma de dos numeros enteros con convert ");
            /*pedimos nuestro primero numero*/
            Console.Write("dame el primer numero ");
            /*guardamos la entrada del usuario*/
            entrada1 = Console.ReadLine();
            /*convertimos la entrada de string a un entero con convert*/
            numero1 = Convert.ToInt32(entrada1);
            /*pedimos nuestro primero numero*/
            Console.Write("dame el segundo numero ");
            /*guardamos la entrada del usuario*/
            entrada2 = Console.ReadLine();
            /*convertimos la entrada de string a un entero con convert*/
            numero2 = Convert.ToInt32(entrada2);
            /*realizamos operaciones aritmeticas */
            resultado= numero1 + numero2;
            /*imprimimos el resultado*/
            Console.WriteLine("El resultado de la suma es {0} " , resultado);

            /*conversion de string a numeros con decimales usando convert*/
            Console.WriteLine("suma de dos numeros con decimales con parse ");
            /*pedimos nuestro primero numero*/
            Console.Write("dame el primer numero decimal ");
            /*guardamos la entrada del usuario*/
            entrada3 = Console.ReadLine();
            /*convertimos la entrada de string a un decimal con convert*/
            numero3 = Convert.ToDouble(entrada3);
            /*pedimos nuestro primero numero*/
            Console.Write("dame el segundo numero ");
            /*guardamos la entrada del usuario*/
            entrada4 = Console.ReadLine();
            /*convertimos la entrada de string a un decimal con convert*/
            numero4 = Convert.ToDouble(entrada4);
            /*realizamos operaciones aritmeticas */
            resultado1 = numero3 + numero4;
            /*imprimimos el resultado*/
            Console.WriteLine("El resultado de la suma es {0} ", resultado1);


            /*otra forma mas facil de  convertir strings a cadenas en una sola linea*/

            Console.WriteLine("suma de dos numeros enteros con convert forma simplificada ");
            /*pedimos nuestro primero numero*/
            Console.Write("dame el primer numero ");
            /*guardamos la entrada del usuario y lo convertimos*/
            numero1 =Convert.ToInt32 (Console.ReadLine());
            /*pedimos nuestro segundo numero*/
            Console.Write("dame el segundo numero ");
            /*guardamos la entrada del usuario*/
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 + numero2;
            /*imprimimos el resultado*/
            Console.WriteLine("El resultado de la suma es {0} ", resultado);


            /*otra forma mas facil de  convertir strings a cadenas en una sola linea con parse*/

            Console.WriteLine("suma de dos numeros enteros con parse forma simplificada ");
            /*pedimos nuestro primero numero*/
            Console.Write("dame el primer numero ");
            /*guardamos la entrada del usuario y lo convertimos*/
            numero3 = double.Parse(Console.ReadLine());
            /*pedimos nuestro segundo numero*/
            Console.Write("dame el segundo numero ");
            /*guardamos la entrada del usuario*/
            numero4 = double.Parse(Console.ReadLine());
            resultado1 = numero3 + numero4;
            /*imprimimos el resultado*/
            Console.WriteLine("El resultado de la suma es {0} ", resultado1);







            /*el metodo readkey se define en la parte de abajo encontrar como numero (2)*/
            Console.ReadKey();
        }
    }
}

/*(1)       El método Write es similar al método WriteLine , excepto que el método Write  *
 * no inserta automáticamente una combinación de caracteres de retorno de carro *
 * o de avance de línea.                                                        */

/*(2)       Uno de los usos más comunes del método ReadKey  es detener la  ejecución del programa hasta que el usuario presiona una tecla y la aplicación finaliza o muestra una ventana adicional de información.*/

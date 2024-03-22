using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion7_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //existen 4 estilos de metodos
            /*
             * 1. Metodos sin parametros ni tipo
             * 2. metodos con parametos
             * 3. metodos que devulven un tipo
             * 4. metodos con parametros y que devuelven un tipo
             */

            //variables 

            int opcion;
            int r; // almacena el valor devuelo de restar();
            int numAr1, numAr2; //Argumentos para enviar una copia de su valor  a los metodos en este caso multiplicar();

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                Console.WriteLine("escoge una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            switch (opcion)
            {

                case 1:// suma, metodo sin parametros ni tipo
                    Sumar();
                    break;
               
                case 2:// resta, metodo que devuelven un tipo 
                    r = Resta(); // asignamos el valor devuelto por el metodo resta a r que en este caso viene siendo resultado por el return
                    Console.WriteLine("El resultado es {0}",r);
                    break;
               
                case 3:// multiplicacion, metodo que contiene parametros 

                    Console.WriteLine("me puedes dar el primer numero");
                    numAr1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("me puedes dar el segundo numero");
                    numAr2 = Convert.ToInt32(Console.ReadLine());

                    //invocamos al metodo
                    multiplicar(numAr1, numAr2);//al invocar el metodo le pasamos los argumentos que necesita el metodo para guardarlo en parametros, tomst en cuenta como se mandan los argumentos ya que si afecta al resivirla en el metodo y guardarla en el parametro 
                   
                    break;
                case 4://division, metodos con parametros y que devuelven un tipo
                    
                    Console.WriteLine("me puedes dar el primer numero");
                    numAr1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("me puedes dar el segundo numero");
                    numAr2 = Convert.ToInt32(Console.ReadLine());

                    r =  division(numAr1, numAr2);
                    Console.WriteLine("El reusltado de la division es {0}",r);
                    break;
                default:

                    break;
            }
        }//Cierre del main

        /* todo los metedos se ponen fuera del main y dentro de la classe program */

        //sintaxis  de un metodo "existen dos tipos de metodos dinamicos y estaticos"
        //[Modificador][tipo informacion][identificador][parametros]
         static void nombre()
         {
         //instrucciones de codigo
         }
        //los metodos mayormente empeizan con static y si no regresan ningun valor o estan vacios siempre iran con void el cual signfica vacio  y en los parametros no tendra ninguno se deja vacio
        static void Sumar()
        {
            // declaracion de vairbales locales solo en el metodo se pueden usar
            int num1, num2, resultado;

            Console.WriteLine("me puedes dar el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("me puedes dar el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es {0}", resultado);
        }
        //[Modificador][tipo informacion][identificador][parametros]   
        static int Resta() // static el tipo de inormacion que regresara que es un intero el identificador del  metodo y sin parametros por que no le esta mandando nada el main
        {
            int num1, num2, resultado;

            Console.WriteLine("me puedes dar el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("me puedes dar el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 - num2;

            //devolvemos un tipo al  main
            return resultado;
        }
        //[Modificador][tipo informacion][identificador][parametros] 
        static void multiplicar(int numPa1, int numPa2) //static que se usa para todos los metodos, void por que el tipo de informacion que regresa no es ninguno, identificador resta, y los parametros sera la informacion que pasen desde main que son variables pero se les conoce mejor como argumentos y se guardaran en los parametros
        {
            int resultado;

            // multiplicacion con los valores que mandaron los argumentos
            resultado = numPa1 * numPa2;

            Console.WriteLine("{0} * {1} = {2}", numPa1, numPa2, resultado);    


        }

        static int division(int numPa1, int numPa2)
        {
            int resultado;

            if (numPa2 != 0) // si el numPa2 es diferente de cero  procedemos 
            {    // dicision con los calores que mandaron los argumentos
                resultado = numPa1 / numPa2;
            }
            else // si el numPa2 es 0  entonces
            {
                Console.WriteLine(" el numero no se puede dividir");
                resultado = 0;
                
            }
            return resultado;

        }
        //[Modificador][tipo informacion][identificador][parametros] 


    }

}

    




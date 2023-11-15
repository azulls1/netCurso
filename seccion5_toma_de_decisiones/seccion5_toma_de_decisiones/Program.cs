﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion5_toma_de_decisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tipo de dato bool*/



            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador de igualdad                           ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /**********************************
             *      Operador de igualdad      *
             **********************************
             *     signo     /  operador      *
             **********************************
             *     ==        /  igualdad      *
             **********************************
             *     !=        /  desigualdad   *
             **********************************/

            Console.WriteLine(6 == 6); //esto devulve true
            Console.WriteLine(5 != 6); //esto devulve true

            Console.WriteLine(5 == 6); //esto devuelve false
            Console.WriteLine(5 != 5); //esto devuelve false



            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador de comparacion                        ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /************************************
            *     Operador de comparacion       *
            *************************************
            *     signo  /  operador            *
            * ***********************************
            *     <      /  menor que           *
            * ***********************************
            *     >      /  mayor que           *    
            * ***********************************
            *    <=      /  menor o igual que   *    
            *************************************
            *     >=     /  mayor o igual que   *     
            *************************************/

            Console.WriteLine( 0 < 1); //esto devulve true
            Console.WriteLine( 1 < 0); //esto devuelve false 
            Console.WriteLine( 0 > 1); //esto devuelve false 
            Console.WriteLine( 1 > 0); //esto devulve true
            Console.WriteLine( 0 <= 1); //esto devulve true
            Console.WriteLine( 1 <= 0); //esto devuelve false
            Console.WriteLine( 1 <= 1); //esto devulve true
            Console.WriteLine( 0 >= 1); //esto devuelve false
            Console.WriteLine( 1 >= 0); //esto devulve true
            Console.WriteLine( 1 >= 1); //esto devulve true

            /*Palabras clave en c#
            https://learn.microsoft.com/es-mx/dotnet/csharp/language-reference/keywords/ */

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Instrucciones de seleccion IF                  ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Instrucciones de seleccion IF*/
            
            /*declaramos variables*/
            double numero1, numero2;

            /*pedimos el numero al usuario*/
            Console.Write("me puedes proporcionar un numero : ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("me puedes proporcionar un numero : ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            /*en caso de que el numero proporcionado sea igual al seugndo numero proprcionado */
            if (numero1 == numero2) {
               Console.WriteLine("los dos numeros proporcionados son iguales : {0} = {1}", numero1, numero2);
            }

            /*en caso que el primer numero sea mayor que el numero dos*/
            if (numero1 > numero2) {
                Console.WriteLine("el primer numero es mayor que  que el segundo numero : {0} mayor que {1} ", numero1, numero2);
            }
            
            /*en caso que el primer numero sea menor que el numero dos */
            if (numero1 < numero2)
            {
               Console.WriteLine("el primer numero es menor que  que el segundo numero : {0} menor que {1}", numero1, numero2);
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Intruccion de seleecion ELSE                   ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Intruccion de seleecion ELSE*/

            int edad;
            Console.Write("cual es tu edad : ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("eres mayor de edad *FELICIDADES* ");
            }
            else
            {
                Console.WriteLine("lo siento aun eres menor de edad : ");
            }
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     IF anidados                                    ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /*IF anidados*/

            int suma, resta, multplicacion, division, numeroIfAnidado1, numeroIfAnidado2, opcion;
            
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.Write("*** Escoge una opcion : ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion <= 4)
            {
                Console.Write( "*** Dame el primer numero : ");
            numeroIfAnidado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("*** Dame el segundo numero : ");
            numeroIfAnidado2 = Convert.ToInt32(Console.ReadLine());


            
                /*Suma*/
                if (opcion == 1)
                {
                    suma = numeroIfAnidado1 + numeroIfAnidado2;
                    Console.WriteLine(" La suma es : {0}", suma);
                }
                /*Resta*/
                if (opcion == 2)
                {

                    Console.WriteLine("1. numero1 menos numero 2 ");
                    Console.WriteLine("2. numero2 menos numero 1 ");
                    Console.Write("****  elige como quieres que se resten :");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 1)
                    {
                        resta = numeroIfAnidado1 - numeroIfAnidado2;
                        Console.WriteLine("la resta es numero1 menos numero2 : {0} ", resta);
                    }
                    if (opcion == 2)
                    {
                        resta = numeroIfAnidado2 - numeroIfAnidado1;
                        Console.WriteLine("la resta es numero2 menos numero1 : {0} ", resta);
                    }
                }

                /*Multiplicacion*/
                if (opcion == 3)
                {
                    multplicacion = numeroIfAnidado1 * numeroIfAnidado2;
                    Console.WriteLine("la multiplicacion es : {0} ", multplicacion);


                }
                /*Division*/
                if (opcion == 4)
                {
                    if (numero2 != 0)
                    {
                        division = numeroIfAnidado1 / numeroIfAnidado2;
                        Console.WriteLine("la division es  {0} :", division);
                    }
                    else
                        Console.WriteLine("no es posible realizar la division : Errror");


                }
            }
            else
                Console.WriteLine("porfavor indica una opcion valida: Error de selecion");



            
            /*Escalaera IF ELSE*/
            /*Operadores logicos booleanos*/
            /*Operador negacion*/
            /*Operador and*/
            /*Operador or*/
            /*Ejercicios operadores logicos booleanos*/
            /*Instruccion switch*/
            /*Ejercicio con swithc*/
            /*Seccion switch*/
            /*Etiqueta case default*/
            /*Ejercicio remplazo if else por switch*/
            /*Las constantes*/


            Console.ReadKey();
        }
    }
}

/*La palabra clave de tipo bool es un alias para el tipo de estructura de .NET System.Boolean que representa un valor booleano que puede ser true o false.*/

/*Las instrucciones if, if-else y switch seleccionan las instrucciones que se ejecutarán a partir de muchos trazados posibles en función del valor de una expresión. La instrucción if ejecuta una instrucción solo si una expresión booleana proporcionada se evalúa como true. La instrucción if-else permite elegir cuál de las dos rutas de acceso al código se deben seguir en función de una expresión booleana. La instrucción switch selecciona una lista de instrucciones para ejecutarla en función de la coincidencia de un patrón con una expresión*/

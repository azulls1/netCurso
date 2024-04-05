using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._1_Matrices_Unidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int tamaño;

            //tipo[] nombre = new tipo[tamaño];   //tipo[] nombre = new tipo[tamaño] + inicialisacion;
            double[] calificaciones = new double[4] {9,10,7.4,6}; //declaracion de una matriz unidimencional "double" y su inicializacion
            // todo lo del lado izquierdo antes del = se le concoe como la declaracion y del lado derecho se le conoce como la creacion de la matriz
            
            //declaramos 3 arreglos de diferentes tipos //instancia que es crearlas y eso se logra con el lado derecho de la declaracion 
            string[] nombres = new string[5] {"juan1", "juan2", "juan3", "juan4", "juan5", };//declaracion de una matriz dimencional de tipo string y su inicializacion
            
            int[]    numeros = {0,2,3}; // esta es otra manera de crear una matriz sin el new ya que se asignan valores y autoaticamente se instancia (crea la matriz) con la cantidad de elementos que se introdujieron


            //declaracion de una matriz
            int[] numeros1;
            //instancia  (creacion del objeto) e inicilizacion
            numeros1 = new int[] { 5, 3, 1 };


            //declaracion de una matriz instancia  (creacion del objeto) e inicilizacion
            int[] numeros2= new int[] { 5, 3, 1 }; ;
           


            //inicializacion de una matriz
            /*
            calificaciones[0] = 9;
            calificaciones[1] = 10;
            calificaciones[2] = 7.4;
            calificaciones[3] = 6; */


            byte[]   datos   = new byte[7];


            //pediremos al usuario que indique el tamaño de la matriz que sera guardado en una variable y pues creada la matriz
            // Console.WriteLine("de que tamaño sera la matriz");
            //tamaño = Convert.ToInt32(Console.ReadLine());

            //int[]    primos  = new int[tamaño];

            // acceder a los elementos de una matriz unidimencional 

            double[] calificaciones1 = new double[4];

            calificaciones1 [0] = 9;    // le damos un valor al indice 0 de la matriz unidimencional
            calificaciones1 [1] = 10;   // le damos un valor al indice 0 de la matriz unidimencional
            calificaciones1 [2] = 7.4;  // le damos un valor al indice 0 de la matriz unidimencional
            calificaciones1 [3] = 6;    // le damos un valor al indice 0 de la matriz unidimencional


            Console.WriteLine(calificaciones1[2]);  //mostramos solo el indice dos de la matriz unidimencional

            double caliFinal;
            caliFinal = calificaciones1[2] - 1;     //al indice dos le restamos uno
            Console.WriteLine(caliFinal);  // mostramos el resultado despues de la operacion en el indice


            //****************************************************************************************************************
            //                      recorrer por medio de un siclo for nuestro matriz unidimencional
            //****************************************************************************************************************


            int i;//variable de control para el siclo for
            //acceder a los elementos de una matriz usando instrucciones de iteracion
            string[] nombres1 = new string [5];

            //forma de recorrer un arreglo y pedir los datos al usuario 
            for (i = 0; i <= 4; i++) // i va ir incrementando con cada siclo
            {
                Console.WriteLine("me puedes dar el valor del indice {0}: ",i);// i se pone en los corchetes asiendo  que tome los valores de los indices y de esta manera imprimiendo cada uno de ellos
                nombres1[i] = Console.ReadLine();// declaramos console.readline por que es un string y no un texto, se guardara en el arreglo en los indices segun el valor de i al recorrer el siclo
            }

            Console.WriteLine("valores del arreglo unidimencional");
            //forma de recorrer un arreglo base al ultimo valor de indice  y imprimirlo
            for (i = 0; i <= 4; i++) // i va ir incrementando con cada siclo
            {
                
                Console.WriteLine("indiice [{0}] = {1}",i,nombres1[i]);// i se pone en los corchetes asiendo  que tome los valores de los indices y de esta manera imprimiendo cada uno de ellos
            }

            Console.WriteLine(" ");
            Console.WriteLine("***************impresion por .length*******");
            Console.WriteLine(" ");

            //declaracion de la sentencia para limpiar un arreglo
            //Array.Clear(array, inicio, longitud);   
            Array.Clear(nombres1,0,nombres1.Length); // con esto limpiamos el arreglo para que no contenga ningun valor anterior 

            //forma avanzada de recorrer un arreglo con.lenght
            for (i = 0; i < nombres1.Length; i++)
            {
                Console.WriteLine("me puedes dar el valor del indice {0}: ", i);// i se pone en los corchetes asiendo  que tome los valores de los indices y de esta manera imprimiendo cada uno de ellos
                nombres1[i] = Console.ReadLine();// declaramos console.readline por que es un string y no un texto, se guardara en el arreglo en los indices segun el valor de i al recorrer el siclo
            }

            //forma avanzada de recorrer un arreglo con.lenght y imprimir sus valores
            for (i = 0; i < nombres1.Length; i++)
            {
                Console.WriteLine(nombres1[i]);
            }

        }
    }
}

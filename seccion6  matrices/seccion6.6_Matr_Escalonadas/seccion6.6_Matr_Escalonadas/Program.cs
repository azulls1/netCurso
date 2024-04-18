using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._6_Matr_Escalonadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nota de diferentes tipo de declaracion de matrices

            /*
            tipo[ ] nombre = new tipo [ ];                          *Matriz unidicmencoonal*
            tipo[,] nombre = new tipo [fila][columna ];             *matriz bidimencional o multidimencional*
            tipo[,,] nombre = new tipo [fila][columna ][capa];      *matriz tridimencional o multidimencional*
            tipo[ ][ ] nombre = new tipo [fila][ ];                 *matriz escalonada, matriz undimencional que contiene otras matrices unidimencionales de 
                                                                     diferentes tamaños
            tipo[ ][,] nombre = new tipo [fila][,];                 *matriz escalonada multidimencional, matriz unidimencional que contiene matrices 
                                                                     mutlidimencionales de diferentes tamños
             */

            //programa de matrices escalonadas

            //ejemplo de la matriz ventas escalonada  que es una matriz unidimencional con 4 matrices de diferentes tamaños

            /*
             *          ----------------------------
                        |  0,0   |  0,1   |  0,2   |
                        ----------------------------
                        |  1,0   |  1,1   |
                        -------------------------------------
                        |  2,0   |  2,1   |  2,2   |  2,3   |
                        -------------------------------------
                        |  3,0   |  3,1   |  3,2   |
                        ----------------------------
             */

            int i, j; //Variables de control para los siclos
            int numMatrices, numAlumnos; // variable que contendra el salon que representa la columna y el numero de alumnos que representa las filas

            //declaramos nuestra  una matriz unidicmencional de matrices unidicmencionales , es una matriz de matrices sencilla
            //tipo[ ][ ] nombre = new tipo [fila][ ];
            double[][] ventas = new double[4][];

            //declaracion de las matrces internas e inicializacion
            ventas[0] = new double[3] { 155, 100, 170 }; //dentro del inidice 0 de la matriz ventas creamos una matriz con 3 elemtos
            ventas[1] = new double[2] { 205, 120 };     //tambien se puede declarar de la siguiente manera ventas[1] = new double[] {205,120}; 
            ventas[2] = new double[4] { 115, 190, 104, 130 };
            ventas[3] = new double[3] { 163, 218, 125 };


            //otra forma de declara una matriz escalonada  e inicializarla 
            //tipo[ ][ ] nombre = new tipo [fila][ ];
            double[][] ventas1 = new double[][] //no decimos la cantidad de matrices que lelvara e inicializamos dentro de la matriz 
            {
                new double[] {155,100,170},
                new double[] {205,120},
                new double[] {115,190,104,130},
                new double[] {163,218,125}

            };
            Console.WriteLine(ventas1.Length+" impresion 1"); //solo imprimira la matriz uniddimencional con los elementos que tiene, resultado 4, no muestra las matrices internas
            Console.WriteLine(ventas1[2].Length+" impresion 2"); //muestra la cantidad de elemtos de la matriz interna  
            Console.WriteLine(ventas1[2][3]+ " impresion 3");//accedemos a un elemtno en espesifico de nuestra matriz de matrices esalonada

            //usamos la propiedad length
            //creamos una matriz unidimencional
            //tipo[] nombre = new tipo [];
            int[] numeros = new int[4] { 5,7,3,11};

            //mostramos cuantos elementos tiene la matriz unidimencional
            Console.WriteLine(numeros.Length+ " impresion 4");


            //acceder a los elementos de una matriz escalonada atraves de intrucciones de iteracion (for)

            for ( i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("Elemento {0}", i);

                for ( j = 0; j < ventas[i].Length; j++)
                {
                    Console.WriteLine(ventas[i][j]);
                }
            }

        }
    }
}

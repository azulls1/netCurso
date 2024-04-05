using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6._4_Matriz_multi_con_iteraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int i; //variable de control de ciclo exterior
            int j; //vatiable de control de ciclo interior
            int elemento;

            //tipo[,] nombre = new tipo [fila,campo];
            double[,] matriz2D = new double[4,3];


            // llenado de nuestra matriz bidimencional
            for ( i = 0; i < 4; i++)
            {
                Console.WriteLine("Fila {0}",i);
                for ( j = 0; j < 3; j++)
                {
                    Console.Write(" [{0},{1}] =  ",i,j);
                    matriz2D[i,j] = Convert.ToDouble(Console.ReadLine());
                }

            }
            Console.WriteLine("impresion de nuestra matriz");
            // impresion de nuestra matriz bidimencional
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write(" [{0}] ",matriz2D[i,j] );
                }

            }
            Console.WriteLine();
        }
    }
}

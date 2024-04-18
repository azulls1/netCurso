using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._9_matriz__pasar_como_argu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pasar matrices como argumentos

            //declaramos una matriz unidimencional e incialisamos esta matriz con 10 elementos ya
            int[] matrizUni = {1,2,3,4,5,6,7,8,9,10};
            int[,] matrizBi = new int[3, 3] { { 1, 2, 3 },
                                              { 3, 2, 1 },
                                              { 2, 1, 3 }  };


            Console.WriteLine(" ");
            Console.WriteLine("matriz unidimencional ");
            //Invocamos al metodo que imprime los valores de la matriz y le pasamos el Argumento matriz  a nuestro metodo
            ImprimirMatrizUniDimencional(matrizUni);


            Console.WriteLine(" ");
            Console.WriteLine("matriz bidimencional ");

            ImprimirMatrizBiDimencional(matrizBi);

        }

        //metodo que imprime los valores de una matriz

        static void ImprimirMatrizUniDimencional(int[] matrizPa) //declaramos nuestro metoo del tipo de matriz intero igual que  el anteriro y lo resivimos en el parametro escrito
        {
            int i, j;

            for (i = 0; i < matrizPa.Length; i++)
            {
                Console.WriteLine(matrizPa[i]);
            }

        }

        static void ImprimirMatrizBiDimencional(int[,] matrizBiPa)
        {
            int i, j;

            for(i = 0; i < matrizBiPa.GetLength(0); i++)
            {
                Console.WriteLine("fila {0} ", i);
                for(j = 0; j < matrizBiPa.GetLength(1); j++)
                {
                    Console.WriteLine(matrizBiPa[i,j]);
                }

            }
        }


    }
}

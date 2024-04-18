using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._8_matriz__Metodo_GetLenght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int i; //variable de control ciclo exterior
            int j; //variable de control ciclo interior

            double[,] matriz2D = new double[4,3]  { {100,120,205},
                                                    {115,196,300},
                                                    {157,172,245},
                                                    {130,180,281} };

            //mostramos los valores
            Console.WriteLine("Mostramos nuestra matriz con el metdo GetLength ");
            for (i = 0; i < matriz2D.GetLength(0); i++) //el metodo GetLength(Inidce) nos ayuda a elegir el indice de la matriz que se recorrera facilitando el recorrido del siclo que se esta ciendo en este caso es 4 
            {
                //Console.WriteLine("Fila {0} ", i);
                for (j = 0; j < matriz2D.GetLength(1); j++) //el metodo GetLength(Inidce) nos ayuda a elegir el indice de la matriz que se recorrera facilitando el recorrido del siclo que se esta ciendo en este caso es 3 
                {
                    Console.Write(matriz2D[i, j]+" , " ); //imprimos nuestro arreglo dependidneo en el indice que valla de la fila y la columna
                }
                Console.WriteLine(" ");

            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("******** Ejemplo de una matriz dimencional usando el metodo getlenght **********");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(".");
            Console.WriteLine(".");

            int i1, j1, salon, alumno;
            
            Console.WriteLine("me puedes dar la cantidad de salones");
            salon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("me puedes dar la cantidad de alumnos");
            alumno = Convert.ToInt32(Console.ReadLine());

            double[,] matriz2D1 = new double[salon,alumno];


            //estrcutra para poder usar  el metodo GetLength
            // nombreMatriz.GetLength(indice) 
            for (i1 = 0; i1 < matriz2D.GetLength(0); i1++)
            {

            }




        }
    }
}

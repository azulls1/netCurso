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
            int i, j; //Variables de control para los siclos
            int salones, numAlumnos; // variable que contendra el salon que representa la columna y el numero de alumnos que representa las filas
            double sumaCalif = 0, promedio, caliMin = 10, caliMax = 0;

            Console.Write("me puedes dar la cantidad de salones :");
            salones = Convert.ToInt32(Console.ReadLine());

            Console.Write("me puedes dar la cantidad de alumnos :");
            numAlumnos = Convert.ToInt32(Console.ReadLine());

            //declaramos nuestra matriz bidimencional siguindo nuestro orden primero filas luego columnas
            //tipo[,] nombre = new tipo [fila,campo];
            double[,] calificaciones = new double[salones, numAlumnos];

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("salon : {0}", i);
                for (j = 0; j < numAlumnos; j++)
                {
                    Console.Write("me puedes dar la calificacion {0}:", j);
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());//se gurda el dato en el la fila y campo que va en el siclo  
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("Impreison de la matriz ");
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine(" " );
                for (j = 0; j < numAlumnos; j++)
                {
                    Console.Write(calificaciones[i,j]);
                    
                }
            }
            Console.WriteLine(" ");


        }
    }
}

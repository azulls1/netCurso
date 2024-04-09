using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6._5_ejercicio_matriz_mult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primer ejercicio de matrices Multidimencionales,
            //ejercicio crear un programa que pida las calificaciones y pueda  determinar el promedio de estas calificaciones usando una matriz bidimencional

            Console.WriteLine("Ejercicio 1");

            int i, j; //variables de control para los siclos
            int salones, numAlumnos; // variable que contendra el salon que representa la columna y el numero de alumnos que representa las filas
            double sumaCalif = 0, promedio, caliMin = 10, caliMax = 0;

            Console.Write("Ingresa el numero de salones :");
            salones = Convert.ToInt32(Console.ReadLine()); //guardamos el numero de salones que hay 

            Console.Write("Ingrese el numero de alumnos :");
            numAlumnos = Convert.ToInt32(Console.ReadLine()); //guardamos la cantidad de alumnos 

            //declaramos nuestra matriz bidimencional siguindo nuestro orden primero filas luego columnas
            //tipo[,] nombre = new tipo [fila,campo];
            double[,] calif = new double[salones,numAlumnos]; //creamos nuestro arreglo bidimencional y le damos un valor a las filas con numAlumnos y las columnas con salon

            /*              calif 1    calif 2    calif N
             *               clo 1       col 2      col N              ID de la matriz bidimencional
                            ----------------------------------          ------------------------ 
      Fila1 (Salon 1)       |         |           |          |          | 0,0   | 0,1   | 0,2  |
                            ----------------------------------          ------------------------ 
      Fila2 (Salon 2)       |         |           |          |          | 1,0   | 1,1   | 1,2  |
                            ----------------------------------          ------------------------ 
      Fila3 (Salon 3)       |         |           |          |          | 2,0   | 2,1   | 2,2  |
                            ----------------------------------          ------------------------ 
      Fila4 (Salon N)       |         |           |          |          | 3,0   | 3,1   | 3,2  |
                            ----------------------------------          ------------------------ 
             */

            //bloque de codigo para pedir los datos  al usuario

            for (i = 0; i < salones; i++) //iniciamos el siclo en nuestra fila 1 e ira incrementando
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < numAlumnos; j++) //iniciamos el siclo en nuestro campo 1 e ira incrementando
                {
                    do
                    {
                        Console.Write("Salon [{0}], alumno [{1}]", i, j); //imprimimos en la vuelta que esta el siclo o indice pidiendo la calificacion
                        calif[i, j] = Convert.ToDouble(Console.ReadLine());  // guardamos el valor de la calificacion  en la matriz calif en el indice que valla el siclo
                    } while ((calif[i,j] < 0) || (calif[i,j] > 10)); //realizamos una validacion para que los valores que introdusca el usuario sean entre el rango de 0 a 10
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("los valores de la matriz son");

            for (i = 0; i < salones; i++) //iniciamos el siclo  recorriendolo todo con.lenght
            {
                Console.WriteLine(" ");
                for (j = 0; j < numAlumnos; j++) {
                    Console.Write(calif[i,j]); //impirmimos la matriz incrementando el indice con i
                    sumaCalif += calif[i,j];// viene siendo sumaCalif = sumaCalif + calif[i];   , como suma de calificacion es 0 al sumarle el primer indice solo tiene el numero del indice y se guarda en sumcalif y pasa a tener valor se repite el  proceso y ahora suma lo que tenia anteriomrente con el nuevo indice y  lo guarda otra vez en su sumcalif
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            promedio = sumaCalif / (salones * numAlumnos); //sacamos el promedio total de todo los salones no individualmente
            Console.WriteLine("El promedio es {0} ", promedio); //imprimimos el promedio

            //calculamos la calificacion minima de todo nuestro arreglo   recorriendolo 
            for (i = 0; i < salones; i++)// recorremos nuestro  arreglo bidimencional empesando por la fila que se representa con la vairable de salones
            {
                for (j = 0; j < numAlumnos; j++) //recirremos nuestro arreglo bidimencional por cada campo que representa el numero del alumno y la calificacion que tendra el alumno
                {
                    if (calif[i, j] < caliMin) // si e calificiacion en el indice que se encuentra es menor que 10 entonces entra al bloque
                    {
                        caliMin = calif[i, j]; // la calificacion en el inddice que se encuentra se   guarda en cal min 
                    }
                }
            }
            //calculamos la calificacion maxima
            for (i = 0; i < salones; i++) // recorremos nuestro  arreglo bidimencional empesando por la fila que se representa con la vairable de salones
            {
                for (j = 0; j < numAlumnos; j++)//recirremos nuestro arreglo bidimencional por cada campo que representa el numero del alumno y la calificacion que tendra el alumno
                {
                    if (calif[i,j] > caliMax) //si la calificacion en el indice que se encuentra es mayor que 0 entonces entra al bloque
                    {
                        caliMax = calif[i,j]; //la calificacion en el indice que se encuentra se guarfa en cal max  y luego se repite el siclo
                    }
                }
            }

           // mostramos la calificacion maxima y minima
            Console.WriteLine("la califificacion minima es : {0}  y la calificacion maxima es : {1} ", caliMin, caliMax);
            Console.ReadKey();
        }
    }
}


/*
 codigo de como se lo aria el profesor

static void Main(string[] args)
        {
            //Variables
            byte i, j, numAlumnos, salones;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            //Pedimos el número de alumnos
            Console.Write("Ingrese el número de alumnos por salón: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            //Creación de la matriz
            double[,] calificaciones = new double[salones, numAlumnos];

            //For para pedir calificaciones
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for(j = 0; j < numAlumnos; j++)
                {
                    //Pedimos la califiación
                    Console.Write("Ingresa la calificación del alumno {0}: ",j);
                    calificaciones[i,j] = Convert.ToDouble(Console.ReadLine());

                    //Acumulamos las califiaciones
                    sumaCalif += calificaciones[i,j];
                }                
            }

            //Calculamos el promedio
            promedio = sumaCalif / (salones * numAlumnos);

            //Calculamos la calificación mínima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < numAlumnos; j++)
                {
                    if (calificaciones[i,j] < califMin)
                    {
                        califMin = calificaciones[i,j];
                    }
                }   
            }

            //Calculamos la califiación máxima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < numAlumnos; j++)
                {

                    if (calificaciones[i,j] > califMax)
                    {
                        califMax = calificaciones[i,j];
                    }
                }
            }

            //Mostramos los resultados
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La califiación mínima es: {0}", califMin);
            Console.WriteLine("La califiación máxima es: {0}", califMax);
        }
 */



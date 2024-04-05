using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._2_Ejercicios_matri_unid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primer ejercicio de matrices unidimencionales
            //ejercicio crear un programa que pida las calificaciones y pueda  determinar el promedio de estas calificaciones

            Console.WriteLine("Ejercicio 1");

            int i, numAlumnos; // variable que contendra el numero de alumnos
            double sumaCalif = 0, promedio, caliMin = 10, caliMax = 0;

            Console.Write("Ingrese el numero de alumnos : ");
            numAlumnos = Convert.ToInt32(Console.ReadLine()); //guardamos la cantidad de alumnos 



            double[] calif = new double[numAlumnos]; //creamos nuestro arreglo unidimencional y le damos un valor con numAlumnos ingresado por el usuario

            for (i = 0; i < calif.Length; i++) //iniciamos el siclo recorriendo todo el arreglo para pedidr calificaciones
            {
                do{// creamos una validacion para que solo pueda ingresar valores del 0 al 10
                    Console.Write("me puedes dar la calificacion del alumno {0}: ", i); //imprimimos en la vuelta que esta el siclo o indice pidiendo la calificacion
                    calif[i] = Convert.ToDouble(Console.ReadLine());  // guardamos el valor de la calificacion  en la matriz calif en el indice que valla el siclo
                } while ((calif[i] < 0) || (calif[i] > 10)); //validamos  que este dentro de los rangos de 0 a 10 en dado caso que no se repetira hasta cumplir este dato

            }

            Console.WriteLine("los valores de la matriz son");

            for (i = 0; i < calif.Length; i++) //iniciamos el siclo  recorriendolo todo con.lenght
            {
                Console.WriteLine(calif[i]); //impirmimos la matriz incrementando el indice con i
                sumaCalif += calif[i];// viene siendo sumaCalif = sumaCalif + calif[i];   , como suma de calificacion es 0 al sumarle el primer indice solo tiene el numero del indice y se guarda en sumcalif y pasa a tener valor se repite el  proceso y ahora suma lo que tenia anteriomrente con el nuevo indice y  lo guarda otra vez en su sumcalif

            }

            promedio = sumaCalif / numAlumnos;
            Console.WriteLine("el promedio es {0} ", promedio);

            //calculamos la calificacion minima de todo nuestro arreglo   recorriendolo 
            for (i = 0; i < calif.Length; i++)// recorremos nuestro  arreglo unidimencional
            {
                if (calif[i] < caliMin) // si e calificiacion en el indice que se encuentra es menor que 10 entonces entra al bloque
                {
                    caliMin = calif[i]; // la calificacion en el inddice que se encuentra se   guarda en cal min 
                }
            }
            //calculamos la calificacion maxima
            for (i = 0; i < calif.Length; i++) // recorremos nuestro  arreglo unidimencional
            {
                if (calif[i] > caliMax) //si la calificacion en el indice que se encuentra es mayor que 0 entonces entra al bloque
                {
                    caliMax = calif[i]; //la calificacion en el indice que se encuentra se guarfa en cal max  y luego se repite el siclo
                }
            }

            //mostramos la calificacion maxima y minima 
            Console.WriteLine("la califificacion minima es : {0}  y la calificacion maxima es : {1} ", caliMin, caliMax);
        }
    }
}



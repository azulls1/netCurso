using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion_de_prueba_individual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule la potencia, ya sea negativo o positivo de cualquier exponente.
            int numero, exponente, i;
            double resultado = 1, resultadoNegativo;

            Console.WriteLine("ingresa el numero que deseas ");
            numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa el exponente ");
            exponente= Convert.ToInt32(Console.ReadLine());

            if (exponente < 0) //si el exponente es negatico, entonces
            {
                exponente *= -1;//// exponente = exponente * -1  ---> convierte el exponente a positivo
                for (i = 1; i <= exponente; i++)// Iteración desde 1 hasta llegar al exponente
                {
                    resultado *= numero;
                    // Dividimos al 1 entre el resultado y se lo asignamos a una nueva variable
                    resultadoNegativo = (1 / resultado);

                    //Mostramos el resultado
                    Console.WriteLine("{0}^-{1} = {2}", numero, exponente, resultadoNegativo);
                }
            }
            else// Si el exponente no es menor que cero, por lo tanto es mayor o igual
            {
                for (i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }

                //Mostramos el resultado
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);


            }



        }
    } 
}
﻿using System;
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

            //Variables
            int numero, divisor, numDivisores = 0;

            //Bucle exterior, se encarga de recorrer los números del 2 al 100
            for (numero = 2; numero <= 100; numero++)
            {
                //Bucle anidado, se encarga de verificar el número de divisores
                for (divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        numDivisores += 1; //numDivisores = numDivisores + 1;
                    }
                }

                //Verificamos que el número de divisiores sea igual a 2
                if (numDivisores <= 2)
                {
                    Console.WriteLine(numero);
                }

                //Reiniciamos el conteo del número de divisores
                numDivisores = 0;
            }

            Console.ReadKey();
        }



    }


}
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion7._3_palabra_OUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //variable local a main (argumento)
            int numAr;
            string textoAr;
            double numDouAr;

            //invocamos al metodo y mandamos a los argumentos
            prueba(out numAr,out textoAr, out numDouAr); // shace la declaracion de ouy para mencionar que el arugmento fue modificado por el parametro
           
            //despues de que el metodo cambio el valor,  mostramos a los argumento
            Console.WriteLine("valor numAr: {0} , valor textoAr: {1} , valor numDouAr:  {2}", numAr, textoAr, numDouAr);

           
        }
        
        static void prueba(out int numPa, out string textoPa, out double numDouPa)// se tiene que poner antes out para indicar que el argumento que fue pasado y guardado en parametro no estaba inicializado y a qui se modifico e incializo regresando el valor a main, se puede aplicar para varios valores
        {
            //modifcamos el valor de los parametro.
            numPa = 20;
            textoPa = "texto prueba";
            numDouPa = 7.5;
        }
        
    }
}

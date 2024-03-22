using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion7._2_pasar_x_ref_vs_pasar_x_val
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /************** Inicio pasar por valor *********************

            //variable local a main (argumento)
            int numAr;
            //asignamos un valor
            numAr = 10;
            //mostramos su valor en la consola
            Console.WriteLine(numAr);
            //invocamos al metodo y mandamos al argumento
            prueba(numAr);
            //despues de que el metodo cambio el valor, volvemos a mostrar al argumento
            Console.WriteLine(numAr);

           *************** Fin pasar por referencia *******************/
           
            //************************************************************************************************************
            
            //************* Inicio pasar por referencia****************

            //variable local a main (argumento)
            int numAr;
            //asignamos un valor
            numAr = 10;
            //mostramos su valor en la consola
            Console.WriteLine(numAr);
            //invocamos al metodo y mandamos al argumento
            prueba(ref numAr); // shace la declaracion de ref para mencionar que el arugmento fue modificado por el parametro
            //despues de que el metodo cambio el valor, volvemos a mostrar al argumento
            Console.WriteLine( numAr);

            //************* Fin pasar por referencia****************
        }
        /******************* metodo pasar por referencia
        static void prueba( int numPa) 
        {
            //modifcamos el valor del parametro
            numPa = 20;
        }
        *****************Fin metodo pasar por referecnia ***********************/

        //***************************************************************************************************************

        //************* Inicio metodo pasar por referencia****************
        static void prueba( ref int numPa)// se tiene que poner antes ref para  que pueda ser moficado el valor y es bueno para tener varios valores y usarlos,  si usamos return solo regresa un valor  
        {
            //modifcamos el valor del parametro
            numPa = 20;
        }
        //************* Fin metodo pasar por referencia****************
    }
}

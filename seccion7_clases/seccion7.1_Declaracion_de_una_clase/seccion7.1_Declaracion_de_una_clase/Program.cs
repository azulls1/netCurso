 using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion7._1_Declaracion_de_una_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recomendacion repasar el programa
            //seccion5.1_metodos_otimizados
            //seccion5.2_pasar_x_ref_vs_pasar_x_val

            //instanciando a la clase automovil
            //el lado izquiero es la referencia  //el lado derecho crea el tipo de objeto
                          automovil automovil1 = new automovil();
            automovil1.Acelerar();
            
        } // fin del MAIN
        
    }//fin de la clase program

    
    //[modificador de acceso] [class] [identificador]
    public class automovil
    {
        //campos
        //color, el numero de puertas, combustible, motor, año, num serie

        public string color, modelo, coumbustible;
        public byte año, numPuertas;
        public int ccMotor;


        //metodos
        //acelerar, frenar, velocidades, seguros, luces

        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            return acelerar;
        }

        public bool Frenar()
        {
            bool Frenar = true;
            Console.WriteLine("Frenar");
            return Frenar;
        }

        public void Velocidades(ref byte velocidadPa)
        {
            velocidadPa++;
            Console.WriteLine("Cambio de velocidad");
        }

        //instancia de una clase.



    }


}

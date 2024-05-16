﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7._2_Acceder_campos_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //recomendacion repasar el programa
            //seccion5.1_metodos_otimizados
            //seccion5.2_pasar_x_ref_vs_pasar_x_val

            //variable local
            bool acelerar;

            //instanciando a la clase automovil
            //el lado izquiero es la referencia  //el lado derecho crea el tipo de objeto
            automovil automovil1 = new automovil();

            //Acceder a los campos de la clase (7.2.1)
            automovil1.color = "rojo";                 //* usamos automovil1  ya que es la referencia del tipo de objeto (la instanciasion)
            automovil1.combustible = "disel";          //* usamos automovil1  ya que es la instancia del objeto de de la clase automovil 

            //forma de acceder a un campo y imprimirlo
            Console.WriteLine("el tipo de combustible es : {0}", automovil1.combustible);

            //acceder a los metodos de la clase (7.2.2)
    //variable local =  instancia . clase
           acelerar =  automovil1.Acelerar();

            if (acelerar) // si acelerar es true entra al codigo, siempre if evalua primero si es verdadero y entrara al primer bloque de codigo 
            {
                Console.WriteLine("Acelerando correctamente");
            }

        }


    }

    //[modificador de acceso] [class] [identificador]
    public class automovil
    {
        //campos
        //color, el numero de puertas, combustible, motor, año, num serie

        public string color, modelo, combustible;
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

        //instancia de una clase



    }




}

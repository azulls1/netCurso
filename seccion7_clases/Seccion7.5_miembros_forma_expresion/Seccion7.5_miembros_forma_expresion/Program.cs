using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7._5_miembros_forma_expresion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //recomendacion repasar el programa
            //seccion5.1_metodos_otimizados
            //seccion5.2_pasar_x_ref_vs_pasar_x_val

            //variable local
            //bool acelerar;

            //instanciando a la clase automovil
            //el lado izquiero es la referencia  //el lado derecho crea el tipo de objeto
            automovil automovil1 = new automovil();

            //mostramos el campo privado
            Console.WriteLine("el colo es : {0} ", automovil1.Color);

            //asinandole un valor a un campo privado y mostrandolo
            automovil1.Combustible = "Diesel";
            Console.WriteLine("el tipo de combustible es : {0}", automovil1.Combustible);
        }


    }

    //[modificador de acceso] [class] [identificador]
    public class automovil
    {
        //campos
        //color, el numero de puertas, combustible, motor, año, num serie


        //los campos usan la notacion camello (minusculas seguido de una mayuscula para concatenar)
        private string color = "rojo", modelo, combustible;   //campos, al ser un campo privado se puede notar al poner el cursos encima un candado
        private byte año, numPuertas;                //campos, al ser un campo privado se puede notar al poner el cursos encima un candado
        private int ccMotor;                         //campos, al ser un campo privado se puede notar al poner el cursos encima un candado

        //propiedades
        //[acceso] [tipo] [nombre]
        public string Color//las propiedades usan una notacion pascal (Inician con mayuscula)
        {
            //descriptor de acceso get (se traduce  como Obtener)
            //miembro => expresion
            get => color;

        }
        public string Combustible
        {
            //descriptor de acceso get para validar que se le asigno el valor correspondiente
            get { return combustible; }
            //descriptor de acceso set (se traduce como colocar) (hace la funcion de un metodo que recibe arugumentos en sus parametros pero no retorna ningun valor )
            set => combustible = value;     /*set { combustible = value; }*/
        }

        //miembro => expresion

        //metodos
        //acelerar, frenar, velocidades, seguros, luces

        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            prueba();
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


        public static void prueba() //classe estatic
        {
            Console.WriteLine("Soy un metodo estatico");
        }


    }
}

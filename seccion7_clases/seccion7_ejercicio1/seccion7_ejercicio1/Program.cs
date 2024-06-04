using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion7_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diagrama UML
            /*      
             *------------------------------------------*
             *           EMPLEADO                       *
             *------------------------------------------*
             * -NOMBRE :        STRING                  *
             * -APELLIDO :      STRING                  *
             * -ID:             STRING                  * 
             * -LOCKER:         STRING                  *
             * -BANCO:          STRING                  *
             * -NIP:            STRING                  *
             * -----------------------------------------*
             * +EMPLEADO (NOMBREPA, APELLIDOPA)         *
             * +NIP():              STRING              *
             * -GENERARID():        STRING              *
             * -GENERARLOCKER():    STRING              *
             * -ASGINABANCO():      STRING              *
             * +TOSTRING():         STRING              *
             * -----------------------------------------*
             */

            string nombreAr, apellidoAr, nip;

            Console.WriteLine("Bienvenido al sistema: \n");
            Console.WriteLine("Ingrese los siguientes campos que se le solicitan: \n");
            Console.WriteLine("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.WriteLine("Apellido");
            apellidoAr = Console.ReadLine();
            Console.WriteLine("Digite su NIP para asignarlo a su tarjeta bancaraia");
            nip = Console.ReadLine();
            //Instanciamos a la clase empleado  y le pasamos dos argumentos
            Empleado empleado1 = new Empleado(nombreAr, apellidoAr);

            empleado1.Nip = nip;

            //Mostrar la información del objeto
            Console.WriteLine(empleado1.ToString());




        }
    }

    public class Empleado
    {

        //Campos
        private string nombre, apellido, id, locker, banco, nip;
        //Instaciamos a Random
        //Random random = new Random();
        //Propiedades
        public string Nip
        {
            //descriptor de acceso set (se traduce como colocar) (hace la funcion de un metodo que recibe arugumentos en sus parametros pero no retorna ningun valor )
            set => nip = value;
        }

        //Constructor
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //Llamando a los métodos para generar los números aleatorios
            id = GenerarID();               //mandamos a llamar el metodo privador y lo que returne lo guardaremos en la variable id
            locker = GenerarLocker();       //mandamos a llamar el metodo privador y lo que returne lo guardaremos en la variable locker
            banco = AsignaBanco();          //mandamos a llamar el metodo privador y lo que returne lo guardaremos en la variable banco
        }

        //Métodos
        private string GenerarID()
        {
            //Instaciamos a Random
            Random random = new Random();

            //Variables
            int i, numero;
            string id = "";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return id;
        }

        private string GenerarLocker()
        {
            //Instaciamos a Random
            Random random = new Random();
            //Variables
            int i, numero;
            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);

                locker += numero.ToString();
            }
            return locker;
        }

        private string AsignaBanco()
        {
            //Instaciamos a Random
            Random random = new Random();
            //Variables
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;
                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";

            mensaje = "Empleado: " + nombre + " " + apellido + "\nNúmero de empleado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;

            return mensaje;
        }
    }
}
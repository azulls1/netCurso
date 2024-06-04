using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace seccion7_tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear un programa que simule una cuenta bancaria, con las siguientes características:
             * Crear una clase "CuentaBancaria" con los campos y métodos correspondientes *ver diagrama UML adjunto en la imagen*
             * El primer método que vemos en el diagrama es el constructor de la clase, que recibirá los argumentos que ahí se indican e inicializará a los campos de la clase.
             * El método "Deposito" se encarga de recibir una suma de dinero desde el exterior y la agregará al campo "saldo".
             * El método "Retiro" se encarga de extraer una suma de dinero del campo "saldo" dada desde el exterior (verificar que sea posible retirar la cantidad de dinero a partir del saldo que ya se encuentra en la cuenta.
             * El método "ConsultaSaldo" se encarga simplemente de mostrarnos el dinero que tenemos en nuestra cuenta bancaria.
             * El método "ToString" se encarga de mostrarnos la información del cliente (objeto).
             * En Main nos encargaremos de pedir los siguientes datos:
             * nombre, apellidos, dirección, rfc(en México el RFC es una clave que nos permite cumplir con nuestras obligaciones fiscales, ustedes pueden usar el similar de su país) y un saldo inicial para depositar a la cuenta bancaria.
             * Todos esos datos serán enviados al constructor de la clase "CuentaBancaria" en el momento de instanciarla.
             * Después crearemos un menú que aparecerá mientras el usuario no decida salir (apoyarse de un Do-While), y contendrá las siguiente opciones:
             * Deposito
             * Retiro
             * Consultar Saldo
             * Mostrar información de la cuenta
             * Salir 
             * Dependiendo de la opción que se escoja, mandar a llamar al método correspondiente de la clase y crear su lógica para que se pueda depositar o retirar dinero.
             * *NOTA* Es una tarea algo amplia en la que puede que surjan algunos problemas y preguntas, intenten resolverlo antes de ver mi vídeo de resolución, les deseo mucha suerte. Les dejo también el diagrama del método "Deposito" para que no estén tan perdidos.
             * 
             * // Diagrama UML
            /*      
             *------------------------------------------------------------------------------*
             *           CUENTA BANCARIA                                                    *
             *------------------------------------------------------------------------------*
             * -NOMBRE :        STRING                                                      *
             * -APELLIDO :      STRING                                                      *
             * -DIRECCION:      STRING                                                      * 
             * -RFC:            STRING                                                      *
             * -SALDO:          DOUBLE                                                      *
             * -----------------------------------------------------------------------------*
             * +CUENTA BANCARIA (NOMBREPA, APELLIDOPA, SALDOPA, DIRECCIONPA, RFCPA)         *
             * +DEPOSITO (MONTOPA):              DOUBLE                                     *
             * -RETIRO (MONTOPA):                DOUBLE                                     *
             * -CONSULTARSALDO():                VOID                                       *
             * +TOSTRING():                      STRING                                     *
             * -----------------------------------------------------------------------------*
             */

            //variables
            double monto, saldoInicialAr;
            int opcion;
            string nombreAr, appellidoAr, direccionAr, rfcAr;

            Console.WriteLine("Estas aputno de crear una cuneta nueva, porfavor presiona cualquier tecla para continuar ");
            Console.ReadKey();
            Console.WriteLine("Ingrese la informacion que se solicita a continuacion");
            
            Console.WriteLine("\nNombre");
            nombreAr = Console.ReadLine();
           
            Console.WriteLine("\nApellido");
            appellidoAr = Console.ReadLine();
           
            Console.WriteLine("\nDireccion");
            direccionAr = Console.ReadLine();
            
            Console.WriteLine("\nRFC");
            rfcAr = Console.ReadLine();
           
            Console.WriteLine("\nIngrese su deposito inicial: $");
            saldoInicialAr = Convert.ToDouble(Console.ReadLine());

            //instaciamos a la clase cuentabancaria
            CuentaBancaria cliente1 = new CuentaBancaria(nombreAr, appellidoAr, saldoInicialAr, direccionAr, rfcAr);

            Console.WriteLine("Felicidades su cuenta ha sido creada con exito, presione cualquier tecla para contunuar");
            Console.ReadKey();
        }
    }

    public class CuentaBancaria
    {
        public CuentaBancaria(string nombrePa, string appellidopA, double saldoInicialPa, string direccionPa, string rfcAp)
        {

        }


    }
}


 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, dirreccion, correo, telefono, sexo;
            int edad;
            double estatura;
            Boolean objeto;

            nombre = "samael";
            apellido = "Hernadez";
            dirreccion = "carlos sagredo 2743";
            correo = "ejemplo@gmail.com";
            telefono = "449????????";
            sexo = "Hombre";
            edad = 27;
            estatura = 1.75;
            objeto = true;

            Console.WriteLine(nombre + " " + apellido + " " + correo + " " + telefono + " " + sexo + " " + edad +" "+ dirreccion + " " +estatura + " " +objeto);
        }
    }
}

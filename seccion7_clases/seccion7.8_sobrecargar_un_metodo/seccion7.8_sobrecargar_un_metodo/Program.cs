﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion7._8_sobrecargar_un_metodo
{
    class Program
    {
        static void Main(string[] args)
        { //Varable para recibir desde "Concatenar"
            string nombreYApellido;

            //Instancia
            Nombres nombres = new Nombres();

            nombreYApellido = nombres.Concatenar("Leticia", "Guzmán", "Valdez");

            //Mostrando las cadenas ya concatenadas
            Console.WriteLine(nombreYApellido);
        }
    }

    class Nombres
    {
        //Método
        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + " " + apellidoPa;

            return nombreApellido;
        }

        //Sobrecarga del método Concatenar
        public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + " " + apellidoPa + " " + apellido2Pa;

            return nombreApellido;
        }

    }
}
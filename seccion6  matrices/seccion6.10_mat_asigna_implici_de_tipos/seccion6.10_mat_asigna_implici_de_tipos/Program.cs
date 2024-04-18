using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._10_mat_asigna_implici_de_tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matrices con asignacio implicita de tipos
            //usamos variables de asignacion implicita, "var"


            //matriz unidimencional con asignacion implicita de tipo
            //declaracion e inicialisacion de la matriz unidimencional
            // var nombre = new[] {};
            var matriz1D = new[] {1,2,3,4,5};

            //matriz bidimencional con asignacion implicita de tipo
            //declaracion e inicialisacion de la matriz bidimencional
            // var nombre = new[,] {};
            var matriz2D = new[,] { { 1, 2, 3, 4, 5 },
                                     {6, 7, 8, 9, 10 }   };


            //matriz escalonada con asignacion implicita de tipo
            //declaracion e inicialisacion de la matriz escalonada cada new representa una matriz dentro de la matriz principal
            // var nombre = new[] {
            // new []{ variables}.
            // new []{ variables}
            // };
            var matrizEscalonada = new[] {

                new[] { 1,2,3 },
                new[] { 4,6 },
                new[] { 7,8,9,11 }

            };



        }
    }
}

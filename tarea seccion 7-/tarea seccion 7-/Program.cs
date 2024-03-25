using System    ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace tarea_seccion_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OpcionRetornada;
            OpcionRetornada=menuPrincipal();
             
            if (OpcionRetornada == 1)
            {
                conversionGraRad();
            }
            else
            {
                calcularArea();
            }

        }

        static int menuPrincipal()
        {
            int opcion;
            do
            {

                Console.WriteLine("Elige la opcion que deseas efectuar");
                Console.WriteLine("1. transformar grados a radianes");
                Console.WriteLine("2. calcular el area de una figura");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while((opcion < 0) || (opcion > 2));


            return opcion;
        }

        static void conversionGraRad()
        {
            double grados, resultado;
                     
            Console.WriteLine("me puedes dar los grados que deseas converitr");
            grados = Convert.ToDouble(Console.ReadLine());

            resultado = (grados * Math.PI) / 180;

            Console.WriteLine(resultado);              
        }

        static void calcularArea()
        {
            int opcion;
            double area;
            do
            {
                Console.WriteLine("elige la figura que deseas obtener el area");
                Console.WriteLine("1 cuadrado ");
                Console.WriteLine("2 ciruclo ");
                Console.WriteLine("3 triangulo ");
                opcion= Convert.ToInt32(Console.ReadLine());

            } 
            while ((opcion < 1) || (opcion > 3));
             
            switch (opcion) {
                case 1:
                    
                   area = areaCuadrado();
                   Console.WriteLine("el area del cuadrado es {0}",area);
                 break;

                case 2:

                    area = areaCirculo();
                    Console.WriteLine("el area del circulo es {0}", area);
                    break;
                case 3:

                    area = areaTriangulo();
                    Console.WriteLine("el area del circulo es {0}", area);
                    break;




            }

        }

        static double areaCuadrado()
        {
            double largo, ancho;
            double resultado;
            Console.WriteLine(" me puedes dar el largo del cuadrado");
            largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("me puedes darl el ancho del cuadrado");
            ancho = Convert.ToDouble(Console.ReadLine());

            resultado = largo * ancho;

            return resultado;
        }
        static double areaCirculo()
        {
            double radio;
            double resultado;
            Console.WriteLine("me puedes dar el radio del circulo : ");
            radio = Convert.ToDouble(Console.ReadLine());
            
            resultado= Math.PI * (Math.Pow(radio,2));

            return resultado;
        }

       static double areaTriangulo()
        {
            double resultado;
            double basee, altura;
            Console.WriteLine("me puedes dar la base :");
            basee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("me puedes dal la altura");
            altura = Convert.ToDouble(Console.ReadLine());

            resultado = (basee * altura) / 2;


            return resultado;
        }






    }//Fin de la clase Program
}
// como lo aria el profesor 
/* calcular el area de las figuras
 namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double radioAr, baseAr, alturaAr, ladoAr, area;
            byte opcion;

            //Mostramos las opciones
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");

            //Preguntamos
            Console.Write("Escoge una opción y calcularé su área: ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.Write("Dame el valor del radio de tu círculo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());

                    //Invocamos al método
                    area = Circulo(radioAr);

                    //Mostramos el resultado
                    Console.WriteLine("El área es: {0}", area);
                    break;
                case 2:
                    //Pedimos los valores de base y altura
                    Console.Write("Dame el valor de la base de tu triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Dame el valor de la altura de tu triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());

                    //Invocamos al método
                    area = Triangulo(baseAr, alturaAr);

                    //Mostramos el resultado
                    Console.WriteLine("El área es: {0}", area);
                    break;
                case 3:
                    Console.Write("Dame el valor de uno de los lados de tu cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());

                    area = Cuadrado(ladoAr);

                    //Mostramos el resultado
                    Console.WriteLine("El área es: {0}", area);
                    break;
            }
        }

        //Método que calcula el área de un círculo
        static double Circulo(double radioPa)
        {
            double area;

            //Calcula el área
            area = Math.PI * (radioPa * radioPa);

            //Regresamos el valor de área
            return area;
        }

        //Método que calcula el área de un triangulo
        static double Triangulo(double basePa, double alturaPa)
        {
            double area;

            //Calcula el área
            area = (basePa * alturaPa) / 2;

            //Regresamos el valor de área
            return area;
        }

        //Método que calcula el área de un cuadrado
        static double Cuadrado(double ladoPa)
        {
            double area;

            //Calculamos el área
            area = ladoPa * ladoPa;

            //Regresamos el valor del área
            return area;
        }
    }
}
 */
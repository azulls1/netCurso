using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion4_calcular_area_y_perimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*programa que calcula el area y el perimetro de un cuadrado dato que proporciona el usuario*/

            /*pseudocodigo
            Inicio
                Varibales:
                    altura, ancho, area, perimetro : double
            escribir ("dame la altura: ")
            leer (altura)
            escribir ("dame el ancho: ")
            leer (ancho)
            area <- altura * ancho
            perimetro <- 2(altura + ancho)
            escribir ("el area es: ", area)
            escribir ("el perimetro es: ", perimetro)
            Fin*/


            /*declaracion de variables*/
            double altura, ancho, radio, area, perimetro;

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************calcular el area y perimetrode un cuadrado con parse****************************");
            Console.WriteLine("*******************************************************************************************************");

            /*sacar el area y el perimetro mediante el  metodo parse*/
            Console.Write("me puedes dar la altura :");
            altura = double.Parse(Console.ReadLine());
            Console.Write("me puedes dar el ancho :");
            ancho = double.Parse(Console.ReadLine());
            area = altura * ancho;
            perimetro = 2 * (altura + ancho);
            Console.WriteLine("el area es: {0}", area);
            Console.WriteLine("el perimetro es: {0}", perimetro);

            Console.ReadKey();

            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("***********************calcular el area y perimetro de un cuadrado con convert***************************");
            Console.WriteLine("*********************************************************************************************************");

            /*sacar el area y el perimetro mediante el  metodo convert*/
            Console.Write("me puedes dar la altura :");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("me puedes dar el ancho :");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = altura * ancho;
            perimetro = 2 * (altura + ancho);
            Console.WriteLine("el area es: {0}", area);
            Console.WriteLine("el perimetro es: {0} ", perimetro);

            Console.ReadKey();

            /*programa que calcula el area y el perimetro de un circulo, dato que proporciona el usuario*/

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("***********************calcular el area y perimetro de un circulo con convert***************************");
            Console.WriteLine("********************************************************************************************************");
            /*pseudocodigo
            Inicio
                Varibales:
                    radio, pi, area, perimetro : double
            escribir ("dame el radio: ")
            leer (radio)
            area <- pi * radio^2
            perimetro <- 2 * pi * radio
            escribir ("el area es: ", area)
            escribir ("el perimetro es: ", perimetro)
            Fin*/

            /*sacar el area y el perimetro mediante el  metodo convert*/
            Console.Write("me puedes dar el radio :");
            radio = Convert.ToDouble(Console.ReadLine());
            /*se usa el metodo math pow se define al final del codigo*/
            area = Math.PI * Math.Pow(radio, 2);
            /*se usa el metodo math pi se define al final del codigo*/
            perimetro = 2 * Math.PI * radio;
            Console.WriteLine("el area es: {0}", area);
            Console.WriteLine("el perimetro es: {0} ", perimetro);

            Console.ReadKey();


            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("***********************calcula el perimetro de cualquie poligono regular********************************");
            Console.WriteLine("********************************************************************************************************");
            
            int numeroDeLados;
            double PerimetroDelPoligono, tamañoDeLado;

            Console.Write("me puedes proporcionar el numero de lados: ");
            numeroDeLados = Convert.ToInt32(Console.ReadLine());
            Console.Write("me puedes dar el tamaño de uno de los lados: ");
            tamañoDeLado = Convert.ToDouble(Console.ReadLine());
            PerimetroDelPoligono = numeroDeLados * tamañoDeLado;
            Console.WriteLine("el perimetro : {0} ", PerimetroDelPoligono);


            Console.ReadKey();

            Console.WriteLine("*************************************************************************************************************************");
            Console.WriteLine("***********************programa que transforme de grados Centígrados a grados Fahrenheit.********************************");
            Console.WriteLine("*************************************************************************************************************************");

            double const1 = 1.8, const2 = 32, fahrenheit, celsius;

            Console.Write("puedes proporcionarme los °C para convertirlos en °F: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * const1) + const2;
            Console.WriteLine("°C : {0}", fahrenheit);

            Console.Write("puedes proporcionarme los °F para convertirlos en °C: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - const2) / const1;
            Console.WriteLine("°F: {0}", celsius);




            Console.ReadKey();

            /*(1) La función Math. pow() retorna la base elevada al exponente , es decir, baseexponente . La base y el exponente estan en el sistema numérico decimal.
               ehemplo de su uso
               math.pow(variable, numero de exponente).*/

            /*(2) La propiedad Math. PI representa la relacion entre la longitud de la circunferencia de un circulo y su diametro, la cual es aproximadamente*/
        }
    }
}

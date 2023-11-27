using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seccion5_toma_de_decisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tipo de dato bool*/



            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador de igualdad                           ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /**********************************
             *      Operador de igualdad      *
             **********************************
             *     signo     /  operador      *
             **********************************
             *     ==        /  igualdad      *
             **********************************
             *     !=        /  desigualdad   *
             **********************************/

            Console.WriteLine(6 == 6); //esto devulve true
            Console.WriteLine(5 != 6); //esto devulve true

            Console.WriteLine(5 == 6); //esto devuelve false
            Console.WriteLine(5 != 5); //esto devuelve false



            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador de comparacion                        ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /************************************
            *     Operador de comparacion       *
            *************************************
            *     signo  /  operador            *
            * ***********************************
            *     <      /  menor que           *
            * ***********************************
            *     >      /  mayor que           *    
            * ***********************************
            *    <=      /  menor o igual que   *    
            *************************************
            *     >=     /  mayor o igual que   *     
            *************************************/

            Console.WriteLine(0 < 1); //esto devulve true
            Console.WriteLine(1 < 0); //esto devuelve false 
            Console.WriteLine(0 > 1); //esto devuelve false 
            Console.WriteLine(1 > 0); //esto devulve true
            Console.WriteLine(0 <= 1); //esto devulve true
            Console.WriteLine(1 <= 0); //esto devuelve false
            Console.WriteLine(1 <= 1); //esto devulve true
            Console.WriteLine(0 >= 1); //esto devuelve false
            Console.WriteLine(1 >= 0); //esto devulve true
            Console.WriteLine(1 >= 1); //esto devulve true

            /*Palabras clave en c#
            https://learn.microsoft.com/es-mx/dotnet/csharp/language-reference/keywords/ */

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Instrucciones de seleccion IF                  ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Instrucciones de seleccion IF*/

            /*declaramos variables*/
            double numero1, numero2;

            /*pedimos el numero al usuario*/
            Console.Write("me puedes proporcionar un numero : ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("me puedes proporcionar un numero : ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            /*en caso de que el numero proporcionado sea igual al seugndo numero proprcionado */
            if (numero1 == numero2)
            {
                Console.WriteLine("los dos numeros proporcionados son iguales : {0} = {1}", numero1, numero2);
            }

            /*en caso que el primer numero sea mayor que el numero dos*/
            if (numero1 > numero2)
            {
                Console.WriteLine("el primer numero es mayor que  que el segundo numero : {0} mayor que {1} ", numero1, numero2);
            }

            /*en caso que el primer numero sea menor que el numero dos */
            if (numero1 < numero2)
            {
                Console.WriteLine("el primer numero es menor que  que el segundo numero : {0} menor que {1}", numero1, numero2);
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Intruccion de seleecion ELSE                   ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Intruccion de seleecion ELSE*/

            int edad;
            Console.Write("cual es tu edad : ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("eres mayor de edad *FELICIDADES* ");
            }
            else
            {
                Console.WriteLine("lo siento aun eres menor de edad : ");
            }
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     IF anidados                                    ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /*IF anidados*/

            int suma, resta, multplicacion, division, numeroIfAnidado1, numeroIfAnidado2, opcion;

            Console.WriteLine("0, informacion del programa");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.Write("*** Escoge una opcion : ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion <= 4) /*validamos si  es introdujo una opcion correcta de las que se le mostro*/
            {
                /*procedemos a pedir los numeros en caso que la opcion proporcionada sea valida*/
                Console.Write("*** Dame el primer numero : ");
                numeroIfAnidado1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("*** Dame el segundo numero : ");
                numeroIfAnidado2 = Convert.ToInt32(Console.ReadLine());

                /*dependiendo la opcion que eligio se ejecutara el codigo de acontinuacion cada uno en su seccion respectivamente*/
                if (opcion == 0)
                {
                    Console.WriteLine("Programa para operaciones basicas usando la estructura if");
                    Console.WriteLine("Elaborado en NOV del 2023");
                    Console.WriteLine("Echo por : Ashernandez");
                }

                /*Suma*/
                if (opcion == 1)
                {
                    suma = numeroIfAnidado1 + numeroIfAnidado2;
                    Console.WriteLine(" La suma es : {0}", suma);
                }
                /*Resta*/
                if (opcion == 2)
                {
                    /*procedemos a dar opcion de como prefiere que se reste dependiendo los numeros proprcionados, el resultado sera difenrente dependiendo la ellecion de como quiere que se resten los datos*/
                    Console.WriteLine("1. numero1 menos numero 2 ");
                    Console.WriteLine("2. numero2 menos numero 1 ");
                    Console.Write("****  elige como quieres que se resten :");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 1)
                    {
                        resta = numeroIfAnidado1 - numeroIfAnidado2;
                        Console.WriteLine("la resta es numero1 menos numero2 : {0} ", resta);
                    }
                    if (opcion == 2)
                    {
                        resta = numeroIfAnidado2 - numeroIfAnidado1;
                        Console.WriteLine("la resta es numero2 menos numero1 : {0} ", resta);
                    }
                }

                /*Multiplicacion*/
                if (opcion == 3)
                {
                    multplicacion = numeroIfAnidado1 * numeroIfAnidado2;
                    Console.WriteLine("la multiplicacion es : {0} ", multplicacion);


                }
                /*Division*/
                if (opcion == 4)
                {
                    /*cuando el divisor que es la parte de abajo de la division sea diferente a 0 se podra lograr efectuar correctamente ya que una division entre 0 marca error por lo cual  entra al bloque de codigo en caso contrario  ba directo al else por que marca error*/
                    if (numero2 != 0)
                    {
                        division = numeroIfAnidado1 / numeroIfAnidado2;
                        Console.WriteLine("la division es  {0} :", division);
                    }
                    else
                        Console.WriteLine("no es posible realizar la division : Errror");


                }
            }
            /*este es el primer if en caso que de no se  seleccione una opcion valida */
            else
            {
                Console.WriteLine("porfavor indica una opcion valida: Error de selecion");
            }

            /*Escalaera IF ELSE*/


            /* forma de realizar if else con el ejemplo anterior forma mas sencilla 
             
              // Suma
            if (opcion == 1)
            {
                resultado = num1 + num2;
            }
            else
            {
                //Resta
                if (opcion == 2)
                {
                    resultado = num1 - num2;
                }
                else
                {
                    // Multiplicación
                    if (opcion == 3)
                    {
                        resultado = num1 * num2;
                    }
                    else
                    {
                        //División
                        if (opcion == 4)
                        {
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("No es posible dividir entre cero!");
                            }
                        }
                    }
                }
            }          
                        
            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);*/

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operadores logicos booleanos    (NEGACION)     ****************************");
            Console.WriteLine("*******************************************************************************************************");

            /*****************************************
            *     Operadores logicos booleanos       *
            ******************************************
            *     signo    /  operador               *
            * ****************************************
            *        !     /  Negacion logica        *
            * ****************************************
            *        &     /  AND logico             *    
            * ****************************************
            *        |     /  OR logico              *    
            ******************************************
            *        ^     /  OR exclusivo logico    *    
            ******************************************
            *        &&    /  AND logico condicional *    
            ******************************************
            *        ||    /  OR logico condicional  *     
            ******************************************/

            /*negacion !*/
            bool negacionLogica = true, bateria;

            Console.WriteLine(negacionLogica); // da como resultado true
            Console.WriteLine(!negacionLogica); //usamos el operador para negar la variable y da como resultado false

            Console.Write("hay bateria? (true/false) :");
            bateria = Convert.ToBoolean(Console.ReadLine());

            if (!(bateria == true)) //dependiendo de la respuesta del usuario puede dar false o true 
            { //solo entra a este bloque de codigo si es verdadero, siempre el primer bloque  se accesa solo si es verdadero en operadores booleanos
                Console.WriteLine("conectar celular");
            }
            else
            {// en caso de que sea false se accede al bloque de codigo
                Console.WriteLine("no es necesario conectar el celular");
            }


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador and &&                                ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Operador and &&*/

            /*****************************************************
             *    Oprando    /   operando    /    conjuncion     *
             *****************************************************
             *       p       /       q       /     p && q        *
             *****************************************************
             *   true        /       true    /       true        *
             *****************************************************
             *   true        /       false   /       false       *
             *****************************************************
             *   false       /       true    /       false       *
             *****************************************************
             *   false       /       false   /       false       *
             *****************************************************/

            int edadParaManejar;
            bool licenciaDeManejar;

            Console.Write("Que edad tienes :");
            edadParaManejar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tienes licencia de manejo (true/false):");
            licenciaDeManejar = Convert.ToBoolean(Console.ReadLine());

            if (edadParaManejar >= 18 && licenciaDeManejar == true) //se tienen que cunplir las dos opciones para entrar en el primer bloque de lo contrario va directo a else
            {
                Console.WriteLine("muchas felicidades");
            }
            else
            {
                Console.WriteLine("lo siento");
            }


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador or ||                                 ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Operador or  || */

            /*****************************************************
             *    Oprando    /   operando    /    conjuncion     *
             *****************************************************
             *       p       /       q       /     p || q        *
             *****************************************************
             *   true        /       true    /       true        *
             *****************************************************
             *   true        /       false   /       true        *
             *****************************************************
             *   false       /       true    /       true        *
             *****************************************************
             *   false       /       false   /       false       *
             *****************************************************/

            double calPrepa, calExamen;

            Console.Write("puedes darme la calificacion de tu prepa :");
            calPrepa = Convert.ToDouble(Console.ReadLine());

            Console.Write("me puedes dar la calificacion de tu examen :");
            calExamen = Convert.ToDouble(Console.ReadLine());

            if (calPrepa >= 9 || calExamen >= 9.5) // si se cumple una u otra condicion entrara en el primer bloque si  no se cumple ninguna va directo a else
            {
                Console.WriteLine("felicidades tienes beca ");
            }
            else
            {
                Console.WriteLine("lo siento no podemos darte la beca");           
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador logicos booleanos                     ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Ejercicios operadores logicos booleanos*/

            // Variables
            float energia; //variable para declarar numeros con decimales
            bool propulsorIzquierdo, propulsorDerecho; //booleano solo puede tomar valores true o false

            Console.Write("Ingrese el nivel de energía: ");
            energia = Convert.ToSingle(Console.ReadLine()); // ToSingle es para convertir de un string a un flotante 

            Console.Write("¿El propulsor derecho está en buen estado? (true/false): ");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine()); //ToBoolean  es para convertir de un string a un booleano que es un valor 0 o 1 , true o false

            Console.Write("¿El propulsor izquierdo está en buen estado? (true/false): ");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine()); //ToBoolean  es para convertir de un string a un booleano que es un valor 0 o 1 , true o false

            if (((((propulsorDerecho) && (propulsorIzquierdo)) == true) && (energia >= 75)) || ((((propulsorDerecho) || (propulsorIzquierdo)) == true) && (energia == 100)))
                //si se cuumple las dos condiciones  es tru y la energia es  mayor  es true o la condicion izquiera o derecha es true sera true y energia es 100 es true
                //si la toda la sentencia primera es verdadera o la segunda sentencia es verdadera entonces entra en el primer bloque si no va directo a else
            {
                Console.WriteLine("Puedes despegar");
            }
            else
            {
                Console.WriteLine("Lo siento, no es seguro despegar");
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador switch                                ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Instruccion switch*/

            // Se necesita un programa que realice las 4 operaciones básicas: suma, resta, multiplicación y división, a partir de dos números, la operación deseada será elegida por el usuario.

            // Variables
            decimal numSwitch1, numSwitch2, resultadoSwitch = 0.0M;
            byte opcionSwitch;

            // Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            // Pedimos al usuario que escoja una opción
            Console.Write("Escoge una opción: ");
            opcionSwitch = Convert.ToByte(Console.ReadLine()); // ToByte lo usamos para convertimos un string a byte  numero enteros

            // Pedimos el primer número
            Console.Write("Dame el primer número: ");
            numSwitch1 = Convert.ToDecimal(Console.ReadLine()); //ToDecimal lo usamos para convertir un string a decimal  numeros enteros con decimal

            // Pedimos el segundo número
            Console.Write("Dame el segundo número: ");
            numSwitch2 = Convert.ToDecimal(Console.ReadLine()); //ToDecimal lo usamos para convertir un string a decimal  numeros enteros con decimal

            switch (opcionSwitch)     //evaluamos la opcion elegida por el usuario
            {
                case 1:
                    resultadoSwitch = numSwitch1 + numSwitch2; //suma
                    break;
                case 2:
                    resultadoSwitch = numSwitch1 - numSwitch2; //resta
                    break;
                case 3:
                    resultadoSwitch = numSwitch1 * numSwitch2; //multiplicacion
                    break;
                case 4:
                    if (numSwitch2 != 0) // entra al primer bloque solo si el numero dos es diferente a 0 ya que algo dividido entre 0 da error
                    {
                        resultadoSwitch = numSwitch1 / numSwitch2; //divicion 
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre cero"); // 0 entre 0 es error damos el siguiente mensaje
                    }
                    break;
                default: //ninguna opcion valida por el usuario 
                    Console.WriteLine("Ingresa una opción valida"); //
                    break;
            }

            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultadoSwitch); //mostramos el resultado

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Operador constantes                            ****************************");
            Console.WriteLine("*******************************************************************************************************");
            /*Las constantes*/

            const int a = 10; //declaramos una constante a con un valor de a
            Console.WriteLine("la constante es = " + a);

            // a = 10;  // no podemos definir a con un nuevo valor devido a que  es una constante marcara un error
            //Console.WriteLine("la constante es = " + a);  // si imprimos de nuevo la variable solo mostrara 10 pero antes marca el error y no compilara el prgrama

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Tarea                            ****************************");
            Console.WriteLine("*******************************************************************************************************");

            //tarea del programa  seccion toma de decisiones

            int mes;

            Console.WriteLine("me puedes dar el numero del mes que quieres ");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break; 
                case 2:
                    Console.WriteLine("Febrero");
                    break; 
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break; 
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default : Console.WriteLine("No digitaste ningun numero de mes valido");
                    break;
            }

            //programa que determina si es par o impar
            long numeroParImpar;

            Console.Write("Dame un número y te diré si es par o impar: ");
            numeroParImpar = Convert.ToInt64(Console.ReadLine());

            if ((numeroParImpar % 2) == 0) // si al dividir no da residuo en este caso la division es exacta sera para ejemplo 4 / 2  es 2 no deja ningun residuo por lo tanto es par, si es impar ejemplo 3 / 2  es 1.5 deja como residuo .5 por lo cual no es igual a 0  y es impar
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }


            Console.ReadKey();
        }
    }
}

/*La palabra clave de tipo bool es un alias para el tipo de estructura de .NET System.Boolean que representa un valor booleano que puede ser true o false.*/

/*Las instrucciones if, if-else y switch seleccionan las instrucciones que se ejecutarán a partir de muchos trazados posibles en función del valor de una expresión. La instrucción if ejecuta una instrucción solo si una expresión booleana proporcionada se evalúa como true. La instrucción if-else permite elegir cuál de las dos rutas de acceso al código se deben seguir en función de una expresión booleana. La instrucción switch selecciona una lista de instrucciones para ejecutarla en función de la coincidencia de un patrón con una expresión*/

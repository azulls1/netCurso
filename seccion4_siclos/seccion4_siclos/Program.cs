using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


//programa que  mostrara el usuo de los siclos 
//for, while, do while
namespace seccion6_siclos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     For Condicional                                ****************************");
            Console.WriteLine("*******************************************************************************************************");
            int i;

            for (i = 1; i <= 10; i++) //se repitira el siclo mientras i incrementa  hasta ser 10 
            {
                Console.WriteLine(i); // se imprimira i hasta que sea 10 
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Asignacion Compuesta                            ****************************");
            Console.WriteLine("*******************************************************************************************************");

            //Asignacion Compuesta

            /********************************************************************
            *   asignacion compuesta | formato xop=y | equivalencia x=x op      *
            *********************************************************************
            *       +=               |    x+=y       |    x = x + y             *
            *********************************************************************
            *       -=               |    x-=y       |    x = x - y             *
            *********************************************************************
            *       *=               |    x*=y       |    x = x * y             *
            *********************************************************************
            *       /=               |    x/=y       |    x = x / y             *
            ********************************************************************/

            int x1 = 2;
            Console.WriteLine("variable sin modificacion " + x1);
            x1 += 5; // asignacion compuesta de suma
            Console.WriteLine("asignacion compuesta suma 'x1 += 5' = " + x1);
            x1 -= 5;// asignacion compuesta de resta
            Console.WriteLine("asignacion compuesta resta 'x1 -= 5' = " + x1);
            x1 *= 5;// asignacion cpmpuesta de multiplicacion
            Console.WriteLine("asignacion compuesta multiplicacion 'x1 *= 5' = " + x1);
            x1 /= 5;// asignacion cpmpuesta de divicion
            Console.WriteLine("asignacion compuesta divicion 'x1 /= 5' = " + x1);


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     For Iterador                                   ****************************");
            Console.WriteLine("*******************************************************************************************************");

            int i1;

            for (i1 = 1;i1 <= 30; i1+= 2, Console.WriteLine("valor de salida {0},",i1))
            {
                Console.WriteLine(i1);
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     For Contador                                   ****************************");
            Console.WriteLine("*******************************************************************************************************");

            int i2;
            int contador = 0;
            for (i2 = 1; i2 <= 10; i2 += 2)
            {
                contador += 1;
                Console.WriteLine("{0}, vuelta del ciclo numero {1} ",i2,contador);
            }
            Console.WriteLine( "numero de vueltas que dio el ciclo fue {0} ", contador );

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************     Acumulador                                     ****************************");
            Console.WriteLine("*******************************************************************************************************");

            int i3;
            int acumulador = 0;
            int precio;

            for (i3 = 1; i3 <=5 ; i3++) 
            {
                Console.Write(" Me puedes dar el precio del producto {0} : $", i3);
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador += precio; // esto es igual a decir acumulador = acumalodr + precio;
                
            }
            Console.WriteLine("el total es : $" + acumulador);

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************    Primer : Ejercicio con la intruccion for        ****************************");
            Console.WriteLine("*******************************************************************************************************");

            //ejercicio con intruccion for para sacar el promedio de las calificaciones

            int i4, numAlumnos;
            double calificacion, sumaCalificacion = 0, promedio;


            Console.WriteLine("Cautnos alumnos a calificar son : ");
            numAlumnos = Convert.ToInt32(Console.ReadLine());
            
            for (i4 = 1; i4 <= numAlumnos; i4++)
            {
                Console.WriteLine("me puedes dar la calificacion del alumno {0} ", i4);
                calificacion = Convert.ToDouble(Console.ReadLine());
                sumaCalificacion += calificacion;
            }
            Console.WriteLine("la suma de las calificaciones es  :" + sumaCalificacion);
            promedio = sumaCalificacion / numAlumnos;
            Console.WriteLine("el promedio de las calificaciones es : "+ promedio);


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************    Segundo : Ejercicio con la intruccion for       ****************************");
            Console.WriteLine("*******************************************************************************************************");

            //factorial de  un numero 

            int i5, factorial = 1, numero;


            Console.Write("me puedes dar el numero que deseas obtener el factorial : ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i5 = numero; i5 >= 1; i5--)
            {
                Console.WriteLine("seguimiento del factorial {0}, {1} * {2}", i5, i5, factorial);
                factorial *= i5; // factorial = factorial * i5      (recordemos que factorial vale 1  al inicio por lo cual  es 1 * 3 = 3 , segunda iteracion  factorial vale 3 * 2 = 6 , tercera iteracion  factorial vale 6 * 1 =  6 total del factorial es 6)
            }
            Console.Write(" El factorial de {0}, es {1}",numero, factorial);

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************    Instruccion While                               ****************************");
            Console.WriteLine("*******************************************************************************************************");
            //  while significa mientras

            int numero2 = 1;

            while (numero <= 10)
            {
                Console.Write(numero2);
                numero2++;  
            }


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************    Instruccion While para comparar contraseñas     ****************************");
            Console.WriteLine("*******************************************************************************************************");

            string contraseña1, contraseña2 = "" ;

            Console.Write("me puedes dar tu contraseña ");
            contraseña1 = Console.ReadLine();
            Console.Write("me puedes repetir tu contraseña " );
            contraseña2 = Console.ReadLine();

            while (contraseña1 != contraseña2) //si la contraseña no es igual entrara al bucle pero si es igual saldra de el 
            {
                Console.WriteLine("confirma tu contraseña ");
                contraseña2 = Console.ReadLine() ;
            }
            
            Console.Write("vienvenido al sistema");


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************    Instruccion Do                                  ****************************");
            Console.WriteLine("*******************************************************************************************************");
            //do se ejecutara por lo menos una vez en el programa y todas las veces que sea necesaria pero si o si almenos sera una vez ejecutada
            //do siempre deve ir acompañada de while

            int i6 = 15;

            do
            {
                Console.Write(i6);
                i6++;
            } while (i6 <= 10);//while (condicion);

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************    Ejercicio con Do                                ****************************");
            Console.WriteLine("*******************************************************************************************************");

            int numeroDo1, numeroDo2, resultadoDo =0, opcionDo;

            do
            {
                Console.WriteLine("1 suma");
                Console.WriteLine("2 suma");
                Console.WriteLine("3 suma");
                Console.WriteLine("4 suma");
                Console.WriteLine("escoge una opcion");
                opcionDo = Convert.ToInt32(Console.ReadLine());
            } while ((opcionDo < 4 || opcionDo > 4)); // se seguira ejecutando mientras sea verdadero hasta que sea falsa la condicion dejara de entrar en el bucle

            Console.WriteLine("dame el primer numero ");
            numeroDo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame el segundo numero ");
            numeroDo2 = Convert.ToInt32(Console.ReadLine());

            switch (opcionDo)
            {
                case 1:
                    resultadoDo = numeroDo1 + numeroDo1;
                    break;
                case 2:
                    resultadoDo = numeroDo1 - numeroDo1;
                    break;
                case 3:
                    resultadoDo = numeroDo1 * numeroDo1;
                    break;
                case 4:
                    if (numeroDo2 != 0) 
                    {
                       resultadoDo= numeroDo1 / numeroDo2;
                     }else
                    {
                        Console.WriteLine(" el numero no se puede dividir");
                        Console.WriteLine("dame un nuevo numero ");
                        numeroDo2= Convert.ToInt32(Console.ReadLine());
                        if (numeroDo2 != 0)
                        {
                            resultadoDo = numeroDo1 / numeroDo2;
                        }
                    }
                    break;

            }
            Console.WriteLine("el resultado es {0} ", resultadoDo);


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("***********************   Iteraciones anidadas  for                        ****************************");
            Console.WriteLine("*******************************************************************************************************");
            //programa que realiza todas las tablas de multiplicar
            int i8, j8, resultado8;

            for (i8 = 1; i8 <= 10; i8++)
            {
                Console.WriteLine(" tabla del {0}", i8);
                for (j8 = 1; j8 <= 10; j8++)
                {
                    resultado8 = i8 * j8;
                    Console.WriteLine(" {0} * {1} = {2}", i8, j8, resultado8);
                }
            }

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("******   Tarea 4.0   calcule la potencia, ya sea negativa o positiva de cualquier exponente    ********");
            Console.WriteLine("*******************************************************************************************************");

            //Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.
            int numero10, exponente10, i10;
            double resultado10 = 1, resultadoNegativo10;

            Console.WriteLine("ingresa el numero que deseas ");
            numero10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa el exponente ");
            exponente10 = Convert.ToInt32(Console.ReadLine());

            if (exponente10 < 0) //si el exponente es negatico, entonces
            {
                exponente10 *= -1;//// exponente = exponente * -1  ---> convierte el exponente a positivo
                for (i10 = 1; i10 <= exponente10; i10++)// Iteración desde 1 hasta llegar al exponente
                {
                    resultado10 *= numero10;
                    // Dividimos  1 entre el resultado y se lo asignamos a una nueva variable
                    resultadoNegativo10 = (1 / resultado10);

                    //Mostramos el resultado
                    Console.WriteLine("{0}^-{1} = {2}", numero10, exponente10, resultadoNegativo10);
                }
            }
            else// Si el exponente no es menor que cero, por lo tanto es mayor o igual
            {
                for (i10 = 1; i10 <= exponente10; i10++)
                {
                    resultado10 *= numero10;
                }

                //Mostramos el resultado
                Console.WriteLine("{0}^{1} = {2}", numero10, exponente10, resultado10);


            }


            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("******   Tarea 4.1   calcule la potencia, ya sea negativa o positiva de cualquier exponente    ********");
            Console.WriteLine("******************************************************************************************************");

            //Variables
            int numero11, divisor11, numDivisores11 = 0;

            //Bucle exterior, se encarga de recorrer los números del 2 al 100
            for (numero11 = 2; numero11 <= 100; numero11++)
            {
                //Bucle anidado, se encarga de verificar el número de divisores
                for (divisor11 = 1; divisor11 <= numero11; divisor11++)
                {
                    if (numero11 % divisor11 == 0)
                    {
                        numDivisores11 += 1; //numDivisores = numDivisores + 1;
                    }
                }

                //Verificamos que el número de divisiores sea igual a 2
                if (numDivisores11 <= 2)
                {
                    Console.WriteLine(numero11);
                }

                //Reiniciamos el conteo del número de divisores
                numDivisores11 = 0;
            }

            Console.ReadKey();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//programa que  mostrara el usuo de los siclos 
//for, while, do while
namespace seccion6_siclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int i;

            for (i = 1; i <= 10; i++) //se repitira el siclo mientras i incrementa  hasta ser 10 
            {
                Console.WriteLine(i); // se imprimira i hasta que sea 10 
            }
            /*********************************************************************
             *   asignacion compuesta | formato xop=y | equivalencia x=x op      *
             *********************************************************************
             *       +=               |    x+=y       |    x = x + y             *
             *********************************************************************
             *       -=               |    x-=y       |    x = x - y             *
             *********************************************************************
             *       *=               |    x*=y       |    x = x * y             *
             *********************************************************************
             *       /=               |    x/=y       |    x = x / y             *
             **********************************************************************/

        }
    }
}

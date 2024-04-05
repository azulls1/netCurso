using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace seccion6._3_Matrices_multidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forma de declarar una matriz multimidimencional
            //Tipo [,] nombre = new tipo [filas,columnas]
            //Nota si  solo se tiene una coma  al inicio es de dos dimenciones si agregamos otra se convierte en tres dimenciones y asi susesivamente dependiendo la cantidad de dimenciones que queremos para nuestra matriz *******tipo[,]**********
            
            //delcaracion e instnacia de una matriz bidimencional y su inicializacion usando {}
            
            double[,] ventas = new double[4, 3] { {100,110,120},{200,210,220},{300,310,320},{400,410,420} };//usamos 4 corechetres con 3 elementos por que so 4 filas y 3 columas  entonces al declararlo asi  es como su usaramos la matriz en la siguiente manera

            /*
             *               clo1   col2    col3            ID de la matriz bidimencional
                           -----------------------          ------------------------ 
              Fila1        | 100  | 110   | 120  |          | 0,0   | 0,1   | 0,2  |
                           -----------------------          ------------------------ 
              Fila2        | 200  | 210   | 220  |          | 1,0   | 1,1   | 1,2  |
                           -----------------------          ------------------------ 
              Fila3        | 300  | 310   | 320  |          | 2,0   | 2,1   | 2,2  |
                           -----------------------          ------------------------ 
              Fila4        | 400  | 410   | 420  |          | 3,0   | 3,1   | 3,2  |
                           -----------------------          ------------------------ 
             */





            //delcaracion e instancia de una matriz tridimencional
            
            //double[,,] ventasAño = new double[5, 3, 3];

            //delcaracion e instancia de una matriz tridimencional e inicializacion usando {}
            int[,,] matriz3D = new int[2, 2, 3] {   { {1,2,3 },{4,5,6 } },  
                                                    { {7,8,9 },{10,11,12 } }  };

            /*                 Porfundidad 1            Profundidad 2               Profundidad 3
             *               clo1   col2                col1   col2                 col1   col2           
                           ----------------          -----------------           -----------------
              Fila1        | 1    | 4     |          | 2     | 5     |           | 3    |   6   |
                           ----------------          -----------------            ----------------
              Fila2        |  7   | 10    |          |  8   |  11    |           |  9   | 12    |
                           ----------------          -----------------           ----------------- 
             */









            // imprimimos nuestra matriz

            //forma de recorrer una matriz columa y todas sus filas



        }
    }
}

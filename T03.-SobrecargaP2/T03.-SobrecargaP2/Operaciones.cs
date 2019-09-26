using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03._SobrecargaP2
{
    class Operaciones
    {
        
            //Hacemos los metodos de la multiplicacion 
            //Un metodo con 2 parametros
            public double Multiplicar(double a, double b)
            {
                return a * b;
            }
            //Un metodo con solo 1 parametro 
            public double Multiplicar(double a)
            {

                return a * 3;
            }
            //Un metodo sin ningun parametro
            public double Multiplicar()
            {
                return 5 * 4;
            }

        
    }
}

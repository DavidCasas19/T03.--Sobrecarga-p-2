using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03._SobrecargaP2
{
    class Datos
    {
        //Hacemos una clase para que el usuario ingrese los datos que necesite
        public void ObtenerDatos()
        {

            Operaciones op = new Operaciones();
            Console.WriteLine("Hola bienvenido");

            Console.WriteLine("Ingrese 2 datos por favor");
            Console.WriteLine("    ");
            Console.WriteLine("Dato 1:");
            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dato 2:");
            double cool2 = Convert.ToDouble(Console.ReadLine());

            double res = op.Multiplicar(cool, cool2);
            Console.WriteLine("El resultado es" + "  " + res);

        }
    }
}

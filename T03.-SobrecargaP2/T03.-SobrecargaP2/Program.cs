using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03._SobrecargaP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciamos los datos y mandamos a llamar al metodo
            Datos d = new Datos();
            d.ObtenerDatos();
            Console.ReadKey();

            //Instanciamos la clase operaciones
            Operaciones op = new Operaciones();

            //mandamos a llamar al metodo 
            op.Multiplicar();

            Console.WriteLine("    ");
            //Le ponemos valores a los parametros
            double res1 = op.Multiplicar(2, 3);
            Console.WriteLine("La respuesta es" + "  " + res1);

            double res2 = op.Multiplicar(5);
            Console.WriteLine("La respuesta es" + "  " + res2);

            double res3 = op.Multiplicar();
            Console.WriteLine("La respuesta es" + "  " + res3);

            Console.ReadKey();
        }
    }
}

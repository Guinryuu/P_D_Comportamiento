using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState
{
    class Program
    {
        static void Main(string[] args)
        {


            Vehiculo v = new Vehiculo(20);

            v.Acelerar();
            v.Contacto();
            v.Acelerar();
            v.Acelerar();
            v.Acelerar();
            v.Frenar();
            v.Frenar();
            v.Frenar();
            v.Frenar();

            //Pausa la ejecución para visualizar resultados
            Console.Read();


        }
    }
}

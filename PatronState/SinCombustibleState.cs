using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState
{
    public class SinCombustibleState : State
    {

        // Referencia a la clase de contexto
        private Vehiculo v;

        // Constructor que inyecta la dependencia en la clase actual
        public SinCombustibleState(Vehiculo v)
        {
            this.v = v;
        }

        public void Acelerar()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

        public void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

        public void Contacto()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

    }
}

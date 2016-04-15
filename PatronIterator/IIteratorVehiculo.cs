using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    public interface IIteratorVehiculo
    {

        void Primero();
        Vehiculo Actual();
        Vehiculo Siguiente();
        bool QuedanElementos();

    }
}

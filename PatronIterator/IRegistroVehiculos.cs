using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    public interface IRegistroVehiculos
    {

        void InsertarVehiculo(string marca, string modelo, double precio);
        Vehiculo MostrarInformacionVehiculo(int indice);



        IIteratorVehiculo ObtenerIterator();

    }
}

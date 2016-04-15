using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public interface ISubject
    {

        // Interfaz que expone los metodos de registro y eliminacion de observers, asi como para
        // la notificacion de los cambios de estado.
        void RegistrarObserver(IObserver o);
        void EliminarObserver(IObserver o);
        void NotificarObservers();

    }
}

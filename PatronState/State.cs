using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState
{
    public interface State
    {

        void Acelerar();
        void Frenar();
        void Contacto();

    }
}

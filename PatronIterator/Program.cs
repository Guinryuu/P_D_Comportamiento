using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaramos el registro
            IRegistroVehiculos registro = new RegistroVehiculos();

            // Insertamos unos cuantos elementos
            registro.InsertarVehiculo("Toyota", "Polo", 12300);
            registro.InsertarVehiculo("Toyota", "Golf GTI", 18900);
            registro.InsertarVehiculo("Nissan", "Passat", 27000);
            registro.InsertarVehiculo("Nissan", "Scirocco", 32100);
            registro.InsertarVehiculo("Ferrari", "Touareg", 218000);

            // Obtenemos el iterator
            IIteratorVehiculo iterador = registro.ObtenerIterator();

            // Mientras queden elementos
            while (iterador.QuedanElementos())
            {
                // Obtenemos el siguiente elemento
                Vehiculo v = iterador.Siguiente();

                // Mostramos su contenido
                Console.WriteLine(v.Marca + " " + v.Modelo + " fabricado el " + v.FechaFabricacion.ToShortDateString() + " (" + v.Precio + " Soles)");
            }

            //Pausa la ejecución para visualizar resultados
            Console.Read();

        }
    }
}

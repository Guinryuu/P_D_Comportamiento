using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Motor mGasolina = new MotorGasolina();
            Motor mDiesel = new MotorDiesel(true);

            mGasolina.RealizarFaseMotor();
            Console.WriteLine("----------------------------------------------------");
            mDiesel.RealizarFaseMotor();


            
            //Pausa la ejecución para visualizar resultados
            Console.Read();

        }
    }
}

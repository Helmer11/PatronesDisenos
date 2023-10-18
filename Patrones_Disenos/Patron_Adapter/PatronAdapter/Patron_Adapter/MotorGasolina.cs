using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter
{
    internal class MotorGasolina : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor Gasolina...");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Acelerando el motor Gasolina...");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Acelerando el motor Gasolina...");
        }

        public override void Detener()
        {
            Console.WriteLine("Acelerando el motor Gasolina...");
        }
    }
}

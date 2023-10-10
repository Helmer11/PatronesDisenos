using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Mathod
{
    internal abstract class Pizzeria
    {
        public abstract Pizza CrearPizza(string tipo);
    }
}

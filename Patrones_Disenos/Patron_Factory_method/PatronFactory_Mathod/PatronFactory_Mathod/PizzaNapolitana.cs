using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Mathod
{
    internal class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string origen) 
        {
            _descripcion = "Pizza napolitana!";
            _origen = origen;
        }
    }
}

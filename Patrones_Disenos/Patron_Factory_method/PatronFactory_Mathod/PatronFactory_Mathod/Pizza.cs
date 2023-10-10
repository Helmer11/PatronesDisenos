﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Mathod
{
    internal abstract class Pizza
    {
        protected string _descripcion;
        protected string _origen;

        public void Render()
        {
            Console.WriteLine(string.Format("Pizza de {0} hecha en {1}", _descripcion, _origen));
        }

    }
}

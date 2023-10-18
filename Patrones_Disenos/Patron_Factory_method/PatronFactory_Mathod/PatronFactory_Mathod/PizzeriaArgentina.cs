﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Mathod
{
    internal class PizzeriaArgentina : Pizzeria
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "cancha")
            {
                return new PizzaCancha("Italia");
            }
            else if (tipo == "napo")
            {
                return new PizzaNapolitana("Italia");
            }
            else
            {
                return null;
            }
        }
    }
}

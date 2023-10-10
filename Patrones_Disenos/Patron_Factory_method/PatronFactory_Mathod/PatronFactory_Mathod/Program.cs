// See https://aka.ms/new-console-template for more information
using PatronFactory_Mathod;

Pizzeria pizzeria;
Pizza pizza;

pizzeria = new PizzeriaArgentina();

pizza = pizzeria.CrearPizza("napo");
pizza.Render();
pizza = pizzeria.CrearPizza("cancha");
pizza.Render();

pizzeria = new PizzeriaItaliana();
pizza = pizzeria.CrearPizza("napo");
pizza.Render();
pizza = pizzeria.CrearPizza("cancha");
pizza.Render();
Console.ReadKey();

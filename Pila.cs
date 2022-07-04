using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace EjemploPila
{

public class Pila
{
    public static void Main(string[] args) {
                string palabra;

            Stack miPila = new Stack();
                miPila.Push("Hola");
                miPila.Push("Buenos");
                miPila.Push("dias");

                for (byte i =0; i < 3; i++)
                    {
                    palabra  = (string) miPila.Pop();
                    Console.WriteLine(palabra);
                }
    }

}


}

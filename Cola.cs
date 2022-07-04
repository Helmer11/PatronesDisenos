using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EjemploCola {

public class Cola {

static void Main(string[] args){

string palabra;

        Queue cola = new Queue();
        cola.Enqueue("Hola ");
        cola.Enqueue("buenos ");
        cola.Enqueue("dias.");

      for (byte i =0; i < 3;i++) {
            palabra = (string) cola.Dequeue();
            Console.WriteLine(palabra);
            }
            Console.ReadKey();

}

}


}

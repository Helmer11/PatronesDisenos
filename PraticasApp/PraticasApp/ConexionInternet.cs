using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticasApp
{
    internal class ConexionInternet
    {

        static void Main(string[] args)
        {

            bool RedActiva = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (RedActiva)
                Console.WriteLine("Se estableció conexión con la red local");
            else
                Console.WriteLine("No está conectado a la red");
			Console.Readkey();
        }
		
    }
}

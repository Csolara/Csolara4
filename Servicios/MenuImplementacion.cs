using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara4.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del menu principal de la aplicación.
    /// csl - 300424
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int MENU()
        {
            int opcionseleccionada;

            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Cerrar menu.");
            Console.WriteLine("1. Registro de llegada.");
            Console.WriteLine("2. Listado consultas.");
            Console.WriteLine("-----------------------");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }

        public int ListadoConsultas()
        {
            int opcionseleccionada;

            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Cerrar menu.");
            Console.WriteLine("1. Mostrar consultas.");
            Console.WriteLine("2. Imprimir consultas.");
            Console.WriteLine("-----------------------");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }

        public int MostrarConsultas()
        {
            int opcionseleccionada;

            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Psicología.");
            Console.WriteLine("1. Traumatología.");
            Console.WriteLine("2. Fisioterapia.");
            Console.WriteLine("-----------------------");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }
    }
}

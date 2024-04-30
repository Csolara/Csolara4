using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara4.Servicios
{
    /// <summary>
    /// Interfaz que contiene todos los menus de la aplicación.
    /// csl - 300424
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Menu principal de la aplicacion.
        /// csl - 300424
        /// </summary>
        /// <returns></returns>
        public int MENU();
        /// <summary>
        /// Menu que muestra las consultas del centro medico.
        /// csl - 300424
        /// </summary>
        /// <returns></returns>
        public int MostrarConsultas();

        /// <summary>
        /// Menu que muestra los tipos de consultas y la informacion de los pacientes.
        /// csl - 300424
        /// </summary>
        /// <returns></returns>
        public int ListadoConsultas();

    }
}

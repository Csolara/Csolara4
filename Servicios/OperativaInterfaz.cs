using Csolara4.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara4.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos de la operativa.
    /// csl - 300424
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que registra el dni introducido por el usuario y responde por consola si dispone cita para hoy o no.
        /// csl - 300424
        /// </summary>
        /// <param name="paciente"></param>
        public void RegistroLlegada(List<PacienteDto> paciente);

        /// <summary>
        /// Método que muestra la cita segun la fecha indicada.
        /// csl - 300424
        /// </summary>
        public void Fisioterapia();

        /// <summary>
        /// Método que muestra la cita segun la fecha indicada.
        /// csl - 300424
        /// </summary>
        public void Psicologia();

        /// <summary>
        /// Método que muestra la cita segun la fecha indicada.
        /// csl - 300424
        /// </summary>
        public void Traumatologia();

    }
}

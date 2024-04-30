using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara4.Dtos
{
    internal class PacienteDto
    {

        string Nombre = "aaaaa";
        string Apellidos = "bbbbb";
        string DNI = "123456789Z";
        string especialida = "ccccc";
        DateTime fechaDeCita = new DateTime();
        Boolean AsistenciaCita = false;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string Especialida { get => especialida; set => especialida = value; }
        public DateTime FechaDeCita { get => fechaDeCita; set => fechaDeCita = value; }
        public bool AsistenciaCita1 { get => AsistenciaCita; set => AsistenciaCita = value; }

        public PacienteDto(string nombre, string apellidos, string dNI, string especialida, DateTime fechaDeCita, bool asistenciaCita)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dNI;
            this.especialida = especialida;
            this.fechaDeCita = fechaDeCita;
            AsistenciaCita = asistenciaCita;
        }

        public PacienteDto()
        {
        }
    }
}

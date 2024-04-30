using Csolara4.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara4.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de la operativa.
    /// csl - 300424
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        public void RegistroLlegada(List<PacienteDto> paciente)
        {
            bool valido = false;

            Console.WriteLine("Introduce su dni (numeros): ");
            int numeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la letra de su dni: ");
            char letra = Convert.ToChar(Console.ReadLine());

            string dniCompleto = numeros.ToString() + letra;

            valido = DNI(numeros, letra);

            foreach (var Paciente in paciente)
            {
                if (Paciente.DNI1.Equals(dniCompleto) != null && Paciente.FechaDeCita.Equals(paciente))
                {
                    Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                }
                else
                {
                    Console.WriteLine("No dispone de cita previa para hoy.");
                }
            }
        }

        private bool DNI(int numeros, char letras)
        {
            char[] letra = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            bool valido = false;

            double calcularDNI = numeros / 23;           

            calcularDNI = Math.Abs(calcularDNI);

            return valido;
        }        

        public void Fisioterapia()
        {
            PacienteDto paciente = new PacienteDto();

            Console.WriteLine("Elija una fecha (dd-MM-yyyy): ");
            DateTime fecha  = Convert.ToDateTime(Console.ReadLine());

            if (fecha == paciente.FechaDeCita)
            {
                Console.WriteLine("Nombre completo: " + paciente.Nombre1 + " " + paciente.Apellidos1 + ", Hora: " + paciente.FechaDeCita);
            }
            else
            {
                Console.WriteLine("La fecha introducida no coincide con ninguna."); 
            }
        }

        public void Psicologia()
        {

            PacienteDto paciente = new PacienteDto();

            Console.WriteLine("Elija una fecha (dd-MM-yyyy): ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            if (fecha == paciente.FechaDeCita)
            {
                Console.WriteLine("Nombre completo: " + paciente.Nombre1 + " " + paciente.Apellidos1 + ", Hora: " + paciente.FechaDeCita);
            }
            else
            {
                Console.WriteLine("La fecha introducida no coincide con ninguna.");
            }
        }

        public void Traumatologia()
        {
            PacienteDto paciente = new PacienteDto();

            Console.WriteLine("Elija una fecha (dd-MM-yyyy): ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            if (fecha == paciente.FechaDeCita)
            {
                Console.WriteLine("Nombre completo: " + paciente.Nombre1 + " " + paciente.Apellidos1 + ", Hora: " + paciente.FechaDeCita);
            }
            else
            {
                Console.WriteLine("La fecha introducida no coincide con ninguna.");
            }
        }
    }
}

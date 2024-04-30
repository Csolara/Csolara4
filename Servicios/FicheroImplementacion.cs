using Csolara4.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara4.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del fichero.
    /// csl - 300424
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {        
        public void CargaInicial()
        {
            string fichero = "C:\\Users\\Profesor\\Desktop\\citas.txt.txt";

            string[] LineaFichero = File.ReadAllLines(fichero);

            PacienteDto paciente = new PacienteDto();            

            try
            {

                for (int i = 0; i < LineaFichero[i].Length; i++)
                {
                    string[] Separacion = LineaFichero[i].Split(";");

                    Console.WriteLine(Separacion[0]);

                    Console.WriteLine(Separacion[1]);

                    Console.WriteLine(Separacion[2]);

                    Console.WriteLine(Separacion[3]);

                    Console.WriteLine(Separacion[4]);

                    Console.WriteLine(Separacion[5]);
                }

            }
            catch(Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}

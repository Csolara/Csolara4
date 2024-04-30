using Csolara4.Dtos;
using Csolara4.Servicios;
using System.Collections.Generic;
using System.Net;

namespace Csolara4.Controladores
{/// <summary>
/// Clase principal de la apliación.
/// csl - 300424
/// </summary>
    class program
    {
        /// <summary>
        /// Metodo principal de la aplicación.
        /// csl - 300424
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {            
            List<PacienteDto> pacienteDtos = new List<PacienteDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                int recogido = mi.MENU();
                switch (recogido)
                {
                    case 0:
                        Console.WriteLine("La aplicación se cerrara.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        //Registro de llegada
                        oi.RegistroLlegada(pacienteDtos);
                        break;                                                
                    case 2:
                        //Listado consultas
                        int recogido2 = mi.ListadoConsultas();
                        switch (recogido2)
                        {
                            case 0:
                                mi.MENU();
                                break;
                            case 1:
                                //Mostrar consultas
                                int recogido3 = mi.MostrarConsultas();
                                switch(recogido3)
                                {
                                    case 0:
                                        //Psicología
                                        oi.Psicologia();
                                        break;
                                    case 1:
                                        //Traumatología
                                        oi.Traumatologia();
                                        break;
                                    case 2:
                                        //Fisioterapia
                                        oi.Fisioterapia();
                                        break;
                                    default:
                                        Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna.");
                                        break;
                                }
                                break;
                            case 2:
                                //Imprimir consultas
                                fi.CargaInicial();
                                break;
                            default:
                                Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna.");
                        break;
                }
            }

        }
    }
}
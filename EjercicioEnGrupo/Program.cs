using System;
using System.Collections.Generic;
using EjercicioEnGrupo;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Perritos> PerresList = new List<Perritos>();
            Perritos newPerro = new Perritos("");

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("         HOTEL DE PERROS ");
                    Console.ResetColor();
                    Console.WriteLine("----------------------------------\n");
                    Console.WriteLine("1. Agregar Perros");
                    Console.WriteLine("2. Mostrar Perros");
                    Console.WriteLine("3. Buscar Perros");
                    Console.WriteLine("4. Eliminar Perros");
                    Console.WriteLine("5. Cambiar Nombre");
                    Console.WriteLine("6. Salir");
                    Console.Write("Choose an option: ");
                    int option1 = Convert.ToInt32(Console.ReadLine());

                    switch (option1)
                    {
                        case 1:
                            {
                                newPerro = newPerro.AgregarPerre();
                                PerresList.Add(newPerro);
                                break;
                            }
                        case 2:
                            {
                                foreach (var perrito in PerresList)
                                {
                                    perrito.MostrarPerro();
                                }
                                break;
                            }
                        case 3:
                            {
                                newPerro.BuscarPerro(PerresList);
                                break;
                            }
                        case 4:
                            {
                                newPerro.DevolverPerro(PerresList);
                                break;
                            }
                        case 5:
                            {
                                newPerro.CambiarNombre(PerresList);
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Ciao User...");
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                            }
                    }Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se produjo un error: {ex.Message}");
                }
            }
        }
    }
}

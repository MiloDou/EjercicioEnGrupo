using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EjercicioEnGrupo
{
    public class Perritos
    {
        public Perritos(string nombre)
        {
            this.nombre = nombre;
        }

        public string nombre { get; set; }

        public void MostrarPerro()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         MOSTAR PERROS");
            Console.ResetColor();
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine(nombre);
        }

        public Perritos AgregarPerre()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         AGREGAR PERRO ");
            Console.ResetColor();
            Console.WriteLine("----------------------------------\n");
            Console.Write("Ingresa nombre del perre: ");
            string perreName = Console.ReadLine();
            Console.WriteLine("Perre agregade correctamente");
            Perritos perre = new Perritos(perreName);
            return perre;
        }

        public void DevolverPerro(List<Perritos> perritosList)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         DEVOLVER PERRO ");
            Console.ResetColor();
            Console.WriteLine("----------------------------------\n");
            Perritos perritoEliminar = new Perritos(""); 
            perritoEliminar = BuscarPerro(perritosList);
            if (perritoEliminar == null) { return; }
            perritosList.Remove(perritoEliminar);
            Console.WriteLine("Enviamos a su perrito a una granja en el cielo correctamente");
            Console.ReadLine();
        }

        public Perritos BuscarPerro(List<Perritos> perritosList)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         BUSCAR PERRO ");
            Console.ResetColor();
            Console.WriteLine("----------------------------------\n");
            Console.Write("Ingresa el nombre del perro: ");
            string perreName = Console.ReadLine();
            foreach (Perritos p in perritosList)
            {
                if (perreName == p.nombre)
                {
                    Console.WriteLine("Se encontro su perro: " + perreName);
                    return p;
                }
            }
            Console.WriteLine("Ese perro no existe");
            Console.ReadLine();

            return null;
        }

        public void CambiarNombre(List<Perritos> perritosList)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         CAMBIAR NOMBRE ");
            Console.ResetColor();
            Console.WriteLine("----------------------------------\n");
            Perritos perritoModificar = BuscarPerro(perritosList);
            if (perritoModificar == null) { return; }
            Console.WriteLine("Ingrese el nuevo nombre: ");
            perritoModificar.nombre = Console.ReadLine();
            Console.WriteLine("Nombre cambiado correctamente");
        }
    }
}

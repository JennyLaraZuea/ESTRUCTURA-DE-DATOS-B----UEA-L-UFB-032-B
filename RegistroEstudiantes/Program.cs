using System;

namespace RegistroEstudiantes
{
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string[] telefonos = new string[3];

            Console.WriteLine("Ingrese los datos del estudiante:");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nombres: ");
            string nombres = Console.ReadLine();

            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);

            Console.WriteLine("\nDatos ingresados del estudiante:");
            estudiante.MostrarInformacion();
        }
    }
}

using System;

class Estudiante
{
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos = new string[3];

    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        this.id = id;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.direccion = direccion;
        this.telefonos = telefonos;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nombres: {nombres}");
        Console.WriteLine($"Apellidos: {apellidos}");
        Console.WriteLine($"Dirección: {direccion}");
        for (int i = 0; i < telefonos.Length; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {telefonos[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los datos del estudiante:");

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nombres: ");
        string nombres = Console.ReadLine();

        Console.Write("Apellidos: ");
        string apellidos = Console.ReadLine();

        Console.Write("Dirección: ");
        string direccion = Console.ReadLine();

        string[] telefonos = new string[3];
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

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de área de un círculo:");
        Console.Write("Ingrese el radio: ");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.PI * radio * radio;
        Console.WriteLine($"El área es: {area}");
    }
}


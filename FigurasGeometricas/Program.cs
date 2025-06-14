using System;

namespace FigurasGeometricas
{
    class Circulo
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    class Cuadrado
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return lado * lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    class Program
    {
        static void Main()
        {
            Circulo c = new Circulo(5);
            Console.WriteLine("Círculo: Área = " + c.CalcularArea() + ", Perímetro = " + c.CalcularPerimetro());

            Cuadrado cu = new Cuadrado(4);
            Console.WriteLine("Cuadrado: Área = " + cu.CalcularArea() + ", Perímetro = " + cu.CalcularPerimetro());
        }
    }
}

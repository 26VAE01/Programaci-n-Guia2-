using System;

class Ejercicio1
{
    static void Main()
    {
        int opcion;

        Console.WriteLine("CALCULADORA TRIGONOMETRICA");
        Console.WriteLine("1. Seno");
        Console.WriteLine("2. Coseno");
        Console.WriteLine("3. Tangente");
        Console.Write("Seleccione: ");
        opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese angulo en grados: ");
        double angulo = double.Parse(Console.ReadLine());

        double rad = angulo * Math.PI / 180;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(rad));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(rad));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(rad));
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
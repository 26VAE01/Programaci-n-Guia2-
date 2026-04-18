using System;

class Ejercicio4
{
    static void Main()
    {
        int opcion;
        double valor;

        Console.WriteLine("CONVERSOR");
        Console.WriteLine("1. Metros");
        Console.WriteLine("2. Pies");
        Console.WriteLine("3. Centimetros");
        Console.WriteLine("4. Pulgadas");
        Console.Write("Seleccione: ");
        opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese valor: ");
        valor = double.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("En pies: " + (valor * 3.28084));
                break;
            case 2:
                Console.WriteLine("En metros: " + (valor * 0.3048));
                break;
            case 3:
                Console.WriteLine("En metros: " + (valor / 100));
                break;
            case 4:
                Console.WriteLine("En metros: " + (valor * 0.0254));
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
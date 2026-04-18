using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        int opcion;

        Console.WriteLine("Ingrese el primer numero:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;

            case 2:
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;

            case 3:
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;

            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Resultado: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre 0");
                }
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

        Console.ReadKey();
    }
}
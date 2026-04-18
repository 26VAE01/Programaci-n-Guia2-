using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine("*********");
        Console.WriteLine("MENU DE COMIDA");
        Console.WriteLine("*********");
        Console.WriteLine("1. Hamburguesa");
        Console.WriteLine("2. Pizza");
        Console.WriteLine("3. Pollo frito");
        Console.WriteLine("4. Ensalada");

        Console.Write("Seleccione una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Pedido: Hamburguesa");
                break;

            case 2:
                Console.WriteLine("Pedido: Pizza");
                break;

            case 3:
                Console.WriteLine("Pedido: Pollo frito");
                break;

            case 4:
                Console.WriteLine("Pedido: Ensalada");
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

        Console.ReadKey();
    }
}
using System;

class Ejercicio3
{
    static void Main()
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("SECTORES:");
        Console.WriteLine("1. Palco (Q300)");
        Console.WriteLine("2. Tribuna (Q100)");
        Console.WriteLine("3. Preferencia (Q50)");
        Console.WriteLine("4. General (Q30)");
        Console.Write("Seleccione sector: ");
        sector = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de entradas: ");
        cantidad = int.Parse(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;
            case 2:
                precio = 100;
                break;
            case 3:
                precio = 50;
                break;
            case 4:
                precio = 30;
                break;
            default:
                Console.WriteLine("Sector invalido");
                return;
        }

        total = precio * cantidad;
        Console.WriteLine("Total a pagar: Q" + total);
    }
}
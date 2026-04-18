using System;

class Ejercicio5
{
    static void Main()
    {
        int cantidad, pago;
        double precioUnit = 650 * 1.12;
        double total, descuento = 0, totalFinal;

        Console.Write("Cantidad de impresoras: ");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta (5%)");
        Console.WriteLine("3. Vale (15%)");
        Console.Write("Seleccione: ");
        pago = int.Parse(Console.ReadLine());

        total = cantidad * precioUnit;

        switch (pago)
        {
            case 1:
                descuento = total * 0.10;
                break;
            case 2:
                descuento = total * 0.05;
                break;
            case 3:
                descuento = total * 0.15;
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }

        totalFinal = total - descuento;

        Console.WriteLine("Total a pagar: Q" + totalFinal);
    }
}
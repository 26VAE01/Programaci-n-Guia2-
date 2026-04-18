using System;

class Ejercicio2
{
    static void Main()
    {
        char c;

        Console.Write("Ingrese un caracter: ");
        c = char.Parse(Console.ReadLine());

        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Es una vocal");
                break;

            default:
                if (c >= '0' && c <= '9')
                {
                    Console.WriteLine("Es un digito");
                }
                else
                {
                    Console.WriteLine("No es vocal ni digito");
                }
                break;
        }
    }
}
internal class Program
{
    //Inglesar un aletra: A ? Exelente, B ? Bueno, C ? Regular,
    //D ? Deficiente, F ? Reprovado
    private static void Main(string[] args)
    {
        Console.WriteLine("CLASIFICACION DE LETRAS POR RANGO");
        Console.WriteLine("Dame una letra:");
        char letra = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (letra)
        {
            case 'A':
                Console.WriteLine("Exelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprovado");
                break;
            default:
                Console.WriteLine("Digite una una letra valida entre A,B,C,D y F");
                break;
        }
    }
}
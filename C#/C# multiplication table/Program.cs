using System;
namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string numero;
            Console.Write("Ingrese multiplicador: ");
            numero = Console.ReadLine();
            n = int.Parse(numero);
            int contador = 1;
            while (contador <= 12)
            {
                Console.Write(n + " * " + contador + " = " + n * contador + "\n");
                contador++;
            }
            Console.ReadKey();
        }
    }
}

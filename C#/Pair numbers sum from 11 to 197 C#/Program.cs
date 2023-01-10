using System;
class Program
{
    static void Main(string[] args)
    {
        int cont = 11;
        int suma = 0;
        Console.WriteLine(" --- Numeros pares del 11 all 197 --- ");
        while (cont <= 197)
        {
            if (cont % 2 == 0)
            {
                Console.Write(cont);
                if (cont != 196)
                {
                    Console.Write("+");
                }
                suma = suma + cont;
            }
            cont++;
        }
        Console.WriteLine("");
        Console.WriteLine("Resultado = " + suma);
    }
}
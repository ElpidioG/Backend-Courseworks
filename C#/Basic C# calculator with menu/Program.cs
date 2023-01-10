using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valor1;
            double valor2;
            double resultado;
            string opcion;

            Console.WriteLine("* CALCULADORA BASICA *");
            Console.WriteLine("**********************");
            Console.WriteLine("*        SUMA        *");
            Console.WriteLine("*       RESTA        *");
            Console.WriteLine("*   MULTIPLICACION   *");
            Console.WriteLine("*      DIVISION      *");
            Console.WriteLine("**********************");
            Console.WriteLine("");


            Console.Write("Escriba una opcion: ");
            opcion = Console.ReadLine();
            
            Console.WriteLine("");

            Console.Write("Digite el primer valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite el segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if (opcion == "SUMA" || opcion == "suma")
            {
                resultado = valor1 + valor2;
                Console.WriteLine("La suma es: " + resultado);
                Console.ReadLine();


            }

            else if (opcion == "RESTA" || opcion == "resta")
            {
                resultado = valor1 - valor2;
                Console.WriteLine("La resta es: " + resultado);
                Console.ReadLine();


            }


            else if (opcion == "MULTIPLICACION" || opcion == "multiplicacion")
            {
                resultado = valor1 * valor2;
                Console.WriteLine("La multiplicacion es: " + resultado);
                Console.ReadLine();


            }

            else if (opcion == "DIVISION" || opcion == "division")
            {
                resultado = valor1 / valor2;
                Console.WriteLine("La division es: " + resultado);
                Console.ReadLine();


            }
        }
    }
}

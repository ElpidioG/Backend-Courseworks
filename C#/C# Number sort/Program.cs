using System;


namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;


            Console.WriteLine("Mayor, Menor, Medio");
            Console.WriteLine("**********************");

            Console.Write("Ingrese su  Primer Numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su Segundo Numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su Tercer Numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            //MAYOR
            if (num1 > num2 && num1 > num3)

            {
                Console.WriteLine("El numero mayor es: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)

            {
                Console.WriteLine("El numero mayor es: {0}", num2);
            }

            else if (num3 > num2 && num3 > num1)

            {
                Console.WriteLine("El numero mayor es: {0}", num3);
            }

            //MEDIO
            if ((num1 < num2 && num1 > num3) || (num1 > num2 && num1 < num3))
            {
                Console.WriteLine("El numero del medio es: {0}", num1);
            }
            else if ((num2 < num1 && num2 > num3) || (num2 > num1 && num2 < num3))
            {
                Console.WriteLine("El numero del medio es: {0}", num2);
            }
            else if ((num3 < num2 && num3 > num1) || (num3 > num2 && num3 < num1))
            {
                Console.WriteLine("El numero del medio es: {0}", num3);
            }

            //MENOR
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("El numero menor es: {0}", num1);
            }

            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("El numero menor es: {0}", num2);
            }

            else if (num3 < num2 && num3 < num1)
            {
                Console.WriteLine("El numero menor es: {0}", num3);
            }
           

        }
    }
}
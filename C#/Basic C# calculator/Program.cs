using System;


namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suma
            float suma1;
            float suma2;
            float resultadosuma;
            suma1 = 19;
            suma2 = 34;

            resultadosuma = suma1 + suma2;
            Console.WriteLine("*   Calculadora Basica    *");

            Console.WriteLine("***************************");
            Console.WriteLine("* La suma es la siguiente *");
            Console.WriteLine("*     {0} + {1} = {2}        *",suma1,suma2,resultadosuma);
            Console.WriteLine("***************************");


            //Resta
            float rest1;
            float rest2;
            float resultadorest;
            rest1 = 10;
            rest2 = 25;

            resultadorest = rest1 - rest2;
            
            Console.WriteLine("****************************");
            Console.WriteLine("* La resta es la siguiente *");
            Console.WriteLine("*      {0} - {1} = {2}       *", rest1, rest2, resultadorest);
            Console.WriteLine("****************************");



            //Multiplicacion
            float mult1;
            float mult2;
            float resultadomult;
            mult1 = 8;
            mult2 = 10;

            resultadomult = mult1 * mult2;

            Console.WriteLine("*************************************");
            Console.WriteLine("* La multiplicación es la siguiente *");
            Console.WriteLine("*          {0} * {1} = {2}              *", mult1, mult2, resultadomult);
            Console.WriteLine("*************************************");


            //Division
            float div1;
            float div2;
            float resultadodiv;
            div1 = 8;
            div2 = 10;

            resultadodiv = div1 / div2;

            Console.WriteLine("*******************************");
            Console.WriteLine("* La división es la siguiente *");
            Console.WriteLine("*       {0} / {1} = {2}          *", div1, div2, resultadodiv);
            Console.WriteLine("*******************************");



        }
    }
}
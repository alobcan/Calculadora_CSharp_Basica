using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Calculadora en C# Consola\r");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Escribe un número y presiona enter");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Escribe otro número y presiona enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elige una opcion de la siguiente lista");
            Console.WriteLine("\ts - Suma");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.WriteLine("tu eleccion?");

            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Tu Resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"Tu Resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu Resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu Resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Presiona cualquier tecla para cerrar la calculadora");
            Console.ReadKey();
        }
    }
}

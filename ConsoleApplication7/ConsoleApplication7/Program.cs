
using System;

class Program
    {
        static void Main(string[] args)
        {
            int ValorProducto = 0;
            int totalProducto = 0;
            int NumeroProducto = 1;
            Console.Write(" ingrese el valor del producto N."+ NumeroProducto + ":");
            ValorProducto = Convert.ToInt32(Console.ReadLine());

            while (ValorProducto != 99999)
            {
                NumeroProducto++;
                totalProducto += ValorProducto;
                Console.Write("ingrese el valor del producto N. " + NumeroProducto + ":");
                ValorProducto = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("valor totasl de la factura: "+ totalProducto);
            Console.ReadLine();

        }
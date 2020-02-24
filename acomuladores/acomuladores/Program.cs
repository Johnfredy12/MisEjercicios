using System;

class Program
{
    static void Main(string[] args)
    {
        int ValorProducto = 0;
        int totalProducto = 0;
        int NumeroProducto = 1;
        int cantidadlProducto = 0;
        int totalCompra = 0;
        string respuestacompra = "";

        Console.Write("Desea agregar producto al carrito Y/N");
        respuestacompra = Console.ReadLine();

        while (respuestacompra == "Y")
        {
            Console.Write("  por favor ingrese  valor de producto N." + NumeroProducto + ":");
            ValorProducto = Convert.ToInt32(Console.ReadLine());

            Console.Write(" por favor ingrese la cantidad de producto N." + NumeroProducto + ":");
            cantidadlProducto = Convert.ToInt32(Console.ReadLine());

            totalProducto = ValorProducto * cantidadlProducto;
            totalCompra += totalProducto;

            Console.WriteLine("desea agregar producto al carrito Y/N");
            respuestacompra =(Console.ReadLine());
        }
        Console.WriteLine("valor total de la factura: " + totalCompra);
        Console.ReadLine(); 
    }
}
        
        
                

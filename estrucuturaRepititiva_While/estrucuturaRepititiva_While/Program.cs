using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            string NombreUsuario= "";
            Console.Write ("por favor ingresa tu nombre: ");
            NombreUsuario = Console.ReadLine();

            while (NombreUsuario != "FIN")

            {
                Console.WriteLine("bienvenido, sr(a)" + NombreUsuario + ".");
                Console.WriteLine("");
                Console.Write("por favor ingresa tu nombre: ");
                NombreUsuario = Console.ReadLine();
            }

            Console.WriteLine("fin del programa");
            Console.ReadLine();
    }
}

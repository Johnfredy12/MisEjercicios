using System;


    class Program
    {
        static void Main(string[] args)
        {
            string NombreCiudad= "";
            int mumerociudad = 1;
            Console.Write("por favor ingresa nombre de ciudad " + mumerociudad +":"); 
            NombreCiudad = Console.ReadLine();

            while (NombreCiudad != "FIN")
            {
                mumerociudad += 1;
                Console.WriteLine("nombre de la ciudad ingresada es " + NombreCiudad + ".");
                Console.WriteLine("");
                Console.Write("por favor ingresa nombre de ciudad: " + mumerociudad + ":");
                NombreCiudad = Console.ReadLine();
                
            }

            Console.WriteLine("fin del programa");
            Console.ReadLine();
    }
    }
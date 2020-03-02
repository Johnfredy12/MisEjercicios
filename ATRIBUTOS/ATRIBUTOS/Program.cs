using System;



    class program 

    {
        static void Main(string[] args)
        {
            Aprendiz apSena = new Aprendiz();
            apSena.Nombre = "Jonh Fredy";
            apSena.Apellidos = "Murcia Roriguez";
            apSena.Direccion = "calle10  # 15 A 88 ";
            Saludo (apSena);

        }

        private static void Saludo(Aprendiz ApSena)
        {
            Console.WriteLine("Bienvenido, sr (as) "+  ApSena.Nombre + "  " + ApSena.Apellidos);
            Console.WriteLine(ApSena.Direccion);


            Console.ReadLine();

        }   





        
    }


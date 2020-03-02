using System;



    class Program

    {
        static void Main(string[] args)
        {
            int NumeroNotas = 0;
            Console.WriteLine("===NOTAS===");
            Console.WriteLine("Ingrese el numero de notas: ");
            Int32.TryParse(Console.ReadLine(), out NumeroNotas);
            string resultado = CalcularNotas(NumeroNotas);
        }

        public static string CalcularNotas (int NumeroNotas)
        { 


        decimal Nota = 0;
        decimal SumaNotas = 0;
        decimal promedio = 0; 
        for (int i = 1; i <= NumeroNotas; i++)

    {
        Console.WriteLine("Ingre la nota N. " +i);
        decimal.TryParse(Console.ReadLine(), out Nota);
        SumaNotas += Nota;
        promedio = SumaNotas / i;

    } 
        if  (promedio >= 6)

    {
        Console.WriteLine(" usted a pasado con un promedio de" +" "+ promedio);
        }
       else
    {
      Console.WriteLine ("usted ha perdido con un promedio de " +" "+promedio);
    }

     Console.ReadLine();
    return "";





   

 







    }
}

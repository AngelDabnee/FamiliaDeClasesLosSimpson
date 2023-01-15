using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Se definirá un abuelo nuevo");
            AbrahamSipson abrahamSipson = new AbrahamSipson();
            BartSimpson bart = new BartSimpson();
        }
    }
}
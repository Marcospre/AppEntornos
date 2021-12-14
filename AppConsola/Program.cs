using System;
using AppLibreria;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sintomas = false;
            var inmuno = true;
            var vacuna = true;

            var Triaje =new Triaje();
            var pcrSN = Triaje.AplicamosPcr(sintomas,inmuno,vacuna);
            Console.WriteLine($"Debe pasar PCR?{pcrSN}");

        }




    }
}

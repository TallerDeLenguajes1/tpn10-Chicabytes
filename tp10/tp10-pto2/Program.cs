using Helpers;
using System;
using System.IO;

namespace tp10_pto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Direccion = @"C:\Morse";
            string Conf_Leida;
            if (File.Exists("destino.dat"))
            {
                Conf_Leida = SoporteParaConfiguracion.LeerConfiguracion();
            }
            else
            {
                SoporteParaConfiguracion.CrearArchivoDeConfiguracion(Direccion);
                Conf_Leida = SoporteParaConfiguracion.LeerConfiguracion();
            }
            ConversorDeMorse.MoverArch(Conf_Leida);
            Console.Write("Ingrese el texto a traducir, en castellano: ");
            string Texto_a_Traducir = Console.ReadLine();
            Console.WriteLine("El texto traducido es: " + ConversorDeMorse.TextoAMorse(Texto_a_Traducir));
            ConversorDeMorse.MorseAudio();

        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace tp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string NombreArchivo = "ListadoInmuebles.csv";
            string PathArch = @"C:\TP10\";
            List<Propiedad> ListaPropiedades = new List<Propiedad>();
            FileStream Arch_Leer = new FileStream(PathArch + NombreArchivo, FileMode.Open);
            StreamReader Leer = new StreamReader(Arch_Leer);

            string Linea;
            int cont = 0;
            while ((Linea = Leer.ReadLine()) != null)
            {
                int id = cont;
                string[] Dato = Linea.Split(';');
                string Doc = Dato[0];
                string TipoProp = Dato[1];
                Propiedad Prop = new Propiedad();
                Prop.CargarInmueble(id, Doc, TipoProp);
                ListaPropiedades.Add(Prop);
                cont++;
            }
            Leer.Close();

            string NuevoArch = "ListadoInmueblesCompleto.csv";
            FileStream Arch_Escribir = new FileStream(PathArch + NuevoArch, FileMode.OpenOrCreate);
            StreamWriter Escribir = new StreamWriter(Arch_Escribir);
            foreach(Propiedad _prop in ListaPropiedades)
            {
                Escribir.WriteLine(_prop.Id.ToString() + ';' + _prop.Tamanio.ToString() + ';' + _prop.Cantidad_baños.ToString() + ';' + _prop.Cantidad_habitaciones.ToString() + ';' + _prop.Domicilio + ';' + _prop.Operacion + ';' + _prop.Precio + ';' + _prop.Estado + ';' + _prop.Propiedades + ';');
                Console.WriteLine(_prop.Id.ToString() + ';' + _prop.Tamanio.ToString() + ';' + _prop.Cantidad_baños.ToString() + ';' + _prop.Cantidad_habitaciones.ToString() + ';' + _prop.Domicilio + ';' + _prop.Operacion + ';' + _prop.Precio + ';' + _prop.Estado + ';' + _prop.Propiedades + ';');

            }
            Escribir.Close();
        }
    }
}

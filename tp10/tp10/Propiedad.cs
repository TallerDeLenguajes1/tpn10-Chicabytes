using System;
using System.Collections.Generic;
using System.Text;

namespace tp10
{
    public class Propiedad
    {

        enum TipoDeOperacion
        {
            Venta,
            Alquiler
        }
        enum TipoDePropiedad
        {
            Departamento,
            Casa,
            Duplex,
            Penthouse,
            Terreno
        }

        private int id;//representa el número de propiedad ingresada
        private float tamanio; // punto flotante
        private int cantidad_baños;
        private int cantidad_habitaciones;
        private string domicilio; // string
        private int precio; // Valor Entero
        private bool estado = false; // bool activo / inactivo
        private string propiedades;
        private string operacion;

        public int Id { get => id; set => id = value; }
        public float Tamanio { get => tamanio; set => tamanio = value; }
        public int Cantidad_baños { get => cantidad_baños; set => cantidad_baños = value; }
        public int Cantidad_habitaciones { get => cantidad_habitaciones; set => cantidad_habitaciones = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Precio { get => precio; set => precio = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Propiedades { get => propiedades; set => propiedades = value; }
        public string Operacion { get => operacion; set => operacion = value; }

        public void CargarInmueble(int _Id, string _Domicilio, string _Propiedades)
        {
            Random Rand = new Random();
            Id = _Id;
            Tamanio = Convert.ToSingle(Rand.Next());
            Cantidad_baños = Rand.Next(1,5);
            Cantidad_habitaciones = Rand.Next(1,10);
            Domicilio = _Domicilio;
            TipoOp();
            Precio = Rand.Next(10000, 1000000);
            Estado = Convert.ToBoolean(Rand.Next(1));
            Propiedades = _Propiedades;
        }

        public float ValorDelInmueble()// sólo devuelve un valor
        {
            float Precio_Operacion;
            if (TipoDeOperacion.Venta.ToString() == Operacion)
            {
                Precio_Operacion = Convert.ToSingle(Precio + (Precio * 0.21) + (Precio * 0.10) + 10000);
                return Precio_Operacion;
            }
            else
            {
                Precio_Operacion = Convert.ToSingle((Precio*0.02) + (Precio*0.005));
                return Precio_Operacion;
            }
        }

        public void TipoOp()
        {
            Random rand = new Random();
            int v_rand = rand.Next(100);
            string[] result;
            result = Enum.GetNames(typeof(TipoDeOperacion));
            if (v_rand > 65)
            { 
                Operacion = result[0];
            }
            else
            {
                Operacion = result[1];
            }
        }
    }
}

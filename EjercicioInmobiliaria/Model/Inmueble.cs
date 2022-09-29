using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInmobiliaria
{
    abstract class Inmueble
    {
        private string direccion;
        private int metrosCuadrados;
        private string estado;
        private int precio;

        public int MetrosCuadrados { get => metrosCuadrados; set => metrosCuadrados = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Precio { get => precio; set => precio = value; }

        public Inmueble(string direccion, int metrosCuadrados, string estado, int precio)
        {
            this.direccion = direccion;
            this.metrosCuadrados = metrosCuadrados;
            this.estado = estado;
            this.Precio = precio;
        }

        public virtual int calcularPrecio()
        {
            int precioNuevo=0;
            if (this.estado == "Nuevo")
            {
                precioNuevo = Precio - Precio  / 100;
            }
            if(this.estado=="Segunda Mano")
            {
                precioNuevo = Precio - Precio * 2 / 100;
            }
            return precioNuevo;
        }
        public virtual string Mostrar()
        {
            return "Direccion: " + this.direccion + " Metros cuadrados: " + metrosCuadrados + " Estado: " + estado + " precio: " + calcularPrecio() ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInmobiliaria
{
    class Local : Inmueble, Imostrable
    {
        private int cantVentanas;
        public int CantVentanas { get => cantVentanas; set => cantVentanas = value; }
        public Local(int cantVentanas, string direccion, int metrosCuadrados, string estado, int precio) : base(direccion, metrosCuadrados, estado, precio)
        {
            this.cantVentanas = cantVentanas;
        }

        public override int calcularPrecio()
        {
            int precioNuevo = base.calcularPrecio();

            if (MetrosCuadrados > 50)
            {
                precioNuevo += precioNuevo / 100;
            }
            if (cantVentanas == 0 || cantVentanas == 1)
            {
                precioNuevo -= precioNuevo * 2 / 100;
            }
            if (cantVentanas > 4)
            {
                precioNuevo += precioNuevo * 2 / 100;
            }
            return precioNuevo;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " cantidad ventanas: " + cantVentanas +"\n";
        }
    }
    
}

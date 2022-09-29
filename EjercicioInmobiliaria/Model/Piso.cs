using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInmobiliaria
{
    class Piso: Inmueble, Imostrable
    {
        private int nroPiso;

        public int NroPiso { get => nroPiso; set => nroPiso = value; }

        public Piso(int nroPiso, string direccion, int metrosCuadrados, string estado, int precio) : base(direccion, metrosCuadrados,  estado,  precio)
        {
            this.nroPiso = nroPiso;
        }
        public override int calcularPrecio()
        {
            int precioNuevo = base.calcularPrecio();
            if (nroPiso >= 3)
            {
                precioNuevo += precioNuevo * 3 / 100;

            }
            return precioNuevo;
        }
        public override string Mostrar()
        {
            return base.Mostrar() + " Numero piso: " + nroPiso + "\n";
        }
    }


}

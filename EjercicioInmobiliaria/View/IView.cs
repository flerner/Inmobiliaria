using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInmobiliaria.View
{
    interface IView
    {
        string TxtDireccion { get; set; }
        string TxtMetrosCuadrados { get; set; }
        string TxtPiso { get; set; }
        string TxtVentanas { get; set; }
        string TxtEstado { get; set; }
        string TxtPrecio { get; set; }
        Boolean RBtnPiso { get; set; }
        Boolean RBtnLocal { get; set; }
        string LblMostrar { get; set; }
        string LblCalcular { get; set; }
    }
}

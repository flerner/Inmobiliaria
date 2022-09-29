using EjercicioInmobiliaria.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInmobiliaria.Presenter
{
    class InmobiliariaPresenter
    {
        IView iview;
        List<Inmueble> inmuebles;
        public InmobiliariaPresenter()
        {      
            inmuebles = new List<Inmueble>();
        }
        public void CalcularPrecio(IView view)
        {
            this.iview = view;
            iview.LblCalcular = "Precio Calculado: ";
            Inmueble inmueble = null;
            if (iview.RBtnLocal)
            {
                inmueble = new Local(int.Parse(iview.TxtVentanas), iview.TxtDireccion,int.Parse(iview.TxtMetrosCuadrados) ,iview.TxtEstado,int.Parse( iview.TxtPrecio));
                
            }
            if (iview.RBtnPiso)
            {
                inmueble = new Piso(int.Parse(iview.TxtPiso), iview.TxtDireccion, int.Parse(iview.TxtMetrosCuadrados), iview.TxtEstado, int.Parse(iview.TxtPrecio));
            }
            iview.LblCalcular += inmueble.calcularPrecio();
            inmuebles.Add(inmueble);
           
        }
        public void Mostrar()
        {
            foreach(Inmueble i in inmuebles)
            {
                iview.LblMostrar+=i.Mostrar();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInmobiliaria
{
    static class Utiles
    {
        public static Boolean Validar(string dato, string tipo)
        {
            switch (tipo)
            {
                case "string":
                    if (dato.Trim() != "") { 
                    try
                    {
                        Convert.ToString(dato);
                        return true;
                    }
                    catch(Exception ex)
                    {
                        return false;
                    }
                    }
                    else
                    {
                        return false;
                    }
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch(FormatException ex)
                    {
                        return false;
                    }
                default: return false;

            }
        }
    }
}

using EjercicioInmobiliaria.Presenter;
using EjercicioInmobiliaria.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioInmobiliaria
{
    public partial class Form1 : Form, IView
    {
        InmobiliariaPresenter presenter;
        public Form1()
        {
            //lo inicialice aca ya que adentro del presenter instancio un array que va guardando cada inmobiliaria por cada click
            //Está bien o el declarar un array adentro del presenter ya es un error?
            presenter = new InmobiliariaPresenter();
            InitializeComponent();
        }
        //Propiedades
        #region
        public string TxtDireccion
        {
            get
            {
                return txtDireccion.Text;
            }
            set
            {
                txtDireccion.Text = value;
            }
        }
        public string TxtMetrosCuadrados
        {
            get
            {
                return txtMts.Text;
            }
            set
            {
                txtMts.Text = value;
            }
        }
        public string TxtPiso
        {
            get
            {
                return txtPiso.Text;
            }
            set
            {
                txtPiso.Text = value;
            }
        }
        public string TxtVentanas
        {
            get
            {
                return txtVentanas.Text;
            }
            set
            {
                txtVentanas.Text = value;
            }
        }
        public string TxtEstado
        {
            get
            {
                return cBoxEstado.Text;
            }
            set
            {
                cBoxEstado.Text = value;
            }
        }
        public string TxtPrecio
        {
            get
            {
                return txtPrecio.Text;
            }
            set
            {
                txtPrecio.Text = value;
            }
        }
        public string LblMostrar
        {
            get
            {
                return lblMostrar.Text;
            }
            set 
            { 
                lblMostrar.Text = value; 
            }
        }
        public string LblCalcular
        {
            get { return lblCalcular.Text; }
            set { lblCalcular.Text = value; }
        }
        public Boolean RBtnPiso
        {
            get
            {
                return rbtnPiso.Checked;
            }
            set { rbtnPiso.Checked = value; }
    
        }
        public Boolean RBtnLocal
        {
            get
            {
                return rbtnLocal.Checked;
            }
            set { rbtnLocal.Checked = value; }
        }
        #endregion

        //activo/desactivo txtBox en base al rbtn
        private void rbtnPiso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPiso.Checked)
            {
                txtPiso.Visible = true;
                lblPiso.Visible = true;
                txtVentanas.Visible = false;
                lblVentana.Visible = false;
            }

        }
        private void rbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLocal.Checked)
            {
                txtVentanas.Visible = true;
                lblVentana.Visible = true;
                txtPiso.Visible = false;
                lblPiso.Visible = false;
            }

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {        
            if (validarDatos())
            {
                MessageBox.Show("Se ingreso todo correctamente");
                //Es correcto instanciar un presentador por cada click que hace? No se puede instanciar afuera
                //para que quede uno y se reutilice, pasandole como parametro this, cada vez que llamas a un metodo?
                
                presenter.CalcularPrecio(this);
            
            }
            else
            {
                MessageBox.Show("No se ingreso todo correctamente");
            }
        }
        private Boolean validarDatos()
        {
            Boolean retorno = true;

            //valido direccion
            #region
            if (!Utiles.Validar(txtDireccion.Text, "string"))
            {
                retorno = false;
                txtDireccion.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.Color.White;
            }
            #endregion
            //valido mts
            #region
            if (!Utiles.Validar(txtMts.Text, "int"))
            {
                retorno = false;
                txtMts.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtMts.BackColor = System.Drawing.Color.White;
            }
            #endregion
            //valido ventanas/piso
            #region
            if (rbtnLocal.Checked)
            {
                if (!Utiles.Validar(txtVentanas.Text, "int"))
                {
                    retorno = false;
                    txtVentanas.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    txtVentanas.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                if (!Utiles.Validar(txtPiso.Text, "int"))
                {
                    retorno = false;
                    txtPiso.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    txtPiso.BackColor = System.Drawing.Color.White;
                }
            }
            #endregion
            //valido estado
            #region
            if (!Utiles.Validar(cBoxEstado.Text, "string"))
            {
                retorno = false;
                cBoxEstado.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                cBoxEstado.BackColor = System.Drawing.Color.White;
            }
            #endregion
            //valido precio
            #region
            if (!Utiles.Validar(txtPrecio.Text, "string"))
            {
                retorno = false;
                txtPrecio.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtPrecio.BackColor = System.Drawing.Color.White;
            }
            #endregion
            return retorno;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            presenter.Mostrar();
        }
    }
}

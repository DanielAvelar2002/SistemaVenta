using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio(); //creo una instancia del formulario de Inicio

            form.Show(); //muestro el formulario de Inicio
            this.Hide(); //Oculto este formulario (Login)

            form.FormClosing += frm_closing;

        }
        /// <summary>
        /// Evento que recibe un objeto y el evento cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtClave.Text = "";
            this.Show();
        }
    }
}

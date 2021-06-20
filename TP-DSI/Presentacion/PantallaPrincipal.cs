using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_DSI.Datos;

namespace TP_DSI.Presentacion
{
    public partial class PantallaPrincipal : Form
    {
        Usuario usuarioActual;

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            PantallaLogin login = new PantallaLogin();
            login.ShowDialog();

            this.usuarioActual = login.Usuario;

            if (this.usuarioActual.Id_usuario == 0)
                this.Close();
            else
                lbl_usuario.Text = "Usuario: " + usuarioActual.Nombre;

            login.Dispose();
           
            
        }
    }
}

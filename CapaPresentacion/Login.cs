using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            MostrarInicio();  
           
        }
     

        private void MostrarInicio()
        {

            List<Alumnos> loginA = new CN_Login().listar();
            Alumnos oalumnos = loginA.Where(p => p.NumeroDocumento == txtDocumento.Text && p.Clave == txtClave.Text).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(txtClave.Text)||string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("La Clave y el Numero De Documento no pueden estar vacios","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (oalumnos != null)
            {
                Incio incio = new Incio(oalumnos);
                incio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La Clave y el Numero De Documento No Son Validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
    }
}

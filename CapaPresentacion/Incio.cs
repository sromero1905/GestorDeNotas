using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Incio : Form
    {
        private static Alumnos objAlumno;
        public Incio(Alumnos alumno)
        {
            objAlumno = alumno;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarInicio();
        }
        private void cerrarInicio()
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Incio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Incio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = objAlumno.Nombre;
        }
    }
}

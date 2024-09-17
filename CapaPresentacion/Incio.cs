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
using FontAwesome.Sharp;
using CapaPresentacion.Admin;
using CapaPresentacion.Alumnos;
using System.ComponentModel.Design;
namespace CapaPresentacion
{
    public partial class Incio : Form
    {
        private static Alumno objAlumno;
        private static Profesor objProfesor;
 
        private static Form FormularioActivo;
        public Incio(Alumno alumno, Profesor profesor)
        {

            objProfesor = profesor;
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
            if (objAlumno != null)
            {
                lblUsuario.Text = objAlumno.Nombre;
            } else if (objProfesor != null)
            {
                lblUsuario.Text = objProfesor.Nombre;

            }
           
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnNotas, new VerNotas());
        }

        private void btnAgregarNotas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btnNotas, new AgregarNotas());
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnMateria, new VerMaterias());
        }

        private void btnAgregarMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btnMateria, new AgregarMateria());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnHistorial, new HistorialMaterias());
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnTeams, new teams());
             
        }

        private void btnSede_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnSede, new Sede());
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnProfesores, new VerProfesores());
        }

        private void btnAgregarProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btnAgregarProfesores, new Agregar_Profesor());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)btnMiCuenta, new MiCuenta());
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btnAlumnos, new AgregarAlumno());
          
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(btnAlumnos, new VerAlumnos());
        }
    }
}

﻿using CapaEntidad;
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

            List<Alumno> loginA = new CN_Login().listarAlumnos();
            List<Profesor> LoginP = new CN_Login().listarProf();
            List<Admins> LoginAd = new CN_Login().ListarAdmin();

            Alumno oalumnos = loginA.Where(p => p.NumeroDocumento == txtDocumento.Text && p.Clave == txtClave.Text).FirstOrDefault();
            Profesor oProfesor = LoginP.Where(P => P.Documento == txtDocumento.Text && P.Clave == txtClave.Text).FirstOrDefault();
            Admins oAdmin = LoginAd.Where(P => P.NumeroDocumento == txtDocumento.Text && P.Password == txtClave.Text).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(txtClave.Text)||string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("La Clave y el Numero De Documento no pueden estar vacios","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (oalumnos != null || oProfesor != null || oAdmin!=null)
            {
                Incio incio = new Incio(oalumnos,oProfesor,oAdmin);
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

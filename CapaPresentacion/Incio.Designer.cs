namespace CapaPresentacion
{
    partial class Incio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNotas = new FontAwesome.Sharp.IconMenuItem();
            this.btnAgregarNotas = new FontAwesome.Sharp.IconMenuItem();
            this.btnMateria = new FontAwesome.Sharp.IconMenuItem();
            this.btnAgregarMaterias = new FontAwesome.Sharp.IconMenuItem();
            this.btnHistorial = new FontAwesome.Sharp.IconMenuItem();
            this.btnTeams = new FontAwesome.Sharp.IconMenuItem();
            this.btnSede = new FontAwesome.Sharp.IconMenuItem();
            this.btnProfesores = new FontAwesome.Sharp.IconMenuItem();
            this.btnAgregarProfesores = new FontAwesome.Sharp.IconMenuItem();
            this.btnMiCuenta = new FontAwesome.Sharp.IconMenuItem();
            this.btnAlumnos = new FontAwesome.Sharp.IconMenuItem();
            this.btnAgregarAlumnos = new FontAwesome.Sharp.IconMenuItem();
            this.btnVerAlumnos = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNotas,
            this.btnMateria,
            this.btnHistorial,
            this.btnTeams,
            this.btnSede,
            this.btnProfesores,
            this.btnMiCuenta,
            this.btnAlumnos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 71);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNotas
            // 
            this.btnNotas.AutoSize = false;
            this.btnNotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarNotas});
            this.btnNotas.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnNotas.IconColor = System.Drawing.Color.Black;
            this.btnNotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(122, 67);
            this.btnNotas.Text = "Notas";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnAgregarNotas
            // 
            this.btnAgregarNotas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarNotas.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNotas.Name = "btnAgregarNotas";
            this.btnAgregarNotas.Size = new System.Drawing.Size(150, 22);
            this.btnAgregarNotas.Text = "Agregar Notas";
            this.btnAgregarNotas.Click += new System.EventHandler(this.btnAgregarNotas_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.AutoSize = false;
            this.btnMateria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarMaterias});
            this.btnMateria.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMateria.IconColor = System.Drawing.Color.Black;
            this.btnMateria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMateria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(122, 67);
            this.btnMateria.Text = "Materias";
            this.btnMateria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnAgregarMaterias
            // 
            this.btnAgregarMaterias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarMaterias.IconColor = System.Drawing.Color.Black;
            this.btnAgregarMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarMaterias.Name = "btnAgregarMaterias";
            this.btnAgregarMaterias.Size = new System.Drawing.Size(164, 22);
            this.btnAgregarMaterias.Text = "Agregar Materias";
            this.btnAgregarMaterias.Click += new System.EventHandler(this.btnAgregarMaterias_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.AutoSize = false;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistorial.IconColor = System.Drawing.Color.Black;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(111, 67);
            this.btnHistorial.Text = "Historial Materias";
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.AutoSize = false;
            this.btnTeams.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnTeams.IconColor = System.Drawing.Color.Black;
            this.btnTeams.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeams.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(87, 67);
            this.btnTeams.Text = "Compañeros";
            this.btnTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnSede
            // 
            this.btnSede.AutoSize = false;
            this.btnSede.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            this.btnSede.IconColor = System.Drawing.Color.Black;
            this.btnSede.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSede.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSede.Name = "btnSede";
            this.btnSede.Size = new System.Drawing.Size(70, 67);
            this.btnSede.Text = "Sede";
            this.btnSede.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSede.Click += new System.EventHandler(this.btnSede_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.AutoSize = false;
            this.btnProfesores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarProfesores});
            this.btnProfesores.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btnProfesores.IconColor = System.Drawing.Color.Black;
            this.btnProfesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfesores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(74, 67);
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnAgregarProfesores
            // 
            this.btnAgregarProfesores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProfesores.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProfesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProfesores.Name = "btnAgregarProfesores";
            this.btnAgregarProfesores.Size = new System.Drawing.Size(174, 22);
            this.btnAgregarProfesores.Text = "Agregar Profesores";
            this.btnAgregarProfesores.Click += new System.EventHandler(this.btnAgregarProfesores_Click);
            // 
            // btnMiCuenta
            // 
            this.btnMiCuenta.AutoSize = false;
            this.btnMiCuenta.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnMiCuenta.IconColor = System.Drawing.Color.Black;
            this.btnMiCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiCuenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMiCuenta.Name = "btnMiCuenta";
            this.btnMiCuenta.Size = new System.Drawing.Size(122, 67);
            this.btnMiCuenta.Text = "Mi Cuenta";
            this.btnMiCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMiCuenta.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.AutoSize = false;
            this.btnAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarAlumnos,
            this.btnVerAlumnos});
            this.btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btnAlumnos.IconColor = System.Drawing.Color.Black;
            this.btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlumnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(122, 67);
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAgregarAlumnos
            // 
            this.btnAgregarAlumnos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarAlumnos.IconColor = System.Drawing.Color.Black;
            this.btnAgregarAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            this.btnAgregarAlumnos.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarAlumnos.Text = "Agregar Alumnos";
            this.btnAgregarAlumnos.Click += new System.EventHandler(this.btnAgregarAlumnos_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerAlumnos.IconColor = System.Drawing.Color.Black;
            this.btnVerAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(180, 22);
            this.btnVerAlumnos.Text = "Ver Alumnos";
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Navy;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1076, 38);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSalir.IconSize = 40;
            this.btnSalir.Location = new System.Drawing.Point(1009, 41);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 60);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Navy;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(105, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 18);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(0, 112);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1076, 354);
            this.contenedor.TabIndex = 5;
            // 
            // Incio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 478);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Incio";
            this.Text = "Incio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Incio_FormClosed);
            this.Load += new System.EventHandler(this.Incio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem btnNotas;
        private FontAwesome.Sharp.IconMenuItem btnMateria;
        private FontAwesome.Sharp.IconMenuItem btnHistorial;
        private FontAwesome.Sharp.IconMenuItem btnTeams;
        private FontAwesome.Sharp.IconMenuItem btnSede;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem btnAlumnos;
        private FontAwesome.Sharp.IconMenuItem btnAgregarNotas;
        private FontAwesome.Sharp.IconMenuItem btnAgregarMaterias;
        private FontAwesome.Sharp.IconMenuItem btnAgregarProfesores;
        private FontAwesome.Sharp.IconMenuItem btnMiCuenta;
        private FontAwesome.Sharp.IconMenuItem btnAgregarAlumnos;
        private FontAwesome.Sharp.IconMenuItem btnVerAlumnos;
        private System.Windows.Forms.Panel contenedor;
    }
}
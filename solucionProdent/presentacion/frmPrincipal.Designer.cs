namespace presentacion
{
    partial class frm_principal
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCitaMedica = new System.Windows.Forms.ToolStripMenuItem();
            this.frmaddCitaMedica = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsignarTratamiendo = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesPorMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMedico = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.menuPaciente,
            this.menuCitaMedica,
            this.tratamientoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPaciente,
            this.medicoToolStripMenuItem,
            this.asistenteToolStripMenuItem});
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(69, 20);
            this.menuPaciente.Text = "Gestionar";
            // 
            // menuItemPaciente
            // 
            this.menuItemPaciente.Name = "menuItemPaciente";
            this.menuItemPaciente.Size = new System.Drawing.Size(122, 22);
            this.menuItemPaciente.Text = "Paciente";
            this.menuItemPaciente.Click += new System.EventHandler(this.menuItemPaciente_Click);
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.medicoToolStripMenuItem.Text = "Medico";
            // 
            // asistenteToolStripMenuItem
            // 
            this.asistenteToolStripMenuItem.Name = "asistenteToolStripMenuItem";
            this.asistenteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.asistenteToolStripMenuItem.Text = "Asistente";
            // 
            // menuCitaMedica
            // 
            this.menuCitaMedica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmaddCitaMedica,
            this.modificarToolStripMenuItem});
            this.menuCitaMedica.Name = "menuCitaMedica";
            this.menuCitaMedica.Size = new System.Drawing.Size(82, 20);
            this.menuCitaMedica.Text = "Cita Medica";
            // 
            // frmaddCitaMedica
            // 
            this.frmaddCitaMedica.Name = "frmaddCitaMedica";
            this.frmaddCitaMedica.Size = new System.Drawing.Size(125, 22);
            this.frmaddCitaMedica.Text = "Registrar";
            this.frmaddCitaMedica.Click += new System.EventHandler(this.frmaddCitaMedica_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // tratamientoToolStripMenuItem
            // 
            this.tratamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAsignarTratamiendo});
            this.tratamientoToolStripMenuItem.Name = "tratamientoToolStripMenuItem";
            this.tratamientoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tratamientoToolStripMenuItem.Text = "Tratamiento";
            // 
            // menuAsignarTratamiendo
            // 
            this.menuAsignarTratamiendo.Name = "menuAsignarTratamiendo";
            this.menuAsignarTratamiendo.Size = new System.Drawing.Size(255, 22);
            this.menuAsignarTratamiendo.Text = "Asignar tratamiendo a cita medica";
            this.menuAsignarTratamiendo.Click += new System.EventHandler(this.menuAsignarTratamiento);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesPorMedicoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // pacientesPorMedicoToolStripMenuItem
            // 
            this.pacientesPorMedicoToolStripMenuItem.Name = "pacientesPorMedicoToolStripMenuItem";
            this.pacientesPorMedicoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pacientesPorMedicoToolStripMenuItem.Text = "Pacientes por Medico";
            this.pacientesPorMedicoToolStripMenuItem.Click += new System.EventHandler(this.pacientesPorMedicoToolStripMenuItem_Click);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(58, 65);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(161, 24);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "lblNombreMedico";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::presentacion.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(632, 409);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_principal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaciente;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCitaMedica;
        private System.Windows.Forms.ToolStripMenuItem tratamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmaddCitaMedica;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAsignarTratamiendo;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesPorMedicoToolStripMenuItem;
        private System.Windows.Forms.Label lblMedico;
    }
}
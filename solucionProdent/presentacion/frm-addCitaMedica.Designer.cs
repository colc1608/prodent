namespace presentacion
{
    partial class frm_addCitaMedica
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarHorario = new System.Windows.Forms.Button();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpFecha = new System.Windows.Forms.DateTimePicker();
            this.dataHorarioAtencion = new System.Windows.Forms.DataGridView();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHorarioAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscarPaciente);
            this.groupBox1.Location = new System.Drawing.Point(35, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Paciente";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(554, 36);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(126, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(322, 39);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(128, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(19, 28);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(35, 34);
            this.btnBuscarPaciente.TabIndex = 0;
            this.btnBuscarPaciente.Text = "b";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarHorario);
            this.groupBox2.Controls.Add(this.cboEspecialidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tpFecha);
            this.groupBox2.Location = new System.Drawing.Point(35, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.Location = new System.Drawing.Point(592, 26);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHorario.TabIndex = 4;
            this.btnBuscarHorario.Text = "Buscar";
            this.btnBuscarHorario.UseVisualStyleBackColor = true;
            this.btnBuscarHorario.Click += new System.EventHandler(this.btnBuscarHorario_Click);
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(398, 26);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(159, 21);
            this.cboEspecialidad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha";
            // 
            // tpFecha
            // 
            this.tpFecha.Location = new System.Drawing.Point(81, 28);
            this.tpFecha.Name = "tpFecha";
            this.tpFecha.Size = new System.Drawing.Size(200, 20);
            this.tpFecha.TabIndex = 0;
            this.tpFecha.Value = new System.DateTime(2015, 11, 20, 0, 0, 0, 0);
            // 
            // dataHorarioAtencion
            // 
            this.dataHorarioAtencion.AllowUserToAddRows = false;
            this.dataHorarioAtencion.AllowUserToDeleteRows = false;
            this.dataHorarioAtencion.AllowUserToOrderColumns = true;
            this.dataHorarioAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHorarioAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medico,
            this.Inicio,
            this.Fin,
            this.Consultorio});
            this.dataHorarioAtencion.Location = new System.Drawing.Point(35, 250);
            this.dataHorarioAtencion.Name = "dataHorarioAtencion";
            this.dataHorarioAtencion.ReadOnly = true;
            this.dataHorarioAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHorarioAtencion.Size = new System.Drawing.Size(697, 263);
            this.dataHorarioAtencion.TabIndex = 3;
            // 
            // Medico
            // 
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Width = 200;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            this.Inicio.Width = 120;
            // 
            // Fin
            // 
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            this.Fin.Width = 120;
            // 
            // Consultorio
            // 
            this.Consultorio.HeaderText = "Consultorio";
            this.Consultorio.Name = "Consultorio";
            this.Consultorio.ReadOnly = true;
            this.Consultorio.Width = 120;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(638, 535);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frm_addCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 601);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataHorarioAtencion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_addCitaMedica";
            this.Text = "frm_addCitaMedica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHorarioAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarHorario;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tpFecha;
        private System.Windows.Forms.DataGridView dataHorarioAtencion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultorio;
    }
}
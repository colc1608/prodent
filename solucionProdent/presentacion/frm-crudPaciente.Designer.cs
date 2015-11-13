namespace presentacion
{
    partial class frm_crudPaciente
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
            this.dataPacientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPacientes
            // 
            this.dataPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellidoPaterno,
            this.apellidoMaterno,
            this.dni,
            this.direccion,
            this.telefono,
            this.celular,
            this.sexo,
            this.correo,
            this.fechaNacimiento});
            this.dataPacientes.Location = new System.Drawing.Point(22, 175);
            this.dataPacientes.Name = "dataPacientes";
            this.dataPacientes.Size = new System.Drawing.Size(851, 246);
            this.dataPacientes.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.HeaderText = "apellidoPaterno";
            this.apellidoPaterno.Name = "apellidoPaterno";
            // 
            // apellidoMaterno
            // 
            this.apellidoMaterno.HeaderText = "apellidoMaterno";
            this.apellidoMaterno.Name = "apellidoMaterno";
            // 
            // dni
            // 
            this.dni.HeaderText = "dni";
            this.dni.Name = "dni";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // celular
            // 
            this.celular.HeaderText = "celular";
            this.celular.Name = "celular";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            // 
            // correo
            // 
            this.correo.HeaderText = "correo";
            this.correo.Name = "correo";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "fechaNacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            // 
            // frm_crudPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 459);
            this.Controls.Add(this.dataPacientes);
            this.Name = "frm_crudPaciente";
            this.Text = "frm_crudPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
    }
}
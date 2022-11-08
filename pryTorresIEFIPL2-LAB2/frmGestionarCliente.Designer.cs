namespace pryTorresIEFIPL2_LAB2
{
    partial class frmGestionarCliente
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
            this.txtDniClienteBusqueda = new System.Windows.Forms.TextBox();
            this.txtApellidoClienteConsulta = new System.Windows.Forms.TextBox();
            this.txtNombreClienteConsulta = new System.Windows.Forms.TextBox();
            this.lblDniClienteBusqueda = new System.Windows.Forms.Label();
            this.mskDniClienteBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.mrcBusquedaCliente = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.mrcDatosClientes = new System.Windows.Forms.GroupBox();
            this.txtDireccionConsultaCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionClienteConsulta = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblSaldoClienteConsulta = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtSaldoClienteConsulta = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreClienteConsulta = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstBarrioConsultaCliente = new System.Windows.Forms.ComboBox();
            this.lstActividadClienteConsulta = new System.Windows.Forms.ComboBox();
            this.mrcBusquedaCliente.SuspendLayout();
            this.mrcDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDniClienteBusqueda
            // 
            this.txtDniClienteBusqueda.Location = new System.Drawing.Point(100, 30);
            this.txtDniClienteBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDniClienteBusqueda.Name = "txtDniClienteBusqueda";
            this.txtDniClienteBusqueda.Size = new System.Drawing.Size(116, 21);
            this.txtDniClienteBusqueda.TabIndex = 0;
            // 
            // txtApellidoClienteConsulta
            // 
            this.txtApellidoClienteConsulta.Location = new System.Drawing.Point(120, 61);
            this.txtApellidoClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoClienteConsulta.Name = "txtApellidoClienteConsulta";
            this.txtApellidoClienteConsulta.ReadOnly = true;
            this.txtApellidoClienteConsulta.Size = new System.Drawing.Size(116, 21);
            this.txtApellidoClienteConsulta.TabIndex = 1;
            // 
            // txtNombreClienteConsulta
            // 
            this.txtNombreClienteConsulta.Location = new System.Drawing.Point(120, 30);
            this.txtNombreClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreClienteConsulta.Name = "txtNombreClienteConsulta";
            this.txtNombreClienteConsulta.ReadOnly = true;
            this.txtNombreClienteConsulta.Size = new System.Drawing.Size(116, 21);
            this.txtNombreClienteConsulta.TabIndex = 2;
            // 
            // lblDniClienteBusqueda
            // 
            this.lblDniClienteBusqueda.AutoSize = true;
            this.lblDniClienteBusqueda.Location = new System.Drawing.Point(37, 30);
            this.lblDniClienteBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniClienteBusqueda.Name = "lblDniClienteBusqueda";
            this.lblDniClienteBusqueda.Size = new System.Drawing.Size(33, 16);
            this.lblDniClienteBusqueda.TabIndex = 3;
            this.lblDniClienteBusqueda.Text = "DNI:";
            // 
            // mskDniClienteBusqueda
            // 
            this.mskDniClienteBusqueda.Location = new System.Drawing.Point(100, 30);
            this.mskDniClienteBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskDniClienteBusqueda.Mask = "99999999";
            this.mskDniClienteBusqueda.Name = "mskDniClienteBusqueda";
            this.mskDniClienteBusqueda.Size = new System.Drawing.Size(116, 21);
            this.mskDniClienteBusqueda.TabIndex = 4;
            // 
            // mrcBusquedaCliente
            // 
            this.mrcBusquedaCliente.Controls.Add(this.button1);
            this.mrcBusquedaCliente.Controls.Add(this.btnBuscarCliente);
            this.mrcBusquedaCliente.Controls.Add(this.lblDniClienteBusqueda);
            this.mrcBusquedaCliente.Controls.Add(this.mskDniClienteBusqueda);
            this.mrcBusquedaCliente.Controls.Add(this.txtDniClienteBusqueda);
            this.mrcBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcBusquedaCliente.Location = new System.Drawing.Point(9, 14);
            this.mrcBusquedaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcBusquedaCliente.Name = "mrcBusquedaCliente";
            this.mrcBusquedaCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcBusquedaCliente.Size = new System.Drawing.Size(271, 102);
            this.mrcBusquedaCliente.TabIndex = 5;
            this.mrcBusquedaCliente.TabStop = false;
            this.mrcBusquedaCliente.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(140, 60);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(77, 27);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.Controls.Add(this.lstActividadClienteConsulta);
            this.mrcDatosClientes.Controls.Add(this.lstBarrioConsultaCliente);
            this.mrcDatosClientes.Controls.Add(this.txtDireccionConsultaCliente);
            this.mrcDatosClientes.Controls.Add(this.lblDireccionClienteConsulta);
            this.mrcDatosClientes.Controls.Add(this.lblDni);
            this.mrcDatosClientes.Controls.Add(this.txtDni);
            this.mrcDatosClientes.Controls.Add(this.lblActividad);
            this.mrcDatosClientes.Controls.Add(this.lblSaldoClienteConsulta);
            this.mrcDatosClientes.Controls.Add(this.lblBarrio);
            this.mrcDatosClientes.Controls.Add(this.txtSaldoClienteConsulta);
            this.mrcDatosClientes.Controls.Add(this.txtApellidoClienteConsulta);
            this.mrcDatosClientes.Controls.Add(this.txtNombreClienteConsulta);
            this.mrcDatosClientes.Controls.Add(this.lblApellidoCliente);
            this.mrcDatosClientes.Controls.Add(this.lblNombreClienteConsulta);
            this.mrcDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatosClientes.Location = new System.Drawing.Point(9, 122);
            this.mrcDatosClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatosClientes.Size = new System.Drawing.Size(271, 245);
            this.mrcDatosClientes.TabIndex = 6;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Datos del Cliente";
            // 
            // txtDireccionConsultaCliente
            // 
            this.txtDireccionConsultaCliente.Location = new System.Drawing.Point(120, 153);
            this.txtDireccionConsultaCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccionConsultaCliente.Name = "txtDireccionConsultaCliente";
            this.txtDireccionConsultaCliente.ReadOnly = true;
            this.txtDireccionConsultaCliente.Size = new System.Drawing.Size(116, 21);
            this.txtDireccionConsultaCliente.TabIndex = 17;
            // 
            // lblDireccionClienteConsulta
            // 
            this.lblDireccionClienteConsulta.AutoSize = true;
            this.lblDireccionClienteConsulta.Location = new System.Drawing.Point(37, 153);
            this.lblDireccionClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionClienteConsulta.Name = "lblDireccionClienteConsulta";
            this.lblDireccionClienteConsulta.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionClienteConsulta.TabIndex = 16;
            this.lblDireccionClienteConsulta.Text = "Dirección:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(37, 92);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 16);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(120, 92);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(116, 21);
            this.txtDni.TabIndex = 14;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(37, 183);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(66, 16);
            this.lblActividad.TabIndex = 12;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblSaldoClienteConsulta
            // 
            this.lblSaldoClienteConsulta.AutoSize = true;
            this.lblSaldoClienteConsulta.Location = new System.Drawing.Point(37, 214);
            this.lblSaldoClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoClienteConsulta.Name = "lblSaldoClienteConsulta";
            this.lblSaldoClienteConsulta.Size = new System.Drawing.Size(46, 16);
            this.lblSaldoClienteConsulta.TabIndex = 8;
            this.lblSaldoClienteConsulta.Text = "Saldo:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(37, 123);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(46, 16);
            this.lblBarrio.TabIndex = 10;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtSaldoClienteConsulta
            // 
            this.txtSaldoClienteConsulta.Location = new System.Drawing.Point(120, 214);
            this.txtSaldoClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldoClienteConsulta.Name = "txtSaldoClienteConsulta";
            this.txtSaldoClienteConsulta.ReadOnly = true;
            this.txtSaldoClienteConsulta.Size = new System.Drawing.Size(116, 21);
            this.txtSaldoClienteConsulta.TabIndex = 9;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(36, 61);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(60, 16);
            this.lblApellidoCliente.TabIndex = 7;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreClienteConsulta
            // 
            this.lblNombreClienteConsulta.AutoSize = true;
            this.lblNombreClienteConsulta.Location = new System.Drawing.Point(37, 30);
            this.lblNombreClienteConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreClienteConsulta.Name = "lblNombreClienteConsulta";
            this.lblNombreClienteConsulta.Size = new System.Drawing.Size(59, 16);
            this.lblNombreClienteConsulta.TabIndex = 7;
            this.lblNombreClienteConsulta.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(9, 373);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(105, 373);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 27);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(201, 373);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 27);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstBarrioConsultaCliente
            // 
            this.lstBarrioConsultaCliente.Enabled = false;
            this.lstBarrioConsultaCliente.FormattingEnabled = true;
            this.lstBarrioConsultaCliente.Location = new System.Drawing.Point(120, 123);
            this.lstBarrioConsultaCliente.Name = "lstBarrioConsultaCliente";
            this.lstBarrioConsultaCliente.Size = new System.Drawing.Size(116, 23);
            this.lstBarrioConsultaCliente.TabIndex = 10;
            // 
            // lstActividadClienteConsulta
            // 
            this.lstActividadClienteConsulta.Enabled = false;
            this.lstActividadClienteConsulta.FormattingEnabled = true;
            this.lstActividadClienteConsulta.Location = new System.Drawing.Point(120, 183);
            this.lstActividadClienteConsulta.Name = "lstActividadClienteConsulta";
            this.lstActividadClienteConsulta.Size = new System.Drawing.Size(116, 23);
            this.lstActividadClienteConsulta.TabIndex = 18;
            // 
            // frmGestionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 506);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.mrcDatosClientes);
            this.Controls.Add(this.mrcBusquedaCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGestionarCliente";
            this.Text = "Gestión Clientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            this.mrcBusquedaCliente.ResumeLayout(false);
            this.mrcBusquedaCliente.PerformLayout();
            this.mrcDatosClientes.ResumeLayout(false);
            this.mrcDatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDniClienteBusqueda;
        private System.Windows.Forms.TextBox txtApellidoClienteConsulta;
        private System.Windows.Forms.TextBox txtNombreClienteConsulta;
        private System.Windows.Forms.Label lblDniClienteBusqueda;
        private System.Windows.Forms.MaskedTextBox mskDniClienteBusqueda;
        private System.Windows.Forms.GroupBox mrcBusquedaCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreClienteConsulta;
        private System.Windows.Forms.TextBox txtSaldoClienteConsulta;
        private System.Windows.Forms.Label lblSaldoClienteConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccionConsultaCliente;
        private System.Windows.Forms.Label lblDireccionClienteConsulta;
        private System.Windows.Forms.ComboBox lstBarrioConsultaCliente;
        private System.Windows.Forms.ComboBox lstActividadClienteConsulta;
    }
}
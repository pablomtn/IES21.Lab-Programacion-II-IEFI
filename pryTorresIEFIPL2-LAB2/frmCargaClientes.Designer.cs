namespace pryTorresIEFIPL2_LAB2
{
    partial class frmCargaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaClientes));
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblActividadCliente = new System.Windows.Forms.Label();
            this.lstActividadCliente = new System.Windows.Forms.ComboBox();
            this.lblBarrioCliente = new System.Windows.Forms.Label();
            this.lstBarrioCliente = new System.Windows.Forms.ComboBox();
            this.mrcCargaClientes = new System.Windows.Forms.GroupBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.mskDniCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcCargaClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(117, 31);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombreCliente.MaxLength = 20;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(116, 21);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(117, 58);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtApellidoCliente.MaxLength = 20;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(116, 21);
            this.txtApellidoCliente.TabIndex = 2;
            this.txtApellidoCliente.TextChanged += new System.EventHandler(this.txtApellidoCliente_TextChanged);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Enabled = false;
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(146, 256);
            this.btnCargarCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(105, 28);
            this.btnCargarCliente.TabIndex = 8;
            this.btnCargarCliente.Text = "Cargar";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(7, 31);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoNombre.Location = new System.Drawing.Point(7, 58);
            this.lblApellidoNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(60, 16);
            this.lblApellidoNombre.TabIndex = 5;
            this.lblApellidoNombre.Text = "Apellido:";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(7, 85);
            this.lblDniCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(33, 16);
            this.lblDniCliente.TabIndex = 6;
            this.lblDniCliente.Text = "DNI:";
            // 
            // lblActividadCliente
            // 
            this.lblActividadCliente.AutoSize = true;
            this.lblActividadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividadCliente.Location = new System.Drawing.Point(7, 168);
            this.lblActividadCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblActividadCliente.Name = "lblActividadCliente";
            this.lblActividadCliente.Size = new System.Drawing.Size(63, 16);
            this.lblActividadCliente.TabIndex = 7;
            this.lblActividadCliente.Text = "Actividad";
            // 
            // lstActividadCliente
            // 
            this.lstActividadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividadCliente.FormattingEnabled = true;
            this.lstActividadCliente.Location = new System.Drawing.Point(117, 168);
            this.lstActividadCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lstActividadCliente.Name = "lstActividadCliente";
            this.lstActividadCliente.Size = new System.Drawing.Size(116, 23);
            this.lstActividadCliente.TabIndex = 6;
            this.lstActividadCliente.SelectedIndexChanged += new System.EventHandler(this.lstActividadCliente_SelectedIndexChanged);
            // 
            // lblBarrioCliente
            // 
            this.lblBarrioCliente.AutoSize = true;
            this.lblBarrioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrioCliente.Location = new System.Drawing.Point(7, 112);
            this.lblBarrioCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBarrioCliente.Name = "lblBarrioCliente";
            this.lblBarrioCliente.Size = new System.Drawing.Size(46, 16);
            this.lblBarrioCliente.TabIndex = 11;
            this.lblBarrioCliente.Text = "Barrio:";
            // 
            // lstBarrioCliente
            // 
            this.lstBarrioCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBarrioCliente.FormattingEnabled = true;
            this.lstBarrioCliente.Location = new System.Drawing.Point(117, 112);
            this.lstBarrioCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lstBarrioCliente.Name = "lstBarrioCliente";
            this.lstBarrioCliente.Size = new System.Drawing.Size(116, 23);
            this.lstBarrioCliente.TabIndex = 4;
            this.lstBarrioCliente.SelectedIndexChanged += new System.EventHandler(this.lstBarrioCliente_SelectedIndexChanged);
            // 
            // mrcCargaClientes
            // 
            this.mrcCargaClientes.Controls.Add(this.txtDireccionCliente);
            this.mrcCargaClientes.Controls.Add(this.lblDireccionCliente);
            this.mrcCargaClientes.Controls.Add(this.lblSaldoCliente);
            this.mrcCargaClientes.Controls.Add(this.txtSaldoCliente);
            this.mrcCargaClientes.Controls.Add(this.mskDniCliente);
            this.mrcCargaClientes.Controls.Add(this.lblNombreCliente);
            this.mrcCargaClientes.Controls.Add(this.lstBarrioCliente);
            this.mrcCargaClientes.Controls.Add(this.txtNombreCliente);
            this.mrcCargaClientes.Controls.Add(this.lblBarrioCliente);
            this.mrcCargaClientes.Controls.Add(this.txtApellidoCliente);
            this.mrcCargaClientes.Controls.Add(this.lstActividadCliente);
            this.mrcCargaClientes.Controls.Add(this.lblApellidoNombre);
            this.mrcCargaClientes.Controls.Add(this.lblActividadCliente);
            this.mrcCargaClientes.Controls.Add(this.lblDniCliente);
            this.mrcCargaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaClientes.Location = new System.Drawing.Point(7, 14);
            this.mrcCargaClientes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mrcCargaClientes.Name = "mrcCargaClientes";
            this.mrcCargaClientes.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mrcCargaClientes.Size = new System.Drawing.Size(244, 236);
            this.mrcCargaClientes.TabIndex = 13;
            this.mrcCargaClientes.TabStop = false;
            this.mrcCargaClientes.Text = "Datos Cliente";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(117, 141);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccionCliente.MaxLength = 20;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(116, 21);
            this.txtDireccionCliente.TabIndex = 5;
            this.txtDireccionCliente.TextChanged += new System.EventHandler(this.txtDireccionCliente_TextChanged);
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(7, 141);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionCliente.TabIndex = 17;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCliente.Location = new System.Drawing.Point(7, 197);
            this.lblSaldoCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(46, 16);
            this.lblSaldoCliente.TabIndex = 15;
            this.lblSaldoCliente.Text = "Saldo:";
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Location = new System.Drawing.Point(117, 197);
            this.txtSaldoCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.Size = new System.Drawing.Size(116, 21);
            this.txtSaldoCliente.TabIndex = 7;
            this.txtSaldoCliente.TextChanged += new System.EventHandler(this.txtSaldoCliente_TextChanged);
            this.txtSaldoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoCliente_KeyPress);
            // 
            // mskDniCliente
            // 
            this.mskDniCliente.Location = new System.Drawing.Point(117, 85);
            this.mskDniCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mskDniCliente.Mask = "99999999";
            this.mskDniCliente.Name = "mskDniCliente";
            this.mskDniCliente.Size = new System.Drawing.Size(116, 21);
            this.mskDniCliente.TabIndex = 3;
            this.mskDniCliente.TextChanged += new System.EventHandler(this.mskDniCliente_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(7, 256);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCargaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 292);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcCargaClientes);
            this.Controls.Add(this.btnCargarCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmCargaClientes";
            this.Text = "Carga Clientes";
            this.Load += new System.EventHandler(this.frmCargaClientes_Load);
            this.mrcCargaClientes.ResumeLayout(false);
            this.mrcCargaClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblActividadCliente;
        private System.Windows.Forms.ComboBox lstActividadCliente;
        private System.Windows.Forms.Label lblBarrioCliente;
        private System.Windows.Forms.ComboBox lstBarrioCliente;
        private System.Windows.Forms.GroupBox mrcCargaClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mskDniCliente;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
    }
}
namespace pryTorresIEFIPL2_LAB2
{
    partial class frmConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientes));
            this.dgvConsultaClientes = new System.Windows.Forms.DataGridView();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSeis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSiete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.mrcListarClientes = new System.Windows.Forms.GroupBox();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.lblSaldoMayor = new System.Windows.Forms.Label();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            this.txtPromedioSaldos = new System.Windows.Forms.TextBox();
            this.txtTotalSaldos = new System.Windows.Forms.TextBox();
            this.txtSaldoMayor = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtSaldoMenor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).BeginInit();
            this.mrcListarClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaClientes
            // 
            this.dgvConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos,
            this.columnaTres,
            this.columnaSeis,
            this.columnaSiete,
            this.columnaCinco,
            this.columnaCuatro});
            this.dgvConsultaClientes.Location = new System.Drawing.Point(6, 22);
            this.dgvConsultaClientes.Name = "dgvConsultaClientes";
            this.dgvConsultaClientes.Size = new System.Drawing.Size(742, 150);
            this.dgvConsultaClientes.TabIndex = 0;
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "DNI";
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Nombre";
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            // 
            // columnaTres
            // 
            this.columnaTres.HeaderText = "Apellido";
            this.columnaTres.Name = "columnaTres";
            this.columnaTres.ReadOnly = true;
            // 
            // columnaSeis
            // 
            this.columnaSeis.HeaderText = "Barrio";
            this.columnaSeis.Name = "columnaSeis";
            this.columnaSeis.ReadOnly = true;
            // 
            // columnaSiete
            // 
            this.columnaSiete.HeaderText = "Dirección";
            this.columnaSiete.Name = "columnaSiete";
            this.columnaSiete.ReadOnly = true;
            // 
            // columnaCinco
            // 
            this.columnaCinco.HeaderText = "Actividad";
            this.columnaCinco.Name = "columnaCinco";
            this.columnaCinco.ReadOnly = true;
            // 
            // columnaCuatro
            // 
            this.columnaCuatro.HeaderText = "Saldo";
            this.columnaCuatro.Name = "columnaCuatro";
            this.columnaCuatro.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(435, 178);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(313, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // mrcListarClientes
            // 
            this.mrcListarClientes.Controls.Add(this.lblSaldoMenor);
            this.mrcListarClientes.Controls.Add(this.lblCantidadClientes);
            this.mrcListarClientes.Controls.Add(this.lblTotalSaldos);
            this.mrcListarClientes.Controls.Add(this.lblPromedioSaldos);
            this.mrcListarClientes.Controls.Add(this.lblSaldoMayor);
            this.mrcListarClientes.Controls.Add(this.txtCantidadClientes);
            this.mrcListarClientes.Controls.Add(this.txtPromedioSaldos);
            this.mrcListarClientes.Controls.Add(this.txtTotalSaldos);
            this.mrcListarClientes.Controls.Add(this.txtSaldoMayor);
            this.mrcListarClientes.Controls.Add(this.btnSalir);
            this.mrcListarClientes.Controls.Add(this.txtSaldoMenor);
            this.mrcListarClientes.Controls.Add(this.dgvConsultaClientes);
            this.mrcListarClientes.Controls.Add(this.btnListar);
            this.mrcListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcListarClientes.Location = new System.Drawing.Point(12, 12);
            this.mrcListarClientes.Name = "mrcListarClientes";
            this.mrcListarClientes.Size = new System.Drawing.Size(761, 298);
            this.mrcListarClientes.TabIndex = 3;
            this.mrcListarClientes.TabStop = false;
            this.mrcListarClientes.Text = "Clientes:";
            this.mrcListarClientes.Enter += new System.EventHandler(this.mrcListarClientes_Enter);
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.AutoSize = true;
            this.lblSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor.Location = new System.Drawing.Point(6, 242);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(87, 16);
            this.lblSaldoMenor.TabIndex = 6;
            this.lblSaldoMenor.Text = "Saldo Menor:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.Location = new System.Drawing.Point(514, 242);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(92, 16);
            this.lblCantidadClientes.TabIndex = 1;
            this.lblCantidadClientes.Text = "Total Clientes:";
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos.Location = new System.Drawing.Point(514, 214);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(87, 16);
            this.lblTotalSaldos.TabIndex = 0;
            this.lblTotalSaldos.Text = "Total Saldos:";
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.AutoSize = true;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(6, 214);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(115, 16);
            this.lblPromedioSaldos.TabIndex = 2;
            this.lblPromedioSaldos.Text = "Promedio Saldos:";
            // 
            // lblSaldoMayor
            // 
            this.lblSaldoMayor.AutoSize = true;
            this.lblSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMayor.Location = new System.Drawing.Point(6, 270);
            this.lblSaldoMayor.Name = "lblSaldoMayor";
            this.lblSaldoMayor.Size = new System.Drawing.Size(87, 16);
            this.lblSaldoMayor.TabIndex = 7;
            this.lblSaldoMayor.Text = "Saldo Mayor:";
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadClientes.Location = new System.Drawing.Point(631, 237);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.ReadOnly = true;
            this.txtCantidadClientes.Size = new System.Drawing.Size(115, 21);
            this.txtCantidadClientes.TabIndex = 4;
            // 
            // txtPromedioSaldos
            // 
            this.txtPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioSaldos.Location = new System.Drawing.Point(127, 214);
            this.txtPromedioSaldos.Name = "txtPromedioSaldos";
            this.txtPromedioSaldos.ReadOnly = true;
            this.txtPromedioSaldos.Size = new System.Drawing.Size(115, 21);
            this.txtPromedioSaldos.TabIndex = 5;
            // 
            // txtTotalSaldos
            // 
            this.txtTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSaldos.Location = new System.Drawing.Point(631, 209);
            this.txtTotalSaldos.Name = "txtTotalSaldos";
            this.txtTotalSaldos.ReadOnly = true;
            this.txtTotalSaldos.Size = new System.Drawing.Size(115, 21);
            this.txtTotalSaldos.TabIndex = 3;
            // 
            // txtSaldoMayor
            // 
            this.txtSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoMayor.Location = new System.Drawing.Point(127, 270);
            this.txtSaldoMayor.Name = "txtSaldoMayor";
            this.txtSaldoMayor.ReadOnly = true;
            this.txtSaldoMayor.Size = new System.Drawing.Size(115, 21);
            this.txtSaldoMayor.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 178);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(313, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtSaldoMenor
            // 
            this.txtSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoMenor.Location = new System.Drawing.Point(127, 242);
            this.txtSaldoMenor.Name = "txtSaldoMenor";
            this.txtSaldoMenor.ReadOnly = true;
            this.txtSaldoMenor.Size = new System.Drawing.Size(115, 21);
            this.txtSaldoMenor.TabIndex = 8;
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 317);
            this.Controls.Add(this.mrcListarClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaClientes";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).EndInit();
            this.mrcListarClientes.ResumeLayout(false);
            this.mrcListarClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaClientes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox mrcListarClientes;
        private System.Windows.Forms.TextBox txtPromedioSaldos;
        private System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.TextBox txtTotalSaldos;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSeis;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSiete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCuatro;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.TextBox txtSaldoMenor;
        private System.Windows.Forms.TextBox txtSaldoMayor;
    }
}
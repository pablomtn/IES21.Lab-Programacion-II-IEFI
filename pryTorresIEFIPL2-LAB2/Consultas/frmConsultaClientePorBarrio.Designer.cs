namespace pryTorresIEFIPL2_LAB2
{
    partial class frmConsultaClientePorBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientePorBarrio));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnReportar = new System.Windows.Forms.Button();
            this.btnListarPorBarrio = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.columnaCero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstBarrioConsulta = new System.Windows.Forms.ComboBox();
            this.lblBarrioConsulta = new System.Windows.Forms.Label();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(20, 239);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 28);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnReportar
            // 
            this.btnReportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportar.Location = new System.Drawing.Point(183, 239);
            this.btnReportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(129, 28);
            this.btnReportar.TabIndex = 10;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // btnListarPorBarrio
            // 
            this.btnListarPorBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPorBarrio.Location = new System.Drawing.Point(345, 239);
            this.btnListarPorBarrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarPorBarrio.Name = "btnListarPorBarrio";
            this.btnListarPorBarrio.Size = new System.Drawing.Size(129, 28);
            this.btnListarPorBarrio.TabIndex = 9;
            this.btnListarPorBarrio.Text = "Listar";
            this.btnListarPorBarrio.UseVisualStyleBackColor = true;
            this.btnListarPorBarrio.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCero,
            this.columnaUno,
            this.columnaDos});
            this.dgvConsulta.Location = new System.Drawing.Point(20, 47);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(455, 185);
            this.dgvConsulta.TabIndex = 8;
            // 
            // columnaCero
            // 
            this.columnaCero.HeaderText = "DNI";
            this.columnaCero.MinimumWidth = 6;
            this.columnaCero.Name = "columnaCero";
            this.columnaCero.ReadOnly = true;
            this.columnaCero.Width = 125;
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "Nombre";
            this.columnaUno.MinimumWidth = 6;
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            this.columnaUno.Width = 125;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Apellido";
            this.columnaDos.MinimumWidth = 6;
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            this.columnaDos.Width = 125;
            // 
            // lstBarrioConsulta
            // 
            this.lstBarrioConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrioConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBarrioConsulta.FormattingEnabled = true;
            this.lstBarrioConsulta.Location = new System.Drawing.Point(225, 11);
            this.lstBarrioConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBarrioConsulta.Name = "lstBarrioConsulta";
            this.lstBarrioConsulta.Size = new System.Drawing.Size(248, 26);
            this.lstBarrioConsulta.TabIndex = 7;
            this.lstBarrioConsulta.SelectedIndexChanged += new System.EventHandler(this.lstBarrioConsulta_SelectedIndexChanged);
            // 
            // lblBarrioConsulta
            // 
            this.lblBarrioConsulta.AutoSize = true;
            this.lblBarrioConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrioConsulta.Location = new System.Drawing.Point(16, 11);
            this.lblBarrioConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrioConsulta.Name = "lblBarrioConsulta";
            this.lblBarrioConsulta.Size = new System.Drawing.Size(153, 20);
            this.lblBarrioConsulta.TabIndex = 6;
            this.lblBarrioConsulta.Text = "Seleccione el Barrio:";
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmConsultaClientePorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 277);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.btnListarPorBarrio);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lstBarrioConsulta);
            this.Controls.Add(this.lblBarrioConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaClientePorBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta por Barrio";
            this.Load += new System.EventHandler(this.frmConsultaClientePorBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Button btnListarPorBarrio;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCero;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.ComboBox lstBarrioConsulta;
        private System.Windows.Forms.Label lblBarrioConsulta;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}
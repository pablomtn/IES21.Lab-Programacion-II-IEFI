namespace pryTorresIEFIPL2_LAB2
{
    partial class frmConsultaClientePorActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientePorActividad));
            this.lblActiviadadConsulta = new System.Windows.Forms.Label();
            this.lstActividadConsulta = new System.Windows.Forms.ComboBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.columnaCero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarPorActividad = new System.Windows.Forms.Button();
            this.btnReportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActiviadadConsulta
            // 
            this.lblActiviadadConsulta.AutoSize = true;
            this.lblActiviadadConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiviadadConsulta.Location = new System.Drawing.Point(16, 11);
            this.lblActiviadadConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiviadadConsulta.Name = "lblActiviadadConsulta";
            this.lblActiviadadConsulta.Size = new System.Drawing.Size(175, 20);
            this.lblActiviadadConsulta.TabIndex = 0;
            this.lblActiviadadConsulta.Text = "Seleccione la Actividad:\r\n";
            // 
            // lstActividadConsulta
            // 
            this.lstActividadConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividadConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividadConsulta.FormattingEnabled = true;
            this.lstActividadConsulta.Location = new System.Drawing.Point(225, 11);
            this.lstActividadConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstActividadConsulta.Name = "lstActividadConsulta";
            this.lstActividadConsulta.Size = new System.Drawing.Size(248, 26);
            this.lstActividadConsulta.TabIndex = 1;
            this.lstActividadConsulta.SelectedIndexChanged += new System.EventHandler(this.lstActividadConsulta_SelectedIndexChanged);
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
            this.dgvConsulta.TabIndex = 2;
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
            // btnListarPorActividad
            // 
            this.btnListarPorActividad.Enabled = false;
            this.btnListarPorActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPorActividad.Location = new System.Drawing.Point(345, 239);
            this.btnListarPorActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarPorActividad.Name = "btnListarPorActividad";
            this.btnListarPorActividad.Size = new System.Drawing.Size(129, 28);
            this.btnListarPorActividad.TabIndex = 3;
            this.btnListarPorActividad.Text = "Listar";
            this.btnListarPorActividad.UseVisualStyleBackColor = true;
            this.btnListarPorActividad.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnReportar
            // 
            this.btnReportar.Enabled = false;
            this.btnReportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportar.Location = new System.Drawing.Point(183, 239);
            this.btnReportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(129, 28);
            this.btnReportar.TabIndex = 4;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(20, 239);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 28);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmConsultaClientePorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 277);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.btnListarPorActividad);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lstActividadConsulta);
            this.Controls.Add(this.lblActiviadadConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaClientePorActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta por Actividad";
            this.Load += new System.EventHandler(this.frmConsultaClientePorActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActiviadadConsulta;
        private System.Windows.Forms.ComboBox lstActividadConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCero;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.Button btnListarPorActividad;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}
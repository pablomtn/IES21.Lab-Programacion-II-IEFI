namespace pryTorresIEFIPL2_LAB2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mspPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.gestionarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.striplblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.picPrincipal = new System.Windows.Forms.PictureBox();
            this.mspPrincipal.SuspendLayout();
            this.statusPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // mspPrincipal
            // 
            this.mspPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mspPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.mspPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspPrincipal.Name = "mspPrincipal";
            this.mspPrincipal.Size = new System.Drawing.Size(1193, 29);
            this.mspPrincipal.TabIndex = 0;
            this.mspPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.dToolStripMenuItem,
            this.gestionarClienteToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultarToolStripMenuItem1,
            this.listadoPorActividadToolStripMenuItem,
            this.listadoPorBarrioToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.consultarToolStripMenuItem.Text = "Registrar Cliente";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(237, 6);
            // 
            // gestionarClienteToolStripMenuItem
            // 
            this.gestionarClienteToolStripMenuItem.Name = "gestionarClienteToolStripMenuItem";
            this.gestionarClienteToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.gestionarClienteToolStripMenuItem.Text = "Gestionar Cliente";
            this.gestionarClienteToolStripMenuItem.Click += new System.EventHandler(this.gestionarClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.consultarToolStripMenuItem1.Text = "Listado Total Clientes";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // listadoPorActividadToolStripMenuItem
            // 
            this.listadoPorActividadToolStripMenuItem.Name = "listadoPorActividadToolStripMenuItem";
            this.listadoPorActividadToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.listadoPorActividadToolStripMenuItem.Text = "Listado por Actividad";
            this.listadoPorActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoPorActividadToolStripMenuItem_Click);
            // 
            // listadoPorBarrioToolStripMenuItem
            // 
            this.listadoPorBarrioToolStripMenuItem.Name = "listadoPorBarrioToolStripMenuItem";
            this.listadoPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.listadoPorBarrioToolStripMenuItem.Text = "Listado por Barrio";
            this.listadoPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoPorBarrioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.statusPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.striplblEstado});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 528);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusPrincipal.Size = new System.Drawing.Size(1193, 26);
            this.statusPrincipal.TabIndex = 1;
            this.statusPrincipal.Text = "statusStrip1";
            this.statusPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // striplblEstado
            // 
            this.striplblEstado.Name = "striplblEstado";
            this.striplblEstado.Size = new System.Drawing.Size(151, 20);
            this.striplblEstado.Text = "toolStripStatusLabel2";
            // 
            // picPrincipal
            // 
            this.picPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("picPrincipal.Image")));
            this.picPrincipal.Location = new System.Drawing.Point(0, 29);
            this.picPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPrincipal.Name = "picPrincipal";
            this.picPrincipal.Size = new System.Drawing.Size(1193, 499);
            this.picPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrincipal.TabIndex = 2;
            this.picPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1193, 554);
            this.Controls.Add(this.picPrincipal);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.mspPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mspPrincipal.ResumeLayout(false);
            this.mspPrincipal.PerformLayout();
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gestionarClienteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel striplblEstado;
        private System.Windows.Forms.PictureBox picPrincipal;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPorActividadToolStripMenuItem;
    }
}


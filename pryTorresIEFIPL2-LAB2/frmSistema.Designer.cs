namespace pryTorresIEFIPL2_LAB2
{
    partial class frmSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCorreoSistema = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNumeroContacto = new System.Windows.Forms.Label();
            this.btnVolves = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(152, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.Location = new System.Drawing.Point(266, 12);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(232, 27);
            this.lblNombreSistema.TabIndex = 1;
            this.lblNombreSistema.Text = "Pablo Martin Torres Nara";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(152, 62);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 25);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Contacto:";
            // 
            // lblCorreoSistema
            // 
            this.lblCorreoSistema.AutoSize = true;
            this.lblCorreoSistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorreoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoSistema.Location = new System.Drawing.Point(266, 62);
            this.lblCorreoSistema.Name = "lblCorreoSistema";
            this.lblCorreoSistema.Size = new System.Drawing.Size(236, 27);
            this.lblCorreoSistema.TabIndex = 3;
            this.lblCorreoSistema.Text = "pablo564903@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(152, 112);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(183, 25);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Numero Telefónico:";
            // 
            // lblNumeroContacto
            // 
            this.lblNumeroContacto.AutoSize = true;
            this.lblNumeroContacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeroContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroContacto.Location = new System.Drawing.Point(374, 112);
            this.lblNumeroContacto.Name = "lblNumeroContacto";
            this.lblNumeroContacto.Size = new System.Drawing.Size(124, 27);
            this.lblNumeroContacto.TabIndex = 6;
            this.lblNumeroContacto.Text = "2966222491";
            this.lblNumeroContacto.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVolves
            // 
            this.btnVolves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolves.Location = new System.Drawing.Point(408, 169);
            this.btnVolves.Name = "btnVolves";
            this.btnVolves.Size = new System.Drawing.Size(94, 25);
            this.btnVolves.TabIndex = 7;
            this.btnVolves.Text = "Volver";
            this.btnVolves.UseVisualStyleBackColor = true;
            this.btnVolves.Click += new System.EventHandler(this.btnVolves_Click);
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 206);
            this.Controls.Add(this.btnVolves);
            this.Controls.Add(this.lblNumeroContacto);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCorreoSistema);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistema";
            this.Text = "Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCorreoSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNumeroContacto;
        private System.Windows.Forms.Button btnVolves;
    }
}
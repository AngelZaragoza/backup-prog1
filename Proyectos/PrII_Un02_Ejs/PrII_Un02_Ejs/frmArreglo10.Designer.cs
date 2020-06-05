namespace PrII_Un02_Ejs
{
    partial class frmArreglo10
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskNros = new System.Windows.Forms.MaskedTextBox();
            this.lblNros = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstNros = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskNros
            // 
            this.mskNros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNros.Location = new System.Drawing.Point(19, 56);
            this.mskNros.Mask = "999999999";
            this.mskNros.Name = "mskNros";
            this.mskNros.Size = new System.Drawing.Size(104, 23);
            this.mskNros.TabIndex = 0;
            // 
            // lblNros
            // 
            this.lblNros.AutoSize = true;
            this.lblNros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNros.Location = new System.Drawing.Point(12, 23);
            this.lblNros.Name = "lblNros";
            this.lblNros.Size = new System.Drawing.Size(151, 17);
            this.lblNros.TabIndex = 1;
            this.lblNros.Text = "Ingrese el 1er número:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(19, 106);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 32);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "&Cargar nro";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstNros
            // 
            this.lstNros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNros.FormattingEnabled = true;
            this.lstNros.ItemHeight = 16;
            this.lstNros.Location = new System.Drawing.Point(182, 23);
            this.lstNros.Name = "lstNros";
            this.lstNros.Size = new System.Drawing.Size(185, 196);
            this.lstNros.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(257, 237);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 39);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(19, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmArreglo10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 300);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lstNros);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblNros);
            this.Controls.Add(this.mskNros);
            this.Name = "frmArreglo10";
            this.Text = "Ejercicio 4: Arreglo 10 números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNros;
        private System.Windows.Forms.Label lblNros;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstNros;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
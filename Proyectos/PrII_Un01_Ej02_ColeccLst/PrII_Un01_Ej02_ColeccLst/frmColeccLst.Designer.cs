namespace PrII_Un01_Ej02_ColeccLst
{
    partial class frmColeccLst
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
            this.lstIzquierda = new System.Windows.Forms.ListBox();
            this.lstDerecha = new System.Windows.Forms.ListBox();
            this.btnTodoDerecha = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnTodoIzquierda = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSelec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstIzquierda
            // 
            this.lstIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIzquierda.FormattingEnabled = true;
            this.lstIzquierda.ItemHeight = 16;
            this.lstIzquierda.Location = new System.Drawing.Point(12, 28);
            this.lstIzquierda.Name = "lstIzquierda";
            this.lstIzquierda.Size = new System.Drawing.Size(152, 212);
            this.lstIzquierda.TabIndex = 0;
            // 
            // lstDerecha
            // 
            this.lstDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDerecha.FormattingEnabled = true;
            this.lstDerecha.ItemHeight = 16;
            this.lstDerecha.Location = new System.Drawing.Point(236, 28);
            this.lstDerecha.Name = "lstDerecha";
            this.lstDerecha.Size = new System.Drawing.Size(152, 212);
            this.lstDerecha.TabIndex = 1;
            // 
            // btnTodoDerecha
            // 
            this.btnTodoDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoDerecha.Location = new System.Drawing.Point(174, 28);
            this.btnTodoDerecha.Name = "btnTodoDerecha";
            this.btnTodoDerecha.Size = new System.Drawing.Size(56, 37);
            this.btnTodoDerecha.TabIndex = 2;
            this.btnTodoDerecha.Text = ">>";
            this.btnTodoDerecha.UseVisualStyleBackColor = true;
            this.btnTodoDerecha.Click += new System.EventHandler(this.btnTodoDerecha_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(174, 71);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(56, 37);
            this.btnDerecha.TabIndex = 3;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnTodoIzquierda
            // 
            this.btnTodoIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoIzquierda.Location = new System.Drawing.Point(174, 114);
            this.btnTodoIzquierda.Name = "btnTodoIzquierda";
            this.btnTodoIzquierda.Size = new System.Drawing.Size(56, 37);
            this.btnTodoIzquierda.TabIndex = 4;
            this.btnTodoIzquierda.Text = "<<";
            this.btnTodoIzquierda.UseVisualStyleBackColor = true;
            this.btnTodoIzquierda.Click += new System.EventHandler(this.btnTodoIzquierda_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(174, 157);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(56, 37);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(291, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 27);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelec.Location = new System.Drawing.Point(12, 304);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(200, 17);
            this.lblSelec.TabIndex = 7;
            this.lblSelec.Text = "Debe seleccionar un elemento";
            this.lblSelec.Visible = false;
            // 
            // frmColeccLst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 352);
            this.Controls.Add(this.lblSelec);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnTodoIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnTodoDerecha);
            this.Controls.Add(this.lstDerecha);
            this.Controls.Add(this.lstIzquierda);
            this.Name = "frmColeccLst";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.frmColeccLst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIzquierda;
        private System.Windows.Forms.ListBox lstDerecha;
        private System.Windows.Forms.Button btnTodoDerecha;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnTodoIzquierda;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSelec;
    }
}


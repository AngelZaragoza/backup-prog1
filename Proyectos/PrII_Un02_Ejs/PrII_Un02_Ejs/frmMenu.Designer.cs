namespace PrII_Un02_Ejs
{
    partial class frmMenu
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
            this.btnEjer04 = new System.Windows.Forms.Button();
            this.btnEjer03 = new System.Windows.Forms.Button();
            this.btnEjer05 = new System.Windows.Forms.Button();
            this.btnEjer06 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjer04
            // 
            this.btnEjer04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjer04.Location = new System.Drawing.Point(82, 91);
            this.btnEjer04.Name = "btnEjer04";
            this.btnEjer04.Size = new System.Drawing.Size(286, 38);
            this.btnEjer04.TabIndex = 1;
            this.btnEjer04.Text = "Ejercicio 4: Arreglo de 10 números";
            this.btnEjer04.UseVisualStyleBackColor = true;
            this.btnEjer04.Click += new System.EventHandler(this.btnEjer04_Click);
            // 
            // btnEjer03
            // 
            this.btnEjer03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjer03.Location = new System.Drawing.Point(82, 31);
            this.btnEjer03.Name = "btnEjer03";
            this.btnEjer03.Size = new System.Drawing.Size(286, 38);
            this.btnEjer03.TabIndex = 0;
            this.btnEjer03.Text = "Ejercicio 3: Colecciones Nuevos Sueldos";
            this.btnEjer03.UseVisualStyleBackColor = true;
            this.btnEjer03.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEjer05
            // 
            this.btnEjer05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjer05.Location = new System.Drawing.Point(82, 149);
            this.btnEjer05.Name = "btnEjer05";
            this.btnEjer05.Size = new System.Drawing.Size(286, 38);
            this.btnEjer05.TabIndex = 2;
            this.btnEjer05.Text = "Ejercicio 5: 10 Productos (3 Arreglos)";
            this.btnEjer05.UseVisualStyleBackColor = true;
            this.btnEjer05.Click += new System.EventHandler(this.btnEjer05_Click);
            // 
            // btnEjer06
            // 
            this.btnEjer06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjer06.Location = new System.Drawing.Point(82, 206);
            this.btnEjer06.Name = "btnEjer06";
            this.btnEjer06.Size = new System.Drawing.Size(286, 38);
            this.btnEjer06.TabIndex = 3;
            this.btnEjer06.Text = "Ejercicio 6: 10 Productos (1 arreglo Prods)";
            this.btnEjer06.UseVisualStyleBackColor = true;
            this.btnEjer06.Click += new System.EventHandler(this.btnEjer06_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 359);
            this.Controls.Add(this.btnEjer06);
            this.Controls.Add(this.btnEjer05);
            this.Controls.Add(this.btnEjer03);
            this.Controls.Add(this.btnEjer04);
            this.Name = "frmMenu";
            this.Text = "Ejercicios Guía Unidad 2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnEjer04;
        public System.Windows.Forms.Button btnEjer03;
        public System.Windows.Forms.Button btnEjer05;
        public System.Windows.Forms.Button btnEjer06;

    }
}


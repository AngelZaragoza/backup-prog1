namespace Cl2309_Colecciones
{
    partial class frmColecciones
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
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lstCurso = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarSelecc = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrarDato = new System.Windows.Forms.Button();
            this.btnBorrarSelecc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCurso
            // 
            this.cboCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(18, 22);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(163, 26);
            this.cboCurso.TabIndex = 0;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // lstCurso
            // 
            this.lstCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurso.FormattingEnabled = true;
            this.lstCurso.ItemHeight = 18;
            this.lstCurso.Location = new System.Drawing.Point(323, 22);
            this.lstCurso.Name = "lstCurso";
            this.lstCurso.Size = new System.Drawing.Size(230, 382);
            this.lstCurso.TabIndex = 1;
            this.lstCurso.SelectedIndexChanged += new System.EventHandler(this.lstCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dato";
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(84, 74);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(117, 24);
            this.txtDato.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(221, 70);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(96, 32);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(221, 126);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(96, 32);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicion.Location = new System.Drawing.Point(84, 130);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(117, 24);
            this.txtPosicion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posición";
            // 
            // btnInsertarSelecc
            // 
            this.btnInsertarSelecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarSelecc.Location = new System.Drawing.Point(84, 165);
            this.btnInsertarSelecc.Name = "btnInsertarSelecc";
            this.btnInsertarSelecc.Size = new System.Drawing.Size(232, 35);
            this.btnInsertarSelecc.TabIndex = 8;
            this.btnInsertarSelecc.Text = "Insertar Seleccionado";
            this.btnInsertarSelecc.UseVisualStyleBackColor = true;
            this.btnInsertarSelecc.Click += new System.EventHandler(this.btnInsertarSelecc_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(85, 206);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(232, 35);
            this.btnBorrarTodo.TabIndex = 9;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrarDato
            // 
            this.btnBorrarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDato.Location = new System.Drawing.Point(85, 247);
            this.btnBorrarDato.Name = "btnBorrarDato";
            this.btnBorrarDato.Size = new System.Drawing.Size(232, 35);
            this.btnBorrarDato.TabIndex = 10;
            this.btnBorrarDato.Text = "Borrar Dato";
            this.btnBorrarDato.UseVisualStyleBackColor = true;
            this.btnBorrarDato.Click += new System.EventHandler(this.btnBorrarDato_Click);
            // 
            // btnBorrarSelecc
            // 
            this.btnBorrarSelecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSelecc.Location = new System.Drawing.Point(84, 288);
            this.btnBorrarSelecc.Name = "btnBorrarSelecc";
            this.btnBorrarSelecc.Size = new System.Drawing.Size(232, 35);
            this.btnBorrarSelecc.TabIndex = 11;
            this.btnBorrarSelecc.Text = "Borrar Seleccionado";
            this.btnBorrarSelecc.UseVisualStyleBackColor = true;
            this.btnBorrarSelecc.Click += new System.EventHandler(this.btnBorrarSelecc_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(85, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "Borrar Primero";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(85, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "Borrar Último";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 433);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBorrarSelecc);
            this.Controls.Add(this.btnBorrarDato);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnInsertarSelecc);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCurso);
            this.Controls.Add(this.cboCurso);
            this.Name = "frmColecciones";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.frmColecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ListBox lstCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarSelecc;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrarDato;
        private System.Windows.Forms.Button btnBorrarSelecc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


namespace Parcial_mascotas
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rbtHembra = new System.Windows.Forms.RadioButton();
            this.rbtMacho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtGato = new System.Windows.Forms.RadioButton();
            this.rbtPerro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCargados = new System.Windows.Forms.ListView();
            this.clmNombre = new System.Windows.Forms.ColumnHeader();
            this.clmDuenio = new System.Windows.Forms.ColumnHeader();
            this.clmEdad = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEdadPromedio = new System.Windows.Forms.Label();
            this.lblGatas = new System.Windows.Forms.Label();
            this.lblPerros = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.clmSexo = new System.Windows.Forms.ColumnHeader();
            this.clmTipo = new System.Windows.Forms.ColumnHeader();
            this.grpSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(106, 64);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(150, 20);
            this.txtProp.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(106, 101);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(53, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rbtHembra);
            this.grpSexo.Controls.Add(this.rbtMacho);
            this.grpSexo.Location = new System.Drawing.Point(17, 140);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(91, 77);
            this.grpSexo.TabIndex = 3;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo Mascota";
            // 
            // rbtHembra
            // 
            this.rbtHembra.AutoSize = true;
            this.rbtHembra.Location = new System.Drawing.Point(16, 43);
            this.rbtHembra.Name = "rbtHembra";
            this.rbtHembra.Size = new System.Drawing.Size(62, 17);
            this.rbtHembra.TabIndex = 1;
            this.rbtHembra.TabStop = true;
            this.rbtHembra.Text = "Hembra";
            this.rbtHembra.UseVisualStyleBackColor = true;
            // 
            // rbtMacho
            // 
            this.rbtMacho.AutoSize = true;
            this.rbtMacho.Location = new System.Drawing.Point(16, 20);
            this.rbtMacho.Name = "rbtMacho";
            this.rbtMacho.Size = new System.Drawing.Size(58, 17);
            this.rbtMacho.TabIndex = 0;
            this.rbtMacho.TabStop = true;
            this.rbtMacho.Text = "Macho";
            this.rbtMacho.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtGato);
            this.groupBox1.Controls.Add(this.rbtPerro);
            this.groupBox1.Location = new System.Drawing.Point(128, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Mascota";
            // 
            // rbtGato
            // 
            this.rbtGato.AutoSize = true;
            this.rbtGato.Location = new System.Drawing.Point(17, 44);
            this.rbtGato.Name = "rbtGato";
            this.rbtGato.Size = new System.Drawing.Size(48, 17);
            this.rbtGato.TabIndex = 1;
            this.rbtGato.TabStop = true;
            this.rbtGato.Text = "Gato";
            this.rbtGato.UseVisualStyleBackColor = true;
            // 
            // rbtPerro
            // 
            this.rbtPerro.AutoSize = true;
            this.rbtPerro.Location = new System.Drawing.Point(17, 21);
            this.rbtPerro.Name = "rbtPerro";
            this.rbtPerro.Size = new System.Drawing.Size(50, 17);
            this.rbtPerro.TabIndex = 0;
            this.rbtPerro.TabStop = true;
            this.rbtPerro.Text = "Perro";
            this.rbtPerro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Propietario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edad Mascota";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCargados);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblEdadPromedio);
            this.groupBox2.Controls.Add(this.lblGatas);
            this.groupBox2.Controls.Add(this.lblPerros);
            this.groupBox2.Location = new System.Drawing.Point(264, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 227);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informes";
            // 
            // lstCargados
            // 
            this.lstCargados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNombre,
            this.clmDuenio,
            this.clmEdad,
            this.clmSexo,
            this.clmTipo});
            this.lstCargados.FullRowSelect = true;
            this.lstCargados.Location = new System.Drawing.Point(7, 101);
            this.lstCargados.Name = "lstCargados";
            this.lstCargados.Size = new System.Drawing.Size(283, 115);
            this.lstCargados.TabIndex = 6;
            this.lstCargados.UseCompatibleStateImageBehavior = false;
            this.lstCargados.View = System.Windows.Forms.View.Details;
            // 
            // clmNombre
            // 
            this.clmNombre.Text = "Nombre";
            this.clmNombre.Width = 72;
            // 
            // clmDuenio
            // 
            this.clmDuenio.Text = "Dueño";
            this.clmDuenio.Width = 68;
            // 
            // clmEdad
            // 
            this.clmEdad.Text = "Edad";
            this.clmEdad.Width = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad Promedio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Gatas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porcentaje de Perros";
            // 
            // lblEdadPromedio
            // 
            this.lblEdadPromedio.AutoSize = true;
            this.lblEdadPromedio.Location = new System.Drawing.Point(133, 69);
            this.lblEdadPromedio.Name = "lblEdadPromedio";
            this.lblEdadPromedio.Size = new System.Drawing.Size(33, 13);
            this.lblEdadPromedio.TabIndex = 2;
            this.lblEdadPromedio.Text = " prom";
            // 
            // lblGatas
            // 
            this.lblGatas.AutoSize = true;
            this.lblGatas.Location = new System.Drawing.Point(133, 45);
            this.lblGatas.Name = "lblGatas";
            this.lblGatas.Size = new System.Drawing.Size(36, 13);
            this.lblGatas.TabIndex = 1;
            this.lblGatas.Text = " gatas";
            // 
            // lblPerros
            // 
            this.lblPerros.AutoSize = true;
            this.lblPerros.Location = new System.Drawing.Point(133, 21);
            this.lblPerros.Name = "lblPerros";
            this.lblPerros.Size = new System.Drawing.Size(39, 13);
            this.lblPerros.TabIndex = 0;
            this.lblPerros.Text = " perros";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(80, 245);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 27);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // clmSexo
            // 
            this.clmSexo.Text = "Sexo";
            this.clmSexo.Width = 45;
            // 
            // clmTipo
            // 
            this.clmTipo.Text = "Tipo";
            this.clmTipo.Width = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 299);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtProp);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Registro de Mascotas";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rbtHembra;
        private System.Windows.Forms.RadioButton rbtMacho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtGato;
        private System.Windows.Forms.RadioButton rbtPerro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEdadPromedio;
        private System.Windows.Forms.Label lblGatas;
        private System.Windows.Forms.Label lblPerros;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lstCargados;
        private System.Windows.Forms.ColumnHeader clmNombre;
        private System.Windows.Forms.ColumnHeader clmDuenio;
        private System.Windows.Forms.ColumnHeader clmEdad;
        private System.Windows.Forms.ColumnHeader clmSexo;
        private System.Windows.Forms.ColumnHeader clmTipo;
    }
}


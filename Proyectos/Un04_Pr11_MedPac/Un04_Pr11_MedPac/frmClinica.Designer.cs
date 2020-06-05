namespace Un04_Pr11_MedPac
{
    partial class frmClinica
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cboMedPac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMedicos = new System.Windows.Forms.GroupBox();
            this.lsvMedicos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEspec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPacientes = new System.Windows.Forms.GroupBox();
            this.lsvPacientes = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.txtHisClin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboObSoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.grpMedicos.SuspendLayout();
            this.grpPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cboMedPac);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.grpSexo);
            this.grpDatos.Controls.Add(this.txtTelef);
            this.grpDatos.Controls.Add(this.txtDNI);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(269, 235);
            this.grpDatos.TabIndex = 3;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos personales";
            // 
            // cboMedPac
            // 
            this.cboMedPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedPac.FormattingEnabled = true;
            this.cboMedPac.Items.AddRange(new object[] {
            "Seleccione...",
            "Médico",
            "Paciente"});
            this.cboMedPac.Location = new System.Drawing.Point(88, 190);
            this.cboMedPac.Name = "cboMedPac";
            this.cboMedPac.Size = new System.Drawing.Size(151, 21);
            this.cboMedPac.TabIndex = 13;
            this.cboMedPac.SelectedIndexChanged += new System.EventHandler(this.cboMedPac_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Méd./Pac.?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rbtMasc);
            this.grpSexo.Controls.Add(this.rbtFem);
            this.grpSexo.Location = new System.Drawing.Point(38, 109);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(145, 68);
            this.grpSexo.TabIndex = 11;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(41, 19);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtMasc.TabIndex = 9;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(41, 42);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(71, 17);
            this.rbtFem.TabIndex = 10;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "Femenino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(79, 77);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(104, 20);
            this.txtTelef.TabIndex = 8;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(79, 47);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(104, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teléfono:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpMedicos
            // 
            this.grpMedicos.Controls.Add(this.lsvMedicos);
            this.grpMedicos.Controls.Add(this.txtCosto);
            this.grpMedicos.Controls.Add(this.label6);
            this.grpMedicos.Controls.Add(this.cboEspec);
            this.grpMedicos.Controls.Add(this.label5);
            this.grpMedicos.Enabled = false;
            this.grpMedicos.Location = new System.Drawing.Point(12, 253);
            this.grpMedicos.Name = "grpMedicos";
            this.grpMedicos.Size = new System.Drawing.Size(269, 235);
            this.grpMedicos.TabIndex = 4;
            this.grpMedicos.TabStop = false;
            this.grpMedicos.Text = "Datos Médicos";
            // 
            // lsvMedicos
            // 
            this.lsvMedicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvMedicos.FullRowSelect = true;
            this.lsvMedicos.Location = new System.Drawing.Point(9, 89);
            this.lsvMedicos.Name = "lsvMedicos";
            this.lsvMedicos.Size = new System.Drawing.Size(254, 134);
            this.lsvMedicos.TabIndex = 18;
            this.lsvMedicos.UseCompatibleStateImageBehavior = false;
            this.lsvMedicos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Especialidad";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "$ Consulta";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(95, 49);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(80, 20);
            this.txtCosto.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Costo Consulta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEspec
            // 
            this.cboEspec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspec.FormattingEnabled = true;
            this.cboEspec.Items.AddRange(new object[] {
            "Seleccione una...",
            "Clínica",
            "Ginecología",
            "Neurología",
            "Urología",
            "Pediatría",
            "Reumatología",
            "Traumatología",
            ""});
            this.cboEspec.Location = new System.Drawing.Point(95, 19);
            this.cboEspec.Name = "cboEspec";
            this.cboEspec.Size = new System.Drawing.Size(151, 21);
            this.cboEspec.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Especialidad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpPacientes
            // 
            this.grpPacientes.Controls.Add(this.lsvPacientes);
            this.grpPacientes.Controls.Add(this.txtHisClin);
            this.grpPacientes.Controls.Add(this.label7);
            this.grpPacientes.Controls.Add(this.cboObSoc);
            this.grpPacientes.Controls.Add(this.label8);
            this.grpPacientes.Enabled = false;
            this.grpPacientes.Location = new System.Drawing.Point(298, 253);
            this.grpPacientes.Name = "grpPacientes";
            this.grpPacientes.Size = new System.Drawing.Size(269, 235);
            this.grpPacientes.TabIndex = 5;
            this.grpPacientes.TabStop = false;
            this.grpPacientes.Text = "Datos Paciente";
            // 
            // lsvPacientes
            // 
            this.lsvPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvPacientes.Location = new System.Drawing.Point(9, 89);
            this.lsvPacientes.Name = "lsvPacientes";
            this.lsvPacientes.Size = new System.Drawing.Size(254, 134);
            this.lsvPacientes.TabIndex = 18;
            this.lsvPacientes.UseCompatibleStateImageBehavior = false;
            this.lsvPacientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Obra Social";
            this.columnHeader5.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hist.Clínica";
            this.columnHeader6.Width = 66;
            // 
            // txtHisClin
            // 
            this.txtHisClin.Location = new System.Drawing.Point(95, 49);
            this.txtHisClin.Name = "txtHisClin";
            this.txtHisClin.Size = new System.Drawing.Size(80, 20);
            this.txtHisClin.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hist. Clínica:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboObSoc
            // 
            this.cboObSoc.FormattingEnabled = true;
            this.cboObSoc.Items.AddRange(new object[] {
            "Seleccione una...",
            "APROSS",
            "IOSE",
            "OSDE",
            "OSECAC",
            "SIPPSA"});
            this.cboObSoc.Location = new System.Drawing.Point(95, 19);
            this.cboObSoc.Name = "cboObSoc";
            this.cboObSoc.Size = new System.Drawing.Size(151, 21);
            this.cboObSoc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(22, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Obra Social:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMedico
            // 
            this.btnMedico.Enabled = false;
            this.btnMedico.Location = new System.Drawing.Point(358, 24);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(141, 36);
            this.btnMedico.TabIndex = 6;
            this.btnMedico.Text = "Guardar &Médico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Enabled = false;
            this.btnPaciente.Location = new System.Drawing.Point(358, 81);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(141, 36);
            this.btnPaciente.TabIndex = 7;
            this.btnPaciente.Text = "Guardar &Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 153);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 491);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.grpPacientes);
            this.Controls.Add(this.grpMedicos);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmClinica";
            this.Text = "Sistema Clínica";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpMedicos.ResumeLayout(false);
            this.grpMedicos.PerformLayout();
            this.grpPacientes.ResumeLayout(false);
            this.grpPacientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMedPac;
        private System.Windows.Forms.GroupBox grpMedicos;
        private System.Windows.Forms.ComboBox cboEspec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lsvMedicos;
        private System.Windows.Forms.GroupBox grpPacientes;
        private System.Windows.Forms.ListView lsvPacientes;
        private System.Windows.Forms.TextBox txtHisClin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboObSoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;

    }
}


namespace Prog_equipos
{
    partial class frmTorneo
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblCantCba = new System.Windows.Forms.Label();
            this.lblPorcTuc = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblMayGolConB = new System.Windows.Forms.Label();
            this.lblMayGolFavA = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblGC = new System.Windows.Forms.Label();
            this.txtGolesCon = new System.Windows.Forms.TextBox();
            this.lblGF = new System.Windows.Forms.Label();
            this.txtGolesFav = new System.Windows.Forms.TextBox();
            this.lblPtos = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpCateg = new System.Windows.Forms.GroupBox();
            this.rbtCatB = new System.Windows.Forms.RadioButton();
            this.rbtCatA = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dteFechaInsc = new System.Windows.Forms.DateTimePicker();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboPcia = new System.Windows.Forms.ComboBox();
            this.txtNomEq = new System.Windows.Forms.TextBox();
            this.grpInfo.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpCateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblCantCba);
            this.grpInfo.Controls.Add(this.lblPorcTuc);
            this.grpInfo.Controls.Add(this.lblInfo4);
            this.grpInfo.Controls.Add(this.lblInfo3);
            this.grpInfo.Controls.Add(this.lblMayGolConB);
            this.grpInfo.Controls.Add(this.lblMayGolFavA);
            this.grpInfo.Controls.Add(this.lblInfo2);
            this.grpInfo.Controls.Add(this.lblInfo1);
            this.grpInfo.Location = new System.Drawing.Point(12, 220);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(486, 145);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Información Registrada";
            // 
            // lblCantCba
            // 
            this.lblCantCba.AutoSize = true;
            this.lblCantCba.Location = new System.Drawing.Point(228, 122);
            this.lblCantCba.Name = "lblCantCba";
            this.lblCantCba.Size = new System.Drawing.Size(73, 13);
            this.lblCantCba.TabIndex = 7;
            this.lblCantCba.Text = "                      ";
            // 
            // lblPorcTuc
            // 
            this.lblPorcTuc.AutoSize = true;
            this.lblPorcTuc.Location = new System.Drawing.Point(225, 92);
            this.lblPorcTuc.Name = "lblPorcTuc";
            this.lblPorcTuc.Size = new System.Drawing.Size(73, 13);
            this.lblPorcTuc.TabIndex = 6;
            this.lblPorcTuc.Text = "                      ";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Location = new System.Drawing.Point(54, 122);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(165, 13);
            this.lblInfo4.TabIndex = 5;
            this.lblInfo4.Text = "Cantidad de equipos cordobeses:";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Location = new System.Drawing.Point(48, 92);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(171, 13);
            this.lblInfo3.TabIndex = 4;
            this.lblInfo3.Text = "Porcentaje de equipos tucumanos:";
            // 
            // lblMayGolConB
            // 
            this.lblMayGolConB.AutoSize = true;
            this.lblMayGolConB.Location = new System.Drawing.Point(228, 62);
            this.lblMayGolConB.Name = "lblMayGolConB";
            this.lblMayGolConB.Size = new System.Drawing.Size(73, 13);
            this.lblMayGolConB.TabIndex = 3;
            this.lblMayGolConB.Text = "                      ";
            // 
            // lblMayGolFavA
            // 
            this.lblMayGolFavA.AutoSize = true;
            this.lblMayGolFavA.Location = new System.Drawing.Point(225, 32);
            this.lblMayGolFavA.Name = "lblMayGolFavA";
            this.lblMayGolFavA.Size = new System.Drawing.Size(73, 13);
            this.lblMayGolFavA.TabIndex = 2;
            this.lblMayGolFavA.Text = "                      ";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(13, 62);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(206, 13);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "Equipo con más goles en contra (cat \"B\"):";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(25, 32);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(194, 13);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Equipo con más goles a favor (cat \"A\"):";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblGC);
            this.grpDatos.Controls.Add(this.txtGolesCon);
            this.grpDatos.Controls.Add(this.lblGF);
            this.grpDatos.Controls.Add(this.txtGolesFav);
            this.grpDatos.Controls.Add(this.lblPtos);
            this.grpDatos.Controls.Add(this.txtPuntos);
            this.grpDatos.Controls.Add(this.btnRegistrar);
            this.grpDatos.Controls.Add(this.grpCateg);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.dteFechaInsc);
            this.grpDatos.Controls.Add(this.lblProv);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.cboPcia);
            this.grpDatos.Controls.Add(this.txtNomEq);
            this.grpDatos.Location = new System.Drawing.Point(14, 22);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(486, 175);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Equipo";
            // 
            // lblGC
            // 
            this.lblGC.AutoSize = true;
            this.lblGC.Location = new System.Drawing.Point(95, 143);
            this.lblGC.Name = "lblGC";
            this.lblGC.Size = new System.Drawing.Size(86, 13);
            this.lblGC.TabIndex = 13;
            this.lblGC.Text = "Goles en Contra:";
            this.lblGC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGolesCon
            // 
            this.txtGolesCon.Location = new System.Drawing.Point(187, 140);
            this.txtGolesCon.Name = "txtGolesCon";
            this.txtGolesCon.Size = new System.Drawing.Size(40, 20);
            this.txtGolesCon.TabIndex = 9;
            // 
            // lblGF
            // 
            this.lblGF.AutoSize = true;
            this.lblGF.Location = new System.Drawing.Point(105, 117);
            this.lblGF.Name = "lblGF";
            this.lblGF.Size = new System.Drawing.Size(76, 13);
            this.lblGF.TabIndex = 11;
            this.lblGF.Text = "Goles a Favor:";
            this.lblGF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGolesFav
            // 
            this.txtGolesFav.Location = new System.Drawing.Point(187, 114);
            this.txtGolesFav.Name = "txtGolesFav";
            this.txtGolesFav.Size = new System.Drawing.Size(40, 20);
            this.txtGolesFav.TabIndex = 8;
            // 
            // lblPtos
            // 
            this.lblPtos.AutoSize = true;
            this.lblPtos.Location = new System.Drawing.Point(87, 91);
            this.lblPtos.Name = "lblPtos";
            this.lblPtos.Size = new System.Drawing.Size(94, 13);
            this.lblPtos.TabIndex = 9;
            this.lblPtos.Text = "Puntos Obtenidos:";
            this.lblPtos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(187, 88);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(40, 20);
            this.txtPuntos.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(294, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // grpCateg
            // 
            this.grpCateg.Controls.Add(this.rbtCatB);
            this.grpCateg.Controls.Add(this.rbtCatA);
            this.grpCateg.Location = new System.Drawing.Point(247, 45);
            this.grpCateg.Name = "grpCateg";
            this.grpCateg.Size = new System.Drawing.Size(218, 50);
            this.grpCateg.TabIndex = 6;
            this.grpCateg.TabStop = false;
            this.grpCateg.Text = "Categoría";
            // 
            // rbtCatB
            // 
            this.rbtCatB.AutoSize = true;
            this.rbtCatB.Location = new System.Drawing.Point(122, 19);
            this.rbtCatB.Name = "rbtCatB";
            this.rbtCatB.Size = new System.Drawing.Size(61, 17);
            this.rbtCatB.TabIndex = 1;
            this.rbtCatB.Text = "Cat \"B\"";
            this.rbtCatB.UseVisualStyleBackColor = true;
            // 
            // rbtCatA
            // 
            this.rbtCatA.AutoSize = true;
            this.rbtCatA.Checked = true;
            this.rbtCatA.Location = new System.Drawing.Point(9, 19);
            this.rbtCatA.Name = "rbtCatA";
            this.rbtCatA.Size = new System.Drawing.Size(61, 17);
            this.rbtCatA.TabIndex = 0;
            this.rbtCatA.TabStop = true;
            this.rbtCatA.Text = "Cat \"A\"";
            this.rbtCatA.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(245, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de Inscripción:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dteFechaInsc
            // 
            this.dteFechaInsc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFechaInsc.Location = new System.Drawing.Point(366, 19);
            this.dteFechaInsc.Name = "dteFechaInsc";
            this.dteFechaInsc.Size = new System.Drawing.Size(99, 20);
            this.dteFechaInsc.TabIndex = 4;
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(6, 56);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(54, 13);
            this.lblProv.TabIndex = 3;
            this.lblProv.Text = "Provincia:";
            this.lblProv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboPcia
            // 
            this.cboPcia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPcia.FormattingEnabled = true;
            this.cboPcia.Items.AddRange(new object[] {
            "Córdoba",
            "San Luis",
            "Tucumán",
            "Catamarca"});
            this.cboPcia.Location = new System.Drawing.Point(66, 53);
            this.cboPcia.Name = "cboPcia";
            this.cboPcia.Size = new System.Drawing.Size(160, 21);
            this.cboPcia.TabIndex = 1;
            // 
            // txtNomEq
            // 
            this.txtNomEq.Location = new System.Drawing.Point(66, 19);
            this.txtNomEq.Name = "txtNomEq";
            this.txtNomEq.Size = new System.Drawing.Size(161, 20);
            this.txtNomEq.TabIndex = 0;
            // 
            // frmTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 430);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmTorneo";
            this.Text = "Torneo Regional";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpCateg.ResumeLayout(false);
            this.grpCateg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblCantCba;
        private System.Windows.Forms.Label lblPorcTuc;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblMayGolConB;
        private System.Windows.Forms.Label lblMayGolFavA;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblGC;
        private System.Windows.Forms.TextBox txtGolesCon;
        private System.Windows.Forms.Label lblGF;
        private System.Windows.Forms.TextBox txtGolesFav;
        private System.Windows.Forms.Label lblPtos;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpCateg;
        private System.Windows.Forms.RadioButton rbtCatB;
        private System.Windows.Forms.RadioButton rbtCatA;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dteFechaInsc;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboPcia;
        private System.Windows.Forms.TextBox txtNomEq;

    }
}


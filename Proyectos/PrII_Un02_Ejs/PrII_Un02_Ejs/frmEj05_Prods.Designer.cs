﻿namespace PrII_Un02_Ejs
{
    partial class frmEj05_Prods
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
            this.lstCant = new System.Windows.Forms.ListBox();
            this.lstPrecio = new System.Windows.Forms.ListBox();
            this.lstProd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstTotales = new System.Windows.Forms.ListBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCant
            // 
            this.lstCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCant.FormattingEnabled = true;
            this.lstCant.ItemHeight = 16;
            this.lstCant.Location = new System.Drawing.Point(263, 66);
            this.lstCant.Name = "lstCant";
            this.lstCant.Size = new System.Drawing.Size(76, 164);
            this.lstCant.TabIndex = 9;
            // 
            // lstPrecio
            // 
            this.lstPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrecio.FormattingEnabled = true;
            this.lstPrecio.ItemHeight = 16;
            this.lstPrecio.Location = new System.Drawing.Point(171, 66);
            this.lstPrecio.Name = "lstPrecio";
            this.lstPrecio.Size = new System.Drawing.Size(76, 164);
            this.lstPrecio.TabIndex = 8;
            // 
            // lstProd
            // 
            this.lstProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProd.FormattingEnabled = true;
            this.lstProd.ItemHeight = 16;
            this.lstProd.Location = new System.Drawing.Point(12, 66);
            this.lstProd.Name = "lstProd";
            this.lstProd.Size = new System.Drawing.Size(142, 164);
            this.lstProd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad:";
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(13, 35);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(140, 23);
            this.txtProd.TabIndex = 0;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(171, 35);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(76, 23);
            this.nudPrecio.TabIndex = 1;
            this.nudPrecio.Enter += new System.EventHandler(this.nudPrecio_Enter);
            // 
            // nudCant
            // 
            this.nudCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCant.Location = new System.Drawing.Point(263, 35);
            this.nudCant.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(76, 23);
            this.nudCant.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(373, 66);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(86, 34);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(373, 106);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 34);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstTotales
            // 
            this.lstTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTotales.FormattingEnabled = true;
            this.lstTotales.ItemHeight = 16;
            this.lstTotales.Location = new System.Drawing.Point(489, 66);
            this.lstTotales.Name = "lstTotales";
            this.lstTotales.Size = new System.Drawing.Size(76, 164);
            this.lstTotales.TabIndex = 10;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(12, 246);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(153, 17);
            this.lblItems.TabIndex = 14;
            this.lblItems.Text = "No hay ítems cargados";
            // 
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(373, 146);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 34);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(373, 196);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 34);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(493, 246);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 17);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "________";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmEj05_Prods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lstTotales);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCant);
            this.Controls.Add(this.lstPrecio);
            this.Controls.Add(this.lstProd);
            this.Name = "frmEj05_Prods";
            this.Text = "Ejercicio 5: Arreglo 10 Productos";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCant;
        private System.Windows.Forms.ListBox lstPrecio;
        private System.Windows.Forms.ListBox lstProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstTotales;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
    }
}
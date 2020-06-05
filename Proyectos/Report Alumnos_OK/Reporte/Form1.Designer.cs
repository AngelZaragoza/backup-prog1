namespace Reporte
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBF_ABM_alumno_personasDataSet = new Reporte.DBF_ABM_alumno_personasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.alumnosTableAdapter = new Reporte.DBF_ABM_alumno_personasDataSetTableAdapters.alumnosTableAdapter();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtApellido = new System.Windows.Forms.RadioButton();
            this.btnImprimiTodo = new System.Windows.Forms.Button();
            this.btnImprimeFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBF_ABM_alumno_personasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.DBF_ABM_alumno_personasDataSet;
            // 
            // DBF_ABM_alumno_personasDataSet
            // 
            this.DBF_ABM_alumno_personasDataSet.DataSetName = "DBF_ABM_alumno_personasDataSet";
            this.DBF_ABM_alumno_personasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.alumnosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporte.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(432, 205);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiltro.Location = new System.Drawing.Point(183, 234);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // rbtNombre
            // 
            this.rbtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(12, 211);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtNombre.TabIndex = 2;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // rbtApellido
            // 
            this.rbtApellido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbtApellido.AutoSize = true;
            this.rbtApellido.Location = new System.Drawing.Point(115, 211);
            this.rbtApellido.Name = "rbtApellido";
            this.rbtApellido.Size = new System.Drawing.Size(62, 17);
            this.rbtApellido.TabIndex = 3;
            this.rbtApellido.TabStop = true;
            this.rbtApellido.Text = "Apellido";
            this.rbtApellido.UseVisualStyleBackColor = true;
            // 
            // btnImprimiTodo
            // 
            this.btnImprimiTodo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimiTodo.Location = new System.Drawing.Point(12, 233);
            this.btnImprimiTodo.Name = "btnImprimiTodo";
            this.btnImprimiTodo.Size = new System.Drawing.Size(85, 23);
            this.btnImprimiTodo.TabIndex = 4;
            this.btnImprimiTodo.Text = "Imprime Todo";
            this.btnImprimiTodo.UseVisualStyleBackColor = true;
            this.btnImprimiTodo.Click += new System.EventHandler(this.btnImprimiTodo_Click);
            // 
            // btnImprimeFiltro
            // 
            this.btnImprimeFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimeFiltro.Location = new System.Drawing.Point(307, 234);
            this.btnImprimeFiltro.Name = "btnImprimeFiltro";
            this.btnImprimeFiltro.Size = new System.Drawing.Size(111, 23);
            this.btnImprimeFiltro.TabIndex = 5;
            this.btnImprimeFiltro.Text = "Imprime Filtro";
            this.btnImprimeFiltro.UseVisualStyleBackColor = true;
            this.btnImprimeFiltro.Click += new System.EventHandler(this.btnImprimeFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 281);
            this.Controls.Add(this.btnImprimeFiltro);
            this.Controls.Add(this.btnImprimiTodo);
            this.Controls.Add(this.rbtApellido);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBF_ABM_alumno_personasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private DBF_ABM_alumno_personasDataSet DBF_ABM_alumno_personasDataSet;
        private DBF_ABM_alumno_personasDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbtApellido;
        private System.Windows.Forms.Button btnImprimiTodo;
        private System.Windows.Forms.Button btnImprimeFiltro;

    }
}


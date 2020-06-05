using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte
{
    public partial class Form1 : Form
    {
         AccesoDato oDato = new AccesoDato(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\gabriel\Desktop\COSAS DE ESCRITORIO\Visual\Reporte\DBF_ABM_alumno_personas.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBF_ABM_alumno_personasDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.DBF_ABM_alumno_personasDataSet.alumnos);

            this.reportViewer1.RefreshReport();
            string consultaSQL = "Select * from  alumnos ";
            alumnosBindingSource.DataSource = oDato.ConsultarBD(consultaSQL);
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
           /* this.ReporteTableAdapter.Fill(this.DBFPersonaDataSet.Persona);
            this.Report1.rdlc.RefreshReport();*/
        }

        private void btnImprimiTodo_Click(object sender, EventArgs e)
        {
            string ConsultaSQL = " SELECT * FROM alumnos";

            if (rbtNombre.Checked)
                ConsultaSQL += " Order By 2";
            else
                ConsultaSQL += " Order By 1 ";

            alumnosBindingSource.DataSource = oDato.ConsultarBD(ConsultaSQL);
            this.reportViewer1.RefreshReport();
        }

        private void btnImprimeFiltro_Click(object sender, EventArgs e)
        {
            string ConsultaSQL = "Select * From  alumnos Where nombres Like '" + txtFiltro.Text + "%' ";
            alumnosBindingSource.DataSource = oDato.ConsultarBD(ConsultaSQL);

            this.reportViewer1.RefreshReport();
          
        }
    }
}

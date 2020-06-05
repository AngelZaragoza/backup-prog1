using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrII_Un02_Ejs
{
    public partial class frmEmpl03 : Form
    {
        int c;
        double total;
        const int tam = 3;
        string[] aEmpleados = new string[tam];
        double[] aSueldo = new double[tam];
        double[] aNeto = new double[tam];
        Empleado[] aObjEmpleado = new Empleado[tam];
        
        public frmEmpl03()
        {
            InitializeComponent();
            c = 0;
            total = 0;
            for (int i = 0; i < tam; i++)
            {
                aEmpleados[i] = string.Empty;
                aSueldo[i] = 0;
                aNeto[i] = 0;
                aObjEmpleado[i] = null;
            }
        }

        private void frmEmpl03_Load(object sender, EventArgs e)
        {
            ////CARGAMOS EMPLEADOS
            //lstEmpleados.Items.Add("Juan");
            //lstEmpleados.Items.Add("María");
            //lstEmpleados.Items.Add("José");
            //lstEmpleados.Items.Add("Pedro");
            //lstEmpleados.Items.Add("Angel");
            ////CARGAMOS SUELDOS
            //lstSueldos.Items.Add(10000);
            //lstSueldos.Items.Add(15000);
            //lstSueldos.Items.Add(20000);
            //lstSueldos.Items.Add(18000);
            //lstSueldos.Items.Add(25000);
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            double neto = 0;
            //CODIGO ANTERIOR (SIN ARREGLOS)
            //******************************
            //lstNeto.Items.AddRange(lstSueldos.Items);            
            //lstNeto.Items.Clear();
            //for (int i = 0; i < lstSueldos.Items.Count; i++)
            //{
            //    neto = Convert.ToDouble(lstSueldos.Items[i]) +
            //          (Convert.ToDouble(lstSueldos.Items[i]) *
            //          Convert.ToDouble(mskPorcent.Text) / 100);
            //    lstNeto.Items.Add(neto);
            //}

            //CODIGO ANTERIOR (CON 3 ARREGLOS)
            //********************************
            
            //lstNeto.Items.Clear();
            //total = 0;
            //for (int i = 0; i < tam; i++)
            //{
            //    neto = aSueldo[i] + (aSueldo[i] *
            //        Convert.ToDouble(mskPorcent.Text) / 100);
            //    aNeto[i] = neto;
            //    lstNeto.Items.Add(aNeto[i]);
            //    total += aNeto[i];
            //}

            lstNeto.Items.Clear();
            total = 0;
            for (int i = 0; i < c; i++)
            {
                neto = aObjEmpleado[i].calcularNeto(Convert.ToDouble(mskPorcent.Text));
                lstNeto.Items.Add(neto);
                total += neto;
            }
            txtTotal.Text = "$ " + total.ToString();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            aEmpleados[c] = txtEmpleado.Text;
            aSueldo[c] = Convert.ToDouble(txtSueldo.Text);
            c++;
            txtEmpleado.Text = "";
            txtSueldo.Text = "";
            txtEmpleado.Focus();
            if (c == tam)
            {
                MessageBox.Show("Se completó el arreglo...","Listo");
                txtEmpleado.Enabled = false;
                txtSueldo.Enabled = false;
                btnCargar.Enabled = false;
                btnMostrar.Enabled = true;
                btnMostrar.Focus();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tam; i++)
            {
                lstEmpleados.Items.Add(aEmpleados[i]);
                lstSueldos.Items.Add(aSueldo[i]);
            }
            btnMostrar.Enabled = false;
            btnAumento.Enabled = true;

        }        

        private void mskPorcent_Enter(object sender, EventArgs e)
        {
            mskPorcent.SelectAll();
        }

        private void mskPorcent_Enter_1(object sender, EventArgs e)
        {
            mskPorcent.Text = "0";
        }

        private void btnCargarClass_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.pNombre = txtEmpleado.Text;
            emp.pLegajo = Convert.ToInt32(txtLegajo.Text);
            emp.pSueldo = Convert.ToDouble(txtSueldo.Text);
            aObjEmpleado[c] = emp;
            c++;
            txtEmpleado.Text = "";
            txtLegajo.Text = "";
            txtSueldo.Text = "";
            txtEmpleado.Focus();
            lblItems.Text = c.ToString() + " empleados cargados";
            if (c == tam)
            {
                MessageBox.Show("Se completó el arreglo...", "Listo");
                txtEmpleado.Enabled = false;
                txtLegajo.Enabled = false;
                txtSueldo.Enabled = false;
                btnCargarClass.Enabled = false;
                btnAumento.Enabled = true;
                btnMostrarClass.Enabled = true;
                btnMostrarClass.Focus();
                
            }
        }

        private void btnMostrarClass_Click(object sender, EventArgs e)
        {
            lstEmpleados.Items.Clear();
            lstSueldos.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstEmpleados.Items.Add(aObjEmpleado[i].pNombre + 
                                " - Leg. " + aObjEmpleado[i].pLegajo);
                lstSueldos.Items.Add(aObjEmpleado[i].pSueldo);
            }
            mskPorcent.Focus();
        }
        
    }
}

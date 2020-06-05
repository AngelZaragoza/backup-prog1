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
    public partial class frmEj05_Prods : Form
    {
        int c;
        const int tam = 3;
        string[] aProds = new string[tam];
        double[] aPrecio = new double[tam];
        double[] aTotal = new double[tam];
        int[] aCant = new int[tam];

        public frmEj05_Prods()
        {
            InitializeComponent();
            limpiarArreglos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtProd.Text != "")
            {
                aProds[c] = txtProd.Text;
                aPrecio[c] = Convert.ToDouble(nudPrecio.Value);
                aCant[c] = Convert.ToInt32(nudCant.Value);
                c++;
                txtProd.Text = "";
                nudPrecio.Value = 0;
                nudCant.Value = 0;
                lblItems.Text = c + " ítem(s) cargado(s)";
                txtProd.Focus();
                if (c == tam)
                {
                    MessageBox.Show("Arreglo completo", "Info");
                    txtProd.Enabled = false;
                    nudPrecio.Enabled = false;
                    nudCant.Enabled = false;
                    btnCargar.Enabled = false;
                    btnMostrar.Enabled = true;
                    btnCalc.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnMostrar.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del Producto",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProd.Focus();
            }
        }

        private void nudPrecio_Enter(object sender, EventArgs e)
        {
            nudPrecio.Select();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //LIMPIAMOS LISTAS
            lstProd.Items.Clear();
            lstPrecio.Items.Clear();
            lstCant.Items.Clear();
            //CARGAMOS LISTAS
            for (int i = 0; i < c; i++)
            {
                lstProd.Items.Add(aProds[i]);
                lstPrecio.Items.Add(aPrecio[i]);
                lstCant.Items.Add(aCant[i]);
            }
            btnCalc.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double tot = 0;
            lstTotales.Items.Clear();
            //CALCULAMOS Y CARGAMOS LISTA DE TOTALES
            for (int i = 0; i < c; i++)
            {
                aTotal[i] = aPrecio[i] * aCant[i];
                lstTotales.Items.Add("$ " + aTotal[i]);
                tot += aTotal[i];
            }
            //MOSTRAMOS EL TOTAL GENERAL EN LA ETIQUETA
            lblTotal.Text = "$ " + tot.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProd.Items.Clear();
            lstPrecio.Items.Clear();
            lstCant.Items.Clear();
            lstTotales.Items.Clear();
            limpiarArreglos();
            lblItems.Text = "No hay ítems cargados";
            lblTotal.Text = "________";
            txtProd.Enabled = true;
            nudPrecio.Enabled = true;
            nudCant.Enabled = true;
            btnCargar.Enabled = true;
            btnMostrar.Enabled = false;
            btnCalc.Enabled = false;
            btnLimpiar.Enabled = false;
            txtProd.Focus();
        }

        void limpiarArreglos()
        {
            //PONE A CERO CONTADORES Y ARREGLOS
            c = 0;
            for (int i = 0; i < tam; i++)
            {
                aProds[i] = "";
                aPrecio[i] = 0;
                aCant[i] = 0;
                aTotal[i] = 0;
            }
        }
    }
}

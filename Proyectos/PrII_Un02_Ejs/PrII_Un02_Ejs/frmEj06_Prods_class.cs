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
    public partial class frmEj06_Prods_class : Form
    {
        int c;
        const int tam = 3;
        Producto prod;
        Producto[] aProds = new Producto [tam];
        double[] aTotal = new double[tam];
        
        public frmEj06_Prods_class()
        {
            InitializeComponent();
            limpiarArreglos();

        }



        void limpiarArreglos()
        {
            c = 0;
            for (int i = 0; i < tam; i++)
            {
                aProds[i] = null;
                aTotal[i] = 0;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtProd.Text != "")
            {
                prod = new Producto();
                prod.pProducto = txtProd.Text;
                prod.pPreUnit = Convert.ToDouble(nudPrecio.Value);
                prod.pStock = Convert.ToInt32(nudCant.Value);
                aProds[c] = prod;
                
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
                MessageBox.Show("Debe ingresar el nombre del producto", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProd.Focus();
            }
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
                lstProd.Items.Add(aProds[i].pProducto;
                lstPrecio.Items.Add(aProds
            }

        }
    }
}

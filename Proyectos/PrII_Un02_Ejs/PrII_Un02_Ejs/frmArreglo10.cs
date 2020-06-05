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
    public partial class frmArreglo10 : Form
    {
        int[] numeros;
        int i;
        public frmArreglo10()
        {
            InitializeComponent();
            numeros = new int[10];
            for (int j = 0; j < numeros.Length; j++)
            {
                numeros[j] = 0;
            }
            i = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            Close();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (i < numeros.Length)
            {
                numeros[i] = Convert.ToInt32(mskNros.Text);
                i++;
                lblNros.Text = "Ingrese el " + (i + 1) + "º número:";
                mskNros.Clear();
                mskNros.Focus();
            }
            //SI LLEGAMOS AL TAMAÑO DEL ARREGLO, CARGA LA LISTA
            //Y ACTIVA BOTON DE LIMPIAR
            if(i == (numeros.Length))
            {
                for (i = 0; i < numeros.Length; i++)
                {
                    lstNros.Items.Add(numeros[i]);
                    lblNros.Text = "Lista completa";
                    btnCargar.Enabled = false;
                    btnLimpiar.Enabled = true;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //LIMPIA LISTA Y PONE INDICE A CERO PARA COMENZAR DE NUEVO
            i = 0;
            lstNros.Items.Clear();
            lblNros.Text = "Ingrese el 1er número:";
            btnCargar.Enabled = true;
            btnLimpiar.Enabled = false;
            mskNros.Clear();
            mskNros.Focus();

        }

        
    }
}

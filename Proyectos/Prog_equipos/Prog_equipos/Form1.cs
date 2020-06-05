using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog_equipos
{
    public partial class frmTorneo : Form
    {
        String masGolesFavCatA, masGolesConCatB;
        int ctdEquipos, ctdTuc, ctdCba, ctdSanLuis, ctdCatama, mayGFCatA, mayGCCatB;

        public frmTorneo()
        {
            InitializeComponent();
            ctdEquipos = 0;
            ctdTuc = 0;
            ctdCba = 0;
            ctdSanLuis = 0;
            ctdCatama = 0;
            masGolesFavCatA = "";
            masGolesConCatB = "";
            cboPcia.SelectedIndex = 0;
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Equipo eq = new Equipo();
                ctdEquipos++;
                eq.pNombre = txtNomEq.Text;
                eq.pProv = cboPcia.SelectedItem.ToString();
                eq.pFecha = dteFechaInsc.Value;
                if (rbtCatA.Checked == true)
                    eq.pCateg = "A";
                else
                    eq.pCateg = "B";
                eq.pPuntos = Convert.ToInt32(txtPuntos.Text);
                eq.pGolesFavor = Convert.ToInt32(txtGolesFav.Text);
                eq.pGolesContra = Convert.ToInt32(txtGolesCon.Text);
            }
        }

        private bool validarDatos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && string.IsNullOrEmpty(c.Text))
                {
                    MessageBox.Show("Complete datos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Equipo eq = new Equipo();
                ctdEquipos++;
                eq.pNombre = txtNomEq.Text;
                eq.pProv = cboPcia.SelectedItem.ToString();
                eq.pFecha = dteFechaInsc.Value;
                if (rbtCatA.Checked == true)
                    eq.pCateg = "A";
                else
                    eq.pCateg = "B";
                eq.pPuntos = Convert.ToInt32(txtPuntos.Text);
                eq.pGolesFavor = Convert.ToInt32(txtGolesFav.Text);
                eq.pGolesContra = Convert.ToInt32(txtGolesCon.Text);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cl2309_Colecciones
{
    public partial class frmColecciones : Form
    {
        string selecc;
        public frmColecciones()
        {
            InitializeComponent();
            selecc = "";
        }

        private void frmColecciones_Load(object sender, EventArgs e)
        {
            cboCurso.Items.Add("1w50");
            cboCurso.Items.Add("1w51");
            cboCurso.Items.Add("1w52");
            cboCurso.Items.Add("1w53");
            cboCurso.Items.Add("1w54");
            cboCurso.Items.Add("1w55");

            lstCurso.Items.Add("1w50");
            lstCurso.Items.Add("1w51");
            lstCurso.Items.Add("1w52");
            lstCurso.Items.Add("1w53");
            lstCurso.Items.Add("1w54");
            lstCurso.Items.Add("1w55");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cboCurso.Items.Add(txtDato.Text);
            lstCurso.Items.Add(txtDato.Text);            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cboCurso.Items.Insert(Convert.ToInt32(txtPosicion.Text), txtDato.Text);
            lstCurso.Items.Insert(Convert.ToInt32(txtPosicion.Text), txtDato.Text);
        }

        private void btnInsertarSelecc_Click(object sender, EventArgs e)
        {
            switch (selecc)
            {
                case "combo":
                    lstCurso.Items.Insert(cboCurso.SelectedIndex, txtDato.Text);
                    cboCurso.Items.Insert(cboCurso.SelectedIndex, txtDato.Text);
                    break;
                case "lista":
                    cboCurso.Items.Insert(lstCurso.SelectedIndex, txtDato.Text);
                    lstCurso.Items.Insert(lstCurso.SelectedIndex, txtDato.Text);
                    break;
                case "":
                    MessageBox.Show("Debe seleccionar un elemento", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }            
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecc = "combo";
        }

        private void lstCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecc = "lista";
        }

        private void btnBorrarDato_Click(object sender, EventArgs e)
        {
            lstCurso.Items.Remove(txtDato.Text);
            cboCurso.Items.Remove(txtDato.Text);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            cboCurso.Items.Clear();
            lstCurso.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cboCurso.Items.RemoveAt(0);
            lstCurso.Items.RemoveAt(0);
        }

        private void btnBorrarSelecc_Click(object sender, EventArgs e)
        {
            cboCurso.Items.RemoveAt(cboCurso.SelectedIndex);
            lstCurso.Items.RemoveAt(lstCurso.SelectedIndex);            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cboCurso.Items.RemoveAt(cboCurso.Items.Count - 1);
            lstCurso.Items.RemoveAt(lstCurso.Items.Count - 1);
        }
    }
}

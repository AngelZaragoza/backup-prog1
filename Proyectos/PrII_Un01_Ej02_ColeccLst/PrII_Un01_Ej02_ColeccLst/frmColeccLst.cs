using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrII_Un01_Ej02_ColeccLst
{
    public partial class frmColeccLst : Form
    {
        public frmColeccLst()
        {
            InitializeComponent();
        }

        private void frmColeccLst_Load(object sender, EventArgs e)
        {
            lstIzquierda.Items.Add("Enero");
            lstIzquierda.Items.Add("Febrero");
            lstIzquierda.Items.Add("Marzo");
            lstIzquierda.Items.Add("Abril");
            lstIzquierda.Items.Add("Mayo");
            lstIzquierda.Items.Add("Junio");
            lstIzquierda.Items.Add("Julio");
            lstIzquierda.Items.Add("Agosto");
            lstIzquierda.Items.Add("Septiembre");
            lstIzquierda.Items.Add("Octubre");
            lstIzquierda.Items.Add("Noviembre");
            lstIzquierda.Items.Add("Diciembre");
        }

        private void btnTodoDerecha_Click(object sender, EventArgs e)
        {
            //MUEVE TODOS LOS ELEMENTOS A LA DERECHA
            for (int i = 0; i < lstIzquierda.Items.Count; i++)
            {
                lstDerecha.Items.Add(lstIzquierda.Items[i]);
            }
            lstIzquierda.Items.Clear();
            chequearListas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            //CONTROLA QUE HAYA UN ELEMENTO SELECCIONADO EN LA LISTA IZQUIERDA
            //Y LO MUEVE A LA LISTA DE LA DERECHA, O AVISA MEDIANTE UNA LABEL            
            if (lstIzquierda.SelectedIndex >= 0)
            {
                lstDerecha.Items.Add(lstIzquierda.SelectedItem);
                lstIzquierda.Items.Remove(lstIzquierda.SelectedItem);
                chequearListas();
                lblSelec.Visible = false;
            }
            else
                lblSelec.Visible = true;

        }

        void chequearListas()
        {
            //ACTIVA Y DESACTIVA LOS BOTONES SEGUN LAS LISTAS SE VACIEN
            if (lstIzquierda.Items.Count == 0)
            {
                btnDerecha.Enabled = false;
                btnTodoDerecha.Enabled = false;                
            }
            else
            {
                btnDerecha.Enabled = true;
                btnTodoDerecha.Enabled = true;
            }

            if (lstDerecha.Items.Count == 0)
            {                
                btnIzquierda.Enabled = false;
                btnTodoIzquierda.Enabled = false;
            }
            else
            {
                btnIzquierda.Enabled = true;
                btnTodoIzquierda.Enabled = true;
            }
        }

        private void btnTodoIzquierda_Click(object sender, EventArgs e)
        {
            //MUEVE TODOS LOS ELEMENTOS A LA IZQUIERDA
            for (int i = 0; i < lstDerecha.Items.Count; i++)
            {
                lstIzquierda.Items.Add(lstDerecha.Items[i]);
            }
            lstDerecha.Items.Clear();
            chequearListas();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            //CONTROLA QUE HAYA UN ELEMENTO SELECCIONADO EN LA LISTA DERECHA
            //Y LO MUEVE A LA LISTA DE LA IZQUIERDA, O AVISA MEDIANTE UNA LABEL            
            if (lstDerecha.SelectedIndex >= 0)
            {
                lstIzquierda.Items.Add(lstDerecha.SelectedItem);
                lstDerecha.Items.Remove(lstDerecha.SelectedItem);
                chequearListas();
                lblSelec.Visible = false;
            }
            else
                lblSelec.Visible = true;
        }

    }
}

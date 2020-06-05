using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Un04_Pr11_MedPac
{
    public partial class frmClinica : Form
    {
        public frmClinica()
        {
            InitializeComponent();
            cboMedPac.SelectedIndex = 0;
            cboEspec.SelectedIndex = 0;
            cboObSoc.SelectedIndex = 0;
        }

        //ACTIVA Y DESACTIVA LOS BOTONES Y GRUPOS DE CONTROLES
        //DE MEDICOS Y PACIENTES DEPENDIENDO DE LA SELECCION
        private void cboMedPac_SelectedIndexChanged(object sender, EventArgs e)
        {         
            switch (cboMedPac.SelectedIndex)
            {
                case 0:
                    grpMedicos.Enabled = false;
                    grpPacientes.Enabled = false;
                    btnMedico.Enabled = false;
                    btnPaciente.Enabled = false;
                    break;
                case 1:
                    grpMedicos.Enabled = true;
                    grpPacientes.Enabled = false;
                    btnMedico.Enabled = true;
                    btnPaciente.Enabled = false;
                    break;
                case 2:
                    grpPacientes.Enabled = true;
                    grpMedicos.Enabled = false;
                    btnPaciente.Enabled = true;
                    btnMedico.Enabled = false;
                    break;
            }
        
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            //CREAR MEDICO Y CARGAR DATOS
            if (validarDatos())
            {
                Medico med = new Medico();
                med.pNombre = txtNombre.Text;
                med.pDNI = Convert.ToInt32(txtDNI.Text);
                med.pTelef = Convert.ToInt32(txtTelef.Text);
                med.pSexo = rbtMasc.Checked;
                med.pEspec = cboEspec.SelectedIndex;
                med.pConsulta = Convert.ToDouble(txtCosto.Text);

                cargarMed(med);
                MessageBox.Show(med.toStringMedico(), "Datos médico");
                limpiarCampos();
            }

        }        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Close(); 
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            //CREAR PACIENTE Y CARGAR DATOS
            if (validarDatos())
            {
                Paciente pac = new Paciente();
                pac.pNombre = txtNombre.Text;
                pac.pDNI = Convert.ToInt32(txtDNI.Text);
                pac.pTelef = Convert.ToInt32(txtTelef.Text);
                pac.pSexo = rbtMasc.Checked;
                pac.pObraSoc = cboObSoc.SelectedIndex;
                pac.pHistCl = Convert.ToInt32(txtHisClin.Text);

                cargarPac(pac);
                MessageBox.Show(pac.toStringPaciente(), "Datos paciente");
                limpiarCampos();
            }
        }

        //CARGA EL CONTROL LISTVIEW CON (ALGUNOS) DATOS DEL MEDICO CARGADO
        private void cargarMed(Medico m)
        {            
            ListViewItem lsMed = new ListViewItem(m.pNombre);
            lsMed.SubItems.Add(m.toStringEspec());
            lsMed.SubItems.Add(Convert.ToString(m.pConsulta));

            lsvMedicos.Items.Add(lsMed);
        }

        //CARGA EL CONTROL LISTVIEW CON (ALGUNOS) DATOS DEL PACIENTE CARGADO
        private void cargarPac(Paciente p)
        {            
            ListViewItem lsPac = new ListViewItem(p.pNombre);
            lsPac.SubItems.Add(p.toStringObraSoc());
            lsPac.SubItems.Add(Convert.ToString(p.pHistCl));

            lsvPacientes.Items.Add(lsPac);
        }

        private bool validarDatos()
        {
            foreach (Control c in grpDatos.Controls) //CHEQUEA DATOS PERSONALES
            {
                if (c is TextBox && string.IsNullOrEmpty(c.Text))
                {
                    MessageBox.Show("Complete todos los datos", "Error", MessageBoxButtons.OK);
                    c.Focus();
                    return false;
                }
            }            
            
            
            if (grpMedicos.Enabled) //CHEQUEA DATOS DE MEDICOS
            {
                if (cboEspec.SelectedIndex == 0) //CHEQUEA ESPECIALIDAD
                {
                    MessageBox.Show("Elija una especialidad", "Error", MessageBoxButtons.OK);
                    return false;
                }
                foreach (Control c in grpMedicos.Controls)
                {
                    if (c is TextBox && string.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show("Complete todos los datos", "Error", MessageBoxButtons.OK);
                        c.Focus();
                        return false;
                    }
                }
            }

            if (grpPacientes.Enabled) //CHEQUEA DATOS DE PACIENTES
            {
                if (cboObSoc.SelectedIndex == 0) //CHEQUEA OBRA SOCIAL
                {
                    MessageBox.Show("Elija una Obra Social", "Error", MessageBoxButtons.OK);
                    return false;
                }
                foreach (Control c in grpPacientes.Controls)
                {
                    if (c is TextBox && string.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show("Complete todos los datos", "Error", MessageBoxButtons.OK);
                        c.Focus();
                        return false;
                    }
                }
            }            

            return true;
        }
        
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtTelef.Text = "";
            txtCosto.Text = "";
            txtHisClin.Text = "";
            cboMedPac.SelectedIndex = 0;
            cboEspec.SelectedIndex = 0;
            cboObSoc.SelectedIndex = 0;
            txtNombre.Focus();
        }
    }
}

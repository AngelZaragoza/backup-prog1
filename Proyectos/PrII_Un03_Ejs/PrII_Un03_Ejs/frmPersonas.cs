using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrII_Un03_Ejs
{
    public partial class frmPersonas : Form
    {
        OleDbConnection conex;
        OleDbCommand comm;
        OleDbDataReader lector;
        DataTable tabla;
        string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Administrador\Escritorio\TUP\Prog 1\Proyectos\PrII_Un03_Ejs\Bases.mdb";
        string comandoSQL;
        bool nuevo;
        int ctdor;
        const int tam = 20;
        Persona[] aPersona = new Persona[tam];

        public frmPersonas()
        {
            //conex = new OleDbConnection(cadenaConexion);
            nuevo = false;            
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            cargarCombo(cboTipoDocumento, "tipo_documento");
            cargarCombo(cboEstadoCivil, "tipo_estado_civil");
            cargarLista();
            habilitar(nuevo);
        }

        private void abrirConexion(string cadenaConexion)
        {
            conex = new OleDbConnection(cadenaConexion);
            conex.Open();
            comm = new OleDbCommand();
            comm.Connection = conex;
            comm.CommandType = CommandType.Text;

        }
                
        private void cargarCombo(ComboBox combo, string nomTabla)
        {
            abrirConexion(cadenaConexion);
            comm.CommandText = "SELECT * FROM " + nomTabla;
            tabla = new DataTable();
            tabla.Load(comm.ExecuteReader());
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
            conex.Close();
        }

        private void cargarLista()
        {
            ctdor = 0;
            lstPersonas.Items.Clear();            
            abrirConexion(cadenaConexion);
            comm.CommandText = "SELECT * FROM Personas";            
            lector = comm.ExecuteReader();
            while (lector.Read())
            {
                Persona p = new Persona();
                if(!lector.IsDBNull(0))
                    p.pDocumento = lector.GetDouble(0);
                if (!lector.IsDBNull(1))
                    p.pApellido = lector.GetString(1);
                if (!lector.IsDBNull(2))
                    p.pNombres = lector.GetString(2);
                if (!lector.IsDBNull(3))
                    p.pTipoDoc = lector.GetInt16(3);
                if (!lector.IsDBNull(4))
                    p.pEstCivil = lector.GetInt16(4);
                if (!lector.IsDBNull(5))
                    p.pSexo = lector.GetInt16(5);
                if (!lector.IsDBNull(6))
                    p.pFallecio = lector.GetInt16(6);
                aPersona[ctdor] = p;
                ctdor++;
            }
            lector.Close();
            conex.Close();            
            for (int i = 0; i < ctdor; i++)
            {
                lstPersonas.Items.Add(aPersona[i].ToString());
            }
        }

        private void habilitar(bool nuevo)
        {
            txtApellido.Enabled = nuevo;
            txtNombres.Enabled = nuevo;
            cboTipoDocumento.Enabled = nuevo;
            txtDocumento.Enabled = nuevo;
            cboEstadoCivil.Enabled = nuevo;
            btnGrabar.Enabled = nuevo;
            btnCancelar.Enabled = nuevo;

            btnNuevo.Enabled = !nuevo;
            btnEditar.Enabled = !nuevo;
            btnBorrar.Enabled = !nuevo;
            lstPersonas.Enabled = !nuevo;
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombres.Text = "";
            txtDocumento.Text = "";
            cboTipoDocumento.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            limpiar();
            habilitar(nuevo);
            lstPersonas.Enabled = false;
            txtApellido.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(nuevo)
                limpiar();
            nuevo = false;
            habilitar(nuevo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex >= 0)
            {
                nuevo = false;
                habilitar(true);

            }
        }

        private void actualizarCampos(int pos)
        {
            txtApellido.Text = aPersona[pos].pApellido;
            txtNombres.Text = aPersona[pos].pNombres;
            cboTipoDocumento.SelectedValue = aPersona[pos].pTipoDoc;
            txtDocumento.Text = aPersona[pos].pDocumento.ToString();
            cboEstadoCivil.SelectedValue = aPersona[pos].pEstCivil;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstPersonas.SelectedIndex);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string comandoSQL = "";
            Persona p = new Persona();
            p.pApellido = txtApellido.Text;
            p.pNombres = txtNombres.Text;
            p.pTipoDoc = Convert.ToInt16(cboTipoDocumento.SelectedValue);
            p.pDocumento = Convert.ToDouble(txtDocumento.Text);
            p.pEstCivil = Convert.ToInt16(cboEstadoCivil.SelectedValue);

            if (nuevo)
            {
                comandoSQL = "INSERT INTO Personas(documento,apellido,nombres,"
                            + "tipo_documento,tipo_estado_civil) VALUES("
                            + p.pDocumento + ",'"
                            + p.pApellido + "','"
                            + p.pNombres + "',"
                            + p.pTipoDoc + ","
                            + p.pEstCivil + ")";
                abrirConexion(cadenaConexion);
                comm.CommandText = comandoSQL;
                comm.ExecuteNonQuery();
                conex.Close();
                cargarLista();
                limpiar();
                nuevo = false;
                habilitar(nuevo);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABMProductos
{
    public partial class frmProducto : Form
    {
        AccesoDato oDato = new AccesoDato(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Administrador\Escritorio\TUP\Prog 1\Proyectos\PRII_Clase_21_Oct\DBFProducto.mdb");
        const int tam = 10;
        Producto[] aProd = new Producto[tam];
        int c;
        bool nuevo;

        public frmProducto()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                aProd[i] = null;
            }
            nuevo = false;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarCombo(cboMarca, "marca");
            cargarLista("Producto");
            habilitar(false);
        }

        private bool existe(int pk)
        {
            //PARA CHEQUEAR CODIGOS REPETIDOS
            for (int i = 0; i < c; i++)
            {
                if (aProd[i].pCodigo == pk)
                    return true;
            }
            return false;
        }

        private bool validar()
        {
            //TERMINAR VALIDACIONES!!!!
            //*************************
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar código...");
                txtCodigo.Focus();
                return false;
            }

            return true;
        }
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES VARIAS NECESARIAS!!
            if (validar())
            {
                string consultaSQL = "";
                Producto p = new Producto();
                p.pCodigo = Convert.ToInt32(txtCodigo.Text);
                p.pDetalle = txtDetalle.Text;
                p.pMarca = Convert.ToInt32(cboMarca.SelectedValue);
                if (rbtNoteBook.Checked)
                    p.pTipo = 1;
                else
                    p.pTipo = 2;
                p.pPrecio = Convert.ToDouble(txtPrecio.Text);
                p.pFecha = dtpFecha.Value;

                if (nuevo)
                {
                    if (!existe(p.pCodigo))
                    {
                        //INSERT
                        consultaSQL = "INSERT INTO Producto (codigo,detalle,marca,tipo,precio,fecha)" +
                                                 " VALUES ("
                                                 + p.pCodigo + ",'"
                                                 + p.pDetalle + "',"
                                                 + p.pMarca + ","
                                                 + p.pTipo + ","
                                                 + p.pPrecio + ",'"
                                                 + p.pFecha + "')";
                        oDato.actualizarBD(consultaSQL);
                        cargarLista("Producto");
                    }
                    else
                    {
                        MessageBox.Show("Este producto ya está registrado...");
                    }
                }
                else
                {
                    //UPDATE
                    consultaSQL = "UPDATE Producto SET detalle='" + p.pDetalle + "',"
                                                   + "marca=" + p.pMarca + ","
                                                   + "tipo=" + p.pTipo + ","
                                                   + "precio=" + p.pPrecio + ","
                                                   + "fecha='" + p.pFecha + "' "
                                                   + "WHERE codigo=" + p.pCodigo;
                    oDato.actualizarBD(consultaSQL);
                    cargarLista("Producto");
                }
            }
            habilitar(false);
            nuevo = false;
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            habilitar(true);
            limpiar();
            txtCodigo.Focus();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            limpiar();
            habilitar(false);
            nuevo = false;
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstProducto.SelectedIndex);
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtCodigo.Enabled = false;
            txtDetalle.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este producto?",
                               "ELIMINANDO",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button2)
                               == DialogResult.Yes)
            {
                string consultaSQL = "DELETE FROM Producto WHERE codigo=" +
                                aProd[lstProducto.SelectedIndex].pCodigo;
                oDato.actualizarBD(consultaSQL);
                cargarLista("Producto");
            }
        }

        private void habilitar(bool x)
        {
            //PARA CONTROLAR EL ESTADO ON/OFF DE LOS CONTROLES
            txtCodigo.Enabled = x;
            txtDetalle.Enabled = x;
            txtPrecio.Enabled = x;
            cboMarca.Enabled = x;
            rbtNoteBook.Enabled = x;
            rbtNetBook.Enabled = x;
            dtpFecha.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            lstProducto.Enabled = x;

            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            lstProducto.Enabled = !x;
        }

        private void limpiar()
        {
            //PARA DEJAR LOS CONTROLES VACIOS O EN ESTADO INICIAL
            txtCodigo.Clear();
            txtDetalle.Text = "";
            txtPrecio.Text = string.Empty;
            cboMarca.SelectedIndex = -1;
            rbtNetBook.Checked = false;
            rbtNoteBook.Checked = false;
            dtpFecha.Value = DateTime.Today;
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = oDato.consultarTabla(nombreTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarLista(string nombreTabla)
        {
            c = 0;
            lstProducto.Items.Clear();
            oDato.leerTabla(nombreTabla);
            //SE LEE EL OBJETO DATAREADER PARA CARGAR EN EL ARREGLO
            while (oDato.pLector.Read())
            {
                Producto p = new Producto();
                if(!oDato.pLector.IsDBNull(0))
                    p.pCodigo = oDato.pLector.GetInt32(0);
                if (!oDato.pLector.IsDBNull(1))
                    p.pDetalle = oDato.pLector["detalle"].ToString();
                if (!oDato.pLector.IsDBNull(2))
                    p.pTipo = oDato.pLector.GetInt32(2);
                if (!oDato.pLector.IsDBNull(3))
                    p.pMarca = oDato.pLector.GetInt32(3);
                if (!oDato.pLector.IsDBNull(4))
                    p.pPrecio = oDato.pLector.GetDouble(4);
                if (!oDato.pLector.IsDBNull(5))
                    p.pFecha = oDato.pLector.GetDateTime(5);
                aProd[c] = p;
                c++;
            }
            //MUY IMPORTANTE!! CERRAR LA CONEXION QUE EL DATA READER MANTUVO ABIERTA
            oDato.pLector.Close();
            oDato.desconectar();
            
            //CARGAMOS LISTA CON LOS OBJETOS DEL ARREGLO
            for (int i = 0; i < c; i++)
            {
                lstProducto.Items.Add(aProd[i].ToString());
            }
            lstProducto.SelectedIndex = 0;
        }

        private void actualizarCampos(int posicion)
        {
            txtCodigo.Text = aProd[posicion].pCodigo.ToString();
            txtDetalle.Text = aProd[posicion].pDetalle;
            cboMarca.SelectedValue = aProd[posicion].pMarca;
            if (aProd[posicion].pTipo == 1)
                rbtNoteBook.Checked = true;
            else
                rbtNetBook.Checked = true;
            txtPrecio.Text = aProd[posicion].pPrecio.ToString();
            dtpFecha.Value = aProd[posicion].pFecha;
        }

    }
}

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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto fp = new frmProducto();
            fp.FormClosed += new FormClosedEventHandler(frmProductos_Closed);
            productosToolStripMenuItem.Enabled = false;
            fp.Show();
            

        }

        void frmProductos_Closed(object sender, FormClosedEventArgs e)
        {
            productosToolStripMenuItem.Enabled = true;
        }
    }
}

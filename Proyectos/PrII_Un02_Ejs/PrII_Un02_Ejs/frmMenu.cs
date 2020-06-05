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
    public partial class frmMenu : Form
    {
        Form ventana;        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEjer04_Click(object sender, EventArgs e)
        {
            ventana = new frmArreglo10();
            //ventana.ShowDialog();
            btnEjer04.Enabled = false;
            ventana.FormClosed += new FormClosedEventHandler(frmArreglo10_FormClosed);
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana = new frmEmpl03();
            //ventana.ShowDialog();            
            btnEjer03.Enabled = false;            
            ventana.FormClosed += new FormClosedEventHandler(frmEmpl03_Closed);
            ventana.Show();
        }

        private void btnEjer05_Click(object sender, EventArgs e)
        {
            ventana = new frmEj05_Prods();
            //ventana.ShowDialog();
            btnEjer05.Enabled = false;
            ventana.FormClosed += new FormClosedEventHandler(frmEj05_Prods_FormClosed);
            ventana.Show();
        }

        private void btnEjer06_Click(object sender, EventArgs e)
        {
            ventana = new frmEj06_Prods_class();
            btnEjer06.Enabled = false;
            ventana.FormClosed += new FormClosedEventHandler(frmEj06_Prods_class_FormClosed);
            ventana.Show();
        }

        void frmEj05_Prods_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnEjer05.Enabled = true;
        }

        void frmEmpl03_Closed(object sender, FormClosedEventArgs e)
        {
            btnEjer03.Enabled = true;
        }

        void frmArreglo10_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnEjer04.Enabled = true;
        }

        void frmEj06_Prods_class_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnEjer06.Enabled = true;
        }
        
    }

    
}

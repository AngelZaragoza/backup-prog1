using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial_mascotas
{
    public partial class Form1 : Form
    {
        float contPerros = 0;
        float contMascotas = 0;
        float porcPerros = 0;
        float acumEdad = 0;
        float promEdad = 0;
        int contGatosHembra = 0;
        int bandera = 0;
        Mascota joven;
        //int edadMasJoven = 0;
        //string nombreMasJoven = "";
        //string propMasJoven = "";
        
        
        public Form1()
        {
            InitializeComponent();
            lblPerros.Text = "";
            lblGatas.Text = "";
            lblEdadPromedio.Text = "";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //CREAMOS UN OBJETO MASCOTA
            Mascota pet = new Mascota();
            contMascotas++;
            
            //CARGAMOS LOS DATOS EN EL OBJETO MASCOTA
            pet.pNombre = txtNombre.Text;
            pet.pPropietario = txtProp.Text;
            pet.pEdad = Convert.ToInt32(txtEdad.Text);
            pet.pSexo = rbtMacho.Checked;
            if (rbtPerro.Checked == true)
                pet.pTipo = 1;         
            else            
                pet.pTipo = 2;
            cargarLista(pet);

            //MOSTRAR LOS DATOS DEL OBJETO MASCOTA
            MessageBox.Show(pet.toString(),"Datos cargados");

            //CALCULAMOS PORC PERROS Y MOSTRAMOS EN ETIQUETA
            if (rbtPerro.Checked == true)
                contPerros++;

            porcPerros = (float) Math.Round((contPerros/contMascotas) * 100,2);
            lblPerros.Text = Convert.ToString(porcPerros);

            //CANTIDAD DE MASCOTAS TIPO GATO HEMBRA
            if (pet.pTipo == 2 && pet.pSexo == false)
                contGatosHembra++;

            lblGatas.Text = Convert.ToString(contGatosHembra);

            //CALCULAR PROMEDIO DE EDAD Y MOSTRAR
            acumEdad = acumEdad + pet.pEdad;
            promEdad = (float) Math.Round(acumEdad / contMascotas, 2);
            lblEdadPromedio.Text = Convert.ToString(promEdad);

            //MOSTRAR MASCOTA MAS JOVEN Y SU PROPIETARIO
            //CODIGO CON VARIABLES

            //if (bandera == 0)
            //{
            //    edadMasJoven = pet.pEdad;
            //    nombreMasJoven = pet.pNombre;
            //    propMasJoven = pet.pPropietario;
            //    bandera = 1;
            //}
            //else
            //    if (pet.pEdad < edadMasJoven)
            //    {
            //        edadMasJoven = pet.pEdad;
            //        nombreMasJoven = pet.pNombre;
            //        propMasJoven = pet.pPropietario;
            //    }
            //
            //MessageBox.Show("Mascota mas Joven: " + nombreMasJoven +
            //                "\nPropietario: " + propMasJoven);

            //MOSTRAR MASCOTA MAS JOVEN Y SU PROPIETARIO
            //CODIGO OPTIMIZADO USANDO OTRO OBJETO "MASCOTA"
            
            if (bandera == 0)
            {
                bandera = 1;
                joven = pet;
            }
            else
                if (pet.pEdad < joven.pEdad)
                    joven = pet;                
            MessageBox.Show("Mascota más Joven: " + joven.pNombre +
                            "\nPropietario: " + joven.pPropietario, "Info");

            limpiarCampos();
            txtNombre.Focus();
        }
        
        void limpiarCampos() 
        { 
            foreach (Control c in this.Controls) 
            { 
                if (c is TextBox)
                    c.Text = ""; 
            }
        }

        void cargarLista(Mascota m)
        {
            ListViewItem item = new ListViewItem(m.pNombre);
            item.SubItems.Add(m.pPropietario);
            item.SubItems.Add((m.pEdad).ToString());
            

            //lstCargados.Columns
            lstCargados.Items.Add(item);
        }
    }
}

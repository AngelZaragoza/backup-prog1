using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial_mascotas
{
    class Mascota
    {
        //ATRIBUTOS
        private string nombre;
        private string propietario;
        private int edad;
        private int tipo;
        private bool sexo;

        //CONSTRUCTORES
        //SIN PARAMETROS
        public Mascota()
        {
            nombre = "";
            propietario = "";
            edad = 0;
            tipo = 0;
            sexo = false;
        }

        //CON PARAMETROS
        public Mascota (string masc, string prop, int ed, int tp, bool sex) 
        {
            nombre = masc;
            propietario = prop;
            edad = ed;
            tipo = tp;
            sexo = sex;
        }

        //PROPIEDADES
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pPropietario
        {
            set { propietario = value; }
            get { return propietario; }
        }
        public int pEdad
        {
            set { edad = value; }
            get { return edad; }
        }
        public int pTipo
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }


        public string toString ()
        {
            string tip, sex;
            if (tipo == 1)
                tip = "Perro";
            else
                tip = "Gato";

            if (sexo == true)
                sex = "Macho";
            else
                sex = "Hembra";
            
            return "Nombre mascota: " + nombre + "\n" +
                  "Propietario: " + propietario + "\n" +
                  "Edad: " + edad + "\n" +
                  "Sexo: " + sex + "\n" +
                  "Tipo: " + tip;
        }
    }
}

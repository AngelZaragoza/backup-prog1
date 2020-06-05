using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrII_Un03_Ejs
{
    class Persona
    {
        string apellido;
        string nombres;
        int tipo_documento;
        double documento;
        int estadoCivil;
        int sexo;
        int fallecio;

        //CONSTRUCTORES
        public Persona()
        {
            apellido = "";
            nombres = "";
            tipo_documento = 0;
            documento = 0;
            estadoCivil = 0;
            sexo = 0;
            fallecio = 0;
        }

        public Persona(string ape, string nom, int tDoc, double doc, int eCiv, int sex, int fall)
        {
            apellido = ape;
            nombres = nom;
            tipo_documento = tDoc;
            documento = doc;
            estadoCivil = eCiv;
            sexo = sex;
            fallecio = fall;
        }

        //PROPIEDADES
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public string pNombres
        {
            set { nombres = value; }
            get { return nombres; }
        }

        public int pTipoDoc
        {
            set { tipo_documento = value; }
            get { return tipo_documento; }
        }

        public double pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }

        public int pEstCivil
        {
            set { estadoCivil = value; }
            get { return estadoCivil; }
        }

        public int pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public int pFallecio
        {
            set { fallecio = value; }
            get { return fallecio; }
        }

        //METODOS
        override public string ToString()
        {
            return apellido + ", " + nombres;
        }
    }
}

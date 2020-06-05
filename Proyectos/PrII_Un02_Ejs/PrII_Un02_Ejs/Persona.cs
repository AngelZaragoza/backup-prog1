using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrII_Un02_Ejs
{
    abstract class Persona
    {
        string nombre;
        int dni;
        int telefono;
        bool sexo;

        //CONSTRUCTORES
        public Persona()
        {
            nombre = "";
            dni = 0;
            telefono = 0;
            sexo = false;
        }

        public Persona(string nom, int doc, int tel, bool s)
        {
            nombre = nom;
            dni = doc;
            telefono = tel;
            sexo = s;
        }

        //PROPIEDADES
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int pDNI
        {
            set { dni = value; }
            get { return dni; }
        }

        public int pTelef
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        
        //METODOS
        public string toStringPersona()
        {
            string sx;
            if (sexo)
                sx = "Masculino";
            else
                sx = "Femenino";

            return "Nombre: " + nombre + "\nDNI: " + dni +
                   "\nTel.: " + telefono + "\nSexo: " + sx;
        }
    }
    
}

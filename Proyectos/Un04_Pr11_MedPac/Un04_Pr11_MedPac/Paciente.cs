using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Un04_Pr11_MedPac
{
    class Paciente:Persona
    {
        int obraSocial;
        int histClinica;

        //CONSTRUCTORES
        public Paciente()
            : base()
        {
            obraSocial = 0;
            histClinica = 0;
        }

        public Paciente(string nom, int doc, int tel, bool s, int os, int hCl)
            : base(nom, doc, tel, s)
        {
            obraSocial = os;
            histClinica = hCl;
        }

        //PROPIEDADES
        public int pObraSoc
        {
            set { obraSocial = value; }
            get { return obraSocial; }
        }
        public int pHistCl
        {
            set { histClinica = value; }
            get { return histClinica; }
        }

        //METODOS
        public string toStringObraSoc() //DEVUELVE OBRA SOCIAL
        {
            string os = "";
            switch (obraSocial)
            {
                case 1: os = "APROSS"; break;
                case 2: os = "IOSE"; break;
                case 3: os = "OSDE"; break;
                case 4: os = "OSECAC"; break;
                case 5: os = "SIPPSA"; break;
            }
            return os;
        }
        
        public string toStringPaciente()
        {
            //string os = "";
            //switch (obraSocial)
            //{
            //    case 1: os = "APROSS"; break;
            //    case 2: os = "IOSE"; break;
            //    case 3: os = "OSDE"; break;
            //    case 4: os = "OSECAC"; break;
            //    case 5: os = "SIPPSA"; break;
            //}
            return toStringPersona() + "\nObra Social: " + 
                this.toStringObraSoc() + "\nNro. Historia Clínica: " + histClinica;
        }

    }
}

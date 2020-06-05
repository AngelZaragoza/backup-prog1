using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrII_Un03_Ejs
{
    class Alumno: Persona
    {
        int carrera;
        DateTime fechaNac;
        string calle;
        int numero;
        bool activo;
        bool hijos;
        int cantHijos;

        //CONSTRUCTORES
        public Alumno()
            : base()
        {
            carrera = 0;
            fechaNac = DateTime.Today;
            calle = "";
            numero = 0;
            activo = false;
            hijos = false;
            cantHijos = 0;
        }

        public Alumno(string ape, string nom, int tDoc, double doc, int eCiv, int sex, int fall,
                      int carr, DateTime fNac, string calle, int nro, bool act, bool h, int cantH)
            : base(ape, nom, tDoc, doc, eCiv, sex, fall)
        {
            carrera = carr;
            fechaNac = fNac;
            this.calle = calle;
            numero = nro;
            activo = act;
            hijos = h;
            cantHijos = cantH;
        }

        //PROPIEDADES
        public int pCarrera
        {
            set { carrera = value; }
            get { return carrera; }
        }

        public DateTime pFechaNac
        {
            set { fechaNac = value; }
            get { return fechaNac; }
        }

        public string pCalle
        {
            set { calle = value; }
            get { return calle; }
        }

        public int pNumero
        {
            set { numero = value; }
            get { return numero; }
        }

        public bool pActivo
        {
            set { activo = value; }
            get { return activo; }
        }

        public bool pHijos
        {
            set { hijos = value; }
            get { return hijos; }
        }

        public int pCantHijos
        {
            set { cantHijos = value; }
            get { return cantHijos; }
        }

        //METODOS
    }
}

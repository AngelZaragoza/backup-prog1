using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrII_Un02_Ejs
{
    class Empleado : Persona
    {
        //ATRIBUTOS
        double sueldo;
        int legajo;

        //CONSTRUCTORES
        public Empleado()
            : base()
        {
            sueldo = 0;
            legajo = 0;
        }

        public Empleado(string nom, int doc, int tel, bool sx, double sd, int leg)
            : base(nom, doc, tel, sx)
        {
            sueldo = sd;
            legajo = leg;
        }

        //PROPIEDADES
        public double pSueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        //METODOS
        public double calcularNeto(double increm)
        {
            double neto = 0;
            neto = sueldo  + (sueldo * increm / 100);
            
            return neto;
        }
        
        public string toStringEmpleado()
        {
            return base.toStringPersona() +
                "\nLegajo nro. " + legajo +
                "\nSueldo: $" + sueldo;
        }

    }
}

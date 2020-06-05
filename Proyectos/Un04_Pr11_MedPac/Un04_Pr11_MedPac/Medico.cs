using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Un04_Pr11_MedPac
{
    class Medico:Persona
    {
        int especialidad;
        double consulta;

        //CONSTRUCTORES
        public Medico()
            : base()
        {
            especialidad = 0;
            consulta = 0;
        }

        public Medico(string nom, int doc, int tel, bool s, int espec, double cons)
            : base(nom, doc, tel, s)
        {
            especialidad = espec;
            consulta = cons;
        }

        //PROPIEDADES
        public int pEspec
        {
            set { especialidad = value; }
            get { return especialidad; }
        }
        public double pConsulta
        {
            set { consulta = value; }
            get { return consulta; }
        }

        //METODOS
        public string toStringEspec()  //DEVUELVE LA ESPECIALIDAD
        {
            string esp = "";
            switch (especialidad)
            {
                case 1: esp = "Clínica"; break;
                case 2: esp = "Ginecología"; break;
                case 3: esp = "Neurología"; break;
                case 4: esp = "Urología"; break;
                case 5: esp = "Pediatría"; break;
                case 6: esp = "Reumatología"; break;
                case 7: esp = "Traumatología"; break;
            }
            return esp;
        }
        
        public string toStringMedico()
        {            
            return toStringPersona() + "\nEspecialidad: " +
                this.toStringEspec() + "\nCosto Consulta: $" + consulta;
        }
    }
}

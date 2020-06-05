using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog_equipos
{
    class Equipo
    {
        //Atributos
        String nombre, categoria, provincia;
        DateTime fechaInsc;
        int puntos, golesFavor, golesContra;

        //Constructores
        public Equipo ()
        {
            nombre = "";
            categoria = "";
            provincia = "";
            fechaInsc = DateTime.Today;
            puntos = 0;
            golesFavor = 0;
            golesContra = 0;
        }

        public Equipo(string nom, string categ, string pcia, DateTime fecInsc, int ptos, int golMas, int golCont)
        {
            nombre = nom;
            categoria = categ;
            provincia = pcia;
            fechaInsc = fecInsc;
            puntos = ptos;
            golesFavor = golMas;
            golesContra = golCont;
        }

        //Propiedades
        public String pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public String pCateg
        {
            set { categoria = value; }
            get { return categoria; }
        }
        public String pProv
        {
            set { provincia = value; }
            get { return provincia; }
        }
        public DateTime pFecha
        {
            set { fechaInsc = value; }
            get { return fechaInsc; }
        }
        public int pPuntos
        {
            set { puntos = value; }
            get { return puntos; }
        }
        public int pGolesFavor
        {
            set { golesFavor = value; }
            get { return golesFavor; }
        }
        public int pGolesContra
        {
            set { golesContra = value; }
            get { return golesContra; }
        }
    }
}

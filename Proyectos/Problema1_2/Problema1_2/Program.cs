using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema1_2
{
    class Cilindro
    {
        private double r, h;
        
        //Propiedades
        public double pRadio
        {
             set { r = value; }
             get { return r; } 
        }
        public double pAltura
        {
            set { h = value; }
            get { return h; }
        }

        //Métodos
        public double volumenC()
        {
            return (Math.PI * Math.Pow(pRadio, 2) * pAltura);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double volSilo, radio, altura;
            Cilindro silo1 = new Cilindro();
            silo1.pAltura = 4.15;
            silo1.pRadio = 1.34;
            volSilo = silo1.volumenC();
            Console.WriteLine("El volumen del primer silo es " + volSilo);
            //Console.ReadKey();
            //Cilindro silo2 = new Cilindro();
            //Console.Write("Ingrese radio de la base del segundo silo: ->");
            //silo2.pRadio = Double.TryParse (Console.ReadLine(), out radio);
            //Console.WriteLine("El radio del segundo silo es " + silo2.pRadio);
            //Console.ReadKey();
        }
    }
}

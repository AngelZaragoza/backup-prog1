using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrII_Un02_Ejs
{
    class Producto
    {
        //ATRIBUTOS
        string nombreProd;
        string unMedida;        
        int stock;
        double preUnit;

        //CONSTRUCTORES
        public Producto()
        {
            nombreProd = "";
            unMedida = "";
            stock = 0;
            preUnit = 0;
        }

        public Producto(string prod, string unMed, int st, double prUn)
        {
            nombreProd = prod;
            unMedida = unMed;
            stock = st;
            preUnit = prUn;
        }

        //PROPIEDADES
        public string pProducto
        {
            set { nombreProd = value; }
            get { return nombreProd; }
        }

        public string pUnMed
        {
            set { unMedida = value; }
            get { return unMedida; }
        }

        public int pStock
        {
            set { stock = value; }
            get { return stock; }
        }

        public double pPreUnit
        {
            set { preUnit = value; }
            get { return preUnit; }
        }

        //METODOS
        public double calcularTotal(double cant)
        {
            double total = preUnit * cant;
            return total;
        }
    }
}

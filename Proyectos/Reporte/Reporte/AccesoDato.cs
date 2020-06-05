using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//conexion al  abm
using System.Data;
using System.Data.OleDb;

namespace Reporte
{
    class AccesoDato
    {
        //necesario para canectarse
        private OleDbConnection Conexion;
        private OleDbCommand Comando;
        private OleDbDataReader Lector;
        private string Cadena_Conexion;

        public OleDbDataReader pLector
        {
            set { Lector = value; }
            get { return Lector; }
        }

        public string pCadena_Conexion
        {
            set { Cadena_Conexion = value; }
            get { return Cadena_Conexion; }
        }

        public AccesoDato()
        {
            this.Conexion = new OleDbConnection();
            this.Comando = new OleDbCommand();
            this.Lector = null;
            this.Cadena_Conexion = null;
        }
        //acceso dato
        public AccesoDato(string CadenaConexion)
        {
            this.Conexion = new OleDbConnection();
            this.Comando = new OleDbCommand();
            this.Lector = null;
            this.Cadena_Conexion = CadenaConexion;
        }
        //abrir conexion
        public void Conectar()
        {
            Conexion.ConnectionString = Cadena_Conexion;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;

        }

        //cerrar conexion
        public void Desconectar()
        {
            Conexion.Close();

        }
        //consultar tabla
        public DataTable ConsultarTabla(string NombreTabla)
        {
            DataTable Tabla = new DataTable();
            Conectar();
            Comando.CommandText = "select * from " + NombreTabla;
            Tabla.Load(Comando.ExecuteReader());


            return Tabla;
        }

        //leer tabla 
        public void LeerTabla(string NombreTabla)
        {
            Conectar();
            Comando.CommandText = "select * from " + NombreTabla;
            Lector = Comando.ExecuteReader();

        }

        //consulta sql

        public DataTable ConsultarBD(string ConsultaSQL)
        {
            DataTable Tabla = new DataTable();
            Conectar();
            Comando.CommandText = ConsultaSQL;
            Tabla.Load(Comando.ExecuteReader());
            Desconectar();
            return Tabla;
        }

        public void ActualizarBD(string ConsultaSQL)
        {
            Conectar();
            Comando.CommandText = ConsultaSQL;
            Comando.ExecuteNonQuery();
            Desconectar();
        }



    }
}


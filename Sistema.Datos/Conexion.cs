using System;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class Conexion
    {
        private static Conexion Con = null;

        private Conexion()
        {

        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Data Source=DESKTOP-L8V665E;Initial Catalog=DBSistema;User ID=sa;Password=Samupi7185467*";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}

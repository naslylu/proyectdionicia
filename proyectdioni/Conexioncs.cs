using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectdioni
{
    internal class Conexioncs
    {
        SqlConnection cnx;
        public Conexioncs()
        {
            cnx = new SqlConnection("Data Source=DESKTOP-DE-NAS;Initial Catalog=SISTEMA_VENTASS;User ID=sa;Password=0311;Trust Server Certificate=True");
        }
        public SqlConnection conectarbd = new SqlConnection();

        public class Conexionbd
        {
            private SqlConnection conectarbd;
            private string cadena;

            public Conexionbd(string cadenaConexion)
            {
                conectarbd = new SqlConnection();
                cadena = cadenaConexion;
                conectarbd.ConnectionString = cadena;
            }
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("conexion abrierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir" + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }


}


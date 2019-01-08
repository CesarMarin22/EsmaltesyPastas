using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregadas
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace jorgeantonio
{
    class conexion
    {
        private SqlConnection cn;//conexion
        private SqlCommand cmd;//comando

        //para crear y conectar
        public conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=MARIN-PC\\SQLEXPRESS;Initial Catalog=EsmaltesyPastas; Integrated Security=True");
                cn.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo abrir. Error: " + ex);
            }
        }

        public void cerrarConexion()
        {
            cn.Close();
        }

        public SqlConnection regresaConexion()
        {
            return cn;
        }
    }
}

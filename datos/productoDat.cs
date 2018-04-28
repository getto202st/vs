using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entidad;
using System.Data.SqlClient;
using System.Data;

namespace datos
{

    public class productoDat
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cnn;

        

        private DataTable llenar(conex mycn, productoEnt prd)
        {
            cnn = new SqlConnection(mycn.conectar());
            
            cmd = new SqlCommand("sp_llenar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    
}

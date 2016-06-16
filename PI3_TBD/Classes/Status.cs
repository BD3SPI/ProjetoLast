using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace MVC.Classes
{
    class Status
    {
        public string codStatus { get; set; }
        public string descStatus { get; set; }


        public static List<Status> SelecionarStatus()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select * FROM status ";

            SqlDataReader rd = cmd.ExecuteReader();
            List<Status> status = new List<Status>();

            while (rd.Read())
            {
                Status st = new Status();
                st.codStatus =(rd["codstatus"].ToString());
                st.descStatus = rd["descStatus"].ToString();
                status.Add(st);
            }
            cn.Close();
            cn.Dispose();
            return status;
        }
    }
}

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
    class tipoEvento
    {
        public string codtipoEvento { get; set; }
        public string descTipoEvento { get; set; }

        public static List<tipoEvento> SelecionarTp()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select * FROM tipoevento ";
            SqlDataReader rd = cmd.ExecuteReader();
            List<tipoEvento> status = new List<tipoEvento>();

            while (rd.Read())
            {
                tipoEvento tp = new tipoEvento();
                tp.codtipoEvento = rd["codtipoEvento"].ToString();
                tp.descTipoEvento = rd["descTipoEvento"].ToString();
                status.Add(tp);
            }
            cn.Close();
            cn.Dispose();
            return status;
        }
    }
}

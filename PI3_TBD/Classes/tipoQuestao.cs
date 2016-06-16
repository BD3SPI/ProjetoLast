using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MVC.Classes
{
    class tipoQuestao
    {
        public string codTipoQuestao { get; set; }
        public string descricao { get; set; }


        public static List<tipoQuestao> SelecionarTipo()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codtipoquestao, descricao FROM tipoQuestao";

            SqlDataReader dr = cmd.ExecuteReader();
            List<tipoQuestao> tipos = new List<tipoQuestao>();

            while (dr.Read())
            {
                tipoQuestao tpe = new tipoQuestao();
                tpe.codTipoQuestao = dr["codtipoquestao"].ToString();
                tpe.descricao = dr["descricao"].ToString();
                tipos.Add(tpe);
            }

            cn.Close();
            cn.Dispose();
            return tipos;
        }

    }
}

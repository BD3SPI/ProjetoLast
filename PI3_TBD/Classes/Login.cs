using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MVC.Telas;


namespace MVC.Classes
{

    class Login
    {
        public bool ValidarLogin(string email, string senha)
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select codProfessor, nome, email, tipo from Professor where email = @email and senha = HASHBYTES('SHA1', @senha)";
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 30).Value = email;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar, 20).Value = senha;

            SqlDataReader dr = cmd.ExecuteReader();
            bool valido = dr.HasRows;

            while (dr.Read())
            {
                Sessao.cod = (dr["codProfessor"].ToString());
                Sessao.nome = Convert.ToString(dr["nome"]);
                Sessao.email = Convert.ToString(dr["email"]);
                Sessao.tipo = Convert.ToChar (dr["tipo"].ToString());


            }
            dr.Close();

            return valido;
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MVC.Classes;
using System.Windows.Forms;
using System.Collections;


namespace MVC.Classes
{
    class Conexao
    {
        public static SqlConnection con;
        //
        //Criação das funções que realizarão a conexão com o Banco
        public static SqlConnection AbrirConexao()
        {
            //Instanciando Conexão
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            //Parâmetros de conexão a serem inseridos
            sb.DataSource = "koo2dzw5dy.database.windows.net";
            sb.InitialCatalog = "SenaQuiz";
            sb.UserID = "TSI";
            sb.Password = "SistemasInternet123";
            con = new SqlConnection(sb.ConnectionString);
            //Realização de abertura de conexão com o Banco
            //auuuu
            try
            {
                con.Open();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

            return con;
        }

        public static SqlConnection FecharConexao()
        {
            //Realização de encerramento de conexão com o Banco
            try
            {
                con.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            return con;
        }

    }
}

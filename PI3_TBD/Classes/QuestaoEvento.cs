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
    class QuestaoEvento
    {
        public string codEvento { get; set; }
        public string codQuestao { get; set; }
        public string status { get; set; }
        public string tempo { get; set; }


        public void Inserir()
        {
            try
            {
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "INSERT INTO QUESTAOEVENTO (codEVENTO, CODQUESTAO, CODSTATUS) values (@codevento, @codQuestao, @Status)";
                cmd.Parameters.Add("@codevento", SqlDbType.Int).Value = this.codEvento;
                cmd.Parameters.Add("@codQuestao", SqlDbType.Int).Value = this.codQuestao;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 5).Value = this.status;
                //cmd.Parameters.Add("@tempo", SqlDbType.DateTime).Value = this.tempo;
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
            }

            catch (ArgumentException)
            {
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir pergunta para esse evento. Certifique se, se  essa questão já está agregada para  esse evento");

            }

        }

        public void Excluir(string codevento, string codQuestao)
        {
            try
            {
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM QUESTAOEVENTO WHERE codevento =" + codevento + "and codQuestao =" + codQuestao;
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro ao mandar o comando SQL para o Banco de dados");
            }
        }
    }
}

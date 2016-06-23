using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MVC.Classes
{
    class Alternativa
    {
        public string texto { get; set; }
        public int correta { get; set; }
        public string codigo { get; set; }
        public int contador { get; set; }
        public string codquestao { get; set; }

        //Teste Alternativa
        public void insertTpAlternativas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INSERT INTO alternativa(codquestao,codalternativa,textoalternativa,correta) VALUES(@codquestao,@codalternativa,@textoalternativa,@correta)");

            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sb.ToString();
            cmd.Parameters.AddWithValue("@codquestao", SqlDbType.Int).Value = this.codquestao;
            cmd.Parameters.AddWithValue("@codalternativa", SqlDbType.Int).Value = this.contador;
            cmd.Parameters.AddWithValue("@textoalternativa", SqlDbType.VarChar).Value = this.texto;
            cmd.Parameters.AddWithValue("@correta", SqlDbType.Bit).Value = this.correta;

            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }


        public int ValidarAlternativaCorreta(string id)
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT Count(*) correta from alternativa where correta = 1 and codquestao =" + id;

            SqlDataReader dr = cmd.ExecuteReader();
            bool valido = dr.HasRows;

            int quant = 0;
            while (dr.Read())
            {
                quant = Convert.ToInt32(dr["correta"].ToString());

            }

            return quant;

            dr.Close();
            dr.Dispose();
        }

        public void insereVouF()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO alternativa(codalternativa,codquestao,correta,textoalternativa) VALUES(@codalternativa,@codquestao,@correta,@textoalternativa)");

                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@textoalternativa", SqlDbType.VarChar).Value = "";
                cmd.Parameters.AddWithValue("@codalternativa", SqlDbType.Int).Value = this.contador;
                cmd.Parameters.AddWithValue("@codquestao", SqlDbType.Int).Value = this.codquestao;
                cmd.Parameters.AddWithValue("@correta", SqlDbType.Bit).Value = this.correta;

                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Já há uma alternativa correta para esta questão. Por gentileza, verifique as alternativas cadastradas");

            }
        }

        public Alternativa()
        {

            this.contador = 3;
        }

        public int novoIdAlternativas(string ultimoId)
        {
            string sql = "select max(codalternativa) from alternativa where codquestao  =" + ultimoId;
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            int codigo;
            codigo = rd.GetInt32(0);

            return codigo;

        }


        public void PreencherDataGridAlternativa(DataGridView tex, string id)
        {
            SqlConnection conn = Conexao.AbrirConexao();

            if (conn == null)
            {
                //MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");

            }
            else
            {


                if (tex.DataSource != null)
                {
                    tex.DataSource = null;
                }
                else
                {
                    tex.Rows.Clear();

                }

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = "SELECT textoalternativa AS 'Texto', codAlternativa, correta from ALTERNATIVA WHERE CODQUESTAO = " + id;


                    var dataTable = new DataTable();
                    using (var reader = comm.ExecuteReader())
                    {

                        dataTable.Load(reader);
                        reader.Close();
                        reader.Dispose();


                    }
                    tex.DataSource = dataTable;
                    tex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    tex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    tex.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    tex.Columns[0].Visible = true;
                    //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dataGridView1.Columns[3].Visible = false;
                }

                conn.Close();
                conn.Dispose();

            }
        }
        public List<Alternativa> listarAlternativa(string codQ)
        {
            try
            {
                //int c = Convert.ToInt32(codQ);
                string sql = "select textoAlternativa,codAlternativa from Alternativa where codquestao = @cod";
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cod", SqlDbType.Int).Value = codQ;
                SqlDataReader rd = cmd.ExecuteReader();
                List<Alternativa> lst = new List<Alternativa>();
                while (rd.Read())
                {
                    Alternativa a = new Alternativa();
                    a.texto = rd["textoAlternativa"].ToString();
                    a.codigo = rd["codAlternativa"].ToString();
                    lst.Add(a);
                }
                return lst;
                con.Dispose();
                con.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        public static void Excluir(string codquestao)
        {
            try
            {
                string sql1 = "DELETE FROM alternativa where codquestao =" + codquestao;
                string sql = "DELETE FROM questao where codquestao =" + codquestao;
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql1 + sql;

                cmd.ExecuteNonQuery();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha na exclusão");
            }


        }
    }
}

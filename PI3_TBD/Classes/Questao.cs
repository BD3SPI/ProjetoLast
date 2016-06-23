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
    class Questao
    {
        public string codQuestao { get; set; }
        public string textoQuestao { get; set; }
        public Assunto assunto { get; set; }
        public int ativo { get; set; }
        public string atividade { get; set; }
        public Professor professor { get; set; }
        public string dificuldade { get; set; }
        public tipoQuestao tipoQuestao { get; set; }
        public Alternativa alternativa { get; set; }
        public int codImagem { get; set; }

        public override string ToString()
        {
            return textoQuestao;
        }
        public Questao()
        {
            this.assunto = new Assunto();
            this.tipoQuestao = new tipoQuestao();
            this.professor = new Professor();
            this.alternativa = new Alternativa();
        }

        public void Inserir()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO QUESTAO(TEXTOQUESTAO,CODASSUNTO,CODTIPOQUESTAO,CODPROFESSOR,ATIVO,DIFICULDADE) VALUES(@TEXTO,@CODASSUNTO,@CODTIPOQUESTAO,@CODPROFESSOR,@ATIVO,@DIFICULDADE)");


            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sb.ToString();
            cmd.Parameters.AddWithValue("@TEXTO", SqlDbType.VarChar).Value = this.textoQuestao;
            cmd.Parameters.AddWithValue("@CODASSUNTO", SqlDbType.Int).Value = this.assunto.codigo;
            cmd.Parameters.AddWithValue("@CODTIPOQUESTAO", SqlDbType.Char).Value = this.tipoQuestao.codTipoQuestao;
            cmd.Parameters.AddWithValue("@CODPROFESSOR", SqlDbType.Int).Value = this.professor.codigo;
            cmd.Parameters.AddWithValue("@ATIVO", SqlDbType.Bit).Value = this.ativo;
            cmd.Parameters.AddWithValue("@DIFICULDADE", SqlDbType.Char).Value = this.dificuldade;
            //cmd.Parameters.AddWithValue("@TextoAlternativa", SqlDbType.VarChar).Value = this.alternativa.texto;
            //cmd.Parameters.AddWithValue("@Correta", SqlDbType.Bit).Value = this.alternativa.correta;
            //cmd.Parameters.AddWithValue("@contador", SqlDbType.Int).Value = this.alternativa.contador;


            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();


        }
        public void InserirImagem()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("INSERT INTO ");
            //sb.AppendLine("SELECT @x = SCOPE_IDENTITY ()");
            //sb.AppendLine("DECLARE @x int ");
            sb.AppendLine("INSERT INTO QUESTAO(TEXTOQUESTAO,CODASSUNTO,CODIMAGEM,CODTIPOQUESTAO,CODPROFESSOR,ATIVO,DIFICULDADE) VALUES(@TEXTO,@CODASSUNTO,@CODIMAGEM,@CODTIPOQUESTAO,@CODPROFESSOR,@ATIVO,@DIFICULDADE)");


            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sb.ToString();
            cmd.Parameters.AddWithValue("@TEXTO", SqlDbType.VarChar).Value = this.textoQuestao;
            cmd.Parameters.AddWithValue("@CODASSUNTO", SqlDbType.Int).Value = this.assunto.codigo;
            cmd.Parameters.AddWithValue("@CODIMAGEM", SqlDbType.Int).Value = Imagem.codImagem;
            cmd.Parameters.AddWithValue("@CODTIPOQUESTAO", SqlDbType.Char).Value = this.tipoQuestao.codTipoQuestao;
            cmd.Parameters.AddWithValue("@CODPROFESSOR", SqlDbType.Int).Value = this.professor.codigo;
            cmd.Parameters.AddWithValue("@ATIVO", SqlDbType.Bit).Value = this.ativo;
            cmd.Parameters.AddWithValue("@DIFICULDADE", SqlDbType.Char).Value = this.dificuldade;
            //cmd.Parameters.AddWithValue("@TextoAlternativa", SqlDbType.VarChar).Value = this.alternativa.texto;
            //cmd.Parameters.AddWithValue("@Correta", SqlDbType.Bit).Value = this.alternativa.correta;
            //cmd.Parameters.AddWithValue("@contador", SqlDbType.Int).Value = this.alternativa.contador;


            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();


        }

        public void PreencherDataGridQuestao(DataGridView tex)
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
                    comm.CommandText = "SELECT codquestao as 'ID', Textoquestao As 'Pergunta' FROM Questao";


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
                    //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dataGridView1.Columns[3].Visible = false;
                }

                conn.Close();
                conn.Dispose();

            }


        }

        public void PreencherDataGridPerguntasdaQuestao(DataGridView tex, string cod)
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
                    //"SELECT codquestao as 'ID', Textoquestao As 'Pergunta' FROM Questao";
                    comm.CommandText = "SELECT ce.codevento, q.Textoquestao, ce.codquestao FROM questaoevento ce inner join Questao q ON ce.codquestao = q.codquestao where codevento = " + cod;


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
                    //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dataGridView1.Columns[3].Visible = false;
                }

                conn.Close();
                conn.Dispose();

            }


        }

        public static List<Questao> SelecionarQuestao(int cod)
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codquestao, textoquestao FROM questao where codassunto =" + cod;

            SqlDataReader dr = cmd.ExecuteReader();
            List<Questao> questoes = new List<Questao>();

            while (dr.Read())
            {
                Questao q = new Questao();
                q.codQuestao = dr["codquestao"].ToString();
                q.textoQuestao = dr["textoquestao"].ToString();
                questoes.Add(q);
            }

            cn.Close();
            cn.Dispose();
            return questoes;


        }

        public static string idQuestao(string textoQ)
        {
            string codigo = "";
            string sql = "select CODQUESTAO from QUESTAO where TEXTOQUESTAO = '" + textoQ + "'";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                codigo = rd["CODQUESTAO"].ToString();

            }

            return codigo;
        }

        public void Alterar(string texto)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE QUESTAO SET TEXTOQUESTAO = @TEXTOQUESTAO, CODASSUNTO = @CODASSUNTO, CODIMAGEM = @CODIMAGEM,  CODTIPOQUESTAO = @CODTIPOQUESTAO, ativo= @ativo, DIFICULDADE = @DIFICULDADE WHERE CODQUESTAO = " + texto;

                cmd.Parameters.Add("@TEXTOQUESTAO", SqlDbType.VarChar).Value = this.textoQuestao;
                cmd.Parameters.Add("@CODASSUNTO", SqlDbType.Int).Value = this.assunto.codigo;
                cmd.Parameters.Add("@CODIMAGEM ", SqlDbType.Int).Value = Imagem.codImagem;
                cmd.Parameters.Add("@CODTIPOQUESTAO", SqlDbType.Char).Value = this.tipoQuestao.codTipoQuestao;
                cmd.Parameters.Add("@ativo", SqlDbType.Char, 1).Value = this.ativo;
                cmd.Parameters.Add("@DIFICULDADE", SqlDbType.Char, 1).Value = this.dificuldade;

                cmd.ExecuteNonQuery();


                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }


        public void Alterarsemimagem(string texto)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE QUESTAO SET TEXTOQUESTAO = @TEXTOQUESTAO, CODASSUNTO = @CODASSUNTO,   CODTIPOQUESTAO = @CODTIPOQUESTAO, ativo= @ativo, DIFICULDADE = @DIFICULDADE WHERE CODQUESTAO = " + texto;

                cmd.Parameters.Add("@TEXTOQUESTAO", SqlDbType.VarChar).Value = this.textoQuestao;
                cmd.Parameters.Add("@CODASSUNTO", SqlDbType.Int).Value = this.assunto.codigo;

                cmd.Parameters.Add("@CODTIPOQUESTAO", SqlDbType.Char).Value = this.tipoQuestao.codTipoQuestao;
                cmd.Parameters.Add("@ativo", SqlDbType.Char, 1).Value = this.ativo;
                cmd.Parameters.Add("@DIFICULDADE", SqlDbType.Char, 1).Value = this.dificuldade;

                cmd.ExecuteNonQuery();


                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }
        public List<Questao> listarQuestao()
        {
            try
            {
                string sql = "select textoquestao, codquestao from questao where codtipoquestao = @codtipoquestao and codassunto = @codassunto and codprofessor = @codprofessor";
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@codtipoquestao", SqlDbType.Char).Value = this.tipoQuestao.codTipoQuestao;
                cmd.Parameters.AddWithValue("@codassunto", SqlDbType.Int).Value = this.assunto.codigo;
                cmd.Parameters.AddWithValue("@codprofessor", SqlDbType.Int).Value = this.professor.codigo;

                SqlDataReader rd = cmd.ExecuteReader();
                List<Questao> lst = new List<Questao>();
                while (rd.Read())
                {
                    Questao Q = new Questao();
                    Q.textoQuestao = rd.GetString(0);
                    Q.codQuestao = rd.GetInt32(1).ToString();

                    lst.Add(Q);

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

        public static bool verificaDependecia(string codquestao)
        {
            string sql = "select count(*) from questaoevento where codquestao =" + codquestao;
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            //SqlDataReader rd = cmd.ExecuteReader();
            Int32 codigo = 0;
            codigo = (Int32)cmd.ExecuteScalar();
            bool verifica;
            if (codigo > 0)

                verifica = true;

            else
                verifica = false;

            return verifica;
        }
        public static void Excluir(string codquestao)
        {
            try
            {
                string sql1 = "DELETE FROM alternativa where codquestao =" + codquestao ;
                string sql = "DELETE FROM questao where codquestao =" + codquestao;
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql1+sql;

                cmd.ExecuteNonQuery();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha na exclusão");
            }


        }
    }
}

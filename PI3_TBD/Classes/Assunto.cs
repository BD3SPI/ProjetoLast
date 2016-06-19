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
    class Assunto
    {
        public string descricao { get; set; }
        //public string idarea { get; set; }
        public int codigo { get; set; }

        public Area area { get; set; }


        public Assunto()
        {
            this.area = new Area();
        }

        public override string ToString()
        {
            return descricao;
        }


        public void Inserir()
        {
            try
            {
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "INSERT  into ASSUNTO (Descricao, codarea) VALUES (@descricao, @codarea)";

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 70).Value = this.descricao;
                cmd.Parameters.Add("@codarea", SqlDbType.VarChar, 20).Value = this.area.codarea;

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Cadastro efetuado com sucesso");
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro");

            }

            catch (Exception)
            {
                MessageBox.Show("Numero de caracter superir ao permitido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void PreencherDataGridAssunto(DataGridView tex)
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
                    comm.CommandText = "SELECT A.codAssunto, A.descricao 'Assunto', R.descricao 'Area' From Assunto A inner join Area R ON A.codarea = r.codarea";


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
                    tex.Columns[0].Visible = false;
                    //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dataGridView1.Columns[3].Visible = false;
                }

                conn.Close();
                conn.Dispose();

            }
        }


        public SqlDataReader Carregargrid(int id)
        {
            string sql = "SELECT A.codAssunto, A.descricao 'Assunto', R.descricao 'Area' From Assunto A inner join Area R ON A.codarea = r.codarea where codassunto =" + id;
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {

                return reader;
            }






        }
        public static List<Assunto> listarAssuntos()
        {
            string sql = "SELECT distinct codassunto,descricao FROM ASSUNTO order by descricao asc";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();

            List<Assunto> assuntos = new List<Assunto>();

            while (rd.Read())
            {
                Assunto a = new Assunto();
                a.codigo = Convert.ToInt32(rd["codassunto"].ToString());
                a.descricao = rd["descricao"].ToString();
                assuntos.Add(a);
            }
            con.Close();
            con.Dispose();
            return assuntos;




        }

        public static List<Assunto> SelecionarAssunto()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codassunto, descricao FROM assunto";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Assunto> Assuntos = new List<Assunto>();

            while (dr.Read())
            {
                Assunto assunto = new Assunto();
                assunto.descricao = dr["descricao"].ToString();
                assunto.codigo = Convert.ToInt32(dr["codassunto"]);
                Assuntos.Add(assunto);
            }

            cn.Close();
            cn.Dispose();
            return Assuntos;



        }

        public static List<Assunto> listadescricaoAssunto(string assunto)
        {
            try
            {
                string sql = "select descricao from assunto where codArea = " + assunto;
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader rd = cmd.ExecuteReader();
                List<Assunto> lst = new List<Assunto>();
                while (rd.Read())
                {
                    Assunto a = new Assunto();
                    a.descricao = (rd.GetString(0));
                    lst.Add(a);

                }
                return lst;
                con.Close();

            }
            catch (ArgumentException ex)
            {
                throw ex;

            }

        }


        public Assunto preencherCampos(string descricao)
        {
            string sql = "SELECT A.codAssunto, A.descricao 'Assunto', R.descricao 'Area' From Assunto A inner join Area R ON A.codarea = r.codarea where a.descricao like '%" + descricao + "%'";
            //string sql = "SELECT *  FROM Assunto";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            Assunto a = new Assunto();
            try
            {
                while (rd.Read())
                {

                    a.codigo = Convert.ToInt32(rd["codAssunto"]);
                    a.descricao = (rd["Assunto"].ToString());
                    a.area.codarea = (rd["Area"].ToString());
                }

                return a;
            }

            catch (ArgumentException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void Excluir(int cod)
        {
            try
            {
                string sql = "DELETE FROM assunto where codAssunto =" + cod;
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha na exclusão");
            }

        }

        public void Alterar(int cod)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE assunto SET descricao = @descricao, codArea = @codArea where codAssunto =" + cod;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 50).Value = this.descricao;
                cmd.Parameters.Add("@codArea", SqlDbType.Int).Value = this.area.codarea;

                cmd.ExecuteNonQuery();


                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }




        }

    }
}

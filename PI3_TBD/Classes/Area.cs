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
    class Area
    {
        public string descricao { get; set; }
        public string codarea { get; set; }

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

                cmd.CommandText = "INSERT INTO area (descricao) values (@descricao)";
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 50).Value = this.descricao;

                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
            }

            catch (ArgumentException)
            {
            }

        }

        public void PreencherDataGrid(DataGridView tex)
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
                    comm.CommandText = "SELECT codArea as 'ID', descricao As 'Descrição' FROM area";
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

        public static List<Area> SelecionarArea()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codArea, descricao FROM area";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Area> Areas = new List<Area>();

            while (dr.Read())
            {
                Area area = new Area();
                area.codarea = dr["codArea"].ToString();
                area.descricao = dr["descricao"].ToString();
                Areas.Add(area);
            }

            cn.Close();
            cn.Dispose();
            return Areas;






        }

        public static List<Area> ListaArea(string descricao)
        {

            try
            {
                String sql = "SELECT DESCRICAO FROM AREA where descricao like '%" + descricao + "%'";
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader rd = cmd.ExecuteReader();
                List<Area> lst = new List<Area>();
                while (rd.Read())
                {
                    Area a = new Area();
                    a.descricao = (rd.GetString(0));
                    lst.Add(a);
                }
                cn.Close();
                return lst;

            }
            catch (ArgumentException ex)
            {
                throw ex;

            }
        }


        public Area preencherCampos(string descricao)
        {
            string sql = "SELECT codarea, descricao FROM AREA WHERE descricao like '%" + descricao + "%'";
            //string sql = "SELECT *  FROM Assunto";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            Area a = new Area();
            try
            {
                while (rd.Read())
                {

                    a.codarea = (rd["codarea"].ToString());
                    a.descricao = (rd["descricao"].ToString());

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


        public static void Excluir(int id)
        {
            try
            {
                string sql = "DELETE FROM AREA WHERE codarea =" + id;
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro");

            }




        }

        public void Alterar(int id)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE Area SET descricao = @descricao where codarea =" + id;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 50).Value = this.descricao;
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

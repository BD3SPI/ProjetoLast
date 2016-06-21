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
    //
    class Professor
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string idSenac { get; set; }
        public string tipo { get; set; }
        public Area area { get; set; }

        public Professor()
        {
          

        }

        public override string ToString()
        {
            return nome;
        }




        public void Inserir()
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO Professor (nome, email, senha, idSenac, tipo) VALUES (@nome, @email, HASHBYTES('SHA1',@senha), @idSenac, @tipo)";

                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = this.email;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar, 50).Value = this.senha;
                cmd.Parameters.Add("@idSenac", SqlDbType.Char, 6).Value = this.idSenac;
                cmd.Parameters.Add("tipo", SqlDbType.Char, 1).Value = this.tipo;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }

            catch (Exception)
            { MessageBox.Show("Erro"); }
        }



        public bool ValidarEmailexistente(string email)
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select  email from Professor where email = @email";
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 30).Value = email;
            SqlDataReader dr = cmd.ExecuteReader();
            bool valido = dr.HasRows;
            dr.Close();
           
            return valido;
        }

        public void Alterar(int cod)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE Professor SET nome = @nome,email= @email,idSenac = @idSenac, tipo= @tipo WHERE codProfessor = " + cod;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = this.email;
                cmd.Parameters.Add("@idSenac", SqlDbType.Char, 6).Value = this.idSenac;
                cmd.Parameters.Add("tipo", SqlDbType.Char, 1).Value = this.tipo;
                cmd.ExecuteNonQuery();
                //                MessageBox.Show("Cadastro efetuado com sucesso!");

                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }

        public void AlterarCSenha(int cod)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE Professor SET nome = @nome,email= @email,senha= HASHBYTES('SHA1',@senha),idSenac = @idSenac, tipo= @tipo WHERE codProfessor = " + cod;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = this.email;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar, 50).Value = this.senha;
                cmd.Parameters.Add("@idSenac", SqlDbType.Char, 6).Value = this.idSenac;
                cmd.Parameters.Add("tipo", SqlDbType.Char, 1).Value = this.tipo;
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Cadastro efetuado com sucesso!");

                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }

        public static List<Professor> listaNomeProfessor(string nome)
        {
            try
            {
                string sql = "select nome from professor where nome like '%" + nome + "%'";
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader rd = cmd.ExecuteReader();
                List<Professor> lst = new List<Professor>();
                while (rd.Read())
                {
                    Professor p = new Professor();
                    p.nome = (rd.GetString(0));
                    lst.Add(p);

                }
                return lst;

                con.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;

            }

        }

        public Professor preencherCampos(string professor)
        {
            string sql = "select * from professor where nome like '" + professor + "%'";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            Professor p = new Professor();
            try
            {
                while (rd.Read())
                {
                    p.codigo = rd["codProfessor"].ToString();
                    p.nome = (rd["nome"].ToString());
                    p.email = (rd["email"].ToString());
                    p.idSenac = (rd["idsenac"].ToString());
                    p.senha = (rd["senha"].ToString());
                    p.tipo = rd["tipo"].ToString();
                }

                return p;
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
                string sql = "DELETE FROM professor where codProfessor =" + cod;
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

        public static List<Professor> SelecionarProf()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codprofessor, nome FROM professor";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Professor> Professores = new List<Professor>();

            while (dr.Read())
            {
                Professor p = new Professor();
                p.codigo = dr["codprofessor"].ToString();
                p.nome = dr["nome"].ToString();
                Professores.Add(p);
            }

            cn.Close();
            cn.Dispose();
            return Professores;
        }
        public static string preencherCod(string professor)
        {
            string sql = "select codProfessor from professor where nome like '" + professor + "'";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            Professor p = new Professor();
            string cod = "";
            try
            {
                while (rd.Read())
                {
                    p.codigo = rd["codProfessor"].ToString();
                    cod = p.codigo;
                }

                return cod;
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
    }


}

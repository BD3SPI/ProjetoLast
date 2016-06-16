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
    class Evento
    {

        public string CodEvento { get; set; }
        public string DataEvento { get; set; }
        public string descEvento { get; set; }
        public tipoEvento tipoEvento { get; set; }
        public Status Status { get; set; }
        public Professor Professor { get; set; }
        public string identificador { get; set; }

        public Evento()
        {
            this.Professor = new Professor();
            this.Status = new Status();
            this.tipoEvento = new tipoEvento();
        }

        public void Inserir()
        {
            try
            {
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO evento (descricao, data, codTipoEvento, codStatus, codProfessor, identificador ) values (@descricao, @dataEvento, @codTipoEvento, @codStatus, @codProfessor, @identificador)";
                //cmd.Parameters.Add("@cod", SqlDbType.Int).Value = this.set_CodEvento;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 80).Value = this.descEvento;
                cmd.Parameters.Add("@dataEvento", SqlDbType.DateTime).Value = this.DataEvento;
                cmd.Parameters.Add("@codTipoEvento", SqlDbType.SmallInt).Value = this.tipoEvento.codtipoEvento;
                cmd.Parameters.Add("@codStatus", SqlDbType.Char).Value = this.Status.codStatus;
                cmd.Parameters.Add("@codProfessor", SqlDbType.Int).Value = this.Professor.codigo;
                cmd.Parameters.Add("@identificador", SqlDbType.VarChar, 10).Value = this.identificador;
                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
            }

            catch (ArgumentException)
            {
            }

        }

        public void Alterar(int codEvento)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Evento SET  descricao = @descricao, data = @dataEvento, codTipoEvento = @codTipoEvento, codStatus = @codStatus, codProfessor = @codProfessor, identificador = @identificador WHERE codEvento = " + codEvento;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 80).Value = this.descEvento;
                cmd.Parameters.Add("@dataEvento", SqlDbType.DateTime).Value = this.DataEvento;
                cmd.Parameters.Add("@TipoEvento", SqlDbType.SmallInt).Value = this.tipoEvento.codtipoEvento;
                cmd.Parameters.Add("@codStatus", SqlDbType.Char).Value = this.Status.codStatus;
                cmd.Parameters.Add("@codProfessor", SqlDbType.Int).Value = this.Professor.codigo;
                cmd.Parameters.Add("@identificador", SqlDbType.Char).Value = this.identificador;
                cmd.Parameters.Add("@codTipoEvento", SqlDbType.Int).Value = this.tipoEvento.codtipoEvento;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }



        //]usar de exemplo pra fazer a combobox do evento, no frmAssuntoPsq.cs digitar o comando Crtl + F e digitar "frmAssuntoPsq()" e usar o exemplo pra evento 
        public static List<Evento> SelecionarEvento(string identificador, string data, string cod)
        {

            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("select e.codevento,e.descricao,e.data,e.codtipoevento,te.descTipoEvento,st.descStatus,st.codStatus,e.codProfessor,pr.nome,e.identificador from evento  e").AppendLine();
            sbSQL.Append("inner join tipoevento te on e.codtipoevento = te.codtipoevento").AppendLine();
            sbSQL.Append("inner join status st on e.codstatus = st.codStatus").AppendLine();
            sbSQL.Append("inner join professor pr on e.codprofessor = pr.codprofessor").AppendLine();
            sbSQL.Append("where e.identificador =@id  or e.data = @data  or e.codprofessor =@cod ;").AppendLine();

            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = data;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = identificador;


            cmd.CommandText = sbSQL.ToString();


            SqlDataReader dr = cmd.ExecuteReader();
            List<Evento> Eventos = new List<Evento>();

            while (dr.Read())
            {
                Evento evento = new Evento();
                evento.CodEvento = dr["codevento"].ToString();
                evento.Professor.codigo = dr["codProfessor"].ToString();
                evento.Status.codStatus = dr["codStatus"].ToString();
                evento.tipoEvento.codtipoEvento = dr["codTipoEvento"].ToString();
                evento.DataEvento = dr["data"].ToString();
                evento.descEvento = dr["descricao"].ToString();
                evento.identificador = dr["identificador"].ToString();
                evento.Professor.nome = dr["nome"].ToString();
                Eventos.Add(evento);
            }

            cn.Close();
            cn.Dispose();
            return Eventos;

        }

        public Evento camposEvento(string identificador, string data, string cod)
        {

            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("select e.codevento,e.descricao,e.data,e.codtipoevento,te.descTipoEvento,st.descStatus,st.codStatus,e.codProfessor,pr.nome,e.identificador from evento  e").AppendLine();
            sbSQL.Append("inner join tipoevento te on e.codtipoevento = te.codtipoevento").AppendLine();
            sbSQL.Append("inner join status st on e.codstatus = st.codStatus").AppendLine();
            sbSQL.Append("inner join professor pr on e.codprofessor = pr.codprofessor").AppendLine();
            sbSQL.Append("where e.identificador =@id  or e.data = @data  or e.codprofessor =@cod ;").AppendLine();

            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = data;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = identificador;


            cmd.CommandText = sbSQL.ToString();


            SqlDataReader dr = cmd.ExecuteReader();
            Evento Eventos = new Evento();
            Evento evento = new Evento();

            while (dr.Read())
            {

                evento.CodEvento = dr["codevento"].ToString();
                evento.Professor.codigo = dr["codProfessor"].ToString();
                evento.Status.codStatus = dr["codStatus"].ToString();
                evento.tipoEvento.codtipoEvento = dr["codTipoEvento"].ToString();
                evento.DataEvento = dr["data"].ToString();
                evento.descEvento = dr["descricao"].ToString();
                evento.identificador = dr["identificador"].ToString();

            }

            cn.Close();
            cn.Dispose();
            return Eventos;

        }

        public Evento preencherEvento(string id)
        {

            try
            {
                StringBuilder sbSQL = new StringBuilder();
                sbSQL.Append("select e.codevento,e.descricao,e.data,e.codtipoevento,te.descTipoEvento,st.descStatus,st.codStatus,e.codProfessor,pr.nome,e.identificador").AppendLine();
                sbSQL.Append("from evento  e ").AppendLine();
                sbSQL.Append("inner join tipoevento te on e.codtipoevento = te.codtipoevento").AppendLine();
                sbSQL.Append("inner join status st on e.codstatus = st.codStatus").AppendLine();
                sbSQL.Append("inner join professor pr on e.codprofessor = pr.codprofessor ").AppendLine();
                sbSQL.Append("where e.identificador = @id").AppendLine();
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                cmd.CommandText = sbSQL.ToString();
                SqlDataReader rd = cmd.ExecuteReader();
                Evento e = new Evento();
                while (rd.Read())
                {
                    e.CodEvento = rd["codEvento"].ToString();
                    e.Professor.codigo = (rd["codProfessor"].ToString());
                    e.Status.descStatus = rd["descStatus"].ToString();
                    e.tipoEvento.descTipoEvento = rd["descTipoEvento"].ToString();
                    e.DataEvento = rd["data"].ToString();
                    e.descEvento = rd["descricao"].ToString();
                    e.identificador = rd["identificador"].ToString();
                    e.Professor.nome = rd["nome"].ToString();

                }
                return e;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

        }




        public static void Excluir(int codEvento)
        {
            try
            {
                string sql = "DELETE FROM Evento where codEvento =" + codEvento;
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
        public static List<Evento> Exibirevento()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codEvento, descricao FROM evento";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Evento> Eventos = new List<Evento>();

            while (dr.Read())
            {
                Evento e = new Evento();
                e.CodEvento = dr["codEvento"].ToString();
                e.descEvento = dr["descricao"].ToString();
                Eventos.Add(e);
            }

            cn.Close();
            cn.Dispose();
            return Eventos;


        }

    }


}

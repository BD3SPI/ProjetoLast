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
    static class Imagem
    {
        public static int codImagem { get; set; }
        public static string tituloImagem { get; set; }
        public static byte[] imagem { get; set; }

        public static void SelecionarImagem()
        {
            //SqlConnection cn = new SqlConnection();
            SqlConnection cn = Conexao.AbrirConexao();
            //SqlCommand cmd = cn.CreateCommand();
            //cn.ConnectionString = "Data Source=m0g6ffl1c8.database.windows.net;Initial Catalog=senaquiz2;User ID=thiago;Password=Tchaikovsky666";
            //cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select TituloImagem, BitmapImagem from Imagem I where codImagem = @codImagem";
            cmd.Parameters.Add("@codImagem", SqlDbType.Int).Value = codImagem;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tituloImagem = dr.GetString(dr.GetOrdinal("tituloImagem"));
                imagem = (byte[])dr["bitmapImagem"];
            }
            cn.Close();
            cn.Dispose();
        }

        public static int Salvar()
        {
            //SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source=m0g6ffl1c8.database.windows.net;Initial Catalog=senaquiz2;User ID=thiago;Password=Tchaikovsky666";
            //cn.Open();
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into imagem (tituloImagem, bitmapImagem)  output INSERTED.codImagem values (@tituloImagem, @bitmapImagem)";
            cmd.Parameters.Add("@tituloimagem", SqlDbType.VarChar, 50).Value = tituloImagem;
            cmd.Parameters.Add("@bitmapimagem", SqlDbType.Image).Value = imagem;
            int id = (Int32)cmd.ExecuteScalar();
            return id;
            cn.Close();
            cn.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Telas;
using MVC.Classes;

namespace MVC.Telas
{
    public partial class frmProfessorIns : Form
    {
        char tipo;
        public frmProfessorIns()
        {
            InitializeComponent();
            DataTable tipo = new DataTable("professor");
            string sql = "SELECT tipo FROM professor";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader read = cmd.ExecuteReader();

        }

        void limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtIdSen.Clear();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja finalizar o cadastro?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Professor Prof = new Professor();
                    Prof.nome = (txtNome.Text);
                    Prof.email = (txtEmail.Text);
                    // validando se email já existe no banco de dados;
                    if (Prof.ValidarEmailexistente(Prof.email) == true)
                    {
                        throw new EmaiProfessorExistente();
                    }
                    Prof.senha = (txtSenha.Text);
                    Prof.idSenac = (txtIdSen.Text);

                    if (rbA.Checked)
                        Prof.tipo = ("A");
                    else
                        Prof.tipo = ("P");


                    if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtIdSen.Text.Equals("") || txtSenha.Text.Equals(""))
                    {

                        MessageBox.Show("Favor preencher todos os campos corretamente!", "Mensagem");
                    }
                    else
                    {
                        Prof.Inserir();
                        MessageBox.Show("Professor Inserido com sucesso!");
                        Close();
                    }
                }

            }
            catch (EmaiProfessorExistente)
            {

                MessageBox.Show("Email já cadastrado para outro professor. Por favor contatar o administrador do sistema.");
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtIdSen.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }


    }
}


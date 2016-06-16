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
using MVC.Classes;

namespace MVC.Telas
{
    public partial class frmProfessorPsq : Form
    {
        string tipo;
        bool senhaAlterada = false;
        public frmProfessorPsq()
        {
            InitializeComponent();
        }

        void Limpar()
        {
            txtEmail.Clear();
            txtIdSenac.Clear();
            txtNome.Clear();
            txtIdSenac.Clear();
            txtCodProfessor.Clear();
            txtSenha.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
            lstProfessores.DataSource = Professor.listaNomeProfessor("limpo");
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            //Executa o Método de Pesquisa
            if (txtNome.Text != null)
            {
                Professor p = new Professor();
                lstProfessores.DataSource = Professor.listaNomeProfessor(txtNome.Text.ToString());
            }




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            txtSenha.Visible = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtIdSenac.Enabled = true;
            gbTipo.Enabled = true;
            gbTipo.Visible = false;
            lstProfessores.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnBusca.Enabled = true;
            btnExcluir.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            txtSenha.Visible = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtIdSenac.Enabled = true;
            //txtCodProfessor.ReadOnly = true;
            gbTipo.Enabled = true;
            gbTipo.Visible = true;
            lstProfessores.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnBusca.Enabled = false;
            btnExcluir.Enabled = false;


        }

        private void novaPesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpar();
            txtSenha.Visible = false;
            label5.Visible = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtIdSenac.Enabled = true;
            //txtCodProfessor.Enabled = true;
            gbTipo.Visible = false;
            gbTipo.Enabled = false;
            lstProfessores.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnBusca.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Professor p = new Professor();
                p.codigo = (txtCodProfessor.Text);
                p.nome = (txtNome.Text);
                p.email = (txtEmail.Text);
                p.idSenac = (txtIdSenac.Text);
                p.senha = (txtSenha.Text);
                p.tipo = (tipo);

                int cod = Convert.ToInt32(txtCodProfessor.Text);
                
                if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtIdSenac.Text.Equals("") || txtSenha.Text.Equals(""))
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!", "Alerta!");
                }
                else
                {
                    if (senhaAlterada)
                    {
                        p.AlterarCSenha(cod);

                        txtEmail.Clear();
                        txtIdSenac.Clear();
                        txtNome.Clear();
                        txtIdSenac.Clear();
                        txtCodProfessor.Clear();
                        txtSenha.Clear();

                        label5.Visible = false;
                        txtSenha.Visible = false;
                        txtNome.Enabled = true;
                        txtEmail.Enabled = true;
                        txtIdSenac.Enabled = true;
                        gbTipo.Enabled = true;
                        gbTipo.Visible = false;
                        lstProfessores.Visible = true;
                        btnConfirmar.Visible = false;
                        btnCancelar.Visible = false;
                        btnBusca.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                    else
                    {
                        p.Alterar(cod);

                        txtEmail.Clear();
                        txtIdSenac.Clear();
                        txtNome.Clear();
                        txtIdSenac.Clear();
                        txtCodProfessor.Clear();
                        txtSenha.Clear();

                        label5.Visible = false;
                        txtSenha.Visible = false;
                        txtNome.Enabled = true;
                        txtEmail.Enabled = true;
                        txtIdSenac.Enabled = true;
                        gbTipo.Enabled = true;
                        lstProfessores.Visible = true;
                        btnConfirmar.Visible = false;
                        btnCancelar.Visible = false;
                        btnBusca.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                    
                }


            }
        }

        private void lsvResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bloqueia os campos
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtIdSenac.Enabled = false;
            //txtCodProfessor.Enabled = false;
            gbTipo.Visible = true;
            gbTipo.Enabled = false;

            Limpar();

            Professor p = new Professor();


            p = p.preencherCampos(lstProfessores.SelectedItem.ToString());
            //MessageBox.Show("Nome" + p.Nome);
            txtCodProfessor.Text = p.codigo;
            txtNome.Text = p.nome;
            txtEmail.Text = p.email;
            txtIdSenac.Text = p.idSenac;
            txtSenha.Text = p.senha;
            if (p.tipo == "A")
            {
                rbA.Checked = true;
            }
            else
            {
                rbP.Checked = true;
            }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "A";
        }

        private void rbP_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "P";
        }

        private void lstProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Professor p = new Professor();
            p = p.preencherCampos(lstProfessores.SelectedItem.ToString());
            txtCodProfessor.Text = p.codigo;
            txtNome.Text = p.nome;
            txtEmail.Text = p.email;
            txtSenha.Text = p.senha;
            txtIdSenac.Text = p.idSenac;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Professor.Excluir(Convert.ToInt32(txtCodProfessor.Text));
                Limpar();
                lstProfessores.DataSource = Professor.listaNomeProfessor("limpo");

                MessageBox.Show("Professor excluído com sucesso!", "Sucesso!");
                

            }
        }
        void limpar()
        {
            
            txtCodProfessor.Clear();
            txtEmail.Clear();
            txtIdSenac.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            senhaAlterada = true;
        }
    }
}

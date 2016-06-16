using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Classes;

namespace MVC.Telas
{
    public partial class frmAssuntoPsq : Form
    {
        public frmAssuntoPsq()
        {
            InitializeComponent();
            

            cbxArea.DataSource = Area.SelecionarArea();
            cbxArea.DisplayMember = "descricao";
            cbxArea.ValueMember = "codArea";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtAssunto != null)
            {

                Assunto a = new Assunto();
                //Professor p = new Professor();
                lstAssunto.DataSource = Assunto.listadescricaoAssunto(txtAssunto.Text.ToString());
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //label5.Visible = true;
            label2.Enabled = true;
            txtAssunto.Visible = true;
           


            lstAssunto.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnBusca.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public void Limpar()
        {
            txtAssunto.Clear();
            
            cbxArea.SelectedIndex = -1;
            txtcodigo.Clear();


        }

        private void lstAssunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assunto assunto = new Assunto();

            assunto = assunto.preencherCampos(lstAssunto.SelectedItem.ToString());
            txtcodigo.Text = assunto.codigo.ToString();
            txtAssunto.Text = assunto.descricao;
            cbxArea.Text = assunto.area.codarea;

            btnEditar.Enabled = true;
            cbxArea.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o registro? ", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Assunto.Excluir(Convert.ToInt32(txtcodigo.Text));
                    Limpar();
                    lstAssunto.DataSource = Assunto.listadescricaoAssunto("limpo");
                    MessageBox.Show("Cadastro excluido com sucesso");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAssunto.Visible = true;
            txtcodigo.Enabled = false;
            cbxArea.Enabled = true;
            lstAssunto.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnBusca.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                        try
            {
                if (MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Assunto a = new Assunto();
                    a.descricao = txtAssunto.Text.ToString();
                   a.area.codarea = cbxArea.SelectedValue.ToString();
                    // Chamando o metodo Alterar.
                    a.Alterar(Convert.ToInt32(txtcodigo.Text));
                    // limpando a pesquisa do list
                    lstAssunto.DataSource = Assunto.listadescricaoAssunto("limpo");
                    MessageBox.Show("Cadastro excluido com sucesso");
                    Limpar();
                    //fvoltando para tela inicial.
                    txtAssunto.Visible = true;
                    txtcodigo.Enabled = false;
                    cbxArea.Enabled = true;
                    lstAssunto.Visible = true;
                    btnConfirmar.Visible = false;
                    btnCancelar.Visible = false;
                    btnBusca.Enabled = true;
                    btnExcluir.Enabled = true;

                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro");

            }
        }

        private void frmAssuntoPsq_Load(object sender, EventArgs e)
        {
            cbxArea.SelectedIndex = -1;

            if (Sessao.tipo == 'P')
            {
                btnExcluir.Enabled = false;
            }
        }

        }

    }


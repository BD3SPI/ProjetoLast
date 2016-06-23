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
    public partial class frmQuestaoPsq : Form
    {
        string txtAlternativa;
        bool imgadicionada = false;
        public frmQuestaoPsq()
        {
            InitializeComponent();
            cbxProf.DataSource = Professor.SelecionarProf();
            cbxProf.DisplayMember = "nome";
            cbxProf.ValueMember = "codigo";

            cbxAssunto.DataSource = Assunto.listarAssuntos();
            cbxAssunto.DisplayMember = "descricao";
            cbxAssunto.ValueMember = "codigo";

            cmbTpQuestao.DataSource = tipoQuestao.SelecionarTipo();
            cmbTpQuestao.DisplayMember = "descricao";
            cmbTpQuestao.ValueMember = "codTipoQuestao";

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                Questao Q = new Questao();
                Q.tipoQuestao.codTipoQuestao = cmbTpQuestao.SelectedValue.ToString();
                Q.assunto.codigo = Convert.ToInt32(cbxAssunto.SelectedValue.ToString());
                Q.professor.codigo = cbxProf.SelectedValue.ToString();

                lstQuestao.DataSource = Q.listarQuestao();
                lstQuestao.DisplayMember = "textoQuestao";
                lstQuestao.ValueMember = "codQuestao";
            }
             catch (Exception)
            {
                MessageBox.Show("Por favor selecione os filtros");
            }
        }

        private void lstQuestao_Click(object sender, EventArgs e)
        {
           
                txtAlternativa = lstQuestao.SelectedValue.ToString();
                txtquestao.Text = lstQuestao.SelectedItem.ToString();
                Alternativa a = new Alternativa();
                //lstAlternativas.DataSource = a.listarAlternativa(txtAlternativa.Text);
                //lstAlternativas.DisplayMember = "texto";
                //lstAlternativas.ValueMember = "codigo";
                a.PreencherDataGridAlternativa(dgvAlternativa, txtAlternativa);
                dgvAlternativa.Columns[1].Visible = false;
                txtAlternativa = lstQuestao.SelectedValue.ToString();
                // exibi a imagem, relacionada com a questão.
                pictureBox1.Image = null;

                Imagem.SelecionarImagem(lstQuestao.SelectedValue.ToString());
                if (Imagem.imagem == null)
                {
                    lblImagem.Visible = true;
                    llbImagem.Visible = true;
                }
                else
                {
                    lblImagem.Visible = false;
                    llbImagem.Visible = false;
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(Imagem.imagem);
                    pictureBox1.Image = Image.FromStream(stream);
                    Imagem.imagem = null;
                }

        }
   
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstQuestao.SelectedItem == null)
            {
                MessageBox.Show("Por gentileza, selecione uma questão");
            }
            else
            {
                panAlterar.Enabled = true;
                btnRemover.Enabled = true;
                btnCancelar.Enabled = true;
                panBusca.Enabled = false;
                dgvAlternativa.Enabled = true;
                btnCadastrarimagem.Enabled = true;
                btnFinalizar.Enabled = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ckbAddAlter.Checked)
            {
                rxtTextoAlternativa.Enabled = false;
                ckbCorreta.Enabled = false;
                btnAdicionar.Enabled = false;
                ckbAddAlter.Checked = false;
            }
            else {
                panAlterar.Enabled = false;
                btnRemover.Enabled = false;
                btnCancelar.Enabled = false;
                panBusca.Enabled = true;
                dgvAlternativa.Enabled = false;
            }
            if (!imgadicionada)
            {
                Imagem.imagem = null;
            }
            
        }

        private void ckbAddAlter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAddAlter.Checked)
            {
                rxtTextoAlternativa.Enabled = true;
                ckbCorreta.Enabled = true;
                btnAdicionar.Enabled = true;
            }
            else
            {
                rxtTextoAlternativa.Enabled = false;
                ckbCorreta.Enabled = false;
                btnAdicionar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Questao Q = new Questao();
            Q.tipoQuestao.codTipoQuestao = "0";
            Q.assunto.codigo = 0;
            Q.professor.codigo = Convert.ToString(0);
            lstQuestao.DataSource = Q.listarQuestao();
            cbxAssunto.SelectedItem = null;
            cbxProf.SelectedItem = null;
            cmbTpQuestao.SelectedItem = null;
            lstQuestao.ClearSelected();
            pictureBox1.Image = null;
            rxtTextoAlternativa.Clear();
            ckbAddAlter.Checked = false;
            ckbCorreta.Checked = false;
            txtquestao.Clear();
            this.dgvAlternativa.DataSource = null;
        }

        private void llbImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmImagem frimagem = new frmImagem();
            frimagem.ShowDialog();
            btnCadastrarimagem.Visible = true;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void frmQuestaoPsq_Load(object sender, EventArgs e)
        {

        }

        private void lstQuestao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtAlternativa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarimagem_Click(object sender, EventArgs e)
        {

            if (frmImagem.imagemCarregada)
            {
                Questao q = new Questao();

                q.Alterarimagem(txtAlternativa);
                imgadicionada = true;
                MessageBox.Show("Foto cadastrada com sucesso");
                btnCadastrarimagem.Enabled = false;
                btnCadastrarimagem.Visible = false;
            }else{
                MessageBox.Show("Imagem não selecionada");
                btnCadastrarimagem.Enabled = false;
                btnCadastrarimagem.Visible = false;
                Imagem.imagem = null;
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool verifica = Questao.verificaDependecia(txtquestao.Text);

            if (verifica.Equals(true))
            {
                MessageBox.Show("Impossível apagar, essa questão está associada um evento !!! ", "Aviso ");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir a questão?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    verifica = Questao.verificaDependecia(txtquestao.Text);
                    if (verifica.Equals(true))
                    {
                        MessageBox.Show("Existem dependentes");

                    }
                    else if (verifica.Equals(false))
                    {
                        Questao.Excluir(txtquestao.Text);
                        Alternativa a = new Alternativa();
                        Questao q = new Questao();
                        lstQuestao.DataSource = null;
                        lstQuestao.Items.Clear();
                        dgvAlternativa.DataSource = null;
                        dgvAlternativa.Rows.Clear();
                    }

                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a Alternativa?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string codigo = Convert.ToString(dgvAlternativa.CurrentRow.Cells[1].Value.ToString());
                Alternativa.Excluir(codigo);
                Alternativa a = new Alternativa();
                a.PreencherDataGridAlternativa(dgvAlternativa, txtquestao.Text);
                dgvAlternativa.Columns[1].Visible = false;


            }
        }
    }
}

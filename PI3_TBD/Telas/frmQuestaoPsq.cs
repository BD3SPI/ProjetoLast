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
            txtAlternativa.Text = lstQuestao.SelectedValue.ToString();
            Alternativa a = new Alternativa();
            //lstAlternativas.DataSource = a.listarAlternativa(txtAlternativa.Text);
            //lstAlternativas.DisplayMember = "texto";
            //lstAlternativas.ValueMember = "codigo";
            a.PreencherDataGridAlternativa(dgvAlternativa, txtAlternativa.Text);
            dgvAlternativa.Columns[1].Visible = false;
            txtAlternativa.Text = lstQuestao.SelectedValue.ToString();
            // exibi a imagem, relacionada com a questão.
            try
            {
                Imagem.SelecionarImagem(lstQuestao.SelectedValue.ToString());
                System.IO.MemoryStream stream = new System.IO.MemoryStream(Imagem.imagem);
                pictureBox1.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao carregar imagens do banco...", "Aviso");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            panAlterar.Enabled = true;
            btnRemover.Enabled = true;
            btnCancelar.Enabled = true;
            panBusca.Enabled = false;
            dgvAlternativa.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ckbAddAlter.Checked)
            {
                rxtTextoAlternativa.Enabled = false;
                ckbCorreta.Enabled = false;
                btnAdicionar.Enabled = false;
                ckbAddAlter.Checked = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                panAlterar.Enabled = false;
                btnRemover.Enabled = false;
                btnCancelar.Enabled = false;
                panBusca.Enabled = true;
                dgvAlternativa.Enabled = false;
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
            lstQuestao.DataSource = null;
            lstQuestao.Items.Clear();
            txtAlternativa.Clear();
            lstQuestao.DataSource = null;
            lstQuestao.Items.Clear();
            dgvAlternativa.DataSource = null;
            dgvAlternativa.Rows.Clear();
            pictureBox1 = null;

            
        }

        private void llbImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmImagem frimagem = new frmImagem();
            frimagem.ShowDialog();

            if (frmImagem.imagemSelecionada)
            {
                //alteração de questão com a nova imagem selecionada

            }
            else
            {
                //alteração de questão sem nenhuma nova imagem selecionada
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Alternativa alt = new Alternativa();
            int codalternativa = Alternativa.novoIdAlternativas(txtAlternativa.Text);
            codalternativa++;
            if (cmbTpQuestao.SelectedValue.Equals("A"))
            {
                alt.codigo = codalternativa.ToString();
                alt.texto = rxtTextoAlternativa.Text;
                alt.codquestao = txtAlternativa.Text;
                if (ckbCorreta.Checked == true)
                {
                    alt.correta = 1;
                }
                else
                {
                    alt.correta = 0;
                }
                if (alt.ValidarAlternativaCorreta(alt.codquestao) >= 1 && ckbCorreta.Checked == true)
                {
                    MessageBox.Show("Já possui alternativa correta");
                    //throw new JaPossuiAlternativacorretaException();
                }
                else
                {
                    alt.insertTpAlternativas2();
                    MessageBox.Show("Alternativa Adicionada");
                }
            }
            if (cmbTpQuestao.SelectedValue.Equals("T"))
            {
                alt.codigo = codalternativa.ToString();
                alt.texto = rxtTextoAlternativa.Text;
                alt.codquestao = txtAlternativa.Text;
                if (ckbCorreta.Checked == true)
                {
                    alt.correta = 1;
                }
                else
                {
                    alt.correta = 0;
                }
                alt.insertTpAlternativas2();
                MessageBox.Show("Alternativa Adicionada");
            }


        }

        private void frmQuestaoPsq_Load(object sender, EventArgs e)
        {

        }

        private void lstQuestao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a Alternativa?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string codigo = Convert.ToString(dgvAlternativa.CurrentRow.Cells[1].Value.ToString());
                Alternativa.Excluir(codigo);
                Alternativa a = new Alternativa();
                a.PreencherDataGridAlternativa(dgvAlternativa, txtAlternativa.Text);
                dgvAlternativa.Columns[1].Visible = false;


            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool verifica = Questao.verificaDependecia(txtAlternativa.Text);

            if (verifica.Equals(true))
            {
                MessageBox.Show("Impossível apagar, essa questão está associada um evento !!! ", "Aviso ");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir a questão?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    verifica = Questao.verificaDependecia(txtAlternativa.Text);
                    if (verifica.Equals(true))
                    {
                        MessageBox.Show("Existem dependentes");

                    }
                    else if (verifica.Equals(false))
                    {
                        Questao.Excluir(txtAlternativa.Text);
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ckbAddAlter.Checked)
            {
                rxtTextoAlternativa.Enabled = false;
                ckbCorreta.Enabled = false;
                btnAdicionar.Enabled = false;
                ckbAddAlter.Checked = false;
                btnExcluir.Enabled = false;
                rxtTextoAlternativa.Clear();
                btnFinalizar.Enabled = false;
            }
            else
            {
                panAlterar.Enabled = false;
                btnRemover.Enabled = false;
                btnCancelar.Enabled = false;
                panBusca.Enabled = true;
                dgvAlternativa.Enabled = false;
                rxtTextoAlternativa.Clear();
                btnFinalizar.Enabled = false;
            }
        }
    }
}

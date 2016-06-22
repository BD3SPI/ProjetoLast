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
                txtquestao.Text = lstQuestao.SelectedItem.ToString();
                Alternativa a = new Alternativa();
                //lstAlternativas.DataSource = a.listarAlternativa(txtAlternativa.Text);
                //lstAlternativas.DisplayMember = "texto";
                //lstAlternativas.ValueMember = "codigo";
                a.PreencherDataGridAlternativa(dgvAlternativa, txtAlternativa.Text);
                dgvAlternativa.Columns[1].Visible = false;
                txtAlternativa.Text = lstQuestao.SelectedValue.ToString();
            // exibi a imagem, relacionada com a questão.
            pictureBox1.Image = null;
                Imagem.SelecionarImagem(lstQuestao.SelectedValue.ToString());
            if (Imagem.imagem == null)
            {
                llbImagem.Visible = true;
                btnCadastrarimagem.Enabled = true;

            }
            else
            {
                llbImagem.Visible = false;
                btnCadastrarimagem.Enabled = false;
                System.IO.MemoryStream stream = new System.IO.MemoryStream(Imagem.imagem);
                pictureBox1.Image = Image.FromStream(stream);
                Imagem.imagem = null;
            }

            }
   
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panAlterar.Enabled = true;
            btnRemover.Enabled = true;
            btnCancelar.Enabled = true;
            panBusca.Enabled = false;
            dgvAlternativa.Enabled = true;
            btnCadastrarimagem.Enabled = true;
            btnFinalizar.Enabled = true;
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
            txtAlternativa.Clear();
            pictureBox1.Image = null;
            dgvAlternativa.ClearSelection();
            rxtTextoAlternativa.Clear();
            ckbAddAlter.Checked = false;
            ckbCorreta.Checked = false;
        }

        private void llbImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmImagem frimagem = new frmImagem();
            frimagem.ShowDialog();

            if (frmImagem.imagemSelecionada) { 
               //alteração de questão com a nova imagem selecionada
                
            }else{
               //alteração de questão sem nenhuma nova imagem selecionada
            }
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
            Questao q = new Questao();

            q.Alterarimagem(txtAlternativa.Text);
            MessageBox.Show("Foto cadastrada com sucesso");
        }
    }
}

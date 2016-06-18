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

        private void frmQuestaoPsq_Load(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Questao Q = new Questao();
            Q.tipoQuestao.codTipoQuestao = cmbTpQuestao.SelectedValue.ToString();
            Q.assunto.codigo = Convert.ToInt32(cbxAssunto.SelectedValue.ToString());
            Q.professor.codigo = cbxProf.SelectedValue.ToString();

            lstQuestao.DataSource = Q.listarQuestao();
            lstQuestao.DisplayMember = "textoQuestao";
            lstQuestao.ValueMember = "codQuestao";
        }

        private void lstQuestao_Click(object sender, EventArgs e)
        {
            txtAlternativa.Text = lstQuestao.SelectedValue.ToString();
            Alternativa a = new Alternativa();
            lstAlternativas.DataSource = a.listarAlternativa(txtAlternativa.Text);
            lstAlternativas.DisplayMember = "texto";
            lstAlternativas.ValueMember = "codigo";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panAlterar.Enabled = true;
            btnRemover.Enabled = true;
            btnCancelar.Enabled = true;
            panBusca.Enabled = false;
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
    }
}

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
using MVC;

namespace MVC.Telas
{
    public partial class frmEventoPsq : Form
    {
        public string codProf = "";

        public frmEventoPsq()
        {
            InitializeComponent();
            desabilita();
            List<Professor> lstprof = new List<Professor>();
            lstprof = Professor.SelecionarProf();
            cbxProfessor.DataSource = lstprof;
            cbxProfessor.DisplayMember = "nome";
            cbxProfessor.ValueMember = "codigo";
            cbxProfessor.ResetText();
            txtCodProf.Text = "1";

            List<Status> lststatus = new List<Status>();
            lststatus = Status.SelecionarStatus();
            cbxStatus.DataSource = lststatus;
            cbxStatus.ValueMember = "codStatus";
            cbxStatus.DisplayMember = "DescStatus";
            cbxStatus.Text = "";

            List<tipoEvento> tp = new List<tipoEvento>();
            tp = tipoEvento.SelecionarTp();
            cbxTpEvento.DataSource = tp;
            cbxTpEvento.ValueMember = "codtipoevento";
            cbxTpEvento.DisplayMember = "desctipoevento";
            cbxTpEvento.Text = "";
            limpa();

            

        }

        //private void AtualizarLista(){
        //    listEvento.Refresh();

        //    List<Evento> eventos = Evento.SelecionarEvento(txtIdentificador.Text, codProf);
        //    listEvento.DataSource = eventos;
        //    listEvento.DisplayMember = "identificador";    
            
        //}

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpar()
        {
            txtCodEvento.Clear();
            //txtCodProf.Clear();

            txtDescricao.Clear();
            txtIdentificador.Clear();
        }

        public void desabilita()
        {
            txtCodEvento.Enabled = false;
            //txtCodProf.Enabled = false;

            txtDescricao.Enabled = false;

        }

        //private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtCodProf.Text = Convert.ToString(Professor.preencherCod(cbxProfessor.SelectedValue.ToString()));
        //    //txtCodProf.Text = Convert.ToString(cbxProfessor.ValueMember.ToString());
        //}

        private void btnBusca_Click(object sender, EventArgs e)
        {
            List<Evento> eventos = Evento.SelecionarEvento(txtIdentificador.Text, dtpDataEvento.Text, txtCodProf.Text);
            listEvento.DataSource = eventos;
            listEvento.DisplayMember = "descEvento";
            listEvento.ValueMember = "identificador";
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void frmEventoPsq_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'senaQuizDataSet.Professor' table. You can move, or remove it, as needed.
            dtpDataEvento.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdentificador.Clear();
            dtpDataEvento.ResetText();
            txtDescricao.Clear();
            txtCodEvento.Clear();
            //txtCodProf.Clear();
            listEvento.SelectedIndex = -1;


            btnBusca.Enabled = true;
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limpa();
        }
        public void limpa()
        {

            btnBusca.Enabled = true;
            btnEditar.Enabled = false;
            txtIdentificador.Clear();
            dtpDataEvento.ResetText();
            cbxTpEvento.ResetText();
            txtDescricao.Clear();
            txtCodEvento.Clear();
            //txtCodProf.Clear();
            listEvento.SelectedIndex = -1;
            cbxTpEvento.ResetText();
            cbxStatus.ResetText();
        }
        private void listEvento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Evento eventos = new Evento();
            eventos = eventos.preencherEvento(listEvento.SelectedValue.ToString());
            string id = eventos.identificador;
            txtIdentificador.Text = eventos.identificador;
            dtpDataEvento.Text = eventos.DataEvento;
            cbxTpEvento.Text = eventos.tipoEvento.descTipoEvento;
            txtDescricao.Text = eventos.descEvento;
            txtCodEvento.Text = eventos.CodEvento;
            txtCodProf.Text = eventos.Professor.codigo;
            cbxStatus.Text = eventos.Status.descStatus;
            //cbxProfessor.Text = eventos.Professor.nome;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Evento evento = new Evento();
                evento.Professor.codigo = (Sessao.cod);
                evento.DataEvento = dtpDataEvento.Text;
                evento.descEvento = txtDescricao.Text;
                evento.tipoEvento.codtipoEvento = cbxTpEvento.SelectedValue.ToString();
                evento.Status.codStatus = cbxStatus.SelectedValue.ToString();
                evento.identificador = txtIdentificador.Text;
                evento.CodEvento = (txtCodEvento.Text);

                evento.Alterar(Convert.ToInt32(evento.CodEvento));
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void frmEventoPsq_Load_1(object sender, EventArgs e)
        {
            limpa();
            //AtualizarLista();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Evento.Excluir(Convert.ToInt32(txtCodEvento.Text));

            }
        }

        private void novaPesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodProf.Text = cbxProfessor.SelectedValue.ToString();

            //AtualizarLista();
        }


    }
}

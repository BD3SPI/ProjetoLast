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
    public partial class frmEventoIns : Form
    {
        string identificador = "";
        public frmEventoIns()
        {
            InitializeComponent();
            identificador = RandomUtil.GetRandomString();
            txtIdentificador.Text = identificador;
            //InitializeComponent();
            //List<Area> data = new List<Area>();
            //data = Area.SelecionarArea();

            //cbxArea.DataSource = data;
            //cbxArea.DisplayMember = "descricao";

            List<Professor> lstprof = new List<Professor>();
            lstprof = Professor.SelecionarProf();

            txtProfessor.Text = Sessao.nome;

            //cbxProfessor.DataSource = lstprof;
            //cbxProfessor.DisplayMember = "nome";
            //cbxProfessor.ValueMember = "codprofessor";

            //List<Status> lststatus = new List<Status>();
            //lststatus = Status.SelecionarStatus();
            //cbxStatus.DataSource = lststatus;
            //cbxStatus.ValueMember = "codStatus";
            //cbxStatus.DisplayMember = "DescStatus";

            List<tipoEvento> tp = new List<tipoEvento>();
            tp = tipoEvento.SelecionarTp();
            cbxTpEvento.DataSource = tp;
            cbxTpEvento.ValueMember = "codtipoevento";
            cbxTpEvento.DisplayMember = "desctipoevento";


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEventoIns_Load(object sender, EventArgs e)
        {
            txtIdentificador.Text = identificador;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento();


                evento.Professor.codigo = (Sessao.cod);
                evento.DataEvento = dateTimePicker1.Text;
                evento.descEvento = txtDescricao.Text;
                evento.tipoEvento.codtipoEvento = cbxTpEvento.SelectedValue.ToString();
                evento.Status.codStatus = "C";
                evento.identificador = txtIdentificador.Text;

                evento.Inserir();
                MessageBox.Show("Cadastro efetuado com sucesso");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro");

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdentificador.Text = identificador;
            txtDescricao.Clear();
            cbxTpEvento.Text = "";
        }
    }
}

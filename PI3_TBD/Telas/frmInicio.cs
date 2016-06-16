using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Telas;
using MVC.Classes;

namespace MVC
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin FormLogin = new frmLogin();
            FormLogin.Show();
            Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(panPesquisa.Visible)
            {
                panPesquisa.Visible = false;
                panCadastrar.Visible = true;
            }else
            {
                panCadastrar.Visible = true;
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (panCadastrar.Visible)
            {
                panCadastrar.Visible = false;
                panPesquisa.Visible = true;
            }
            else
            {
                panPesquisa.Visible = true;
            }
            
        }

        private void btnProfessoresC_Click(object sender, EventArgs e)
        {
            Telas.frmProfessorIns FormProfessor = new Telas.frmProfessorIns();
            FormProfessor.ShowDialog();
        }

        private void btnProfessoresP_Click(object sender, EventArgs e)
        {
            frmProfessorPsq FormProfessorPsq = new frmProfessorPsq();
            FormProfessorPsq.ShowDialog();
        }

        private void btnAreasC_Click(object sender, EventArgs e)
        {
            frmAreaIns FormAreaIns = new frmAreaIns();
            FormAreaIns.ShowDialog();
        }

        private void btnAssuntosC_Click(object sender, EventArgs e)
        {
            frmAssuntoIns FormAssuntoIns = new frmAssuntoIns();
            FormAssuntoIns.ShowDialog();
        }

        private void btnAreasP_Click(object sender, EventArgs e)
        {
            frmAreaPsq FormAreaPsq = new frmAreaPsq();
            FormAreaPsq.ShowDialog();
        }

        private void btnAssuntoP_Click(object sender, EventArgs e)
        {
            frmAssuntoPsq FormAssuntoPsq = new frmAssuntoPsq();
            FormAssuntoPsq.ShowDialog();
        }

        private void btnEventosC_Click(object sender, EventArgs e)
        {
            frmEventoIns FormEventoIns = new frmEventoIns();
            FormEventoIns.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEventosP_Click(object sender, EventArgs e)
        {
            frmEventoPsq FormEventoPsq = new frmEventoPsq();
            FormEventoPsq.Show();
        }

        private void btnQuestoesC_Click(object sender, EventArgs e)
        {
            frmQuestaoIns form = new frmQuestaoIns();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuestaoEvento FormQuestaoEvento = new frmQuestaoEvento();
            FormQuestaoEvento.ShowDialog();
        }

        private void btnQuestoesP_Click(object sender, EventArgs e)
        {
            frmQuestaoPsq FormQuestaoPsq = new frmQuestaoPsq();
            FormQuestaoPsq.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            tspOperador.Text = "Professor: " + Sessao.nome;
            // Atualizando a hora
            timer1.Enabled = true;
            timer1.Interval = 1000;

            if (Sessao.tipo == 'A')
            {
                tspTipo.Text = "Administrador";
                tspTipo.ForeColor = Color.Purple;
            }

            else
            {
                tspTipo.Text = null;
                //desativar permissões
                button1.Enabled = false;

            }


        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // adicionado a hora para o toolStrip
            tspHorario.Text = (DateTime.Now.ToString("HH:mm:ss"));

        }

        private void panPesquisa_Paint(object sender, PaintEventArgs e)
        {
            if (Sessao.tipo == 'P')
            {
                btnAssuntoP.Enabled = false;
                btnAreasP.Enabled = false;
                btnEventosP.Enabled = false;
                btnProfessoresP.Enabled = false;


            }
        }



        private void panCadastrar_Paint_1(object sender, PaintEventArgs e)
        {
            if (Sessao.tipo == 'P')
            {
                btnAssuntosC.Enabled = false;
                btnAreasC.Enabled = false;
                btnEventosC.Enabled = false;
                btnProfessoresC.Enabled = false;


            }

        }

        private void panPesquisa_Paint_1(object sender, PaintEventArgs e)
        {
            if (Sessao.tipo == 'P')
            {
                btnAssuntoP.Enabled = false;
                btnAreasP.Enabled = false;
                btnEventosP.Enabled = false;
                btnProfessoresP.Enabled = false;


            }
        }

        private void panCadastrar_Paint(object sender, PaintEventArgs e)
        {
            if (Sessao.tipo == 'P')
            {
                btnAssuntosC.Enabled = false;
                btnAreasC.Enabled = false;
                btnEventosC.Enabled = false;
                btnProfessoresC.Enabled = false;


            }
        }

    }
}
;
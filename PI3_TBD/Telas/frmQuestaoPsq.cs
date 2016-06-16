﻿using System;
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
    }
}

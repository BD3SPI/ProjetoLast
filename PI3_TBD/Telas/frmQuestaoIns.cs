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
    public partial class frmQuestaoIns : Form
    {
        int contadorCorretas = 0;
        int contadorAlternativas = 0;
        int bit;
        static string codQuestao;
        static bool Alterando;
        public frmQuestaoIns()
        {
            InitializeComponent();

            List<Assunto> assuntos = new List<Assunto>();
            assuntos = Assunto.listarAssuntos();

            cbxAssunto.DataSource = assuntos;
            cbxAssunto.DisplayMember = "descricao";
            cbxAssunto.ValueMember = "codigo";

            List<tipoQuestao> tpQuestao = new List<tipoQuestao>();
            tpQuestao = tipoQuestao.SelecionarTipo();
            cmbTpQuestao.DataSource = tpQuestao;
            cmbTpQuestao.DisplayMember = "descricao";
            cmbTpQuestao.ValueMember = "codtipoquestao";
            txtProfessor.Text = Sessao.nome;

            Alterando = false;
            btnAlterar.Enabled = false;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Questao questao = new Questao();

                questao.assunto.codigo = Convert.ToInt32(cbxAssunto.SelectedValue.ToString());
                questao.ativo = 1;
                questao.dificuldade = cmbNivel.Text;
                questao.professor.codigo = Sessao.cod;
                questao.textoQuestao = txtTexto.Text;
                questao.tipoQuestao.codTipoQuestao = cmbTpQuestao.SelectedValue.ToString();
                if (ckCorreta.Checked == true)
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }

                if (cckImagem.Checked)
                {
                    questao.InserirImagem();
                    codQuestao = Questao.idQuestao(txtTexto.Text);
                }
                else
                {
                    questao.Inserir();
                    codQuestao = Questao.idQuestao(txtTexto.Text);
                }
                MessageBox.Show("Você cadastrou a questão. Por gentileza, cadastre a(s) alternativa(s)");
                panQuestao.Enabled = false;
                panAlternativa.Enabled = true;
                btnAlterar.Enabled = true;
                btnInserir.Enabled = false;
                btnCancelar.Visible = false;

                if (cmbTpQuestao.SelectedValue.Equals("T"))
                {
                    ckCorreta.Checked = true;
                    ckCorreta.Enabled = false;
                    btnAlterar.Visible = true;
                }
            }
               catch (Exception)
            {
                MessageBox.Show("Erro");
            }
            
        }

        void limpar()
        {
            txtAlternativa.Clear();
            ckCorreta.Checked = false;

        }

        private void cmbTpQuestao_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpar();
            contadorAlternativas = 0;

            if (cmbTpQuestao.SelectedValue.Equals("V"))
            {
                txtAlternativa.Hide();
            }
            else
            {
                txtAlternativa.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAlternativa.Text == "")
                {
                    throw new PreencherocampoException();
                }
                int bit = 0;
                if (contadorCorretas > 0)
                {
                    ckCorreta.Enabled = false;
                }


                if (ckCorreta.Checked == true)
                {
                    bit = 1;
                }

                if (cmbTpQuestao.SelectedValue.Equals("A"))
                {
                    Alternativa alternativa = new Alternativa();
                    alternativa.contador = contadorAlternativas;
                    alternativa.correta = bit;
                    alternativa.texto = txtAlternativa.Text;
                    alternativa.codquestao = codQuestao;
                    // validando se já possui alternativa verdadeira.
                    if (alternativa.ValidarAlternativaCorreta(alternativa.codquestao) >= 1 && ckCorreta.Checked == true)
                    {

                        throw new JaPossuiAlternativacorretaException();


                    }
                    alternativa.insertTpAlternativas();
                    contadorAlternativas++;
                    MessageBox.Show("Alternativa cadastrada com sucesso");
                    alternativa.PreencherDataGridAlternativa(dataGridView1, codQuestao);
                    ckCorreta.Checked = false;
                }
                int cont = 0;
                if (cmbTpQuestao.SelectedValue.Equals("V"))
                {

                    ckCorreta.Checked = true;
                    bit = 1;
                    Alternativa alternativa = new Alternativa();
                    alternativa.contador = contadorAlternativas;
                    alternativa.correta = bit;
                    alternativa.codquestao = codQuestao;
                    if (cont > 1)
                    {
                        throw new JaPossuiAlternativacorretaException();
                    }
                    alternativa.insereVouF();
                    cont++;
                    MessageBox.Show("Alternativa cadastrada com sucesso");
                    alternativa.PreencherDataGridAlternativa(dataGridView1, codQuestao);
                    ckCorreta.Checked = false;
                }

                if (cmbTpQuestao.SelectedValue.Equals("T"))
                {
                    ckCorreta.Checked = true;
                    ckCorreta.Enabled = false;
                    Alternativa alternativa = new Alternativa();
                    alternativa.contador = contadorAlternativas;
                    alternativa.correta = bit;
                    alternativa.texto = txtAlternativa.Text;
                    alternativa.codquestao = codQuestao;
                    alternativa.insertTpAlternativas();
                    contadorAlternativas++;
                    MessageBox.Show("Alternativa cadastrada com sucesso");
                    alternativa.PreencherDataGridAlternativa(dataGridView1, codQuestao);
                    //              dataGridView1.Columns[1].Visible = false;

                }
            }

            catch (JaPossuiAlternativacorretaException)
            {
                MessageBox.Show("Já existe uma alternativa correta vinculada para essa questão");
                ckCorreta.Checked = false;
            }

            catch (PreencherocampoException)

            {
                MessageBox.Show("Por favor entre com o texto da Alternativa!", "Aviso");

            }

           

            txtAlternativa.Clear();
            
        }

        private void txtDescQuestao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cckImagem_CheckedChanged(object sender, EventArgs e)
        {
            if (cckImagem.Checked == true)
            {
                frmImagem frimagem = new frmImagem();
                frimagem.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Alterando) {
                Alterando = false;
                panQuestao.Enabled = false;
                panAlternativa.Enabled = true;
                btnInserir.Enabled = true;
                txtTexto.Enabled = true;                
            }else{
                Close();
            }
            
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterando = true;
            panQuestao.Enabled = true;
            panAlternativa.Enabled = false;
            btnCancelar.Enabled = true;
            txtTexto.Enabled = false;
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                Questao questao = new Questao();


                questao.textoQuestao = txtTexto.Text;
                questao.assunto.codigo = Convert.ToInt32(cbxAssunto.SelectedValue.ToString());
                questao.ativo = 1;
                questao.dificuldade = cmbNivel.Text;
                questao.professor.codigo = Sessao.cod;

                questao.tipoQuestao.codTipoQuestao = cmbTpQuestao.SelectedValue.ToString();
                if (ckCorreta.Checked == true)
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }

                if (cckImagem.Checked)
                {
                    codQuestao = Questao.idQuestao(txtTexto.Text);
                    questao.Alterar(codQuestao);
                }
                else
                {
                    codQuestao = Questao.idQuestao(txtTexto.Text);
                    questao.Alterarsemimagem(codQuestao);

                }
                
                MessageBox.Show("Questão alterada com sucesso");
                panQuestao.Enabled = false;
                panAlternativa.Enabled = true;
                btnConfirmar.Visible = false;

                if (cmbTpQuestao.SelectedValue.Equals("T"))
                {
                    ckCorreta.Checked = true;
                    ckCorreta.Enabled = false;
                    btnAlterar.Visible = true;
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Erro");
            }
            
        }

        }
    }


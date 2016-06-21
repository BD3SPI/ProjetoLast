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
    public partial class frmQuestaoEvento : Form
    {
        public frmQuestaoEvento()
        {
            InitializeComponent();

            // carregando o combox - EVENTO
            cbxEvento.DataSource = Evento.Exibirevento();
            cbxEvento.DisplayMember = "descEvento";
            cbxEvento.ValueMember = "CodEvento";


            // carregando o combox - ASSUNTO
            cbxAssunto.DataSource = Assunto.SelecionarAssunto();
            cbxAssunto.DisplayMember = "descricao";
            cbxAssunto.ValueMember = "codigo";

            // Carregando o DatagridQuestão - Perguntas
            Questao questao = new Questao();
            questao.PreencherDataGridQuestao(dataGridView1);
            dataGridView1.Columns[0].Visible = false;

            ckbCarrega.Checked = false;
        }

        // evento CELL CLIK - Joga a pergunta seleciona no grid para o TextBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string texto = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtQuestao.Text = texto;

            string id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtID.Text = id;



        }



        // data grid que recebe as perguntas incluidas no evento
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // retornar o texto para o grid.
            string texto = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            txtQuestao.Text = texto;

            // retornar o ID da pergunta.
            string id = Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            txtID.Text = id;

        }


        public void Limpar()
        {
            txtID.Clear();
            txtQuestao.Clear();
            cbxAssunto.SelectedItem = "";
        }
        
        // Ckeck Box para o usuario selecionar se quer que exibi as perguntas ou não.
        private void ckbCarrega_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCarrega.Checked == true) { 
                if(cbxEvento.SelectedItem != null){
                    Questao questao = new Questao();
                    string evento = cbxEvento.SelectedValue.ToString();
                    //  Carregar as perguntas do GridView
                        questao.PreencherDataGridPerguntasdaQuestao(dataGridView2, evento);
                        dataGridView2.Columns[0].Visible = false;
                        dataGridView2.Columns[2].Visible = false;
                }
                else
                {
                    MessageBox.Show("Selecione o evento");
                    ckbCarrega.Checked = false;
                }
            }
            else
                {
                    // limpando o grid - Perguntas
                    this.dataGridView2.DataSource = null;
                }
        }

        private void cbxAssunto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            Questao questao = new Questao();
            // Selecionando por tipo de assunto as perguntas!!!!!!!!!!
            //string codassunto = cbxAssunto.SelectedValue.ToString();
            //MessageBox.Show(cbxAssunto.SelectedValue.ToString());
            if (cbxAssunto.ValueMember == "codigo")
            {
                dataGridView1.DataSource = Questao.SelecionarQuestao(Convert.ToInt32(cbxAssunto.SelectedValue));

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;

            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string texto = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtQuestao.Text = texto;

            string id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtID.Text = id;

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // retornar o texto para o grid.
            string texto = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            txtQuestao.Text = texto;

            // retornar o ID da pergunta.
            string id = Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            txtID.Text = id;
        }

        private void btnInseri_Click_1(object sender, EventArgs e)
        {
            try
            {
                QuestaoEvento questaoevento = new QuestaoEvento();
                Questao questao = new Questao();


                string evento = cbxEvento.SelectedValue.ToString();
                questaoevento.codEvento = evento;
                questaoevento.codQuestao = txtID.Text;
                questaoevento.status = "C";
                //questaoevento.tempo = null;
                //if (txtID.Text == "")
                //{
                //    MessageBox.Show("Por favor selecione uma pergunta");
                //}

                if (MessageBox.Show("Tem certeza que deseja inserir essa pergunta", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && txtID.Text != "")
                {
                    questaoevento.Inserir();
                    MessageBox.Show("Pergunta vinculada com o evento");
                    questao.PreencherDataGridPerguntasdaQuestao(dataGridView2, evento);
                    dataGridView2.Columns[0].Visible = false;
                    Limpar();
                }

                else if  (txtID.Text == "")
                {
                    MessageBox.Show("Por favor selecione a questão, para ser incluída no evento");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro");
            }

            catch (Exception)
            {
                MessageBox.Show("Erro"); 
            }

        }

        private void btnTira_Click_1(object sender, EventArgs e)
        {
            try
            {
                Questao questao = new Questao();

                string evento = cbxEvento.SelectedValue.ToString();
                QuestaoEvento questaoevento = new QuestaoEvento();
                string codpergunta = txtID.Text;
                if (MessageBox.Show("Deseja realmente excluir a questão do evento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    questaoevento.Excluir(evento, codpergunta);
                    MessageBox.Show("Pergunta desvinculada do evento");
                    questao.PreencherDataGridPerguntasdaQuestao(dataGridView2, evento);
                    Limpar();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQuestaoEvento_Load_1(object sender, EventArgs e)
        {
            cbxAssunto.SelectedIndex = -1;
            cbxEvento.SelectedIndex = -1;
        }

        private void cbxEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEvento.SelectedValue != null) { 
                Questao questao = new Questao();
                string evento = cbxEvento.SelectedValue.ToString();
                //  Carregar as perguntas do GridView
                if (ckbCarrega.Checked == true)
                {
                    questao.PreencherDataGridPerguntasdaQuestao(dataGridView2, evento);
                    dataGridView2.Columns[0].Visible = false;
                    dataGridView2.Columns[2].Visible = false;
                    
                }
                // limpando o grid - Perguntas
                else
                {
                    this.dataGridView2.DataSource = null;
                }
            }
        }
            
        
    }
  }
 



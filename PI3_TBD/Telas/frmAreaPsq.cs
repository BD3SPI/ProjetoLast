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
    public partial class frmAreaPsq : Form
    {
        public frmAreaPsq()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Limpar()
        {
            txtArea.Clear();
            txtCodigo.Clear();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtArea != null)
            {

                lstArea.DataSource = Area.ListaArea(txtArea.Text.ToString());
            }

        }

        private void lstArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area area = new Area();

            area = area.preencherCampos(lstArea.SelectedValue.ToString());
            txtArea.Text = area.descricao;
            txtCodigo.Text = area.codarea;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
             
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                        if (MessageBox.Show ("Deseja realmente excluir o cadastro", "Confirmaçao", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                    Area.Excluir(Convert.ToInt32(txtCodigo.Text));
                    Limpar();
                    lstArea.DataSource = Area.ListaArea("limpo");
                    MessageBox.Show("Cadastro excluido com sucesso");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Area a = new Area();
                    a.descricao = txtArea.Text;
                    a.Alterar(Convert.ToInt32(txtCodigo.Text));

                    Limpar();
                    lstArea.DataSource = Area.ListaArea("limpo");
                    MessageBox.Show("Cadastro excluido com sucesso");
                    //fvoltando para tela inicial.
                    txtArea.Visible = true;
                    txtCodigo.Enabled = false;
                    btnConfirmar.Visible = false;
                    btnCancelar.Visible = false;
                    btnBusca.Enabled = true;
                    btnExcluir.Enabled = true;
                    lstArea.Visible = true;


                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            txtCodigo.Enabled = false;
            txtArea.Visible = true;
            lstArea.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnBusca.Enabled = false;
            btnExcluir.Enabled = false;
            
        }





        }
    }


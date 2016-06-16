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
    public partial class frmAssuntoIns : Form
    {
        public frmAssuntoIns()
        {
            InitializeComponent();
            cbxArea.DataSource = Area.SelecionarArea();
            cbxArea.DisplayMember = "descricao";
            cbxArea.ValueMember = "codArea";

            Assunto assunto = new Assunto();
            assunto.PreencherDataGridAssunto(dgvAssunto);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text != "")
                {
                    Assunto assunto = new Assunto();
                    assunto.descricao = txtDescricao.Text;
                    string area = cbxArea.SelectedValue.ToString();
                    assunto.area.codarea = area.ToString();
                    assunto.Inserir();
                    assunto.PreencherDataGridAssunto(dgvAssunto);
                }
                else
                {
                    MessageBox.Show("Por favor entre com todos os dados", "Mensagem");
                }
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Por favor entre com todos os dados", "Mensagem");
            }

        }

        private void Cod_Area_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvAssunto.CurrentRow.Cells[0].Value.ToString());
                Assunto assunto = new Assunto();
      

                using (var reader = assunto.Carregargrid(id))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtDescricao.Text = reader["descricao"].ToString();
                            cbxArea.Text = reader["assunto"].ToString();
                            if (reader["descricao"] != DBNull.Value)
                            {
                                cbxArea.SelectedValue = Convert.ToInt32(reader["PermissaoID"].ToString());
                            }
                            if (reader["Status"] != DBNull.Value)
                            {
                                cbxArea.SelectedIndex = Convert.ToInt32(reader["Status"].ToString());
                            }
                            txtDescricao.Text = reader["descricao"].ToString();
                            cbxArea.Text = reader["assunto"].ToString();

                        }





                    }
                }
            }
        }
    }
}

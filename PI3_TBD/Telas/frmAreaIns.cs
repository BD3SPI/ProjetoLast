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
    public partial class frmAreaIns : Form
    {
        public frmAreaIns()
        {
            InitializeComponent();
            Area area = new Area();
            area.PreencherDataGrid(dataGridView1);
        
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Area area = new Area();

                if (txtDescricao.Text != "")
                {
                    area.descricao = txtDescricao.Text;

                    area.Inserir();
                    MessageBox.Show("Dados cadastrada com sucesso!");

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
    }
}

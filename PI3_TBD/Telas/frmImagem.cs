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
    public partial class frmImagem : Form
    {
        bool imagemSelecionada = false;
        public frmImagem()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Imagem.codImagem = Convert.ToInt32(txtCodImagem.Text);
            Imagem.SelecionarImagem();
            System.IO.MemoryStream stream = new System.IO.MemoryStream(Imagem.imagem);
            picImagem1.Image = Image.FromStream(stream);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog F = new OpenFileDialog();
            F.CheckFileExists = true;
            F.CheckPathExists = true;
            F.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.png)|*.jpg;*.gif;*.png";
            F.Multiselect = false;
            if (F.ShowDialog() == DialogResult.OK)
            {
                picImagem2.Image = Image.FromFile(F.FileName.ToString());
                lblCaminho.Text = F.FileName.ToString();
                imagemSelecionada = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picImagem2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!imagemSelecionada) {
                MessageBox.Show("Por gentileza, selecione uma imagem!");
            }
            else if (txtTitulo.Text == "") {
                MessageBox.Show("Por gentileza, defina um título para a imagem");
            }
            else
            {
                //Imagem i = new Imagem();
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                picImagem2.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagem.imagem = stream.ToArray();
                Imagem.tituloImagem = txtTitulo.Text;
                Imagem.codImagem = Imagem.Salvar();

                picImagem2.Image = null;
                txtTitulo.Text = "";
                lblCaminho.Text = "Caminho";
                MessageBox.Show("Imagem gravada com cod = " + Imagem.codImagem.ToString());
            }
            
        }
    }
}

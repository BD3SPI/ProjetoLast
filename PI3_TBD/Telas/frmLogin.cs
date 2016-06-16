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

namespace MVC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin FormLogin = new frmLogin();
            Login login = new Login();


            if (login.ValidarLogin(txtLogin.Text, txtSenha.Text))
            {
                frmInicio FormInicio = new frmInicio();
                FormInicio.Show();
                FormLogin.Enabled = false;
                Hide();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorreta");
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ale_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void pb_ledLogado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.botão_off;
            Globais.nivel = 0; 
            Globais.logado = false;
        }

        private void manutençãoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.logado == true)
            {
                if(Globais.nivel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("Acesso negado!\nVocê não possui permição para acessar este recurso.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_novousuario = new F_NovoUsuario();
                    f_novousuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado!\nVocê não possui permição para acessar este recurso.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 1)
                {
                    F_Gestao f_gestao = new F_Gestao();
                    f_gestao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado!\nVocê não possui permição para acessar este recurso.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                // PROCEDIMENTOS
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }
    }
}

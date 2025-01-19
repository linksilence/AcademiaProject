using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Forms_Academia
{
    public partial class Forms_inicio : Form
    {
        Form1 form1;
      
        public Forms_inicio(Form1 repasse)
        {
            InitializeComponent();
            
            DataTable dt = Querys.query_retorno(@"select nome_usuario, nivel_usuario
            from usuarios
            where username ='" + repasse.usuario.Text+ "'and senha_usuario ='"+repasse.senha.Text+"'");
            usu.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
            acess.Text = dt.Rows[0].Field<int>("nivel_usuario").ToString();
            usu.ForeColor = Color.Blue;
            acess.ForeColor = Color.Blue;
            pictureBox1.Image = Properties.Resources.pngwing_com__2_;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Isso fará com que sua conta seja" +
                " deslogada de todos os serviços", "Saida permanente", MessageBoxButtons.YesNo);
            if (resposta==DialogResult.Yes)
            {
                usu.Text = "desconhecido";
                acess.Text = "desconhecido";
                usu.ForeColor = Color.Red;
                acess.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.pngwing_com__3_;
            }

            
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form estado = Application.OpenForms["Forms_inicio"] as Forms_inicio;
            if (estado!=null)
            {
                this.Close();
            }
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_prof professores = new Forms_prof();
            professores.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turmas turmas = new Turmas();
            turmas.Show();
        }

        private void administraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_user new_User = new New_user();
            new_User.Show();
        }

        private void atualizaçãoCadastralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_AtCad atualizacao = new Forms_AtCad();
            atualizacao.Show();
        }
    }
}

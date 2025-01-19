using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string comando = @"select * from usuarios
            where username ='"+usuario.Text+"'and senha_usuario = '"+ senha.Text+"'";
            DataTable result = Querys.query_retorno(comando);
            if (result.Rows.Count==0)
            {
                MessageBox.Show("usuário inválido");
                usuario.Clear();
                senha.Clear();
                return;
            }
           
            Forms_inicio inicial = new Forms_inicio(this);
            inicial.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}

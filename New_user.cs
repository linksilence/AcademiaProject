using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Forms_Academia
{
    public partial class New_user : Form
    {
    
        public New_user()
        {
            InitializeComponent();
            dataGridView1.DataSource = Querys.query_retorno("select * from usuarios order by nome_usuario");
        }
        public enum Sexo
        {
            Masculino,
            Feminino,
            Outro
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView tabela = (DataGridView)sender;
            DataTable dt = new DataTable();
            int linha_selecionada = tabela.SelectedRows.Count;

            if (linha_selecionada>0)
            {
                string id_usuario = tabela.SelectedRows[0].Cells[0].Value.ToString();
                dt = Querys.query_retorno("select *from usuarios where id_usuario='"+id_usuario+"'");

                
                textBox1.Text = dt.Rows[0].Field<string>("nome_usuario");
                textBox2.Text = dt.Rows[0].Field<string>("username");
                textBox3.Text = dt.Rows[0].Field<string>("senha_usuario");
                textBox4.Text = dt.Rows[0].Field<string>("sexo_usuario");
                numericUpDown1.Value = dt.Rows[0].Field<int>("nivel_usuario");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query_ = "insert into usuarios(id_usuario, nome_usuario, username, senha_usuario, sexo_usuario, nivel_usuario)" +
                       "values(@id_usuario, @nome_usuario, @username, @senha_usuario, @sexo_usuario, @nivel_usuario)";
                
                DataTable dt = new DataTable();
                string query__ = @"SELECT * FROM usuarios " +
                "WHERE nome_usuario = '" + textBox1.Text + "' OR senha_usuario = '" + textBox3.Text + "'";
                dt = Querys.query_retorno(query__);

                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Usuário já está inserido no banco de dados");
                    textBox1.Clear();
                    textBox3.Clear();
                    return;
                }

                using (MySqlCommand cmd = new MySqlCommand(query_, Querys.conect_()))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", "dafault");
                    cmd.Parameters.AddWithValue("@nome_usuario", textBox1.Text);
                    cmd.Parameters.AddWithValue("@username", textBox2.Text);
                    cmd.Parameters.AddWithValue("@senha_usuario", textBox3.Text);
                    cmd.Parameters.AddWithValue("@sexo_usuario", textBox4.Text);
                    cmd.Parameters.AddWithValue("@nivel_usuario", numericUpDown1.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception error)
            {
                throw error;
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Usuário inserido com sucesso", "Novo usuário", MessageBoxButtons.OK);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string query_ =  @"Delete from usuarios where id_usuario='"+id+"'";
            Querys.exe(query_);
            dataGridView1.DataSource = Querys.query_retorno("Select *from usuarios");
            MessageBox.Show("Exclusão de usuário efetivada com sucesso", "Exclusão de usuário", MessageBoxButtons.OK);
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_Academia
{
    public partial class Forms_prof : Form
    {
        public Forms_prof()
        {
            InitializeComponent();
            dataGridView1.DataSource = Querys.query_retorno("Select nome, cref from responsavel");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            DataGridView dt = (DataGridView)sender;

            if (dt.SelectedRows.Count>0)
            {

                string userId = dt.SelectedRows[0].Cells[1].Value.ToString();
                DataTable tb = new DataTable();
              
                    tb = Querys.query_retorno("SELECT * FROM responsavel WHERE cref = '"+userId+"';");

                    textBox1.Text = tb.Rows[0].Field<String>("nome").ToString();
                    textBox2.Text = tb.Rows[0].Field<int>("cref").ToString();
                    maskedTextBox1.Text = tb.Rows[0].Field<DateTime>("validade").ToString();
                
               
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string cmd = "insert into responsavel values(@cref, @nome, @validade)";
                DataTable dt = new DataTable();

                string query_ = @"SELECT * FROM responsavel " +
                   "WHERE cref = '" + textBox2.Text + "'";
                dt = Querys.query_retorno(query_);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cref já cadastrado");
                    textBox2.Clear();
                    return;
                }

                using (MySqlCommand cmd_2 = new MySqlCommand(cmd, Querys.conect_()))
                {
                    cmd_2.Parameters.AddWithValue("@cref",textBox2.Text );
                    cmd_2.Parameters.AddWithValue("@nome", textBox1.Text);
                    cmd_2.Parameters.AddWithValue("@validade",maskedTextBox1.Text);
                    cmd_2.ExecuteNonQuery();
                }
        

            }
            catch(Exception error)
            {
                throw error;
            }
           

        }

        private void Forms_prof_Load(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

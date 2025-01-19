using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Academia
{
    public partial class Forms_AtCad : Form
    {

        string query = @"select distinct responsavel.nome
        from responsavel join atividades
        on responsavel.cref= atividades.cref_responsavel_str;";
        public Forms_AtCad()
        {
            InitializeComponent();
            comboBox1.DataSource = Querys.query_retorno("select distinct nome_atividade from atividades order by nome_atividade;");
            comboBox1.DisplayMember = "nome_atividade";
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Consulta o cref_responsavel_str com DISTINCT
            using (DataTable dtAtividades = Querys.query_retorno(
                 "SELECT DISTINCT cref_responsavel_str FROM atividades WHERE nome_atividade = '" + comboBox1.Text.Replace("'", "''") + "'"
             ))
            {

                // Verifica se há resultados antes de prosseguir
                if (dtAtividades.Rows.Count > 0)
                {
                    // Obtém o primeiro resultado
                    int cref = dtAtividades.Rows[0].Field<int>("cref_responsavel_str");

                    // Consulta os dados do responsável com base no cref
                    DataTable dtResponsavel = Querys.query_retorno(
                        "SELECT * FROM responsavel WHERE cref = '" + cref + "'"
                    );

                    // Preenche o comboBox2 com os nomes dos responsáveis
                    DataTable dtNomes = Querys.query_retorno(
                        "SELECT nome FROM responsavel WHERE cref = '" + cref + "'"
                    );

                    comboBox2.DataSource = dtNomes;
                    comboBox2.DisplayMember = "nome";
                }
            }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(usernam.Text=="" || maskedTextBox1.Text=="")
            {
                MessageBox.Show("Valores não inseridos");
                return;
            }

            DataTable dt = new DataTable();
            dt = Querys.query_retorno("select *from  usuarios where nome_usuario ='"+usernam.Text+"'");

            if (dt.Rows.Count > 0)
            {
                int id_usu = dt.Rows[0].Field<int>("id_usuario");
                dt.Clear();
                dt = Querys.query_retorno(
                "SELECT * FROM atividades " +
                "JOIN usuarios ON atividades.id_usuario_str = usuarios.id_usuario " +
                "WHERE atividades.id_usuario_str = '" + id_usu + "' " +
                "AND atividades.nome_atividade = '" + comboBox1.Text + "'"
                                                                    );
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cadastro já existente na turma");
                    return;
                }
                else
                {
                    dt = Querys.query_retorno("select *from responsavel where nome='"+comboBox2.Text+"'");
                    Querys.exe(@"insert  atividades
                                values('default','"+comboBox1.Text+ "','default','" + id_usu + "','" + dt.Rows[0].Field<int>("cref")+"')");

                    MessageBox.Show("Usuário inserido com sucesso na atividade, verifique o restante em turmas.");
                    maskedTextBox1.Clear();

                }
            }
            else {
                MessageBox.Show("Usuário inexistente em cadastro do Banco de Dados");
                return;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turmas exclusao_de_turma = new Turmas();
            exclusao_de_turma.Show();
        }
    }
}

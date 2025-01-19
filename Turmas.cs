using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importe das bibliotecas do arquivo pdf
using iTextSharp;////////////////////////
using iTextSharp.text;///////////////////
using iTextSharp.text.pdf;///////////////
/////////////////////////////////////////
namespace Forms_Academia
{
    public partial class Turmas : Form
    {
        public Turmas()
        {
            InitializeComponent();
            comboBox1.DataSource = Querys.query_retorno("select nome from responsavel");
            comboBox1.DisplayMember = "nome";
            comboBox2.DataSource = Querys.query_retorno("select distinct nome_atividade from atividades order by nome_atividade;");
            comboBox2.DisplayMember = "nome_atividade";
            comboBox3.DataSource = Querys.query_retorno("SELECT CONCAT(inicio_time, ' - ', final_time) AS horarios FROM horarios;");
            comboBox3.DisplayMember = "horarios";
            dataGridView1.DataSource = Querys.query_retorno("select nome_atividade as Atividade, count(nome_atividade) as 'Alunos cadastrados' from atividades\r\ngroup by nome_atividade;");

        }

        private void Turmas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ArquivName = "E:\\Arquivo.Net\\Forms_academia" + "\\turmas.pdf";

            using (FileStream arquivoPdf = new FileStream(ArquivName, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPdf = PdfWriter.GetInstance(doc, arquivoPdf);
                string caminho = "E:\\Arquivo.Net\\Forms_academia";

                //configuração da imgagem que vai no pdf
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("E:\\Arquivo.Net\\Forms_academia\\OIP.jpg");
                logo.ScaleToFit(90f,120f);
                logo.Alignment=Element.ALIGN_CENTER;

                //arquivos de texto pertencentes ao mesmo
                string info = "";
                Paragraph paragraph = new Paragraph(info, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.Add("IronBerg Academy\n");
                paragraph.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.Add("\nRelatório de Professores\n\n\n");

                //tratamento das tabelas no pdf
                PdfPTable table = new PdfPTable(2);
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                //criação da celula para adicionar a mesma a tabela
                PdfPCell cell = new PdfPCell();
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.AddElement(logo);//adiciona a logo a própria celula
                cell.Colspan = 2;
                table.AddCell(cell);//adicionado a tabela!!!


                DataTable dt = new DataTable();
                dt = Querys.query_retorno("Select nome, cref from responsavel");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    table.AddCell(dt.Rows[i].Field<string>("nome").ToString());
                    table.AddCell(dt.Rows[i].Field<int>("cref").ToString());
                }
                


                doc.Open();
                doc.Add(paragraph);//adiciona o parágrafo ao documento
                doc.Add(table);//adiciona a tabela ao documento
                doc.Close();

                DialogResult dialg = MessageBox.Show("Deseja abrir o relatório?", "Êxito em relatório", MessageBoxButtons.YesNo);
                if (dialg==DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("E:\\Arquivo.Net\\Forms_academia\\turmas.pdf");
                }
            }
        }
    }
}

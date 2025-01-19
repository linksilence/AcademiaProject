namespace Forms_Academia
{
    partial class Forms_AtCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.acess = new System.Windows.Forms.Label();
            this.exibicao = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.usernam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 76);
            this.panel2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Excluir ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // acess
            // 
            this.acess.AutoSize = true;
            this.acess.Location = new System.Drawing.Point(12, 81);
            this.acess.Name = "acess";
            this.acess.Size = new System.Drawing.Size(64, 16);
            this.acess.TabIndex = 14;
            this.acess.Text = "Atividade";
            // 
            // exibicao
            // 
            this.exibicao.AutoSize = true;
            this.exibicao.Location = new System.Drawing.Point(12, 59);
            this.exibicao.Name = "exibicao";
            this.exibicao.Size = new System.Drawing.Size(0, 16);
            this.exibicao.TabIndex = 13;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(12, 10);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(44, 16);
            this.username.TabIndex = 11;
            this.username.Text = "Nome";
            // 
            // usernam
            // 
            this.usernam.Location = new System.Drawing.Point(12, 29);
            this.usernam.Name = "usernam";
            this.usernam.Size = new System.Drawing.Size(326, 22);
            this.usernam.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(372, 29);
            this.maskedTextBox1.Mask = "(00)0 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 22);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(183, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Responsável";
            // 
            // Forms_AtCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 238);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.usernam);
            this.Controls.Add(this.username);
            this.Controls.Add(this.acess);
            this.Controls.Add(this.exibicao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forms_AtCad";
            this.Text = "Cadastro";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label acess;
        private System.Windows.Forms.Label exibicao;
        private System.Windows.Forms.Label username;
        public System.Windows.Forms.TextBox usernam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
    }
}
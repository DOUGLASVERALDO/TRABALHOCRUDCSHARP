namespace AppCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNovoCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGravarCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textdatadenascimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoCadastro
            // 
            this.BtnNovoCadastro.BackColor = System.Drawing.Color.Gold;
            this.BtnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnNovoCadastro.Location = new System.Drawing.Point(679, 13);
            this.BtnNovoCadastro.Name = "BtnNovoCadastro";
            this.BtnNovoCadastro.Size = new System.Drawing.Size(95, 41);
            this.BtnNovoCadastro.TabIndex = 0;
            this.BtnNovoCadastro.Text = "Novo Cadastro";
            this.BtnNovoCadastro.UseVisualStyleBackColor = false;
            this.BtnNovoCadastro.Click += new System.EventHandler(this.BtnNovoCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(5, 72);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(280, 20);
            this.textNome.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 159);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnGravarCadastro
            // 
            this.btnGravarCadastro.BackColor = System.Drawing.Color.Gold;
            this.btnGravarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarCadastro.Location = new System.Drawing.Point(679, 81);
            this.btnGravarCadastro.Name = "btnGravarCadastro";
            this.btnGravarCadastro.Size = new System.Drawing.Size(95, 41);
            this.btnGravarCadastro.TabIndex = 4;
            this.btnGravarCadastro.Text = "Gravar Cadastro";
            this.btnGravarCadastro.UseVisualStyleBackColor = false;
            this.btnGravarCadastro.Click += new System.EventHandler(this.btnGravarCadastro_Click);
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.BackColor = System.Drawing.Color.Gold;
            this.btnEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCadastro.Location = new System.Drawing.Point(679, 142);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(95, 47);
            this.btnEditarCadastro.TabIndex = 5;
            this.btnEditarCadastro.Text = "Editar Cadastro";
            this.btnEditarCadastro.UseVisualStyleBackColor = false;
            this.btnEditarCadastro.Click += new System.EventHandler(this.btnEditarCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(690, 221);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(60, 23);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 7;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(4, 130);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(281, 20);
            this.textEndereco.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Endereço";
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(4, 186);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(280, 20);
            this.textCidade.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cidade";
            // 
            // textdatadenascimento
            // 
            this.textdatadenascimento.Location = new System.Drawing.Point(323, 169);
            this.textdatadenascimento.Name = "textdatadenascimento";
            this.textdatadenascimento.Size = new System.Drawing.Size(280, 20);
            this.textdatadenascimento.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Nascimento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(323, 93);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(280, 20);
            this.textCelular.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Celular";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(5, 240);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(280, 20);
            this.textEmail.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "E - Mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 21;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(9, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textdatadenascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditarCadastro);
            this.Controls.Add(this.btnGravarCadastro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNovoCadastro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovoCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGravarCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textdatadenascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
    }
}


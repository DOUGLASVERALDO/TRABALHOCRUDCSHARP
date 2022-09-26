using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovoCadastro_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Inserir(txtNome.Text, txtendereco.Text, txtcidade.Text, txtemail.Text,
            txtcelular.Text, txtdatadenascimento.Text);
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoas;
            txtNome.Text = "";
            txtendereco.Text = "";
            txtcidade.Text = "";
            txtemail.Text = "";
            txtcelular.Text = "";
            txtdatadenascimento.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
           

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }
    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Pessoa pessoa = new Pessoa();
            pessoa.Localizar(Id);
            txtNome.Text = pessoa.nome;
            txtendereco.Text = pessoa.endereco;
            txtcidade.Text = pessoa.cidade;
            txtemail.Text = pessoa.email;
            txtcelular.Text = pessoa.celular;
            txtdatadenascimento.Text = pessoa.datadenascimento;
        }

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnGravarCadastro_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Inserir(txtNome.Text, txtendereco.Text, txtcidade.Text, txtemail.Text,
            txtcelular.Text, txtdatadenascimento.Text);
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoas;
            txtNome.Text = "";
            txtendereco.Text = "";
            txtcidade.Text = "";
            txtemail.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    }
    }
    }
    }

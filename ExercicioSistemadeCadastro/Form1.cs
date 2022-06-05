using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioSistemadeCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O cadastro foi realizado com sucesso!\nNome: " +tbnome.Text + "\nTelefone: " +tbtel.Text + "\nCPF: " +tbcpf.Text+ "\nStatus: " +cbstatus.Text+ "\nTipo de conta: " +cbconta.Text+ "\nUsuário: " +tbusuario.Text+ "Senha: " +tbsenha.Text );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao seu cadastro!");
        }

        private void limpar_Click(object sender, EventArgs e)
        {

        }

        private void lbltipousuario_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void lblcpf_Click(object sender, EventArgs e)
        {

        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }
    }
}

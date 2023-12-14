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

namespace ProjetoFinalMod10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PreencherCategorias()
        {
            // Limpe os itens existentes na ComboBox
            comboBox1.Items.Clear();

            // Adicione as categorias desejadas à ComboBox
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Software");
            comboBox1.Items.Add("Hardware");

            // Se desejar uma categoria padrão selecionada
            comboBox1.SelectedIndex = 0; // Isso seleciona o primeiro item na lista
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PreencherCategorias();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Verifica se as três TextBox e a ComboBox têm dados inseridos
            if (!string.IsNullOrWhiteSpace(textBoxCodigo.Text) &&
                !string.IsNullOrWhiteSpace(textBoxDesignação.Text) &&
                !string.IsNullOrWhiteSpace(textBoxpreço.Text) &&
                comboBox1.SelectedItem != null)
            {
                // Constrói a string combinada dos dados
                string dados = $"{textBoxCodigo.Text}, {textBoxDesignação.Text}, {textBoxpreço.Text}, {comboBox1.SelectedItem}";

                // Adiciona os dados à ListBox
                listBoxProdutos.Items.Add(dados);

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Dados transferidos para a ListBox com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa as TextBox e a ComboBox após transferir os dados
                LimparControles();
            }
            else
            {
                // Exibe uma mensagem de erro se algum campo estiver vazio
                MessageBox.Show("Por favor, preencha todos os campos antes de transferir os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparControles()
        {
            // Limpa as TextBox e a ComboBox
            textBoxCodigo.Clear();
            textBoxDesignação.Clear();
            textBoxpreço.Clear();
            comboBox1.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNovaInstancia();
        }
        private void AbrirNovaInstancia()
        {
            Form2 novaInstancia = new Form2();
            novaInstancia.Show();
        }
    }
}

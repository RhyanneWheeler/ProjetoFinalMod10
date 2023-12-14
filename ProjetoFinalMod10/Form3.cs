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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Verifica se as três TextBox e a ComboBox têm dados inseridos
            if (!string.IsNullOrWhiteSpace(textBoxCodigo.Text) &&
                !string.IsNullOrWhiteSpace(textBoxNome.Text) &&
                !string.IsNullOrWhiteSpace(textBoxContato.Text) &&
                !string.IsNullOrWhiteSpace(textBoxEmail.Text) &&
                comboBoxDescrição.SelectedItem != null &&
                comboBoxData.SelectedItem != null)
            {
                // Constrói a string combinada dos dados
                string dados = $"{textBoxCodigo.Text}, {textBoxNome.Text}, {textBoxContato.Text}, {textBoxEmail.Text}, {comboBoxData.SelectedItem}, {comboBoxDescrição.SelectedItem}";

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
            textBoxNome.Clear();
            textBoxContato.Clear();
            textBoxEmail.Clear();
            comboBoxDescrição.SelectedItem = null;
            comboBoxData.SelectedItem = null;
        }
        private void PreencherCategorias()
        {
            // Limpe os itens existentes na ComboBox
            comboBoxDescrição.Items.Clear();
            comboBoxData.Items.Clear();

            // Adicione as categorias desejadas à ComboBox
            comboBoxDescrição.Items.Add("");
            comboBoxDescrição.Items.Add("Não liga");
            comboBoxDescrição.Items.Add("Outro");

            comboBoxData.Items.Add("");
            comboBoxData.Items.Add("Janeiro");
            comboBoxData.Items.Add("Fevereiro");

            // Se desejar uma categoria padrão selecionada
            comboBoxDescrição.SelectedIndex = 0; // Isso seleciona o primeiro item na lista
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PreencherCategorias();
        }
    }
}

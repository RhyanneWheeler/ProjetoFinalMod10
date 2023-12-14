using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalMod10
{
    public partial class Form4 : Form
    {
        private Dictionary<string, string> accounts = new Dictionary<string, string>(); // Simulação de armazenamento de contas
        private bool accountCreated = false;

        public string Username { get; private set; }
        private Form1 mdiParent;
        public Form4(Form1 mdiParent)
        {
            InitializeComponent();
            this.mdiParent = mdiParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;

            // Verifica se ambos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai da função se campos estiverem vazios
            }

            // Simplesmente exibe uma mensagem de login bem-sucedido
            MessageBox.Show($"Login bem-sucedido para {username}!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abre o Form6
            Form6 form6 = new Form6();
            form6.MdiParent = mdiParent;
            form6.Show();

            // Fecha o formulário de login
            this.Close();
        }

    }
    }

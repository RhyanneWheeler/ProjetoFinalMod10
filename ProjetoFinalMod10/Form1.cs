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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;

            AtualizarDataHoraNaBarraDeStatus();

            // Configure um temporizador para atualizar a data e a hora a cada minuto (opcional)
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo (em milissegundos)
            timer.Tick += (sender, e) => AtualizarDataHoraNaBarraDeStatus();
            timer.Start();
        }
        private void AtualizarDataHoraNaBarraDeStatus()
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 loginForm = new Form4(this);
            loginForm.MdiParent = this; // Define o formulário principal como pai do formulário de login
            loginForm.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this; // Define o formulário principal como pai do formulário filho
            form2.Show();
        }

        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do Form3
            Form3 form3 = new Form3();

            // Define o Forms1 como o formulário pai do Form3
            form3.MdiParent = this;

            // Exibe o Form3
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("hh:mm - dd/MM/yyyy");
        }
    }
    }

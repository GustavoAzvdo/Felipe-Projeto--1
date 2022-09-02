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

namespace Rebeca_Projeto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(string Valor)
        {
            InitializeComponent();
            txtAvisos.Text = Valor;
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas form = new Vendas();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form = new Form10();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 form = new Form18();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void abrirFecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas form = new Vendas();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form18 form = new Form18();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void txtAvisos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form = new Form10();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}

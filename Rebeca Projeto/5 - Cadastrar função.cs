using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebeca_Projeto
{
    public partial class Cadastramento : Form
    {
        public Cadastramento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form = new Form10();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função cadastrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

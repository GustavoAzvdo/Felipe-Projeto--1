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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                
                Form7 form = new Form7();   
                form.Show();
                this.Close();

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form =  new Form5();
            form.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido adicionado com sucesso !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deseja alterar o pedido?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


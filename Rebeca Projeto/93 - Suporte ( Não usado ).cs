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
    public partial class Suporte : Form
    {
        public Suporte()
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja confirmar o envio do atendimento? Dentro de 24 horas você receberá uma resposta através do contato enviado.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }
    }
}

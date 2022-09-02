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
    public partial class Form15 : Form
    {
        public Form15()
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
            Form5 destino = new Form5(textBox1.Text);
            destino.Show();
            
        }
    }
}

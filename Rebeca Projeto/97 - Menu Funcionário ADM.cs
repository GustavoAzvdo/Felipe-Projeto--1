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
    public partial class _97___Menu_Funcionário_ADM : Form
    {
        public _97___Menu_Funcionário_ADM()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form10 form = new Form10();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void abrirVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _99__Abrir_venda_ADM form = new _99__Abrir_venda_ADM();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void últimasVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void _97___Menu_Funcionário_ADM_Load(object sender, EventArgs e)
        {

        }
    }
}

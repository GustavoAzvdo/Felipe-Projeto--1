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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuário.Text.Equals("Felipe") && txtSenha.Text.Equals("0"))

                {
                    Form5 from = new Form5();
                    from.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuário.Focus();
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário ou senha incorretos.",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


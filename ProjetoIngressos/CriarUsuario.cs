using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIngressos
{
    public partial class CriarUsuario : Form
    {
        public CriarUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            inicial nw = new inicial();
            nw.Show();
            this.Close();
        }

        private void criarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("conta criada. entre novamente");
            inicial nw = new inicial();
            nw.Show();
            this.Close();
        }
    }
}

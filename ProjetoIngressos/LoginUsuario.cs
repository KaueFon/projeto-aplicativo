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
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            CriarUsuario nw = new CriarUsuario();
            nw.Show();
            this.Close();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            inicial nw = new inicial();
            nw.Show();
            this.Close();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            telaPrincipal nw = new telaPrincipal();
            nw.Show();
            this.Close();
        }
    }
}

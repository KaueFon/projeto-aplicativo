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
    public partial class LoginDev : Form
    {
        public LoginDev()
        {
            InitializeComponent();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            inicial nw = new inicial();
            nw.Show();
            this.Close();
        }

        private void criarContalbl_Click(object sender, EventArgs e)
        {
            CriarDev nw = new CriarDev();
            nw.Show();
            this.Close();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

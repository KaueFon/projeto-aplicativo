﻿using System;
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
    public partial class CriarDev : Form
    {
        public CriarDev()
        {
            InitializeComponent();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            inicial nw = new inicial();
            nw.Show();
            this.Close();
        }

        private void criarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conta Criada!");
            LoginDev nw = new LoginDev();
            nw.Show();
            this.Close();
        }
    }
}

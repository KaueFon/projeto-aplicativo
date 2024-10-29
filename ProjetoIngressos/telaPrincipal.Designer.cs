namespace ProjetoIngressos
{
    partial class telaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativosToolStripMenuItem,
            this.aJudaToolStripMenuItem,
            this.deslogarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaliaçõesToolStripMenuItem,
            this.avaliarToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            // 
            // avaliaçõesToolStripMenuItem
            // 
            this.avaliaçõesToolStripMenuItem.Name = "avaliaçõesToolStripMenuItem";
            this.avaliaçõesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.avaliaçõesToolStripMenuItem.Text = "Avaliações";
            this.avaliaçõesToolStripMenuItem.Click += new System.EventHandler(this.avaliaçõesToolStripMenuItem_Click);
            // 
            // avaliarToolStripMenuItem
            // 
            this.avaliarToolStripMenuItem.Name = "avaliarToolStripMenuItem";
            this.avaliarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.avaliarToolStripMenuItem.Text = "Avaliar";
            // 
            // aJudaToolStripMenuItem
            // 
            this.aJudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoUsarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.aJudaToolStripMenuItem.Name = "aJudaToolStripMenuItem";
            this.aJudaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aJudaToolStripMenuItem.Text = "AJuda";
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // comoUsarToolStripMenuItem
            // 
            this.comoUsarToolStripMenuItem.Name = "comoUsarToolStripMenuItem";
            this.comoUsarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.comoUsarToolStripMenuItem.Text = "Como Usar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoIngressos.Properties.Resources.Aptoide_icon;
            this.pictureBox1.Location = new System.Drawing.Point(269, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem comoUsarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
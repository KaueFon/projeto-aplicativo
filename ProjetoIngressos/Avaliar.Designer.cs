namespace ProjetoIngressos
{
    partial class Avaliar
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
            this.voltarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 415);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 8;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // Avaliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.voltarBtn);
            this.Name = "Avaliar";
            this.Text = "Avaliar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voltarBtn;
    }
}
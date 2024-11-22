namespace Ex.Array2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lsbVetorA = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lsbVetorB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(112, 364);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 53);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lsbVetorA
            // 
            this.lsbVetorA.FormattingEnabled = true;
            this.lsbVetorA.Location = new System.Drawing.Point(162, 58);
            this.lsbVetorA.Name = "lsbVetorA";
            this.lsbVetorA.Size = new System.Drawing.Size(120, 251);
            this.lsbVetorA.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(649, 364);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 53);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lsbVetorB
            // 
            this.lsbVetorB.FormattingEnabled = true;
            this.lsbVetorB.Location = new System.Drawing.Point(466, 58);
            this.lsbVetorB.Name = "lsbVetorB";
            this.lsbVetorB.Size = new System.Drawing.Size(120, 251);
            this.lsbVetorB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbVetorB);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lsbVetorA);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lsbVetorA;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lsbVetorB;
    }
}


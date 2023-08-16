namespace Xiao_music_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelnome = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.labelsenha = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(1575, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 314);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.BackColor = System.Drawing.Color.Transparent;
            this.labelnome.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelnome.Location = new System.Drawing.Point(101, 54);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(202, 50);
            this.labelnome.TabIndex = 1;
            this.labelnome.Text = "NOME:";
            this.labelnome.Click += new System.EventHandler(this.labelnome_Click);
            // 
            // textnome
            // 
            this.textnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnome.Location = new System.Drawing.Point(100, 137);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(402, 62);
            this.textnome.TabIndex = 2;
            // 
            // textsenha
            // 
            this.textsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsenha.Location = new System.Drawing.Point(100, 306);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(402, 62);
            this.textsenha.TabIndex = 3;
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.BackColor = System.Drawing.Color.Transparent;
            this.labelsenha.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelsenha.Location = new System.Drawing.Point(101, 235);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(234, 50);
            this.labelsenha.TabIndex = 4;
            this.labelsenha.Text = "SENHA:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(110, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 85);
            this.button2.TabIndex = 5;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.Button button2;
    }
}


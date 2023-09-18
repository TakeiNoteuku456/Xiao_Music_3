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
            this.button3 = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListView();
            this.ColunadoID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunadoNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.labelnome.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelnome.Location = new System.Drawing.Point(101, 54);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(202, 50);
            this.labelnome.TabIndex = 1;
            this.labelnome.Text = "NOME:";
            this.labelnome.Click += new System.EventHandler(this.Labelnome_Click);
            // 
            // textnome
            // 
            this.textnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnome.Location = new System.Drawing.Point(100, 140);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(402, 62);
            this.textnome.TabIndex = 2;
            // 
            // textsenha
            // 
            this.textsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsenha.Location = new System.Drawing.Point(100, 306);
            this.textsenha.Name = "textsenha";
            this.textsenha.PasswordChar = '*';
            this.textsenha.Size = new System.Drawing.Size(402, 62);
            this.textsenha.TabIndex = 3;
            this.textsenha.TextChanged += new System.EventHandler(this.textsenha_TextChanged);
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.BackColor = System.Drawing.Color.Transparent;
            this.labelsenha.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
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
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(110, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 85);
            this.button2.TabIndex = 5;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(395, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 85);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cadastar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColunadoID,
            this.ColunadoNome});
            this.lista.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(100, 515);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(127, 254);
            this.lista.TabIndex = 7;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // ColunadoID
            // 
            this.ColunadoID.Text = "ID";
            // 
            // ColunadoNome
            // 
            this.ColunadoNome.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pagína_Login";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader ColunadoID;
        private System.Windows.Forms.ColumnHeader ColunadoNome;
    }
}


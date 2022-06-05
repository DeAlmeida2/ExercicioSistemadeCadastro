namespace ExercicioSistemadeCadastro
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lbltipousuario = new System.Windows.Forms.Label();
            this.cbconta = new System.Windows.Forms.ComboBox();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(429, 260);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(143, 48);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(309, 36);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(388, 20);
            this.tbnome.TabIndex = 2;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(306, 20);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(122, 16);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome Completo:";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(306, 59);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(73, 16);
            this.lbltelefone.TabIndex = 4;
            this.lbltelefone.Text = "Telefone:";
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(309, 75);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(183, 20);
            this.tbtel.TabIndex = 5;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(498, 59);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(40, 16);
            this.lblcpf.TabIndex = 6;
            this.lblcpf.Text = "CPF:";
            this.lblcpf.Click += new System.EventHandler(this.lblcpf_Click);
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(500, 75);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(197, 20);
            this.tbcpf.TabIndex = 7;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(307, 98);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(54, 16);
            this.lblstatus.TabIndex = 9;
            this.lblstatus.Text = "Status:";
            // 
            // lbltipousuario
            // 
            this.lbltipousuario.AutoSize = true;
            this.lbltipousuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbltipousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipousuario.Location = new System.Drawing.Point(498, 98);
            this.lbltipousuario.Name = "lbltipousuario";
            this.lbltipousuario.Size = new System.Drawing.Size(109, 16);
            this.lbltipousuario.TabIndex = 10;
            this.lbltipousuario.Text = "Tipo de Conta:";
            this.lbltipousuario.Click += new System.EventHandler(this.lbltipousuario_Click);
            // 
            // cbconta
            // 
            this.cbconta.FormattingEnabled = true;
            this.cbconta.Items.AddRange(new object[] {
            "Adminstrador",
            "Usuário"});
            this.cbconta.Location = new System.Drawing.Point(500, 114);
            this.cbconta.Name = "cbconta";
            this.cbconta.Size = new System.Drawing.Size(197, 21);
            this.cbconta.TabIndex = 11;
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbstatus.Location = new System.Drawing.Point(309, 114);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(182, 21);
            this.cbstatus.TabIndex = 13;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(307, 158);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(131, 16);
            this.lblusuario.TabIndex = 14;
            this.lblusuario.Text = "Insira um Usuário:";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(498, 158);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(55, 16);
            this.lblsenha.TabIndex = 15;
            this.lblsenha.Text = "Senha:";
            this.lblsenha.Click += new System.EventHandler(this.lblsenha_Click);
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(501, 177);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(196, 20);
            this.tbsenha.TabIndex = 17;
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(309, 177);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(182, 20);
            this.tbusuario.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::ExercicioSistemadeCadastro.Properties.Resources.MicrosoftTeams_image;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.cbconta);
            this.Controls.Add(this.lbltipousuario);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbltipousuario;
        private System.Windows.Forms.ComboBox cbconta;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.TextBox tbusuario;
    }
}


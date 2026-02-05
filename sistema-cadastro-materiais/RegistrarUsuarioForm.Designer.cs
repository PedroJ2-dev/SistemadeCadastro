namespace sistema_cadastro_materiais
{
    partial class RegistrarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuarioForm));
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModoEditando = new System.Windows.Forms.Label();
            this.btnSairModoEditando = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "Usuários do Sistema";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Login,
            this.Senha,
            this.Perfil,
            this.Editar,
            this.Excluir});
            this.dgvUsuario.Location = new System.Drawing.Point(11, 168);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 45;
            this.dgvUsuario.Size = new System.Drawing.Size(647, 208);
            this.dgvUsuario.TabIndex = 105;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 120;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.Width = 120;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.MinimumWidth = 6;
            this.Senha.Name = "Senha";
            this.Senha.Width = 120;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "Perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.MinimumWidth = 6;
            this.Perfil.Name = "Perfil";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 50;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 50;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Vendas",
            "Conferência"});
            this.cmbPerfil.Location = new System.Drawing.Point(369, 39);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(288, 21);
            this.cmbPerfil.TabIndex = 104;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(556, 70);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 25);
            this.btnSalvar.TabIndex = 103;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Perfil";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(70, 39);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 20);
            this.txtNome.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nome";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(369, 10);
            this.txtSenha.MaxLength = 35;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(288, 20);
            this.txtSenha.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(71, 10);
            this.txtUsuario.MaxLength = 35;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(242, 20);
            this.txtUsuario.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Usuário";
            // 
            // txtModoEditando
            // 
            this.txtModoEditando.AutoSize = true;
            this.txtModoEditando.Enabled = false;
            this.txtModoEditando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoEditando.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtModoEditando.Location = new System.Drawing.Point(256, 72);
            this.txtModoEditando.Name = "txtModoEditando";
            this.txtModoEditando.Size = new System.Drawing.Size(123, 15);
            this.txtModoEditando.TabIndex = 108;
            this.txtModoEditando.Text = "*Modo de Edição*";
            this.txtModoEditando.Visible = false;
            // 
            // btnSairModoEditando
            // 
            this.btnSairModoEditando.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSairModoEditando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSairModoEditando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairModoEditando.Enabled = false;
            this.btnSairModoEditando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairModoEditando.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairModoEditando.ForeColor = System.Drawing.Color.White;
            this.btnSairModoEditando.Location = new System.Drawing.Point(384, 72);
            this.btnSairModoEditando.Margin = new System.Windows.Forms.Padding(0);
            this.btnSairModoEditando.Name = "btnSairModoEditando";
            this.btnSairModoEditando.Size = new System.Drawing.Size(24, 24);
            this.btnSairModoEditando.TabIndex = 107;
            this.btnSairModoEditando.Text = "X";
            this.btnSairModoEditando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSairModoEditando.UseVisualStyleBackColor = false;
            this.btnSairModoEditando.Visible = false;
            this.btnSairModoEditando.Click += new System.EventHandler(this.btnSairModoEditando_Click);
            // 
            // RegistrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 387);
            this.Controls.Add(this.txtModoEditando);
            this.Controls.Add(this.btnSairModoEditando);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarUsuarioForm";
            this.Text = "RegistrarUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.Label txtModoEditando;
        private System.Windows.Forms.Button btnSairModoEditando;
    }
}
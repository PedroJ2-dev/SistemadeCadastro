namespace sistema_cadastro_materiais
{
    partial class CadMaterialComprasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadMaterialComprasForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.txtModoEditando = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSairModoEditando = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.materialFlatButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTamanho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodMaterial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodBar);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tamanho:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTamanho.Location = new System.Drawing.Point(392, 56);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(176, 20);
            this.txtTamanho.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código Material:";
            // 
            // txtCodMaterial
            // 
            this.txtCodMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCodMaterial.Location = new System.Drawing.Point(392, 24);
            this.txtCodMaterial.Name = "txtCodMaterial";
            this.txtCodMaterial.Size = new System.Drawing.Size(176, 20);
            this.txtCodMaterial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCor.Location = new System.Drawing.Point(112, 56);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(168, 20);
            this.txtCor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Barras:";
            // 
            // txtCodBar
            // 
            this.txtCodBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCodBar.Location = new System.Drawing.Point(112, 24);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(168, 20);
            this.txtCodBar.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(476, 104);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 25);
            this.btnSalvar.TabIndex = 93;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 15);
            this.label7.TabIndex = 98;
            this.label7.Text = "Materiais do Fornecedor";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo_Barra,
            this.Codigo_Material,
            this.Cor,
            this.Tamanho,
            this.Editar,
            this.Excluir});
            this.dgvMaterial.Location = new System.Drawing.Point(8, 192);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.Size = new System.Drawing.Size(568, 296);
            this.dgvMaterial.TabIndex = 99;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Codigo_Barra
            // 
            this.Codigo_Barra.DataPropertyName = "Codigo_Barra";
            this.Codigo_Barra.HeaderText = "Código de Barra";
            this.Codigo_Barra.Name = "Codigo_Barra";
            this.Codigo_Barra.Width = 150;
            // 
            // Codigo_Material
            // 
            this.Codigo_Material.DataPropertyName = "Codigo_Material";
            this.Codigo_Material.HeaderText = "Cód. Material";
            this.Codigo_Material.Name = "Codigo_Material";
            this.Codigo_Material.Width = 150;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "Cor";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.Width = 50;
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.Width = 85;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Editar";
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.Width = 30;
            // 
            // Excluir
            // 
            this.Excluir.DataPropertyName = "Excluir";
            this.Excluir.HeaderText = "";
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 30;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.btnGerarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(8, 104);
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(0);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(104, 25);
            this.btnGerarRelatorio.TabIndex = 100;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // txtModoEditando
            // 
            this.txtModoEditando.AutoSize = true;
            this.txtModoEditando.Enabled = false;
            this.txtModoEditando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoEditando.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtModoEditando.Location = new System.Drawing.Point(192, 96);
            this.txtModoEditando.Name = "txtModoEditando";
            this.txtModoEditando.Size = new System.Drawing.Size(123, 15);
            this.txtModoEditando.TabIndex = 98;
            this.txtModoEditando.Text = "*Modo de Edição*";
            this.txtModoEditando.Visible = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(376, 80);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
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
            this.btnSairModoEditando.Location = new System.Drawing.Point(320, 96);
            this.btnSairModoEditando.Margin = new System.Windows.Forms.Padding(0);
            this.btnSairModoEditando.Name = "btnSairModoEditando";
            this.btnSairModoEditando.Size = new System.Drawing.Size(24, 24);
            this.btnSairModoEditando.TabIndex = 93;
            this.btnSairModoEditando.Text = "X";
            this.btnSairModoEditando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSairModoEditando.UseVisualStyleBackColor = false;
            this.btnSairModoEditando.Visible = false;
            this.btnSairModoEditando.Click += new System.EventHandler(this.btnSairModoEditando_Click);
            // 
            // CadMaterialComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 497);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.txtModoEditando);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSairModoEditando);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadMaterialComprasForm";
            this.Text = "CadMaterialComprasForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label txtModoEditando;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Button btnSairModoEditando;
    }
}
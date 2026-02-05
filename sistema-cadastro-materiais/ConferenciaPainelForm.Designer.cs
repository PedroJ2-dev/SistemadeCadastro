namespace sistema_cadastro_materiais
{
    partial class ConferenciaPainelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenciaPainelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.btnCadMaterial = new System.Windows.Forms.Button();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btnCadUsuario);
            this.panel1.Controls.Add(this.btnCadMaterial);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 496);
            this.panel1.TabIndex = 0;
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadUsuario.Image")));
            this.btnCadUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadUsuario.Location = new System.Drawing.Point(0, 40);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(120, 40);
            this.btnCadUsuario.TabIndex = 0;
            this.btnCadUsuario.Text = "Cad. Usuário";
            this.btnCadUsuario.UseVisualStyleBackColor = false;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // btnCadMaterial
            // 
            this.btnCadMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            this.btnCadMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadMaterial.ForeColor = System.Drawing.Color.White;
            this.btnCadMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnCadMaterial.Image")));
            this.btnCadMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadMaterial.Location = new System.Drawing.Point(0, 0);
            this.btnCadMaterial.Name = "btnCadMaterial";
            this.btnCadMaterial.Size = new System.Drawing.Size(120, 40);
            this.btnCadMaterial.TabIndex = 0;
            this.btnCadMaterial.Text = "Cad. Material";
            this.btnCadMaterial.UseVisualStyleBackColor = false;
            this.btnCadMaterial.Click += new System.EventHandler(this.btnCadMaterial_Click);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.painelPrincipal.Location = new System.Drawing.Point(136, 72);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(667, 497);
            this.painelPrincipal.TabIndex = 0;
            // 
            // ConferenciaPainelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 579);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "ConferenciaPainelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conferência de Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConferenciaPainelForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadMaterial;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Button btnCadUsuario;
    }
}
namespace WindowsFormsApp3
{
    partial class telaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaFornecedor));
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(110, 39);
            this.txtNomeFornecedor.Multiline = true;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(226, 24);
            this.txtNomeFornecedor.TabIndex = 0;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(110, 101);
            this.txtCnpj.Multiline = true;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(226, 24);
            this.txtCnpj.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 162);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(42, 42);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(59, 21);
            this.nome.TabIndex = 3;
            this.nome.Text = "Nome:";
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(7, 104);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(94, 21);
            this.cnpj.TabIndex = 4;
            this.cnpj.Text = "CNPJ/CPF:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(28, 165);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(73, 21);
            this.email.TabIndex = 5;
            this.email.Text = "Contato:";
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFornecedor.Image")));
            this.btnCadFornecedor.Location = new System.Drawing.Point(265, 205);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(71, 55);
            this.btnCadFornecedor.TabIndex = 7;
            this.btnCadFornecedor.Text = "Incluir";
            this.btnCadFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // telaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.btnCadFornecedor);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaFornecedor";
            this.Text = "Cadastro Fornecedor";
            this.Load += new System.EventHandler(this.telaFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button btnCadFornecedor;
    }
}
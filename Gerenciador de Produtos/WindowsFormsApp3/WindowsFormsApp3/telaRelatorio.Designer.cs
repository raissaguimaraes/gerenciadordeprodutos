namespace WindowsFormsApp3
{
    partial class telaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaRelatorio));
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncluirStatus = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAlterarRe = new System.Windows.Forms.Button();
            this.btnDeletarRe = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(129, 71);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(194, 24);
            this.txtData.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(436, 25);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 24);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 27);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 24);
            this.txtNome.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(436, 71);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(194, 24);
            this.txtStatus.TabIndex = 9;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(365, 73);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 21);
            this.email.TabIndex = 12;
            this.email.Text = "Status:";
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(356, 28);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(73, 21);
            this.cnpj.TabIndex = 11;
            this.cnpj.Text = "Produto:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(23, 30);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 21);
            this.nome.TabIndex = 10;
            this.nome.Text = "Fornecedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Emissão:";
            // 
            // btnIncluirStatus
            // 
            this.btnIncluirStatus.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirStatus.Image")));
            this.btnIncluirStatus.Location = new System.Drawing.Point(554, 169);
            this.btnIncluirStatus.Name = "btnIncluirStatus";
            this.btnIncluirStatus.Size = new System.Drawing.Size(71, 55);
            this.btnIncluirStatus.TabIndex = 14;
            this.btnIncluirStatus.Text = "Salvar";
            this.btnIncluirStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluirStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncluirStatus.UseVisualStyleBackColor = true;
            this.btnIncluirStatus.Click += new System.EventHandler(this.btnIncluirStatus_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 169);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(527, 253);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // btnAlterarRe
            // 
            this.btnAlterarRe.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarRe.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarRe.Image")));
            this.btnAlterarRe.Location = new System.Drawing.Point(555, 301);
            this.btnAlterarRe.Name = "btnAlterarRe";
            this.btnAlterarRe.Size = new System.Drawing.Size(71, 55);
            this.btnAlterarRe.TabIndex = 16;
            this.btnAlterarRe.Text = "Alterar";
            this.btnAlterarRe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterarRe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarRe.UseVisualStyleBackColor = true;
            this.btnAlterarRe.Click += new System.EventHandler(this.btnAlterarRe_Click);
            // 
            // btnDeletarRe
            // 
            this.btnDeletarRe.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarRe.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarRe.Image")));
            this.btnDeletarRe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletarRe.Location = new System.Drawing.Point(555, 367);
            this.btnDeletarRe.Name = "btnDeletarRe";
            this.btnDeletarRe.Size = new System.Drawing.Size(71, 55);
            this.btnDeletarRe.TabIndex = 18;
            this.btnDeletarRe.Text = "Excluir";
            this.btnDeletarRe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletarRe.UseVisualStyleBackColor = true;
            this.btnDeletarRe.Click += new System.EventHandler(this.btnDeletarRe_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Image = ((System.Drawing.Image)(resources.GetObject("btnExibir.Image")));
            this.btnExibir.Location = new System.Drawing.Point(555, 235);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(71, 55);
            this.btnExibir.TabIndex = 21;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(423, 115);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 30);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(208, 121);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(194, 24);
            this.txtPesquisar.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "IdStatus:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpar.Location = new System.Drawing.Point(542, 115);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 30);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // telaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 437);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnDeletarRe);
            this.Controls.Add(this.btnAlterarRe);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnIncluirStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaRelatorio";
            this.Text = "Cadastro Acompanhamento de TP";
            this.Load += new System.EventHandler(this.telaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncluirStatus;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAlterarRe;
        private System.Windows.Forms.Button btnDeletarRe;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
    }
}
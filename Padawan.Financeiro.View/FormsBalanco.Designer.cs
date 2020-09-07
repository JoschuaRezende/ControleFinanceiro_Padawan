namespace Padawan.Financeiro.View
{
    partial class FormsBalanco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ListaBalanco = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_Debito = new System.Windows.Forms.TextBox();
            this.txt_Credito = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_TpOperacao = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.lbl_Debitos = new System.Windows.Forms.Label();
            this.lbl_Créditos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ListaBalanco
            // 
            this.txt_ListaBalanco.Location = new System.Drawing.Point(481, 48);
            this.txt_ListaBalanco.Multiline = true;
            this.txt_ListaBalanco.Name = "txt_ListaBalanco";
            this.txt_ListaBalanco.Size = new System.Drawing.Size(203, 27);
            this.txt_ListaBalanco.TabIndex = 0;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(67, 207);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(13, 167);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(194, 23);
            this.txt_valor.TabIndex = 2;
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
            this.cmb_Tipo.Location = new System.Drawing.Point(13, 123);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(195, 23);
            this.cmb_Tipo.TabIndex = 3;
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(237, 77);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(126, 23);
            this.cmb_Categoria.TabIndex = 3;
            this.cmb_Categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_Categoria_SelectedIndexChanged);
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(13, 77);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(194, 23);
            this.txt_Descricao.TabIndex = 2;
            // 
            // txt_Debito
            // 
            this.txt_Debito.Location = new System.Drawing.Point(481, 96);
            this.txt_Debito.Multiline = true;
            this.txt_Debito.Name = "txt_Debito";
            this.txt_Debito.Size = new System.Drawing.Size(203, 27);
            this.txt_Debito.TabIndex = 0;
            this.txt_Debito.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Credito
            // 
            this.txt_Credito.Location = new System.Drawing.Point(481, 149);
            this.txt_Credito.Multiline = true;
            this.txt_Credito.Name = "txt_Credito";
            this.txt_Credito.Size = new System.Drawing.Size(203, 27);
            this.txt_Credito.TabIndex = 0;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Location = new System.Drawing.Point(17, 58);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(58, 15);
            this.lbl_Descricao.TabIndex = 4;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // lbl_TpOperacao
            // 
            this.lbl_TpOperacao.AutoSize = true;
            this.lbl_TpOperacao.Location = new System.Drawing.Point(17, 105);
            this.lbl_TpOperacao.Name = "lbl_TpOperacao";
            this.lbl_TpOperacao.Size = new System.Drawing.Size(58, 15);
            this.lbl_TpOperacao.TabIndex = 4;
            this.lbl_TpOperacao.Text = "Operação";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(18, 149);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(33, 15);
            this.lbl_Valor.TabIndex = 4;
            this.lbl_Valor.Text = "Valor";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(240, 57);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_Categoria.TabIndex = 4;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Location = new System.Drawing.Point(412, 53);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(67, 15);
            this.lbl_Saldo.TabIndex = 4;
            this.lbl_Saldo.Text = "Saldo Atual";
            // 
            // lbl_Debitos
            // 
            this.lbl_Debitos.AutoSize = true;
            this.lbl_Debitos.Location = new System.Drawing.Point(403, 102);
            this.lbl_Debitos.Name = "lbl_Debitos";
            this.lbl_Debitos.Size = new System.Drawing.Size(75, 15);
            this.lbl_Debitos.TabIndex = 4;
            this.lbl_Debitos.Text = "Total Débitos";
            // 
            // lbl_Créditos
            // 
            this.lbl_Créditos.AutoSize = true;
            this.lbl_Créditos.Location = new System.Drawing.Point(400, 154);
            this.lbl_Créditos.Name = "lbl_Créditos";
            this.lbl_Créditos.Size = new System.Drawing.Size(79, 15);
            this.lbl_Créditos.TabIndex = 4;
            this.lbl_Créditos.Text = "Total Creditos";
            this.lbl_Créditos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormsBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 251);
            this.Controls.Add(this.lbl_Créditos);
            this.Controls.Add(this.lbl_Debitos);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_TpOperacao);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.txt_Credito);
            this.Controls.Add(this.txt_Debito);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_ListaBalanco);
            this.Name = "FormsBalanco";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormsBalanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ListaBalanco;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.TextBox txt_Debito;
        private System.Windows.Forms.TextBox txt_Credito;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_TpOperacao;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_Debitos;
        private System.Windows.Forms.Label lbl_Créditos;
    }
}


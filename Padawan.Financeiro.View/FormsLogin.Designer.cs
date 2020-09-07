namespace Padawan.Financeiro.View
{
    partial class FormsLogin
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.lbl_CadastrarUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(62, 58);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(248, 23);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(62, 106);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(248, 23);
            this.txt_senha.TabIndex = 0;
            // 
            // btn_Logar
            // 
            this.btn_Logar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Logar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Logar.Location = new System.Drawing.Point(118, 164);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(152, 23);
            this.btn_Logar.TabIndex = 1;
            this.btn_Logar.Text = "Logar";
            this.btn_Logar.UseVisualStyleBackColor = false;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // lbl_CadastrarUsuario
            // 
            this.lbl_CadastrarUsuario.AutoSize = true;
            this.lbl_CadastrarUsuario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_CadastrarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CadastrarUsuario.Location = new System.Drawing.Point(62, 136);
            this.lbl_CadastrarUsuario.Name = "lbl_CadastrarUsuario";
            this.lbl_CadastrarUsuario.Size = new System.Drawing.Size(100, 15);
            this.lbl_CadastrarUsuario.TabIndex = 2;
            this.lbl_CadastrarUsuario.Text = "Cadastrar Usuario";
            this.lbl_CadastrarUsuario.Click += new System.EventHandler(this.lbl_CadastrarUsuario_Click);
            // 
            // FormsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 234);
            this.Controls.Add(this.lbl_CadastrarUsuario);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Name = "FormsLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormsLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.Label lbl_CadastrarUsuario;
    }
}
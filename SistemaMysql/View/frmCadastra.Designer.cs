namespace SistemaMysql
{
    partial class frmCadastra
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
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.txt_Senha = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRepitaSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSair.Location = new System.Drawing.Point(384, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 37);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseSelectable = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.Location = new System.Drawing.Point(257, 276);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 37);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntrar.Location = new System.Drawing.Point(134, 276);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(99, 37);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Cadastrar";
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txt_Senha
            // 
            // 
            // 
            // 
            this.txt_Senha.CustomButton.Image = null;
            this.txt_Senha.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txt_Senha.CustomButton.Name = "";
            this.txt_Senha.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_Senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Senha.CustomButton.TabIndex = 1;
            this.txt_Senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Senha.CustomButton.UseSelectable = true;
            this.txt_Senha.CustomButton.Visible = false;
            this.txt_Senha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Senha.Lines = new string[0];
            this.txt_Senha.Location = new System.Drawing.Point(178, 121);
            this.txt_Senha.MaxLength = 32767;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Senha.SelectedText = "";
            this.txt_Senha.SelectionLength = 0;
            this.txt_Senha.SelectionStart = 0;
            this.txt_Senha.ShortcutsEnabled = true;
            this.txt_Senha.Size = new System.Drawing.Size(178, 37);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.UseSelectable = true;
            this.txt_Senha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Senha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(178, 63);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(305, 37);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(44, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Senha:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(44, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Login:";
            // 
            // txtRepitaSenha
            // 
            // 
            // 
            // 
            this.txtRepitaSenha.CustomButton.Image = null;
            this.txtRepitaSenha.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtRepitaSenha.CustomButton.Name = "";
            this.txtRepitaSenha.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtRepitaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepitaSenha.CustomButton.TabIndex = 1;
            this.txtRepitaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepitaSenha.CustomButton.UseSelectable = true;
            this.txtRepitaSenha.CustomButton.Visible = false;
            this.txtRepitaSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRepitaSenha.Lines = new string[0];
            this.txtRepitaSenha.Location = new System.Drawing.Point(178, 215);
            this.txtRepitaSenha.MaxLength = 32767;
            this.txtRepitaSenha.Name = "txtRepitaSenha";
            this.txtRepitaSenha.PasswordChar = '*';
            this.txtRepitaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepitaSenha.SelectedText = "";
            this.txtRepitaSenha.SelectionLength = 0;
            this.txtRepitaSenha.SelectionStart = 0;
            this.txtRepitaSenha.ShortcutsEnabled = true;
            this.txtRepitaSenha.Size = new System.Drawing.Size(178, 37);
            this.txtRepitaSenha.TabIndex = 2;
            this.txtRepitaSenha.UseSelectable = true;
            this.txtRepitaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepitaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(44, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "ContraSenha:";
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VerSenha.Location = new System.Drawing.Point(384, 121);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(99, 37);
            this.Btn_VerSenha.TabIndex = 6;
            this.Btn_VerSenha.Text = "Ver";
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lbl_Resultado.Location = new System.Drawing.Point(180, 180);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 0);
            this.Lbl_Resultado.TabIndex = 17;
            // 
            // frmCadastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 337);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.txtRepitaSenha);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCadastra";
            this.Text = "Formulário Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Controls.MetroTextBox txt_Senha;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRepitaSenha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button Btn_VerSenha;
        private MetroFramework.Controls.MetroLabel Lbl_Resultado;
    }
}
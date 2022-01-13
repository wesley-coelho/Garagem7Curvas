namespace Garagem7Curvas
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRepeatSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPermissoes = new System.Windows.Forms.CheckedListBox();
            this.grplogin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddUser = new System.Windows.Forms.Button();
            this.grplogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(18, 55);
            this.tbUsername.MaxLength = 40;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(242, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(18, 108);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(242, 22);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.Leave += new System.EventHandler(this.tbSenha_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // tbRepeatSenha
            // 
            this.tbRepeatSenha.Location = new System.Drawing.Point(18, 165);
            this.tbRepeatSenha.Name = "tbRepeatSenha";
            this.tbRepeatSenha.PasswordChar = '*';
            this.tbRepeatSenha.Size = new System.Drawing.Size(242, 22);
            this.tbRepeatSenha.TabIndex = 5;
            this.tbRepeatSenha.Leave += new System.EventHandler(this.tbRepeatSenha_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir a senha:";
            // 
            // chkPermissoes
            // 
            this.chkPermissoes.FormattingEnabled = true;
            this.chkPermissoes.Items.AddRange(new object[] {
            "Administrador",
            "Editar",
            "Adicionar",
            "Deletar"});
            this.chkPermissoes.Location = new System.Drawing.Point(17, 32);
            this.chkPermissoes.Name = "chkPermissoes";
            this.chkPermissoes.Size = new System.Drawing.Size(242, 89);
            this.chkPermissoes.TabIndex = 7;
            this.chkPermissoes.UseCompatibleTextRendering = true;
            this.chkPermissoes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkPermissoes_ItemCheck);
            // 
            // grplogin
            // 
            this.grplogin.Controls.Add(this.tbSenha);
            this.grplogin.Controls.Add(this.label1);
            this.grplogin.Controls.Add(this.tbUsername);
            this.grplogin.Controls.Add(this.label2);
            this.grplogin.Controls.Add(this.tbRepeatSenha);
            this.grplogin.Controls.Add(this.label3);
            this.grplogin.Location = new System.Drawing.Point(12, 12);
            this.grplogin.Name = "grplogin";
            this.grplogin.Size = new System.Drawing.Size(322, 204);
            this.grplogin.TabIndex = 9;
            this.grplogin.TabStop = false;
            this.grplogin.Text = "Login";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPermissoes);
            this.groupBox1.Location = new System.Drawing.Point(13, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões";
            // 
            // tbAddUser
            // 
            this.tbAddUser.Location = new System.Drawing.Point(13, 392);
            this.tbAddUser.Name = "tbAddUser";
            this.tbAddUser.Size = new System.Drawing.Size(321, 35);
            this.tbAddUser.TabIndex = 11;
            this.tbAddUser.Text = "Adicionar";
            this.tbAddUser.UseVisualStyleBackColor = true;
            this.tbAddUser.Click += new System.EventHandler(this.tbAddUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 445);
            this.Controls.Add(this.tbAddUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grplogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo usuário";
            this.grplogin.ResumeLayout(false);
            this.grplogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRepeatSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkPermissoes;
        private System.Windows.Forms.GroupBox grplogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tbAddUser;
        public System.Windows.Forms.TextBox tbSenha;
    }
}
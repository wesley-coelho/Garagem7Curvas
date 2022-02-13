namespace Garagem7Curvas
{
    partial class FrmGerUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColEdicao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColDeletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColAdicionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColUsuario,
            this.ColSenha,
            this.ColIsAdmin,
            this.ColEdicao,
            this.ColDeletar,
            this.ColAdicionar});
            this.dgvUsers.Location = new System.Drawing.Point(6, 35);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1020, 186);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellEndEdit);
            this.dgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseClick_1);
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 48;
            // 
            // ColUsuario
            // 
            this.ColUsuario.HeaderText = "Usuario";
            this.ColUsuario.MinimumWidth = 6;
            this.ColUsuario.Name = "ColUsuario";
            this.ColUsuario.Width = 86;
            // 
            // ColSenha
            // 
            this.ColSenha.HeaderText = "Senha";
            this.ColSenha.MinimumWidth = 6;
            this.ColSenha.Name = "ColSenha";
            this.ColSenha.Width = 78;
            // 
            // ColIsAdmin
            // 
            this.ColIsAdmin.HeaderText = "Administrador";
            this.ColIsAdmin.MinimumWidth = 6;
            this.ColIsAdmin.Name = "ColIsAdmin";
            this.ColIsAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColIsAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColIsAdmin.Width = 124;
            // 
            // ColEdicao
            // 
            this.ColEdicao.HeaderText = "Editar";
            this.ColEdicao.MinimumWidth = 6;
            this.ColEdicao.Name = "ColEdicao";
            this.ColEdicao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEdicao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColEdicao.Width = 74;
            // 
            // ColDeletar
            // 
            this.ColDeletar.HeaderText = "Deletar";
            this.ColDeletar.MinimumWidth = 6;
            this.ColDeletar.Name = "ColDeletar";
            this.ColDeletar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDeletar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDeletar.Width = 83;
            // 
            // ColAdicionar
            // 
            this.ColAdicionar.HeaderText = "Adicionar";
            this.ColAdicionar.MinimumWidth = 6;
            this.ColAdicionar.Name = "ColAdicionar";
            this.ColAdicionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAdicionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAdicionar.Width = 96;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(913, 280);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(125, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Novo";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Enabled = false;
            this.btnDelUser.Location = new System.Drawing.Point(782, 280);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(125, 40);
            this.btnDelUser.TabIndex = 2;
            this.btnDelUser.Text = "Remover";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // FrmGerUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 333);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmGerUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSenha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColIsAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColEdicao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDeletar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColAdicionar;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelUser;
    }
}
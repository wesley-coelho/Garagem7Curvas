namespace Garagem7Curvas
{
    partial class FrmJanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJanelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarAoFirebaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgListaFinanciamento = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNUmero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidadeVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtdParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaFinanciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarAoFirebaseToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // conectarAoFirebaseToolStripMenuItem
            // 
            this.conectarAoFirebaseToolStripMenuItem.Name = "conectarAoFirebaseToolStripMenuItem";
            this.conectarAoFirebaseToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.conectarAoFirebaseToolStripMenuItem.Text = "Conectar ao firebase";
            this.conectarAoFirebaseToolStripMenuItem.Click += new System.EventHandler(this.conectarAoFirebaseToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripTextBox1,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dtgListaFinanciamento);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Size = new System.Drawing.Size(800, 396);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 2;
            // 
            // dtgListaFinanciamento
            // 
            this.dtgListaFinanciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaFinanciamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.ColCliente,
            this.ColCpf,
            this.ColCEP,
            this.ColEnd,
            this.ColNUmero,
            this.ColBairro,
            this.ColCidade,
            this.ColEstado,
            this.ColTelefone,
            this.ColCelular,
            this.ColEmail,
            this.ColVeiculo,
            this.ColAno,
            this.ColChassi,
            this.ColCidadeVeiculo,
            this.ColCor,
            this.ColMarca,
            this.ColModelo,
            this.ColPlaca,
            this.ColQtdParcelas});
            this.dtgListaFinanciamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgListaFinanciamento.Location = new System.Drawing.Point(20, 20);
            this.dtgListaFinanciamento.Name = "dtgListaFinanciamento";
            this.dtgListaFinanciamento.RowHeadersWidth = 51;
            this.dtgListaFinanciamento.RowTemplate.Height = 24;
            this.dtgListaFinanciamento.Size = new System.Drawing.Size(377, 352);
            this.dtgListaFinanciamento.TabIndex = 0;
            // 
            // Col
            // 
            this.Col.HeaderText = "Id";
            this.Col.MinimumWidth = 6;
            this.Col.Name = "Col";
            this.Col.Width = 125;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 6;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.Width = 125;
            // 
            // ColCpf
            // 
            this.ColCpf.HeaderText = "CPF";
            this.ColCpf.MinimumWidth = 6;
            this.ColCpf.Name = "ColCpf";
            this.ColCpf.Width = 125;
            // 
            // ColCEP
            // 
            this.ColCEP.HeaderText = "CEP";
            this.ColCEP.MinimumWidth = 6;
            this.ColCEP.Name = "ColCEP";
            this.ColCEP.Width = 125;
            // 
            // ColEnd
            // 
            this.ColEnd.HeaderText = "Endereço";
            this.ColEnd.MinimumWidth = 6;
            this.ColEnd.Name = "ColEnd";
            this.ColEnd.Width = 125;
            // 
            // ColNUmero
            // 
            this.ColNUmero.HeaderText = "Número";
            this.ColNUmero.MinimumWidth = 6;
            this.ColNUmero.Name = "ColNUmero";
            this.ColNUmero.Width = 125;
            // 
            // ColBairro
            // 
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.MinimumWidth = 6;
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.Width = 125;
            // 
            // ColCidade
            // 
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.MinimumWidth = 6;
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.Width = 125;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.MinimumWidth = 6;
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Width = 125;
            // 
            // ColTelefone
            // 
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.MinimumWidth = 6;
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.Width = 125;
            // 
            // ColCelular
            // 
            this.ColCelular.HeaderText = "Celular";
            this.ColCelular.MinimumWidth = 6;
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.Width = 125;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 6;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 125;
            // 
            // ColVeiculo
            // 
            this.ColVeiculo.HeaderText = "Veículo";
            this.ColVeiculo.MinimumWidth = 6;
            this.ColVeiculo.Name = "ColVeiculo";
            this.ColVeiculo.Width = 125;
            // 
            // ColAno
            // 
            this.ColAno.HeaderText = "Ano";
            this.ColAno.MinimumWidth = 6;
            this.ColAno.Name = "ColAno";
            this.ColAno.Width = 125;
            // 
            // ColChassi
            // 
            this.ColChassi.HeaderText = "Chassi";
            this.ColChassi.MinimumWidth = 6;
            this.ColChassi.Name = "ColChassi";
            this.ColChassi.Width = 125;
            // 
            // ColCidadeVeiculo
            // 
            this.ColCidadeVeiculo.HeaderText = "Cidade Veículo";
            this.ColCidadeVeiculo.MinimumWidth = 6;
            this.ColCidadeVeiculo.Name = "ColCidadeVeiculo";
            this.ColCidadeVeiculo.Width = 125;
            // 
            // ColCor
            // 
            this.ColCor.HeaderText = "Cor";
            this.ColCor.MinimumWidth = 6;
            this.ColCor.Name = "ColCor";
            this.ColCor.Width = 125;
            // 
            // ColMarca
            // 
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.MinimumWidth = 6;
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.Width = 125;
            // 
            // ColModelo
            // 
            this.ColModelo.HeaderText = "Modelo";
            this.ColModelo.MinimumWidth = 6;
            this.ColModelo.Name = "ColModelo";
            this.ColModelo.Width = 125;
            // 
            // ColPlaca
            // 
            this.ColPlaca.HeaderText = "Placa";
            this.ColPlaca.MinimumWidth = 6;
            this.ColPlaca.Name = "ColPlaca";
            this.ColPlaca.Width = 125;
            // 
            // ColQtdParcelas
            // 
            this.ColQtdParcelas.HeaderText = "Parcelas";
            this.ColQtdParcelas.MinimumWidth = 6;
            this.ColQtdParcelas.Name = "ColQtdParcelas";
            this.ColQtdParcelas.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColParcela,
            this.ColVencimento,
            this.ColValor,
            this.ColValorPago,
            this.ColStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(331, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColParcela
            // 
            this.ColParcela.HeaderText = "Parcela";
            this.ColParcela.MinimumWidth = 6;
            this.ColParcela.Name = "ColParcela";
            this.ColParcela.Width = 125;
            // 
            // ColVencimento
            // 
            this.ColVencimento.HeaderText = "Vencimento";
            this.ColVencimento.MinimumWidth = 6;
            this.ColVencimento.Name = "ColVencimento";
            this.ColVencimento.Width = 125;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor R$";
            this.ColValor.MinimumWidth = 6;
            this.ColValor.Name = "ColValor";
            this.ColValor.Width = 125;
            // 
            // ColValorPago
            // 
            this.ColValorPago.HeaderText = "Valor Pago R$";
            this.ColValorPago.MinimumWidth = 6;
            this.ColValorPago.Name = "ColValorPago";
            this.ColValorPago.Width = 125;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 6;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.Width = 125;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barraStatus
            // 
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // FrmJanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmJanelaPrincipal";
            this.Text = "Gerenciamento de Financiamentos de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaFinanciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgListaFinanciamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.ToolStripMenuItem conectarAoFirebaseToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNUmero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidadeVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtdParcelas;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel barraStatus;
    }
}


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
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financiamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inadimplentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalRecebidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
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
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParcelas = new System.Windows.Forms.DataGridView();
            this.ColParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.abrirPlanilhaExcel = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaFinanciamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
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
            this.conectarAoFirebaseToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.gerenciarUsuariosToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.inicioToolStripMenuItem.Text = "Programa";
            // 
            // conectarAoFirebaseToolStripMenuItem
            // 
            this.conectarAoFirebaseToolStripMenuItem.Name = "conectarAoFirebaseToolStripMenuItem";
            this.conectarAoFirebaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.conectarAoFirebaseToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.conectarAoFirebaseToolStripMenuItem.Text = "Conectar ao firebase";
            this.conectarAoFirebaseToolStripMenuItem.Click += new System.EventHandler(this.conectarAoFirebaseToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportPlan});
            this.importarToolStripMenuItem.Enabled = false;
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // menuImportPlan
            // 
            this.menuImportPlan.Name = "menuImportPlan";
            this.menuImportPlan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuImportPlan.Size = new System.Drawing.Size(194, 26);
            this.menuImportPlan.Text = "Planilha ";
            this.menuImportPlan.Click += new System.EventHandler(this.menuImportPlan_Click);
            // 
            // gerenciarUsuariosToolStripMenuItem
            // 
            this.gerenciarUsuariosToolStripMenuItem.Enabled = false;
            this.gerenciarUsuariosToolStripMenuItem.Name = "gerenciarUsuariosToolStripMenuItem";
            this.gerenciarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.gerenciarUsuariosToolStripMenuItem.Text = "Gerenciar Usuarios";
            this.gerenciarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuariosToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.editarToolStripMenuItem.Text = "Registro";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaToolStripMenuItem,
            this.financiamentoToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // fichaToolStripMenuItem
            // 
            this.fichaToolStripMenuItem.Name = "fichaToolStripMenuItem";
            this.fichaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.fichaToolStripMenuItem.Text = "Ficha";
            // 
            // financiamentoToolStripMenuItem
            // 
            this.financiamentoToolStripMenuItem.Name = "financiamentoToolStripMenuItem";
            this.financiamentoToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.financiamentoToolStripMenuItem.Text = "Financiamento";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inadimplentesToolStripMenuItem,
            this.totalAReceberToolStripMenuItem,
            this.totalRecebidoToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.relatoriosToolStripMenuItem.Text = "Relatório";
            // 
            // inadimplentesToolStripMenuItem
            // 
            this.inadimplentesToolStripMenuItem.Name = "inadimplentesToolStripMenuItem";
            this.inadimplentesToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.inadimplentesToolStripMenuItem.Text = "Cobrança";
            // 
            // totalAReceberToolStripMenuItem
            // 
            this.totalAReceberToolStripMenuItem.Name = "totalAReceberToolStripMenuItem";
            this.totalAReceberToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.totalAReceberToolStripMenuItem.Text = "Valor a Receber";
            // 
            // totalRecebidoToolStripMenuItem
            // 
            this.totalRecebidoToolStripMenuItem.Name = "totalRecebidoToolStripMenuItem";
            this.totalRecebidoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.totalRecebidoToolStripMenuItem.Text = "Valor Recebido";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.programaToolStripMenuItem.Text = "Sobre o Gerenciamento de Financiamentos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnDelete,
            this.toolStripButton3,
            this.btnImprimir,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(158, 27);
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
            this.toolStripButton1.ToolTipText = "Adicionar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 24);
            this.btnDelete.ToolTipText = "Excluir";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Recarregar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(29, 24);
            this.btnImprimir.Text = "toolStripButton4";
            this.btnImprimir.ToolTipText = "Imprimir";
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barraStatus
            // 
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(800, 398);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Panel2.Controls.Add(this.dtgParcelas);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Size = new System.Drawing.Size(800, 396);
            this.splitContainer1.SplitterDistance = 419;
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
            this.ColQtdParcelas,
            this.colObs});
            this.dtgListaFinanciamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgListaFinanciamento.Location = new System.Drawing.Point(20, 20);
            this.dtgListaFinanciamento.Name = "dtgListaFinanciamento";
            this.dtgListaFinanciamento.RowHeadersWidth = 51;
            this.dtgListaFinanciamento.RowTemplate.Height = 24;
            this.dtgListaFinanciamento.Size = new System.Drawing.Size(375, 352);
            this.dtgListaFinanciamento.TabIndex = 0;
            this.dtgListaFinanciamento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaFinanciamento_CellEndEdit);
            this.dtgListaFinanciamento.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgListaFinanciamento_RowHeaderMouseClick);
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
            // colObs
            // 
            this.colObs.HeaderText = "Obs.:";
            this.colObs.MinimumWidth = 6;
            this.colObs.Name = "colObs";
            this.colObs.Width = 125;
            // 
            // dtgParcelas
            // 
            this.dtgParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColParcela,
            this.ColVencimento,
            this.ColValor,
            this.ColValorPago,
            this.ColStatus});
            this.dtgParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgParcelas.Location = new System.Drawing.Point(20, 20);
            this.dtgParcelas.Name = "dtgParcelas";
            this.dtgParcelas.RowHeadersWidth = 51;
            this.dtgParcelas.RowTemplate.Height = 24;
            this.dtgParcelas.Size = new System.Drawing.Size(333, 352);
            this.dtgParcelas.TabIndex = 0;
            this.dtgParcelas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParcelas_CellEndEdit);
            // 
            // ColParcela
            // 
            this.ColParcela.HeaderText = "Parcela";
            this.ColParcela.MinimumWidth = 6;
            this.ColParcela.Name = "ColParcela";
            this.ColParcela.ReadOnly = true;
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
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 396);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 423);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbPesquisar,
            this.btnPesquisar});
            this.toolStrip2.Location = new System.Drawing.Point(162, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(244, 27);
            this.toolStrip2.TabIndex = 2;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPesquisar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(200, 27);
            this.tbPesquisar.Text = "NOME DO CLIENTE";
            this.tbPesquisar.ToolTipText = "Digite o nome";
            this.tbPesquisar.Leave += new System.EventHandler(this.tbPesquisar_Leave);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            this.tbPesquisar.Click += new System.EventHandler(this.tbPesquisar_Click);
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(29, 24);
            this.btnPesquisar.Text = "toolStripButton6";
            this.btnPesquisar.ToolTipText = "Pesquisar por Nome";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // abrirPlanilhaExcel
            // 
            this.abrirPlanilhaExcel.FileName = "Selecionar path Planilha";
            // 
            // FrmJanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmJanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Financiamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaFinanciamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem conectarAoFirebaseToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel barraStatus;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgParcelas;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox tbPesquisar;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        public System.Windows.Forms.DataGridView dtgListaFinanciamento;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.ToolStripMenuItem menuImportPlan;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.OpenFileDialog abrirPlanilhaExcel;
        public System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financiamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inadimplentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalRecebidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gerenciarUsuariosToolStripMenuItem;
    }
}


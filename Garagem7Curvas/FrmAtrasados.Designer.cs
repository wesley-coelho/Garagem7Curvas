namespace Garagem7Curvas
{
    partial class FrmAtrasados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listaAtrasados = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.linhas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSoma = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaAtrasados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaAtrasados
            // 
            this.listaAtrasados.AllowUserToAddRows = false;
            this.listaAtrasados.AllowUserToDeleteRows = false;
            this.listaAtrasados.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listaAtrasados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listaAtrasados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaAtrasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAtrasados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNome,
            this.ColTelefone,
            this.ColCelular,
            this.ColVeiculo,
            this.ColMarca,
            this.ColModelo,
            this.ColCor,
            this.ColParcela,
            this.ColVencimento,
            this.ColValor,
            this.ColValorPago,
            this.ColObs});
            this.listaAtrasados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaAtrasados.Location = new System.Drawing.Point(0, 0);
            this.listaAtrasados.Name = "listaAtrasados";
            this.listaAtrasados.ReadOnly = true;
            this.listaAtrasados.RowHeadersWidth = 51;
            this.listaAtrasados.RowTemplate.Height = 24;
            this.listaAtrasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaAtrasados.Size = new System.Drawing.Size(927, 450);
            this.listaAtrasados.TabIndex = 0;  
            this.listaAtrasados.SelectionChanged += new System.EventHandler(this.listaAtrasados_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = true;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.linhas,
            this.lblSoma});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(927, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // linhas
            // 
            this.linhas.Name = "linhas";
            this.linhas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linhas.Size = new System.Drawing.Size(65, 20);
            this.linhas.Text = "Parcelas:";
            // 
            // lblSoma
            // 
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(54, 20);
            this.lblSoma.Text = "Soma: ";
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.MinimumWidth = 6;
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNome.Width = 51;
            // 
            // ColTelefone
            // 
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.MinimumWidth = 6;
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.ReadOnly = true;
            this.ColTelefone.Width = 93;
            // 
            // ColCelular
            // 
            this.ColCelular.HeaderText = "Celular";
            this.ColCelular.MinimumWidth = 6;
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.ReadOnly = true;
            this.ColCelular.Width = 81;
            // 
            // ColVeiculo
            // 
            this.ColVeiculo.HeaderText = "Veiculo";
            this.ColVeiculo.MinimumWidth = 6;
            this.ColVeiculo.Name = "ColVeiculo";
            this.ColVeiculo.ReadOnly = true;
            this.ColVeiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVeiculo.Width = 60;
            // 
            // ColMarca
            // 
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.MinimumWidth = 6;
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.ReadOnly = true;
            this.ColMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColMarca.Width = 53;
            // 
            // ColModelo
            // 
            this.ColModelo.HeaderText = "Modelo";
            this.ColModelo.MinimumWidth = 6;
            this.ColModelo.Name = "ColModelo";
            this.ColModelo.ReadOnly = true;
            this.ColModelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColModelo.Width = 60;
            // 
            // ColCor
            // 
            this.ColCor.HeaderText = "Cor";
            this.ColCor.MinimumWidth = 6;
            this.ColCor.Name = "ColCor";
            this.ColCor.ReadOnly = true;
            this.ColCor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCor.Width = 36;
            // 
            // ColParcela
            // 
            this.ColParcela.HeaderText = "Parcela";
            this.ColParcela.MinimumWidth = 6;
            this.ColParcela.Name = "ColParcela";
            this.ColParcela.ReadOnly = true;
            this.ColParcela.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColParcela.Width = 62;
            // 
            // ColVencimento
            // 
            this.ColVencimento.HeaderText = "Vencimento";
            this.ColVencimento.MinimumWidth = 6;
            this.ColVencimento.Name = "ColVencimento";
            this.ColVencimento.ReadOnly = true;
            this.ColVencimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVencimento.Width = 88;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor R$";
            this.ColValor.MinimumWidth = 6;
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColValor.Width = 69;
            // 
            // ColValorPago
            // 
            this.ColValorPago.HeaderText = "Valor Pago R$";
            this.ColValorPago.MinimumWidth = 6;
            this.ColValorPago.Name = "ColValorPago";
            this.ColValorPago.ReadOnly = true;
            this.ColValorPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColValorPago.Width = 106;
            // 
            // ColObs
            // 
            this.ColObs.HeaderText = "Observação";
            this.ColObs.MinimumWidth = 6;
            this.ColObs.Name = "ColObs";
            this.ColObs.ReadOnly = true;
            this.ColObs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColObs.Width = 91;
            // 
            // FrmAtrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listaAtrasados);
            this.Name = "FrmAtrasados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Em atraso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAtrasados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaAtrasados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaAtrasados;
        private System.Windows.Forms.ToolStripStatusLabel linhas;
        public System.Windows.Forms.ToolStripProgressBar progressBar;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObs;
    }
}
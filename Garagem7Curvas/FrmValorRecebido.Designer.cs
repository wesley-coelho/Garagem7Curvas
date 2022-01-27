namespace Garagem7Curvas
{
    partial class FrmValorRecebido
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
            this.cbOpRelValorRecebido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvValRecebido = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbValRecebido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarRecebido = new System.Windows.Forms.ToolStripProgressBar();
            this.ParcelasRecebidas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSomaRecebido = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataPagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValRecebido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOpRelValorRecebido
            // 
            this.cbOpRelValorRecebido.FormattingEnabled = true;
            this.cbOpRelValorRecebido.Items.AddRange(new object[] {
            "HOJE",
            "ONTEM",
            "15 DIAS",
            "MÊS",
            "BIMESTRE",
            "TRIMESTRE",
            "SEMESTRE",
            "ANO"});
            this.cbOpRelValorRecebido.Location = new System.Drawing.Point(88, 30);
            this.cbOpRelValorRecebido.Name = "cbOpRelValorRecebido";
            this.cbOpRelValorRecebido.Size = new System.Drawing.Size(150, 24);
            this.cbOpRelValorRecebido.TabIndex = 1;
            this.cbOpRelValorRecebido.SelectedValueChanged += new System.EventHandler(this.cbOpRelValorRecebido_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Período:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.dgvValRecebido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(800, 383);
            this.panel3.TabIndex = 10;
            // 
            // dgvValRecebido
            // 
            this.dgvValRecebido.AllowUserToAddRows = false;
            this.dgvValRecebido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvValRecebido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvValRecebido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvValRecebido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValRecebido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColVeiculo,
            this.ColMarca,
            this.ColModelo,
            this.ColAno,
            this.ColCor,
            this.ColParcela,
            this.ColVencimento,
            this.ColValor,
            this.ColDataPagto,
            this.ColValorPago});
            this.dgvValRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValRecebido.Location = new System.Drawing.Point(10, 10);
            this.dgvValRecebido.Name = "dgvValRecebido";
            this.dgvValRecebido.RowHeadersWidth = 51;
            this.dgvValRecebido.RowTemplate.Height = 24;
            this.dgvValRecebido.Size = new System.Drawing.Size(780, 363);
            this.dgvValRecebido.TabIndex = 2;
            this.dgvValRecebido.SelectionChanged += new System.EventHandler(this.dgvValRecebido_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbOpRelValorRecebido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbValRecebido);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 258);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.panel2.Size = new System.Drawing.Size(780, 89);
            this.panel2.TabIndex = 9;
            // 
            // tbValRecebido
            // 
            this.tbValRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValRecebido.Location = new System.Drawing.Point(568, 19);
            this.tbValRecebido.Name = "tbValRecebido";
            this.tbValRecebido.Size = new System.Drawing.Size(150, 22);
            this.tbValRecebido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = true;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarRecebido,
            this.ParcelasRecebidas,
            this.lblSomaRecebido});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(10, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(780, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarRecebido
            // 
            this.progressBarRecebido.MarqueeAnimationSpeed = 1;
            this.progressBarRecebido.Name = "progressBarRecebido";
            this.progressBarRecebido.Size = new System.Drawing.Size(100, 18);
            // 
            // ParcelasRecebidas
            // 
            this.ParcelasRecebidas.Name = "ParcelasRecebidas";
            this.ParcelasRecebidas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ParcelasRecebidas.Size = new System.Drawing.Size(65, 20);
            this.ParcelasRecebidas.Text = "Parcelas:";
            // 
            // lblSomaRecebido
            // 
            this.lblSomaRecebido.Name = "lblSomaRecebido";
            this.lblSomaRecebido.Size = new System.Drawing.Size(54, 20);
            this.lblSomaRecebido.Text = "Soma: ";
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 6;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCliente.Width = 57;
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
            // ColAno
            // 
            this.ColAno.HeaderText = "Ano";
            this.ColAno.MinimumWidth = 6;
            this.ColAno.Name = "ColAno";
            this.ColAno.ReadOnly = true;
            this.ColAno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColAno.Width = 39;
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
            // ColDataPagto
            // 
            this.ColDataPagto.HeaderText = "Data Pgto";
            this.ColDataPagto.MinimumWidth = 6;
            this.ColDataPagto.Name = "ColDataPagto";
            this.ColDataPagto.ReadOnly = true;
            this.ColDataPagto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDataPagto.Width = 77;
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
            // FrmValorRecebido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmValorRecebido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor recebido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValRecebido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOpRelValorRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvValRecebido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbValRecebido;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar progressBarRecebido;
        private System.Windows.Forms.ToolStripStatusLabel ParcelasRecebidas;
        private System.Windows.Forms.ToolStripStatusLabel lblSomaRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorPago;
    }
}
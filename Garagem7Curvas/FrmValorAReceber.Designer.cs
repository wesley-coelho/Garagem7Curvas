namespace Garagem7Curvas
{
    partial class FrmValorAReceber
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpRelValorAReceber = new System.Windows.Forms.ComboBox();
            this.dgvValReceber = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarValAReceber = new System.Windows.Forms.ToolStripProgressBar();
            this.linhasValAReceber = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSomaValAReceber = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValReceber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // cbOpRelValorAReceber
            // 
            this.cbOpRelValorAReceber.FormattingEnabled = true;
            this.cbOpRelValorAReceber.Items.AddRange(new object[] {
            "ATRASADOS",
            "HOJE",
            "AMANHÃ",
            "15 DIAS",
            "MÊS",
            "BIMESTRE",
            "TRIMESTRE",
            "SEMESTRE",
            "ANO"});
            this.cbOpRelValorAReceber.Location = new System.Drawing.Point(88, 30);
            this.cbOpRelValorAReceber.Name = "cbOpRelValorAReceber";
            this.cbOpRelValorAReceber.Size = new System.Drawing.Size(150, 24);
            this.cbOpRelValorAReceber.TabIndex = 1;
            this.cbOpRelValorAReceber.SelectedValueChanged += new System.EventHandler(this.cbOpRelValorAReceber_SelectedValueChanged);
            // 
            // dgvValReceber
            // 
            this.dgvValReceber.AllowUserToAddRows = false;
            this.dgvValReceber.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvValReceber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvValReceber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvValReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColVeiculo,
            this.ColMarca,
            this.ColModelo,
            this.ColAno,
            this.ColCor,
            this.ColParcela,
            this.ColVencimento,
            this.ColValor});
            this.dgvValReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValReceber.Location = new System.Drawing.Point(10, 10);
            this.dgvValReceber.Name = "dgvValReceber";
            this.dgvValReceber.RowHeadersWidth = 51;
            this.dgvValReceber.RowTemplate.Height = 24;
            this.dgvValReceber.Size = new System.Drawing.Size(911, 299);
            this.dgvValReceber.TabIndex = 2;
            this.dgvValReceber.SelectionChanged += new System.EventHandler(this.dgvValReceber_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorTotal.Location = new System.Drawing.Point(699, 19);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(150, 22);
            this.tbValorTotal.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbOpRelValorAReceber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(931, 67);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbValorTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 223);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.panel2.Size = new System.Drawing.Size(911, 60);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.dgvValReceber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(931, 319);
            this.panel3.TabIndex = 7;
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
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = true;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarValAReceber,
            this.linhasValAReceber,
            this.lblSomaValAReceber});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(10, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(911, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarValAReceber
            // 
            this.progressBarValAReceber.MarqueeAnimationSpeed = 1;
            this.progressBarValAReceber.Name = "progressBarValAReceber";
            this.progressBarValAReceber.Size = new System.Drawing.Size(100, 18);
            // 
            // linhasValAReceber
            // 
            this.linhasValAReceber.Name = "linhasValAReceber";
            this.linhasValAReceber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linhasValAReceber.Size = new System.Drawing.Size(65, 20);
            this.linhasValAReceber.Text = "Parcelas:";
            // 
            // lblSomaValAReceber
            // 
            this.lblSomaValAReceber.Name = "lblSomaValAReceber";
            this.lblSomaValAReceber.Size = new System.Drawing.Size(54, 20);
            this.lblSomaValAReceber.Text = "Soma: ";
            // 
            // FrmValorAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmValorAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor a receber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvValReceber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpRelValorAReceber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvValReceber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar progressBarValAReceber;
        private System.Windows.Forms.ToolStripStatusLabel linhasValAReceber;
        private System.Windows.Forms.ToolStripStatusLabel lblSomaValAReceber;
    }
}
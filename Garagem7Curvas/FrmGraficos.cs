using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Garagem7Curvas
{
    public partial class FrmGraficos : Form
    {

        FrmJanelaPrincipal formJanelaPrincipal = new FrmJanelaPrincipal();

        public FrmGraficos(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.formJanelaPrincipal = janelaPrincipal;
        }

        private void FrmGraficos_Load(object sender, EventArgs e)
        { 
            //config grafico                                
            graficoFaturamento.Series.FindByName("Recebido").ChartType = SeriesChartType.Column;
            graficoFaturamento.Series.FindByName("Receita").ChartType = SeriesChartType.Column;
            graficoFaturamento.Series.FindByName("Atrasado").ChartType = SeriesChartType.Column;
            if (cbGraficoAno.Items.Contains(DateTime.Now.Year.ToString()))           
                cbGraficoAno.SelectedIndex = cbGraficoAno.Items.IndexOf(DateTime.Now.Year.ToString());
            else
                cbGraficoAno.SelectedIndex = 0;

            setChart(int.Parse(cbGraficoAno.Text), graficoFaturamento);
        }

        private async void setChart(int ano, Chart grafico)
        {
            try
            {
                
                double mesRecebido = 0;
                double mesAtrasado = 0;
                double mesReceita = 0;
                CollectionReference colRef = formJanelaPrincipal.db.Collection("financiamentos");
                QuerySnapshot qSnap = await colRef.GetSnapshotAsync();
                pBarGraph.Visible = true;
                pBarGraph.Value = 0;
                pBarGraph.Maximum = 13;
                grafico.Series.FindByName("Recebido").Points.Clear();
                grafico.Series.FindByName("Receita").Points.Clear();
                grafico.Series.FindByName("Atrasado").Points.Clear();
                for (int i = 1; i < 13; i++)
                {
                    pBarGraph.Value++;
                    foreach (var query in qSnap)
                    {
                       
                        if (query.Exists)
                        {
                            Financiamento financiamento = query.ConvertTo<Financiamento>();
                                for (int j = 0; j < financiamento.Parcelas.Length; j++)
                                {

                                 ///////////////SERIE 1////////////////
                                 //parcelas  a receber
                                 if (Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date.Year == ano && Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date.Month == i)
                                     mesReceita += financiamento.Parcelas[j].ValorNominal;
                                ///////////////SERIE 2////////////////
                                //parcelas pagas com campo dataPgto não nulo
                                if (!string.IsNullOrEmpty(financiamento.Parcelas[j].DataPgto))
                                    {
                                        if(Convert.ToDateTime(financiamento.Parcelas[j].DataPgto).Date.Year == ano && Convert.ToDateTime(financiamento.Parcelas[j].DataPgto).Date.Month == i && financiamento.Parcelas[j].ValorPago > 0)
                                        mesRecebido += financiamento.Parcelas[j].ValorPago;
                                        //parcelas pagas com campo dataPgto NULO
                                    }
                                    else if (Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date.Year == ano && Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date.Month == i && financiamento.Parcelas[j].ValorPago > 0)
                                    mesRecebido += financiamento.Parcelas[j].ValorPago;                                   

                                    ///////////////SERIE 3////////////////
                                    ///parcelas em atraso
                                    if (Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date.Year == ano && Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date.Month == i && Convert.ToDateTime(financiamento.Parcelas[j].Vencimento).Date < DateTime.Now.Date && financiamento.Parcelas[j].ValorPago == 0)
                                    {
                                        mesAtrasado += financiamento.Parcelas[j].ValorNominal;                                        
                                    }
                                       
                                }
                        }
                    }
                    //total mes
                    grafico.Series.FindByName("Recebido").Points.AddXY(i, mesRecebido);
                    grafico.Series.FindByName("Atrasado").Points.AddXY(i, mesAtrasado);
                    grafico.Series.FindByName("Receita").Points.AddXY(i, mesReceita);
                    mesRecebido = 0;
                    mesAtrasado = 0;
                    mesReceita = 0;
                }
                await Task.Delay(500);
                pBarGraph.Visible = false;

                

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            setChart(int.Parse(cbGraficoAno.Text),  graficoFaturamento);
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            graficoFaturamento.Printing.Print(true); 
        }

        
        private void printGrafico_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printGrafico.DefaultPageSettings.Landscape = true;           

        }

        private  void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog windowSalvar = new SaveFileDialog();
            windowSalvar.DefaultExt = ".png";
            windowSalvar.Title = "Escolha o local para salvar o gráfico.";
            windowSalvar.Filter = "Arquivo de imagem PNG |*.png";
            if(windowSalvar.ShowDialog() != DialogResult.Cancel)
            {
                if (windowSalvar.FileName.EndsWith(".png"))
                {
                    string pathImage = windowSalvar.FileName;
                    graficoFaturamento.SaveImage(pathImage, ChartImageFormat.Png);
                }
                else
                {
                    MessageBox.Show("O arquivo não foi salvo, pois tem que ser salvo em .png","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
              
        }
    }
}

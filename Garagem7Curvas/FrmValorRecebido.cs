using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem7Curvas
{
    public partial class FrmValorRecebido : Form
    {

        FrmJanelaPrincipal janelaPrincipal = new FrmJanelaPrincipal();
        public FrmValorRecebido(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.janelaPrincipal = janelaPrincipal;
        }

        private void cbOpRelValorRecebido_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cbOpRelValorRecebido.Text == "HOJE")
            {

                getValorRecebido("HOJE");
            }            
            else if (cbOpRelValorRecebido.Text == "ONTEM")
            {
                getValorRecebido("ONTEM");
            }
            else if (cbOpRelValorRecebido.Text == "15 DIAS")
            {
                getValorRecebido("15 DIAS");
            }
            else if (cbOpRelValorRecebido.Text == "MÊS")
            {
                getValorRecebido("MÊS");
            }
            else if (cbOpRelValorRecebido.Text == "BIMESTRE")
            {
                getValorRecebido("BIMESTRE");
            }
            else if (cbOpRelValorRecebido.Text == "TRIMESTRE")
            {
                getValorRecebido("TRIMESTRE");
            }
            else if (cbOpRelValorRecebido.Text == "SEMESTRE")
            {
                getValorRecebido("SEMESTRE");
            }
            else if (cbOpRelValorRecebido.Text == "ANO")
            {
                getValorRecebido("ANO");
            }
        }

        private async void getValorRecebido(string periodo)
        {
            dgvValRecebido.UseWaitCursor = true;
            CollectionReference colRef = this.janelaPrincipal.db.Collection("financiamentos");
            try
            {
               
                double soma = 0;
                Query qdocs = colRef.OrderBy("ClienteNome");
                QuerySnapshot qSnap = await qdocs.GetSnapshotAsync();
                progressBarRecebido.Visible = true;
                progressBarRecebido.Step = 10;
                progressBarRecebido.Value = 0;
                progressBarRecebido.Minimum = 0;
                progressBarRecebido.Maximum = qSnap.Count;
                dgvValRecebido.Rows.Clear();

                foreach (var item in qSnap)
                {
                    progressBarRecebido.Value = progressBarRecebido.Value + 1;
                    if (item.Exists)
                    {
                        Financiamento financiamento = item.ConvertTo<Financiamento>();
                       
                        for (int i = 0; i < financiamento.Parcelas.Length; i++)
                        {
                            string[] linha =
                            {
                                            financiamento.ClienteNome,
                                            financiamento.Veiculo,
                                            financiamento.Marca,
                                            financiamento.Modelo,
                                            financiamento.AnoVeiculo,
                                            financiamento.Cor,
                                            financiamento.Parcelas[i].Id,
                                            financiamento.Parcelas[i].Vencimento,
                                            financiamento.Parcelas[i].ValorNominal.ToString(),
                                            financiamento.Parcelas[i].DataPgto,
                                            financiamento.Parcelas[i].ValorPago.ToString(),
                                };
                            

                            
                            if (periodo == "HOJE" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date == DateTime.Now.Date
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "HOJE"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date == DateTime.Now.Date
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                                dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;


                            }
                            else if (periodo == "ONTEM" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date == DateTime.Now.Date.AddDays(-1)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "ONTEM"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date == DateTime.Now.Date.AddDays(-1)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                                dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                                
                            }
                            else if (periodo == "15 DIAS" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date >= DateTime.Now.Date.AddDays(-15)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "15 DIAS"
                                    &&    Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date.AddDays(-15)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                                dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                               


                            }
                            else if (periodo == "MÊS" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date >= DateTime.Now.Date.AddMonths(-1)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "MÊS"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date.AddMonths(-1)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                                dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                                

                            }
                            else if (periodo == "BIMESTRE" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date >= DateTime.Now.Date.AddMonths(-2)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "BIMESTRE"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date.AddMonths(-2)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                               dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                 


                            }
                            else if (periodo == "TRIMESTRE" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date >= DateTime.Now.Date.AddMonths(-3)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "TRIMESTRE"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date.AddMonths(-3)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                               dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                                

                            }
                            else if (periodo == "SEMESTRE" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date >= DateTime.Now.Date.AddMonths(-6)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "SEMESTRE"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date.AddMonths(-6)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                               dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                                
                            }
                            else if (periodo == "ANO" && !string.IsNullOrEmpty(financiamento.Parcelas[i].DataPgto)
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].DataPgto).Date >= DateTime.Now.Date.AddYears(-1)
                                    && financiamento.Parcelas[i].ValorPago > 0
                                    || periodo == "ANO"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date.AddYears(-1)
                                    && financiamento.Parcelas[i].ValorPago > 0)
                            {
                               dgvValRecebido.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorPago;
                            }
                        }
                    }
                }
                tbValRecebido.Text = soma.ToString();
                if (!tbValRecebido.Text.Contains(","))
                    tbValRecebido.Text = soma.ToString() + ",00";
                else
                    tbValRecebido.Text = soma.ToString();
                await Task.Delay(500);
                progressBarRecebido.Visible = false;
                dgvValRecebido.UseWaitCursor = false;

            }
            catch (Exception)
            {

                throw;

            }
        }

        private void dgvValRecebido_SelectionChanged(object sender, EventArgs e)
        {
            ParcelasRecebidas.Text = "Parcelas: " + dgvValRecebido.SelectedRows.Count.ToString();
            double soma = 0.0d;
            for (int i = 0; i < dgvValRecebido.SelectedRows.Count; i++)
            {
                soma = soma + Convert.ToDouble(dgvValRecebido.SelectedRows[i].Cells[10].Value);
            }
            lblSomaRecebido.Text = "Soma =  " + soma.ToString();
            if (!lblSomaRecebido.Text.Contains(","))
            lblSomaRecebido.Text = "Soma =  " + soma.ToString() + ",00";
            else
                lblSomaRecebido.Text = "Soma =  " + soma.ToString();
        }
    }
}

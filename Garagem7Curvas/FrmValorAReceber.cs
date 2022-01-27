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
    public partial class FrmValorAReceber : Form
    {
        FrmJanelaPrincipal janelaPrincipal = new FrmJanelaPrincipal();
        public FrmValorAReceber(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.janelaPrincipal = janelaPrincipal;
        }

        private void cbOpRelValorAReceber_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cbOpRelValorAReceber.Text == "ATRASADOS")
            {

                getValorAReceber("ATRASADOS");
            }
            else if (cbOpRelValorAReceber.Text == "HOJE")
            {
                getValorAReceber("HOJE");
            }
            else if (cbOpRelValorAReceber.Text == "AMANHÃ")
            {
                getValorAReceber("AMANHÃ");
            }
            else if (cbOpRelValorAReceber.Text == "15 DIAS")
            {
                getValorAReceber("15 DIAS");
            }
            else if (cbOpRelValorAReceber.Text == "MÊS")
            {
                getValorAReceber("MÊS");
            }
            else if (cbOpRelValorAReceber.Text == "BIMESTRE")
            {
                getValorAReceber("BIMESTRE");
            }
            else if (cbOpRelValorAReceber.Text == "TRIMESTRE")
            {
                getValorAReceber("TRIMESTRE");
            }
            else if (cbOpRelValorAReceber.Text == "SEMESTRE")
            {
                getValorAReceber("SEMESTRE");
            }
            else if (cbOpRelValorAReceber.Text == "ANO")
            {
                getValorAReceber("ANO");
            }
           
        }

        private async void getValorAReceber(string periodo)
        {
            dgvValReceber.UseWaitCursor = true;
            CollectionReference colRef = this.janelaPrincipal.db.Collection("financiamentos");
            try
            {

                double soma = 0;               
                Query qdocs = colRef.OrderBy("ClienteNome");
                QuerySnapshot qSnap = await qdocs.GetSnapshotAsync();
                progressBarValAReceber.Visible = true;
                progressBarValAReceber.Step = 10;
                progressBarValAReceber.Value = 0;
                progressBarValAReceber.Minimum = 0;
                progressBarValAReceber.Maximum = qSnap.Count;
                dgvValReceber.Rows.Clear();

                foreach (var item in qSnap)
                {
                    progressBarValAReceber.Value = progressBarValAReceber.Value + 1;
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
                                };
                            if (periodo == "ATRASADOS"
                                && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date < DateTime.Now.Date
                                && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                
                                

                            }
                            else if (periodo == "HOJE"
                                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date == DateTime.Now.Date
                                       && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                               

                            }
                            else if (periodo == "AMANHÃ"
                                      && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date == DateTime.Now.Date.AddDays(1)
                                      && financiamento.Parcelas[i].ValorPago == 0)
                            {
                               dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                

                            }
                            else if (periodo == "15 DIAS"
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                                    && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddDays(15)
                                    && financiamento.Parcelas[i].ValorPago == 0)
                            {
                               dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                

                            }
                            else if (periodo == "MÊS"
                              && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                              && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddMonths(1)
                              && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                

                            }
                            else if (periodo == "MÊS"
                        && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                        && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddMonths(1)
                        && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                               

                            }
                            else if (periodo == "BIMESTRE"
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddMonths(2)
                       && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                

                            }
                            else if (periodo == "TRIMESTRE"
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddMonths(3)
                       && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                

                            }
                            else if (periodo == "SEMESTRE"
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddMonths(6)
                       && financiamento.Parcelas[i].ValorPago == 0)
                            {
                              dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                
                            }
                            else if (periodo == "ANO"
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date >= DateTime.Now.Date
                       && Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date <= DateTime.Now.Date.AddYears(1)
                       && financiamento.Parcelas[i].ValorPago == 0)
                            {
                                dgvValReceber.Rows.Add(linha);
                                soma += financiamento.Parcelas[i].ValorNominal;
                                

                            }
                        }
                    }
                }
                tbValorTotal.Text = soma.ToString();
               
                if (!tbValorTotal.Text.Contains(","))
                    tbValorTotal.Text = soma.ToString() + ",00";
                else
                    tbValorTotal.Text = soma.ToString();
                await Task.Delay(500);
                progressBarValAReceber.Visible = false;
                dgvValReceber.UseWaitCursor = false;
            }
            catch (Exception)
            {

                throw;

            }
        }

        private void dgvValReceber_SelectionChanged(object sender, EventArgs e)
        {
            linhasValAReceber.Text = "Parcelas: " + dgvValReceber.SelectedRows.Count.ToString();
            double soma = 0.0d;
            for (int i = 0; i < dgvValReceber.SelectedRows.Count; i++)
            {
                soma = soma + Convert.ToDouble(dgvValReceber.SelectedRows[i].Cells[8].Value);
            }
            lblSomaValAReceber.Text = "Soma =  " + soma.ToString();
            if (!lblSomaValAReceber.Text.Contains(","))
                lblSomaValAReceber.Text = "Soma =  " + soma.ToString() + ",00";
            else
                lblSomaValAReceber.Text = "Soma =  " + soma.ToString();

           
        }
    }
}

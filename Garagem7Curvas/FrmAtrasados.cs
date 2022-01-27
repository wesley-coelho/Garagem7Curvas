using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem7Curvas
{
    public partial class FrmAtrasados : Form
    {
        FrmJanelaPrincipal janelaPrincipal = new FrmJanelaPrincipal();
        public FrmAtrasados(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.janelaPrincipal = janelaPrincipal;
        }

        private void FrmAtrasados_Load(object sender, EventArgs e)
        {
           
            getClientesAtrasados( );
        }

        private async void getClientesAtrasados()
        {

            listaAtrasados.UseWaitCursor = true;
            CollectionReference colRef = janelaPrincipal.db.Collection("financiamentos");
            try
            {
                bool mudaCor = true;
                Query qdocs = colRef.OrderBy("ClienteNome");
                QuerySnapshot qSnap = await qdocs.GetSnapshotAsync();                
               
                progressBar.Visible = true;
                progressBar.Step = 10;
                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = qSnap.Count;
                listaAtrasados.Rows.Clear();

                foreach (var docSnap in qSnap)
                {
                    progressBar.Value = progressBar.Value + 1; 

                    if (docSnap.Exists)
                    {
                        
                        Financiamento financiamento = docSnap.ConvertTo<Financiamento>();
                        mudaCor = !mudaCor;
                        for (int i = 0; i < financiamento.Parcelas.Length; i++)
                        {
                            if( Convert.ToDateTime(financiamento.Parcelas[i].Vencimento).Date < DateTime.Now.Date 
                                && financiamento.Parcelas[i].ValorPago == 0)
                            {


                                string[] item =
                                     {
                                        financiamento.ClienteNome,
                                        financiamento.Telefone,
                                        financiamento.Celular,
                                        financiamento.Veiculo,
                                        financiamento.Marca,
                                        financiamento.Modelo,
                                        financiamento.Cor,
                                        financiamento.Parcelas[i].Id,
                                        financiamento.Parcelas[i].Vencimento,
                                        financiamento.Parcelas[i].ValorNominal.ToString(),
                                        financiamento.Parcelas[i].ValorPago.ToString(),
                                        financiamento.Parcelas[i].Observacao,
                                    };
                                int row = listaAtrasados.Rows.Add(item);

                                if (mudaCor == true)
                                    listaAtrasados.Rows[row].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                                else
                                    listaAtrasados.Rows[row].DefaultCellStyle.BackColor = Color.White;
                            }
                        }
                    }
                }
                listaAtrasados.Sort(listaAtrasados.Columns[0], ListSortDirection.Ascending);
                await Task.Delay(500);
                progressBar.Visible = false;
                listaAtrasados.UseWaitCursor = false;

            }
            catch (Exception err)
            {
                MessageBox.Show("Verifique sua conexão com a internet.\n" +  err.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



        }

        private void listaAtrasados_SelectionChanged(object sender, EventArgs e)
        {
            linhas.Text = "Parcelas: " + listaAtrasados.SelectedRows.Count.ToString();
            double soma = 0.0d;
            for (int i = 0; i < listaAtrasados.SelectedRows.Count; i++)
            {
                soma = soma + Convert.ToDouble(listaAtrasados.SelectedRows[i].Cells[9].Value);
            }
            lblSoma.Text = "Soma =  " + soma.ToString();
            if (!lblSoma.Text.Contains(","))
                lblSoma.Text = "Soma =  " + soma.ToString() + ",00";
            else
                lblSoma.Text = "Soma =  " + soma.ToString();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using ClosedXML.Excel;




namespace Garagem7Curvas
{
    public partial class FrmJanelaPrincipal : Form
    {
        public FirestoreDb db;
        public Usuario usuario;
        

        public FrmJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void conectarAoFirebaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmLogin login = new FrmLogin(this);
            login.ShowDialog();

            
        }

        public async void getFinanciamentos()
        {
            try
            {
                CollectionReference colRef = db.Collection("financiamentos");
                QuerySnapshot qSnap = await colRef.GetSnapshotAsync();
                dtgListaFinanciamento.Rows.Clear();

                foreach (var doc in qSnap)
                {
                    if (doc.Exists)
                    {
                        Financiamento financiamento = doc.ConvertTo<Financiamento>();
                        string[] linha =
                        {
                        doc.Id,
                        financiamento.ClienteNome,
                        financiamento.Cpf,
                        financiamento.Cep,
                        financiamento.Endereco,
                        financiamento.Numero,
                        financiamento.Bairro,
                        financiamento.Cidade,
                        financiamento.Estado,
                        financiamento.Telefone,
                        financiamento.Celular,
                        financiamento.Email,
                        financiamento.Veiculo,
                        financiamento.AnoVeiculo,
                        financiamento.Chassi,
                        financiamento.CidadeVeiculo,
                        financiamento.Cor,
                        financiamento.Marca,
                        financiamento.Modelo,
                        financiamento.Placa,
                        financiamento.Parcelas.Length.ToString(),
                        financiamento.Obs,
                    };
                        dtgListaFinanciamento.Rows.Add(linha);
                    }
                }
                dtgListaFinanciamento.Sort(dtgListaFinanciamento.Columns[1], ListSortDirection.Ascending);

            }
            catch (Exception)
            {

             
            }
            
            
        }

        private async void dtgListaFinanciamento_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                string key = dtgListaFinanciamento.Rows[e.RowIndex].Cells[0].Value.ToString();
                DocumentReference docRef = db.Collection("financiamentos").Document(key);
                DocumentSnapshot docSnap = await docRef.GetSnapshotAsync();
                Financiamento financ = docSnap.ConvertTo<Financiamento>();
                dtgParcelas.Rows.Clear();
                for (int i = 0; i < financ.Parcelas.Length; i++)
                {
                    string[] linha =
                    {
                        financ.Parcelas[i].Id,
                        financ.Parcelas[i].Vencimento,
                        financ.Parcelas[i].ValorNominal.ToString(),
                        financ.Parcelas[i].ValorPago.ToString(),
                        financ.Parcelas[i].Situacao,

                    };
                    dtgParcelas.Rows.Add(linha);
                }
                //ativando o botao de excluir
                btnDelete.Enabled = true;
            }
            catch (Exception)
            {
                dtgParcelas.Rows.Clear();
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           if(usuario != null)
            {
                FrmAddFinanciamento novoFinanciamento = new FrmAddFinanciamento(this);
                novoFinanciamento.Show();
            }
            

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(dtgListaFinanciamento.SelectedRows.Count != 0)
            {
                btnDelete.Enabled = true;
                
               if(MessageBox.Show("Confirma exclusão DEFINITIVA da base de dados?","Exclusão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        string key = dtgListaFinanciamento.SelectedRows[0].Cells[0].Value.ToString();
                        await db.Collection("financiamentos").Document(key).DeleteAsync();
                        getFinanciamentos();

                    }
                    catch (Exception)
                    {


                    }
                }
               
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                getFinanciamentos();
            }
            catch (Exception)
            {

                
            }
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                CollectionReference colRef = db.Collection("financiamentos");
                QuerySnapshot docSnap = await colRef.GetSnapshotAsync();
                dtgListaFinanciamento.Rows.Clear();
              
                foreach (var doc in docSnap)
                {
                    if (doc.Exists)
                    {
                        Financiamento financiamento = doc.ConvertTo<Financiamento>();
                        if (financiamento.ClienteNome.Contains(tbPesquisar.Text))
                        {
                            string[] linha =
                            {
                                doc.Id,
                                financiamento.ClienteNome,
                                financiamento.Cpf,
                                financiamento.Cep,
                                financiamento.Endereco,
                                financiamento.Numero,
                                financiamento.Bairro,
                                financiamento.Cidade,
                                financiamento.Estado,
                                financiamento.Telefone,
                                financiamento.Celular,
                                financiamento.Email,
                                financiamento.Veiculo,
                                financiamento.AnoVeiculo,
                                financiamento.Chassi,
                                financiamento.CidadeVeiculo,
                                financiamento.Cor,
                                financiamento.Marca,
                                financiamento.Modelo,
                                financiamento.Placa,
                                financiamento.Parcelas.Length.ToString(),
                            };
                                   dtgListaFinanciamento.Rows.Add(linha);
                        }
                    }
                }
                dtgListaFinanciamento.Sort(dtgListaFinanciamento.Columns[1], ListSortDirection.Ascending);
            }
            catch (Exception)
            {

               
            }
        }

        private async void dtgListaFinanciamento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string key = dtgListaFinanciamento.Rows[e.RowIndex].Cells[0].Value.ToString();
                string updateValue = dtgListaFinanciamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string[] prop =
                {
                   "Id",
                   "ClienteNome",
                   "Cpf",
                   "Cep",
                   "Endereco",
                   "Numero",
                   "Bairro",
                   "Cidade",
                   "Estado",
                   "Telefone",
                   "Celular",
                   "Email",
                   "Veiculo",
                   "AnoVeiculo",
                   "Chassi",
                   "CidadeVeiculo",
                   "Cor",
                   "Marca",
                   "Modelo",
                   "Placa",
                   "Parcelas"
                };

                if (prop[e.ColumnIndex] == "Parcelas")
                    await db.Collection("financiamentos").Document(key).UpdateAsync(prop[e.ColumnIndex], int.Parse(updateValue));
               else
                    await db.Collection("financiamentos").Document(key).UpdateAsync(prop[e.ColumnIndex], updateValue);
            }
            catch (Exception)
            {

                
            }
        }

        private async void dtgParcelas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string key = dtgListaFinanciamento.SelectedRows[0].Cells[0].Value.ToString();
                string updateValue = dtgParcelas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                CollectionReference colRef = db.Collection("financiamentos");
                QuerySnapshot docSnap = await colRef.GetSnapshotAsync();

                foreach (var doc in docSnap)
                {
                    if (doc.Exists)
                    {
                        if(doc.Id == key)
                        {
                            Financiamento financiamento = doc.ConvertTo<Financiamento>();
                            switch (e.ColumnIndex)
                            {
                                case 1:                                  
                                        financiamento.Parcelas[e.RowIndex].Vencimento = updateValue;                               
                                    break;
                                case 2:
                                    financiamento.Parcelas[e.RowIndex].ValorNominal = float.Parse(updateValue);
                                    break;
                                case 3:
                                    financiamento.Parcelas[e.RowIndex].ValorPago = float.Parse(updateValue);
                                    break;
                                case 4:
                                    financiamento.Parcelas[e.RowIndex].Situacao = updateValue;
                                    break;
                                
                                default:
                                    break;
                            }
                            await colRef.Document(key).UpdateAsync("Parcelas", financiamento.Parcelas);


                        }
                    }
                }
            }
            catch (Exception)
            {

              
            }
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            tbPesquisar.Text = tbPesquisar.Text.ToUpper();
            tbPesquisar.SelectionStart = tbPesquisar.Text.Length;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();
        }

        private void menuImportPlan_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirPlanilhaExcel = new OpenFileDialog();
           if(abrirPlanilhaExcel.ShowDialog() == DialogResult.OK)
            {
                importarDadosExcelToFirestore(abrirPlanilhaExcel.FileName);
            }            
            
        }


        private async void importarDadosExcelToFirestore(string pathPlanilha)
        {
            var pasta = new XLWorkbook(@pathPlanilha);
            var planClientes = pasta.Worksheet("Clientes");
            var planStatus = pasta.Worksheet("Status");
            var planValPago = pasta.Worksheet("Val_Pgto");

            int linha = 2;
           
            while (!string.IsNullOrEmpty(planClientes.Cell(linha, 2).Value.ToString()))
            {
                Parcela[] parcelas = new Parcela[int.Parse(planClientes.Cell(linha, 17).Value.ToString())];
                //gerando o array das parcelas
                for (int i = 0, l = 2; i < int.Parse(planClientes.Cell(linha, 17).Value.ToString()); i++, l++)
                {
                    Parcela parcela = new Parcela();
                    parcela.Id = (i + 1).ToString();
                    parcela.Situacao = planStatus.Cell(l, linha-1).Value.ToString();
                    parcela.ValorNominal = float.Parse(planClientes.Cell(linha, 18).Value.ToString());

                    if ( planValPago.Cell(l, linha - 1).Value.ToString() == "" )
                        parcela.ValorPago = 0.00f;
                    else
                    {
                        if(planValPago.Cell(l, linha - 1).Value.ToString().Contains(","))
                            parcela.ValorPago = float.Parse(planValPago.Cell(l, linha - 1).Value.ToString().Replace(",", "."));
                        else
                            parcela.ValorPago = float.Parse(planValPago.Cell(l, linha - 1).Value.ToString());
                    }
                       
                    parcela.Vencimento = planClientes.Cell(linha, 19).Value.ToString();
                    parcelas[i] = parcela;
                }

                Dictionary<string, object> registro = new Dictionary<string, object>()
            {
               //dados cliente
                {"ClienteNome", planClientes.Cell(linha, 2).Value.ToString()},
                {"Cpf", planClientes.Cell(linha, 3).Value.ToString()},
                {"Endereco", planClientes.Cell(linha, 4).Value.ToString() + " " + planClientes.Cell(linha, 5).Value.ToString()},
                {"Numero", planClientes.Cell(linha, 6).Value.ToString()},
                {"Cep", ""},
                {"Bairro", planClientes.Cell(linha, 8).Value.ToString()},
                {"Cidade", planClientes.Cell(linha, 9).Value.ToString()},
                {"Estado", ""},
                {"Telefone", planClientes.Cell(linha, 10).Value.ToString()},
                {"Celular", planClientes.Cell(linha, 11).Value.ToString()},
                {"Email", ""},
                //dados veiculo
                {"Veiculo", planClientes.Cell(linha, 12).Value.ToString()},
                {"Chassi", ""},
                {"Placa", ""},
                {"CidadeVeiculo", ""},
                {"AnoVeiculo",planClientes.Cell(linha, 15).Value.ToString()},
                {"Marca", planClientes.Cell(linha, 13).Value.ToString()},
                {"Modelo", planClientes.Cell(linha, 14).Value.ToString()},
                {"Cor", planClientes.Cell(linha, 16).Value.ToString()},
                {"Parcelas", parcelas},
                {"Obs", planClientes.Cell(linha, 21).Value.ToString()},
            };

                try
                {

                    await db.Collection("financiamentos").AddAsync(registro);
                    getFinanciamentos();
                    MessageBox.Show("Dados importados com suxesso.", "Importar Dados de Planilha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                linha +=1;
            }
            
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void tbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick();
            }
        }
    }
}

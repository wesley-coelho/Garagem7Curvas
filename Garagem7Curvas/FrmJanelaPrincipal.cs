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
        public string valorDaCelularAntesDaEdicao = "";
        

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
                await Task.Delay(500);
                progressBar.Visible = true;
                progressBar.Step = 10;
                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = qSnap.Count;

                foreach (var doc in qSnap)
                {

                    if (doc.Exists)
                    {
                        progressBar.Value = progressBar.Value + 1;
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
                await Task.Delay(500);
                progressBar.Visible = false;
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
                        key,
                        financ.Parcelas[i].Id,
                        financ.Parcelas[i].Vencimento,
                        financ.Parcelas[i].ValorNominal.ToString(),
                        financ.Parcelas[i].ValorPago.ToString(),
                        financ.Parcelas[i].DataPgto,
                        "",
                        (financ.Parcelas[i].ValorPago - financ.Parcelas[i].ValorNominal).ToString(),                        
                        financ.Parcelas[i].Observacao,


                    };
                    int rowIndex = dtgParcelas.Rows.Add(linha);
                    double valPago = financ.Parcelas[i].ValorPago;
                    double valNominal = financ.Parcelas[i].ValorNominal;
                    DateTime venc = Convert.ToDateTime(financ.Parcelas[i].Vencimento).Date;

                    if (venc < DateTime.Today && valPago == 0)
                    {
                        dtgParcelas.Rows[rowIndex].Cells[6].Style.BackColor = Color.Red;
                        dtgParcelas.Rows[rowIndex].Cells[6].Value = "ATRASO";
                    }else if( valPago == 0 && venc >= DateTime.Today)
                    {
                        dtgParcelas.Rows[rowIndex].Cells[6].Style.BackColor = Color.White;
                        dtgParcelas.Rows[rowIndex].Cells[6].Value = "NORMAL";
                    }
                    else if (valPago >= valNominal)
                    {
                        dtgParcelas.Rows[rowIndex].Cells[6].Style.BackColor = Color.LimeGreen;
                        dtgParcelas.Rows[rowIndex].Cells[6].Value = "PAGO";
                    }else if(valPago < valNominal && valPago > 0)
                    {
                        dtgParcelas.Rows[rowIndex].Cells[6].Style.BackColor = Color.Orange;
                        dtgParcelas.Rows[rowIndex].Cells[6].Value = "PENDENTE";
                    }

                }
                //ativando o botao de excluir
                btnDelete.Enabled = true;
                //ativando o botao imprimir ficha na barra de ferramentas
                if(dtgListaFinanciamento.SelectedRows[0].Cells[1].Value != null)
                    btnImprimir.Enabled = true;
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
                        foreach (DataGridViewRow row in dtgListaFinanciamento.SelectedRows)
                        {
                            string key = row.Cells[0].Value.ToString();
                            await db.Collection("financiamentos").Document(key).DeleteAsync();

                        }
                        
                       
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
                btnImprimir.Enabled = false;
                getFinanciamentos();
                dtgParcelas.Rows.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar. Verifique a conexão com a internet.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);

                
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
                                financiamento.Obs,

                            };
                                   dtgListaFinanciamento.Rows.Add(linha);
                        }
                    }
                }
                dtgListaFinanciamento.Sort(dtgListaFinanciamento.Columns[1], ListSortDirection.Ascending);
                tbPesquisar.SelectAll();
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
                string updateValue = "";
                if(dtgListaFinanciamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    updateValue = dtgListaFinanciamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
                dtgListaFinanciamento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = updateValue;
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
                   "Parcelas",
                   "Obs"
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
            try
            {
                var pasta = new XLWorkbook(@pathPlanilha);
                var planClientes = pasta.Worksheet("Clientes");
                var planStatus = pasta.Worksheet("Status");
                var planValPago = pasta.Worksheet("Val_Pgto");
                var planParcelas = pasta.Worksheet("Parcelas");

                int linha = 2;

                while (!string.IsNullOrEmpty(planClientes.Cell(linha, 2).Value.ToString()))
                {
                    Parcela[] parcelas = new Parcela[int.Parse(planClientes.Cell(linha, 17).Value.ToString())];
                    //gerando o array das parcelas
                    for (int i = 0, l = 2; i < int.Parse(planClientes.Cell(linha, 17).Value.ToString()); i++, l++)
                    {
                        Parcela parcela = new Parcela();
                        parcela.Id = (i + 1).ToString();
                        //parcela.Situacao = planStatus.Cell(l, linha - 1).Value.ToString();
                        parcela.ValorNominal = Math.Round(Convert.ToDouble(planClientes.Cell(linha, 18).Value.ToString()), 2);

                        if (planValPago.Cell(l, linha - 1).Value.ToString() == "")
                            parcela.ValorPago = 0.00d;
                        else
                            parcela.ValorPago = Math.Round(Convert.ToDouble(planValPago.Cell(l, linha - 1).Value.ToString()), 2);

                        parcela.Vencimento = planParcelas.Cell(l, linha - 1).Value.ToString().Remove(10);
                        parcela.DataPgto = "";
                        parcela.Observacao = "";
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
                        
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    linha += 1;
                }
                MessageBox.Show("Dados importados com suxesso.", "Importar Dados de Planilha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("A planilha já está em uso por outro processo!", "Planilha Aberta", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
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

        private void gerenciarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerUsers formUsers = new FrmGerUsers(this);
            formUsers.Show();
        }

        private void tbPesquisar_Click(object sender, EventArgs e)
        {
            if(tbPesquisar.Text == "NOME DO CLIENTE")
            {
                tbPesquisar.Text = "";
            }
        }

        private void tbPesquisar_Leave(object sender, EventArgs e)
        {
            if (tbPesquisar.Text == "")
                tbPesquisar.Text = "Nome do Cliente";
        }


       

        

        private void dtgParcelas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateDgvParcelasCells(e.RowIndex, e.ColumnIndex);
        }

        private void dtgListaFinanciamento_Leave(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgParcelas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(dtgParcelas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            valorDaCelularAntesDaEdicao= dtgParcelas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
          
        }




        private async void updateDgvParcelasCells(int rowIndex, int columnIndex)
        {
            dtgParcelas.UseWaitCursor = true;
            try
            {
                string key = dtgParcelas.Rows[rowIndex].Cells[0].Value.ToString(); //esse atributo está invisível no datagrid
                string updateValue = "";
                if (dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value != null)
                    updateValue = dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                double valorPago = Convert.ToDouble(dtgParcelas.Rows[rowIndex].Cells[4].Value);
                double valorNominal = Convert.ToDouble(dtgParcelas.Rows[rowIndex].Cells[3].Value);
                var dataPgto = dtgParcelas.Rows[rowIndex].Cells[5];
                var situacao = dtgParcelas.Rows[rowIndex].Cells[6];
                var diferenca = dtgParcelas.Rows[rowIndex].Cells[7];
                DateTime venc = Convert.ToDateTime(dtgParcelas.Rows[rowIndex].Cells[2].Value).Date;

                if (updateValue.Contains("."))
                {
                    dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                    return;
                }

                if (columnIndex == 2)
                {
                    try
                    {
                        dtgParcelas.UseWaitCursor = true;
                        DocumentSnapshot docSnap = await db.Collection("financiamentos").Document(key).GetSnapshotAsync();
                        if (docSnap.Exists)
                        {
                            Financiamento financiamento = docSnap.ConvertTo<Financiamento>();
                            financiamento.Parcelas[rowIndex].Vencimento = updateValue;

                            try
                            {
                               
                                await db.Collection("financiamentos").Document(key).UpdateAsync("Parcelas", financiamento.Parcelas);
                               
                            }
                            catch (Exception)
                            {
                                dtgParcelas.UseWaitCursor = false;
                                dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                                MessageBox.Show("Verifique a conexão com a internet", "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        dtgParcelas.UseWaitCursor = false;
                    }
                    catch (Exception)
                    {
                        dtgParcelas.UseWaitCursor = false;
                        dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                        MessageBox.Show("Verifique a conexão com a internet", "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else if (columnIndex == 3)
                {
                    try
                    {
                        dtgParcelas.UseWaitCursor = true;
                        DocumentSnapshot docSnap = await db.Collection("financiamentos").Document(key).GetSnapshotAsync();
                        if (docSnap.Exists)
                        {
                            Financiamento financiamento = docSnap.ConvertTo<Financiamento>();
                            financiamento.Parcelas[rowIndex].ValorNominal = Math.Round(Convert.ToDouble(updateValue), 2);

                            try
                            {
                                await db.Collection("financiamentos").Document(key).UpdateAsync("Parcelas", financiamento.Parcelas);
                            }
                            catch (Exception)
                            {


                            }
                        }
                        dtgParcelas.UseWaitCursor = false;
                    }
                    catch (Exception)
                    {


                    }

                }
                else if (columnIndex == 4)//valor Pago
                {
                    try
                    {
                        dtgParcelas.UseWaitCursor = true;
                        DocumentSnapshot docSnap = await db.Collection("financiamentos").Document(key).GetSnapshotAsync();

                        if (docSnap.Exists)
                        {
                            Financiamento financiamento = docSnap.ConvertTo<Financiamento>();
                            financiamento.Parcelas[rowIndex].ValorPago = Math.Round(Convert.ToDouble(updateValue), 2);
                            

                            try
                            {
                                if( valorPago >= valorNominal)
                                {
                                    situacao.Value = "PAGO";
                                    situacao.Style.BackColor = Color.LimeGreen;
                                    diferenca.Value = valorPago - valorNominal;
                                    financiamento.Parcelas[rowIndex].DataPgto = DateTime.Now.ToShortDateString();
                                    dataPgto.Value = DateTime.Now.ToShortDateString();
                                    //financiamento.Parcelas[rowIndex].Situacao = "PAGO";
                                }
                                else if( valorPago < valorNominal && valorPago != 0)
                                {
                                    situacao.Value = "PENDENTE";
                                    situacao.Style.BackColor = Color.Orange;
                                    diferenca.Value = valorPago - valorNominal;
                                    financiamento.Parcelas[rowIndex].DataPgto = DateTime.Now.ToShortDateString();
                                    dataPgto.Value = DateTime.Now.ToShortDateString();
                                    // financiamento.Parcelas[rowIndex].Situacao = "PENDENTE";
                                } else if( valorPago == 0 && venc >= DateTime.Today)
                                {
                                    situacao.Value = "NORMAL";
                                    situacao.Style.BackColor = Color.White;
                                    diferenca.Value = valorPago - valorNominal;
                                    financiamento.Parcelas[rowIndex].DataPgto = "";
                                    dataPgto.Value = "";
                                }
                                else if (valorPago == 0 && venc < DateTime.Today)
                                {
                                    situacao.Value = "ATRASO";
                                    situacao.Style.BackColor = Color.Red;
                                    diferenca.Value = valorPago - valorNominal;
                                    financiamento.Parcelas[rowIndex].DataPgto = "";
                                    dataPgto.Value = "";
                                }


                                    await db.Collection("financiamentos").Document(key).UpdateAsync("Parcelas", financiamento.Parcelas);
                                dtgParcelas.Cursor = DefaultCursor;
                                dtgParcelas.UseWaitCursor = false;

                            }
                            catch (Exception)
                            {

                                dtgParcelas.Cursor = DefaultCursor;
                                dtgParcelas.UseWaitCursor = false;
                                dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                                MessageBox.Show("Verifique a conexão com a internet", "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                        }
                        dtgParcelas.Cursor = DefaultCursor;
                        dtgParcelas.UseWaitCursor = false;
                    }
                    catch (Exception)
                    {
                        dtgParcelas.UseWaitCursor = false;
                        dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                        MessageBox.Show("Verifique a conexão com a internet", "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else if (columnIndex == 5)
                {
                    try
                    {
                        dtgParcelas.UseWaitCursor = true;
                        DocumentSnapshot docSnap = await db.Collection("financiamentos").Document(key).GetSnapshotAsync();
                        if (docSnap.Exists)
                        {
                            Financiamento financiamento = docSnap.ConvertTo<Financiamento>();
                            financiamento.Parcelas[rowIndex].DataPgto = updateValue;

                            try
                            {
                                await db.Collection("financiamentos").Document(key).UpdateAsync("Parcelas", financiamento.Parcelas);
                            }
                            catch (Exception)
                            {


                            }
                        }
                        dtgParcelas.UseWaitCursor = false;
                    }
                    catch (Exception)
                    {


                    }

                }
                else if (columnIndex == 8)//Observaocao
                {
                    try
                    {
                        dtgParcelas.UseWaitCursor = true;
                        DocumentSnapshot docSnap = await db.Collection("financiamentos").Document(key).GetSnapshotAsync();

                        if (docSnap.Exists)
                        {
                            Financiamento financiamento = docSnap.ConvertTo<Financiamento>();                           
                               financiamento.Parcelas[rowIndex].Observacao = updateValue;
                           

                            try
                            {
                                await db.Collection("financiamentos").Document(key).UpdateAsync("Parcelas", financiamento.Parcelas);
                                dtgParcelas.Cursor = DefaultCursor;
                                dtgParcelas.UseWaitCursor = false;

                            }
                            catch (Exception)
                            {

                                dtgParcelas.Cursor = DefaultCursor;
                                dtgParcelas.UseWaitCursor = false;
                                dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                                MessageBox.Show("Verifique a conexão com a internet", "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                        }
                        dtgParcelas.Cursor = DefaultCursor;
                        dtgParcelas.UseWaitCursor = false;
                    }
                    catch (Exception)
                    {
                        dtgParcelas.UseWaitCursor = false;
                        dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                        MessageBox.Show("Verifique a conexão com a internet", "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            catch (Exception)
            {
                dtgParcelas.UseWaitCursor = false;
                dtgParcelas.Rows[rowIndex].Cells[columnIndex].Value = valorDaCelularAntesDaEdicao;
                MessageBox.Show("Verifique a conexão com a internet","Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            if (printDialogFicha.ShowDialog() == DialogResult.Cancel)
                return;
            imprimirVerso = false;
            printFicha.Print();
        }

        private void printFicha_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

       
        
        Font fonte = new Font("Arial", 12);
        Brush cor = new SolidBrush(Color.Black);
        bool imprimirVerso = false;
        private void printFicha_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float marginLeft = 100;
            float marginTop = 56.92f;
            
            if (imprimirVerso == false)
            {
                //primeira linha impressao frente
                e.Graphics.DrawString("Cliente: " + dtgListaFinanciamento.SelectedRows[0].Cells[1].Value.ToString(), fonte, cor, marginLeft, marginTop);
                e.Graphics.DrawString("CPF: " + dtgListaFinanciamento.SelectedRows[0].Cells[2].Value.ToString(), fonte, cor, marginLeft + 450, marginTop);
                //segunda  linha impressao frente
                e.Graphics.DrawString("Endereço: " + dtgListaFinanciamento.SelectedRows[0].Cells[4].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 1);
                e.Graphics.DrawString("Numero: " + dtgListaFinanciamento.SelectedRows[0].Cells[5].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 1);
                //terceira linha impressao frente
                e.Graphics.DrawString("Bairro: " + dtgListaFinanciamento.SelectedRows[0].Cells[6].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 2);
                e.Graphics.DrawString("CEP: " + dtgListaFinanciamento.SelectedRows[0].Cells[3].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 2);
                //quarta linha impressao frente
                e.Graphics.DrawString("Cidade: " + dtgListaFinanciamento.SelectedRows[0].Cells[7].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 3);
                e.Graphics.DrawString("Estado: " + dtgListaFinanciamento.SelectedRows[0].Cells[8].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 3);
                //quinta linha impressao frente
                e.Graphics.DrawString("Telefone: " + dtgListaFinanciamento.SelectedRows[0].Cells[9].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 4);
                e.Graphics.DrawString("Celular: " + dtgListaFinanciamento.SelectedRows[0].Cells[10].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 4);
                //sexta linha impressao frente
                e.Graphics.DrawString("Email: " + dtgListaFinanciamento.SelectedRows[0].Cells[11].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 5);
                e.Graphics.DrawString("1ª parcela: " + dtgParcelas.Rows[0].Cells[2].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 5);
                //setima linha impressao frente
                e.Graphics.DrawString("Prazo: " + dtgListaFinanciamento.SelectedRows[0].Cells[20].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 6);
                e.Graphics.DrawString("Valor: " + dtgParcelas.Rows[0].Cells[3].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 6);

            }
            else
            {
                marginLeft = 50;
                //primeira linha impressao verso


                for (int i = 0, j = 0; i < int.Parse(dtgListaFinanciamento.SelectedRows[0].Cells[20].Value.ToString()); i++)
                {
                    if (i % 10 == 0 && i != 0)
                    {
                        j = 0;
                        e.Graphics.DrawString((i + 1).ToString() + "  " + dtgParcelas.Rows[i].Cells[2].Value.ToString(), new Font(new Font("Arial", 8), FontStyle.Bold), cor, marginLeft += 130, marginTop + 24.45f * (++j));

                    }
                    else
                    {
                        e.Graphics.DrawString((i + 1).ToString() + "  " + dtgParcelas.Rows[i].Cells[2].Value.ToString(), new Font(new Font("Arial", 8), FontStyle.Bold), cor, marginLeft, marginTop + 24.45f * (++j));
                    }

                }

                dtgListaFinanciamento.Enabled = true;
                e.HasMorePages = false;
                return;
            }

            //imprimir verso
            if (MessageBox.Show("Deseja imprimir o verso da página?", "Imprimir verso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.HasMorePages = true;
                imprimirVerso = true;
            }
            dtgListaFinanciamento.Enabled = true;


        }

        private void dtgListaFinanciamento_Click(object sender, EventArgs e)
        {
          
            if (dtgListaFinanciamento.SelectedRows.Count != 1 )
            {
                btnImprimir.Enabled = false;
            }
            
        }

        private void fichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimirFichaToolStripMenuItem.PerformClick();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnImprimir.Enabled == true)
            {
                fichaToolStripMenuItem.Enabled = true;
                financiamentoToolStripMenuItem.Enabled = true;
            }

            else
            {
                fichaToolStripMenuItem.Enabled = false;
                financiamentoToolStripMenuItem.Enabled = false;
            }
                
        }

        int pagina = 1;
        

        private void imprimirFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgListaFinanciamento.Enabled = false;
            printDialogFicha.Document = printFicha;
            if (printDialogFicha.ShowDialog() == DialogResult.Cancel)
            {
                dtgListaFinanciamento.Enabled = true;
                return;
            }
                
            imprimirVerso = false;
            printFicha.Print();
        }

        private void imprimirFinanciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dtgListaFinanciamento.Enabled = false;
            printDialogFicha.Document = printFinanciamento;
            if (printDialogFicha.ShowDialog() == DialogResult.Cancel)
            {
                dtgListaFinanciamento.Enabled = true;
                return;
            }
               
             pagina = 1;
            printFinanciamento.Print();
        }

        private void printFinanciamento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float marginLeft = 100;
            float marginTop = 120;
            float largura = e.PageBounds.Width;
            float altura = e.PageBounds.Height;
            

            if (pagina == 1)
            {
                //cabeçaho
                e.Graphics.DrawString(pagina.ToString(), fonte, cor,largura-40, 20);
                e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial",8), cor, largura - 220, 90);
                e.Graphics.DrawLine(new Pen(Color.Black), marginLeft, 110f, largura - 100, 110f);
                e.Graphics.DrawString("CLIENTE", fonte, cor, marginLeft, 115);
                e.Graphics.DrawLine(new Pen(Color.Black), marginLeft, 140f, largura - 100, 140f);

                //primeira linha 
                e.Graphics.DrawString("Cliente: " + dtgListaFinanciamento.SelectedRows[0].Cells[1].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 1);
                e.Graphics.DrawString("CPF: " + dtgListaFinanciamento.SelectedRows[0].Cells[2].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 1);
                //segunda  linha 
                e.Graphics.DrawString("Endereço: " + dtgListaFinanciamento.SelectedRows[0].Cells[4].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 2);
                e.Graphics.DrawString("Numero: " + dtgListaFinanciamento.SelectedRows[0].Cells[5].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 2);
                //terceira linha 
                e.Graphics.DrawString("Bairro: " + dtgListaFinanciamento.SelectedRows[0].Cells[6].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 3);
                e.Graphics.DrawString("CEP: " + dtgListaFinanciamento.SelectedRows[0].Cells[3].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 3);
                //quarta linha 
                e.Graphics.DrawString("Cidade: " + dtgListaFinanciamento.SelectedRows[0].Cells[7].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 4);
                e.Graphics.DrawString("Estado: " + dtgListaFinanciamento.SelectedRows[0].Cells[8].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 4);
                //quinta linha 
                e.Graphics.DrawString("Telefone: " + dtgListaFinanciamento.SelectedRows[0].Cells[9].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 5);
                e.Graphics.DrawString("Celular: " + dtgListaFinanciamento.SelectedRows[0].Cells[10].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 5);
                //sexta linha 
                e.Graphics.DrawString("Email: " + dtgListaFinanciamento.SelectedRows[0].Cells[11].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 6);
                e.Graphics.DrawString("1ª parcela: " + dtgParcelas.Rows[0].Cells[2].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 6);
                //setima linha 
                e.Graphics.DrawString("Prazo: " + dtgListaFinanciamento.SelectedRows[0].Cells[20].Value.ToString(), fonte, cor, marginLeft, marginTop + 26.45f * 7);
                e.Graphics.DrawString("Valor: " + dtgParcelas.Rows[0].Cells[3].Value.ToString(), fonte, cor, marginLeft + 450, marginTop + 26.45f * 7);

                ///////////////////////////////////////FINANCIAMENTOS///////////////////////////////                
                e.Graphics.DrawLine(new Pen(Color.Black), marginLeft, marginTop + 26.45f * 9, largura - 100, marginTop + 26.45f * 9);
                e.Graphics.DrawString("FINANCIAMENTO", fonte, cor, marginLeft, marginTop + 26.45f * 9 + 5);
                e.Graphics.DrawLine(new Pen(Color.Black), marginLeft, marginTop + 26.45f * 9 + 30, largura - 100, marginTop + 26.45f * 9 + 30);
                e.Graphics.DrawString("Parcela", fonte, cor, marginLeft, marginTop + 27 * 10);
                e.Graphics.DrawString("Vencimento", fonte, cor, marginLeft+80, marginTop + 27 * 10);
                e.Graphics.DrawString("Valor (R$)", fonte, cor, marginLeft + 190, marginTop + 27 * 10);
                e.Graphics.DrawString("Valor Pago (R$)", fonte, cor, marginLeft + 290, marginTop + 27 * 10);
                e.Graphics.DrawString("Situação", fonte, cor, marginLeft + 430, marginTop + 27 * 10);
                e.Graphics.DrawString("Diferença", fonte, cor, marginLeft + 530, marginTop + 27 * 10);
                e.Graphics.DrawLine(new Pen(Color.Black), marginLeft, marginTop + 29f * 10, largura - 100, marginTop + 29f * 10);

                for (int i = 0; i < int.Parse(dtgListaFinanciamento.SelectedRows[0].Cells[20].Value.ToString()); i++)
                {
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[1].Value.ToString(), fonte, cor, marginLeft, 415 + i* 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[2].Value.ToString(), fonte, cor, marginLeft + 80, 415 + i * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[3].Value.ToString(), fonte, cor, marginLeft + 190, 415 + i * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[4].Value.ToString(), fonte, cor, marginLeft + 290, 415 + i * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[5].Value.ToString(), fonte, cor, marginLeft + 430, 415 + i * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[6].Value.ToString(), fonte, cor, marginLeft + 530, 415 + i * 26.45f);
                    if(i == 24 && int.Parse(dtgListaFinanciamento.SelectedRows[0].Cells[20].Value.ToString()) > 25)
                    {
                       
                        e.HasMorePages = true;
                        pagina++;
                        return;
                    }
                }
                dtgListaFinanciamento.Enabled = true;
            }
            else if(pagina ==2)
            {
                e.Graphics.DrawString(pagina.ToString(), fonte, cor, largura - 40, 20);
                for (int i = 25; i < int.Parse(dtgListaFinanciamento.SelectedRows[0].Cells[20].Value.ToString()); i++)
                {
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[1].Value.ToString(), fonte, cor, marginLeft, marginTop + (i-25) * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[2].Value.ToString(), fonte, cor, marginLeft + 80, marginTop + (i - 25) * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[3].Value.ToString(), fonte, cor, marginLeft + 190, marginTop + (i - 25) * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[4].Value.ToString(), fonte, cor, marginLeft + 290, marginTop + (i - 25) * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[5].Value.ToString(), fonte, cor, marginLeft + 430, marginTop + (i - 25) * 26.45f);
                    e.Graphics.DrawString(dtgParcelas.Rows[i].Cells[6].Value.ToString(), fonte, cor, marginLeft + 530, marginTop + (i - 25) * 26.45f);
                    
                }


                e.HasMorePages = false;
                dtgListaFinanciamento.Enabled = true;
                return;
            }
        }

        private void financiamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimirFinanciamentoToolStripMenuItem.PerformClick();
        }

        private void inadimplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                FrmAtrasados formAtrasados = new FrmAtrasados(this);
                formAtrasados.ShowDialog();            
           
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(usuario == null)
            {
                inadimplentesToolStripMenuItem.Enabled = false;
                totalAReceberToolStripMenuItem.Enabled = false;
                totalRecebidoToolStripMenuItem.Enabled = false;
            }
            else
            {
                inadimplentesToolStripMenuItem.Enabled = true;
                totalAReceberToolStripMenuItem.Enabled = true;
                totalRecebidoToolStripMenuItem.Enabled = true;
            }

        }

        private void totalAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValorAReceber frmValorAReceber = new FrmValorAReceber(this);
            frmValorAReceber.ShowDialog();
        }

        private void totalRecebidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValorRecebido frmValorRecebido = new FrmValorRecebido(this);
            frmValorRecebido.ShowDialog();
        }
    }
}

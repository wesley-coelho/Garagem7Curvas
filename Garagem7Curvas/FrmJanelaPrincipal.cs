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
    }
}

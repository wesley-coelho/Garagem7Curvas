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
                        financiamento.FinanciamentoId,
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
    }
}

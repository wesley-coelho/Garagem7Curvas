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

            FrmLogin login = new FrmLogin(this, usuario);
            login.ShowDialog();

            
        }

        public async void getFinanciamentos()
        {
            CollectionReference colRef = db.Collection("financiamentos");
            QuerySnapshot qSnap = await colRef.GetSnapshotAsync();

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
    }
}

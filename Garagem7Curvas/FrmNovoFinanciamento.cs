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
using Correios.CorreiosServiceReference;


namespace Garagem7Curvas
{
    public partial class FrmAddFinanciamento : Form
    {

        FrmJanelaPrincipal janelaPrincipal;
        public FrmAddFinanciamento(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.janelaPrincipal = janelaPrincipal;
        }

     

        private async void btnAddFinanciamento_Click(object sender, EventArgs e)
        {
            CollectionReference colRef = janelaPrincipal.db.Collection("financiamentos");

            Parcela[] parcelas = new Parcela[int.Parse(cbPrazo.Text)];
            //gerando o array das parcelas
            for (int i  = 0;  i < int.Parse(cbPrazo.Text); i++)
            {
                Parcela parcela = new Parcela();
                parcela.Id = (i + 1).ToString();
                parcela.Situacao = "NORMAL";
                parcela.ValorNominal = float.Parse(tbValor.Text);
                parcela.ValorPago = 0f;
                parcela.Vencimento = dtPrimeiraParcela.Value.Date.AddMonths(i).ToString().Remove(10);
                parcelas[i] = parcela;
            }

            Dictionary<string, object> registro = new Dictionary<string, object>()
            {
               //dados cliente
                {"ClienteNome", tbNome.Text},
                {"Cpf", tbCpf.Text},
                {"Endereco", tbEndereco.Text},
                {"Numero", tbNumero.Text},
                {"Cep", tbCep.Text},
                {"Bairro", tbBairro.Text},
                {"Cidade", tbCidade.Text},
                {"Estado", cbEstado.Text},
                {"Telefone", tbTelefone.Text},
                {"Celular", tbCelular.Text},
                {"Email", tbEmail.Text},
                //dados veiculo
                {"Veiculo", cbVeiculo.Text},
                {"Chassi", tbChassi.Text},
                {"Placa", tbPlaca.Text},
                {"CidadeVeiculo", tbCidadeVeiculo.Text},
                {"AnoVeiculo", tbAno.Text},
                {"Marca", tbMarca.Text},
                {"Modelo", tbModelo.Text},
                {"Cor", cbCor.Text},
                {"Parcelas", parcelas},
            };

            try
            {
                await colRef.AddAsync(registro);
                janelaPrincipal.getFinanciamentos();
            }
            catch (System.Exception )
            {
                             
            }
            

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            verificaTexto(ref tbNome);
        }


        private void verificaNumero(ref TextBox tb)
        {
            string txt = tb.Text.ToUpper();
            if (!string.IsNullOrEmpty(txt))
            {
                if (!char.IsDigit(char.Parse(txt.Substring(txt.Length - 1))))
                {
                    MessageBox.Show("Digite apenas números.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tb.Text = txt.Remove(txt.Length - 1);
                    tb.SelectionStart = txt.Length;
                }

                
            }
        }

        private void verificaTexto(ref TextBox txt)
        {
            string txtUpper = txt.Text.ToUpper();

            if (!string.IsNullOrEmpty(txtUpper))
            {
                txt.Text = txtUpper;
                txt.SelectionStart = txt.Text.Length;
                if (char.IsDigit(char.Parse(txtUpper.Substring(txt.Text.Length - 1))))
                {
                    MessageBox.Show("Digite apenas letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Text = txtUpper.Remove(txtUpper.Length - 1);
                }
            }
        }

        private void verificaTexto(ref ComboBox txt)
        {
            string txtUpper = txt.Text.ToUpper();

            if (!string.IsNullOrEmpty(txtUpper))
            {
                txt.Text = txtUpper;
                txt.SelectionStart = txt.Text.Length;
                if (char.IsDigit(char.Parse(txtUpper.Substring(txt.Text.Length - 1))))
                {
                    MessageBox.Show("Digite apenas letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Text = txtUpper.Remove(txtUpper.Length - 1);
                }
            }
        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            verificaTexto(ref cbEstado);
        }

        private void cbVeiculo_TextChanged(object sender, EventArgs e)
        {
            verificaTexto(ref cbVeiculo);
        }

        private void cbCor_TextChanged(object sender, EventArgs e)
        {
            verificaTexto(ref cbCor);
        }

        private void tbMarca_TextChanged(object sender, EventArgs e)
        {
            verificaTexto(ref tbMarca);
        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref tbCpf);
        }

        private void tbCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCep.Text))
            {
                try
                {
                    var cliente = new Correios.CorreiosApi();
                    var resposta = cliente.consultaCEP(tbCep.Text);

                    tbEndereco.Text = resposta.end.ToUpper();
                    tbBairro.Text = resposta.bairro.ToUpper();
                    tbCidade.Text = resposta.cidade.ToUpper();
                    cbEstado.Text = resposta.uf.ToUpper();
                    tbNumero.Focus();
                }
                catch (System.Exception)
                {

                 
                }
                

            }
        }

        private void tbCep_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref tbCep);
        }
    }
}

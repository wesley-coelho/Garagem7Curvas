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
        //configuração de impressao
        public Font fonte = new Font("Arial", 12);
        public Brush cor = new SolidBrush(Color.Black);
        bool imprimirVerso = false;


        public FrmAddFinanciamento(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.janelaPrincipal = janelaPrincipal;
        }

     

        private async void btnAddFinanciamento_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpDadosCliente.Controls)
            {
                if(item.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }

            }
            
            CollectionReference colRef = janelaPrincipal.db.Collection("financiamentos");

            Parcela[] parcelas = new Parcela[int.Parse(cbPrazo.Text)];
            //gerando o array das parcelas
            for (int i  = 0;  i < int.Parse(cbPrazo.Text); i++)
            {
                Parcela parcela = new Parcela();
                parcela.Id = (i + 1).ToString();
                parcela.Situacao = "NORMAL";
                //if (tbValor.Text.Contains(","))
                //{
                //    tbValor.Text = tbValor.Text.Replace(",", ".");
                //}
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
                {"Obs", tbObs.Text},
            };

            try
            {
                this.Enabled = false;
                await colRef.AddAsync(registro);                               
                janelaPrincipal.getFinanciamentos();               
                if( MessageBox.Show("Registro adicionado com sucesso.\nDeseja imprimir a ficha?","Imprimir ficha", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printDocument1.Print();
                }
                this.Enabled = true;
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

        private void verificaNumero(ref ComboBox tb)
        {
            string txt = tb.Text.ToUpper();
            if (!string.IsNullOrEmpty(txt))
            {
                if (!char.IsDigit(char.Parse(txt.Substring(txt.Length - 1))))
                {
                    MessageBox.Show("Digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool validaCpf(string cpf)
        { 
            
            char[] vetCpf = cpf.ToArray<char>();
            int[]  cpfNumber = new int[11];
            int cpfSoma = 0;
            bool flagTodosIguais = true;
            for (int i = 0; i < vetCpf.Length; i++)
            {
                cpfNumber[i] = int.Parse(vetCpf[i].ToString());

            }
          
            for (int i = 0; i < cpfNumber.Length-1; i++)
            {
                if(cpfNumber[i] != cpfNumber[i + 1])
                {
                    flagTodosIguais = false;
                    break;
                }
            }

            if (flagTodosIguais == true)
                return false;

            for (int i = 0, j = 10; i < 9; i++, j--)
            {
                cpfSoma += j * cpfNumber[i];
            }

            if((cpfSoma*10)%11  == cpfNumber[9] || (cpfSoma * 10) % 11 == 10 && cpfNumber[9] == 0)
            {
                cpfSoma = 0;
                for (int i = 0, j = 11; i < 10; i++, j--)
                {
                    cpfSoma += j * cpfNumber[i];
                }
                if ((cpfSoma * 10) % 11 == cpfNumber[10] || (cpfSoma * 10) % 11 == 10 && cpfNumber[10] == 0)
                    return true;
                else 
                    return false;
            }
            else
            {
                return false;
            }

        }

        private void tbCpf_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCpf.Text))
                return;
            if (!validaCpf(tbCpf.Text))
            {
                MessageBox.Show("CPF inválido", "´CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCpf.Focus();
                tbCpf.SelectAll();
            }              


        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref tbNumero);
        }

        private void tbTelefone_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref tbTelefone);
        }

        private void tbCelular_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref tbCelular);
        }

        private void tbAno_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref tbAno);
        }

        private void cbPrazo_TextChanged(object sender, EventArgs e)
        {
            verificaNumero(ref cbPrazo);
        }

        private void tbEndereco_TextChanged(object sender, EventArgs e)
        {
            tbEndereco.Text = tbEndereco.Text.ToUpper();
            tbEndereco.SelectionStart = tbEndereco.Text.Length;
        }

        private void tbBairro_TextChanged(object sender, EventArgs e)
        {
            tbBairro.Text = tbBairro.Text.ToUpper();
            tbBairro.SelectionStart = tbBairro.Text.Length;
        }

        private void tbCidade_TextChanged(object sender, EventArgs e)
        {
            tbCidade.Text = tbCidade.Text.ToUpper();
            tbCidade.SelectionStart = tbCidade.Text.Length;
        }

        private void tbChassi_TextChanged(object sender, EventArgs e)
        {
            tbChassi.Text = tbChassi.Text.ToUpper();
            tbChassi.SelectionStart = tbChassi.Text.Length;
        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {
            tbModelo.Text = tbModelo.Text.ToUpper();
            tbModelo.SelectionStart = tbModelo.Text.Length;
        }

        private void tbCidadeVeiculo_TextChanged(object sender, EventArgs e)
        {
            tbCidadeVeiculo.Text = tbCidadeVeiculo.Text.ToUpper();
            tbCidadeVeiculo.SelectionStart = tbCidadeVeiculo.Text.Length;
        }

        private void tbPlaca_TextChanged(object sender, EventArgs e)
        {
            tbPlaca.Text = tbPlaca.Text.ToUpper();
            tbPlaca.SelectionStart = tbPlaca.Text.Length;
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbValor.Text))
            {
                
            }
        }


        private void printDocument1_BeginPrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float marginLeft = 100;
            float marginTop = 56.92f;

            if (imprimirVerso == false)
            {
                //primeira linha impressao frente
                e.Graphics.DrawString("Cliente: " + tbNome.Text, fonte, cor, marginLeft, marginTop);
                e.Graphics.DrawString("CPF: " + tbCpf.Text, fonte, cor, marginLeft + 450, marginTop);
                //segunda  linha impressao frente
                e.Graphics.DrawString("Endereço: " + tbEndereco.Text, fonte, cor, marginLeft, marginTop + 26.45f * 1);
                e.Graphics.DrawString("Numero: " + tbNumero.Text, fonte, cor, marginLeft + 450, marginTop + 26.45f * 1);
                //terceira linha impressao frente
                e.Graphics.DrawString("Bairro: " + tbBairro.Text, fonte, cor, marginLeft, marginTop + 26.45f * 2);
                e.Graphics.DrawString("CEP: " + tbCep.Text, fonte, cor, marginLeft + 450, marginTop + 26.45f * 2);
                //quarta linha impressao frente
                e.Graphics.DrawString("Cidade: " + tbCidade.Text, fonte, cor, marginLeft, marginTop + 26.45f * 3);
                e.Graphics.DrawString("Estado: " + cbEstado.Text, fonte, cor, marginLeft + 450, marginTop + 26.45f * 3);
                //quinta linha impressao frente
                e.Graphics.DrawString("Telefone: " + tbTelefone.Text, fonte, cor, marginLeft, marginTop + 26.45f * 4);
                e.Graphics.DrawString("Celular: " + tbCelular.Text, fonte, cor, marginLeft + 450, marginTop + 26.45f * 4);
                //sexta linha impressao frente
                e.Graphics.DrawString("Email: " + tbEmail.Text, fonte, cor, marginLeft, marginTop + 26.45f * 5);
                e.Graphics.DrawString("1ª parcela: " + dtPrimeiraParcela.Value.Date.ToString().Remove(10), fonte, cor, marginLeft+450, marginTop + 26.45f * 5);
                //setima linha impressao frente
                e.Graphics.DrawString("Prazo: " + cbPrazo.Text, fonte, cor, marginLeft, marginTop + 26.45f * 6);
                e.Graphics.DrawString("Valor: " + tbValor.Text, fonte, cor, marginLeft+450, marginTop + 26.45f * 6);
                
            }
            else
            {
                marginLeft = 50;
                //primeira linha impressao verso


                for (int i = 0, j=0; i < int.Parse(cbPrazo.Text); i++)
                {
                    if(i % 10 == 0 && i != 0)
                    {
                        j = 0;
                        e.Graphics.DrawString((i + 1).ToString() + "  " + dtPrimeiraParcela.Value.Date.AddMonths(i).ToString().Remove(10), new Font(new Font("Arial", 8), FontStyle.Bold), cor, marginLeft+=160, marginTop + 24.45f * (++j));
                        
                    }
                    else
                    {
                        e.Graphics.DrawString((i+1).ToString() + "  " + dtPrimeiraParcela.Value.Date.AddMonths(i).ToString().Remove(10), new Font(new Font("Arial", 8), FontStyle.Bold), cor, marginLeft, marginTop+24.45f*(++j));
                    }
                    
                }

                
                e.HasMorePages = false;
                return;
            }

            //imprimir verso
            if (MessageBox.Show("Deseja imprimir o verso da página?", "Imprimir verso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.HasMorePages = true;
                imprimirVerso = true;
            }
        }
    }
}

﻿using Google.Cloud.Firestore;
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
            catch (Exception)
            {

             
            }
            

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            string txtUpper = tbNome.Text.ToUpper();

            if (!string.IsNullOrEmpty(txtUpper))
            {
                tbNome.Text = txtUpper;
                tbNome.SelectionStart = tbNome.Text.Length;
                if (char.IsDigit(char.Parse(txtUpper.Substring(tbNome.Text.Length - 1))))
                {
                    MessageBox.Show("Digite apenas letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNome.Text = txtUpper.Remove(txtUpper.Length - 1);
                }
            }
                
               
        }


    }
}

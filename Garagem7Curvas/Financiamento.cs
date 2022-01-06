using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem7Curvas
{
    [FirestoreData]
    public class Financiamento
    {
        [FirestoreProperty]
        public string FinanciamentoId { get; set; }
        [FirestoreProperty]
        public string ClienteNome { get; set; }
        [FirestoreProperty]
        public string Cpf { get; set; }
        [FirestoreProperty]
        public string Cep { get; set; }
        [FirestoreProperty]
        public string Endereco { get; set; }
        [FirestoreProperty]
        public string Numero { get; set; }
        [FirestoreProperty]
        public string Bairro { get; set; }
        [FirestoreProperty]
        public string Cidade { get; set; }
        [FirestoreProperty]
        public string Estado { get; set; }
        [FirestoreProperty]
        public string Telefone { get; set; }
        [FirestoreProperty]
        public string Celular { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public string Veiculo { get; set; }
        [FirestoreProperty]
        public string AnoVeiculo { get; set; }
        [FirestoreProperty]
        public string Chassi { get; set; }
        [FirestoreProperty]
        public string CidadeVeiculo { get; set; }
        [FirestoreProperty]
        public string Cor { get; set; }
        [FirestoreProperty]
        public string Marca { get; set; }
        [FirestoreProperty]
        public string Modelo { get; set; }
        [FirestoreProperty]
        public string Placa { get; set; }
        [FirestoreProperty]
        public Parcela[] Parcelas { get; set; }

    }
}

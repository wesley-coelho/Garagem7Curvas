using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem7Curvas
{
    [FirestoreData]
   public  class Parcela
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Situacao { get; set; }
        [FirestoreProperty]
        public float ValorNominal { get; set; }
        [FirestoreProperty]
        public float ValorPago { get; set; }
        [FirestoreProperty]
        public string Vencimento { get; set; }
    }
}

using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem7Curvas
{
    [FirestoreData]
   public class Parcela
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Vencimento { get; set; }
        
        [FirestoreProperty]
        public double ValorNominal { get; set; }
        [FirestoreProperty]
        public double ValorPago { get; set; }
       
        [FirestoreProperty]
        public string DataPgto { get; set; }
        [FirestoreProperty]
        public string Observacao { get; set; }

    }
}

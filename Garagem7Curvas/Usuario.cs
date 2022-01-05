using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Garagem7Curvas
{
    [FirestoreData]
    public class Usuario
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Senha { get; set; }
        [FirestoreProperty]
        public bool IsAdmin { get; set; }
        [FirestoreProperty]
        public bool Write { get; set; }
        [FirestoreProperty]
        public bool Read { get; set; }
        [FirestoreProperty]
        public bool Edit { get; set; }
        [FirestoreProperty]
        public bool Delete { get; set; }

    }
}

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
    public partial class FrmLogin : Form
    {

        FrmJanelaPrincipal janelaPrincipal;
        public FrmLogin(FrmJanelaPrincipal janelaPrincipal)
        {
            InitializeComponent();
            this.janelaPrincipal = janelaPrincipal;
        }

        
        private async void btnLoginConectar_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "logando...";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"garagem7curvas-firebase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            janelaPrincipal.db = FirestoreDb.Create("garagem7curvas");           

            try
            {
               
                CollectionReference colRef = janelaPrincipal.db.Collection("usuarios");
                Query userQuery = colRef.WhereEqualTo("Username", tbLoginUsuario.Text);
                QuerySnapshot users = await userQuery.GetSnapshotAsync();

                foreach (var user in users)
                {                     
                    Usuario usuario = user.ConvertTo<Usuario>();
                    if(usuario.Senha != tbSenha.Text)
                    {
                         lbStatus.Text = "Usuário ou senha incorretos.";
                         tbLoginUsuario.Clear();
                         tbSenha.Clear();
                         tbLoginUsuario.Focus();
                         return;
                    }
                        this.Close();
                    janelaPrincipal.barraStatus.Text = "@" + usuario.Username;
                        //chama função getFinanciamentos
                    
                }
                lbStatus.Text = "Usuário ou senha incorretos.";
                tbLoginUsuario.Clear();
                tbSenha.Clear();
                tbLoginUsuario.Focus();
                return;
            }
            catch (Exception ex)            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}

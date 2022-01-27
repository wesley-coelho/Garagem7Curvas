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
            this.UseWaitCursor = true;
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
                    janelaPrincipal.usuario = user.ConvertTo<Usuario>();
                    if(janelaPrincipal.usuario.Senha != tbSenha.Text)
                    {
                         lbStatus.Text = "Usuário ou senha incorretos.";
                         tbLoginUsuario.Clear();
                         tbSenha.Clear();
                         tbLoginUsuario.Focus();
                        janelaPrincipal.importarToolStripMenuItem.Enabled = false;
                        this.UseWaitCursor = false;
                        return;
                    }
                        this.Close();
                    janelaPrincipal.barraStatus.Text = "@" + janelaPrincipal.usuario.Username;
                    //chama função getFinanciamentos
                    janelaPrincipal.getFinanciamentos();
                    janelaPrincipal.importarToolStripMenuItem.Enabled = true;
                    if (janelaPrincipal.usuario.IsAdmin == true)
                        janelaPrincipal.gerenciarUsuariosToolStripMenuItem.Enabled = true;
                    else
                        janelaPrincipal.gerenciarUsuariosToolStripMenuItem.Enabled = false;

                }               
             
                tbLoginUsuario.Clear();
                tbSenha.Clear();
                tbLoginUsuario.Focus();
                this.UseWaitCursor = false;
                return;
            }
            catch (Exception ex)            {

                MessageBox.Show(ex.Message);
                this.UseWaitCursor = false;
            }

        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginConectar.Focus();
                btnLoginConectar.PerformClick();
            }
        }
    }
}

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
    public partial class FrmGerUsers : Form
    {

        FrmJanelaPrincipal janelaPrincipal = new FrmJanelaPrincipal();

        public FrmGerUsers( FrmJanelaPrincipal janelaPrincipal)
        {
            this.janelaPrincipal = janelaPrincipal;
            InitializeComponent();
            getUsers(janelaPrincipal.db, dgvUsers);

        }



        public async void getUsers(FirestoreDb db, DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
                QuerySnapshot docSnap = await db.Collection("usuarios").GetSnapshotAsync();
                foreach (var doc in docSnap)
                {
                    if (doc.Exists)
                    {
                        Usuario user = doc.ConvertTo<Usuario>();
                        string[] linha =
                        {
                            doc.Id,
                            user.Username,
                            user.Senha,
                            user.IsAdmin.ToString(),
                            user.Edit.ToString(),
                            user.Delete.ToString(),
                            user.Write.ToString(),
                        };
                        dgv.Rows.Add(linha);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void dgvUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string key = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (e.ColumnIndex == 1)
                {
                    string valueUpdate = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    await janelaPrincipal.db.Collection("usuarios").Document(key).UpdateAsync("Username", valueUpdate);

                }
                else if(e.ColumnIndex == 2)
                {
                    string valueUpdate = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    await janelaPrincipal.db.Collection("usuarios").Document(key).UpdateAsync("Senha", valueUpdate);
                }
                else if (e.ColumnIndex == 3)
                {
                    bool valueUpdate = bool.Parse(dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    await janelaPrincipal.db.Collection("usuarios").Document(key).UpdateAsync("IsAdmin", valueUpdate);
                }
                else if (e.ColumnIndex == 4)
                {
                    bool valueUpdate = bool.Parse(dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    await janelaPrincipal.db.Collection("usuarios").Document(key).UpdateAsync("Edit", valueUpdate);
                }
                else if (e.ColumnIndex == 5)
                {
                    bool valueUpdate = bool.Parse(dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    await janelaPrincipal.db.Collection("usuarios").Document(key).UpdateAsync("Delete", valueUpdate);
                }
                else if(e.ColumnIndex == 6)
                {
                    bool valueUpdate = bool.Parse(dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    await janelaPrincipal.db.Collection("usuarios").Document(key).UpdateAsync("Write", valueUpdate);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Atualizar. Verifique a conexao com a internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
               
            }
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelUser.Enabled = true;
        }

        private void dgvUsers_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelUser.Enabled = true;
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if(dgvUsers.SelectedRows.Count != 0)
                btnDelUser.Enabled = true;
            else
                btnDelUser.Enabled = false;
        }

        private async void btnDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                string key = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                
               if(MessageBox.Show("Confirma exclusão de  " + dgvUsers.SelectedRows[0].Cells[1].Value.ToString(), "Confirma Exclusao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK){
                    await janelaPrincipal.db.Collection("usuarios").Document(key).DeleteAsync();
                    getUsers(janelaPrincipal.db, dgvUsers);
                    MessageBox.Show("Usuario Excluído com sucesso!", "Exclusão confirmada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser frmNovoUser = new AddUser(janelaPrincipal, this);
            frmNovoUser.Show();
        }
    }
}

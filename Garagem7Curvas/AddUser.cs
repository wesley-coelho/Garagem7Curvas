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
    public partial class AddUser : Form
    {
        FrmJanelaPrincipal janelaPrincipal = new FrmJanelaPrincipal();
        FrmGerUsers frmGerUsers;
        public AddUser(FrmJanelaPrincipal janelaPrincipal, FrmGerUsers frmGerUsers)
        {
            InitializeComponent();

            this.janelaPrincipal = janelaPrincipal;
            this.frmGerUsers = frmGerUsers;
        }

        

        private void chkPermissoes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.CurrentValue == CheckState.Unchecked)
            {
                chkPermissoes.SetItemChecked(1, true);
                chkPermissoes.SetItemChecked(2, true);
                chkPermissoes.SetItemChecked(3, true);               
            }
            
        }

        private void tbSenha_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbSenha.Text) && tbSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSenha.Clear();
                tbSenha.Focus();
            }
        }

        private void tbRepeatSenha_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbRepeatSenha.Text))
            {
                if(tbRepeatSenha.Text != tbSenha.Text)
                {
                    MessageBox.Show("Senha Incorreta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRepeatSenha.Clear();
                    tbRepeatSenha.Focus();
                }
                          
            }
        }

        private void tbAddUser_Click(object sender, EventArgs e)
        {
            if( tbUsername.Text != "")
                if( tbSenha.Text != "")
                    if( tbRepeatSenha.Text != "")
                        if( chkPermissoes.CheckedItems.Count != 0)
                        {
                            try
                            {
                                Dictionary<string, object> user = new Dictionary<string, object>()
                                {
                                    {"Username", tbUsername.Text},
                                    {"Senha", tbSenha.Text},
                                    {"IsAdmin", chkPermissoes.GetItemChecked(0)},
                                    {"Edit", chkPermissoes.GetItemChecked(1)},
                                    {"Write", chkPermissoes.GetItemChecked(2)},
                                    {"Delete", chkPermissoes.GetItemChecked(3)},
                                };
                                
                                janelaPrincipal.db.Collection("usuarios").AddAsync(user);
                                frmGerUsers.getUsers(janelaPrincipal.db, frmGerUsers.dgvUsers);
                                MessageBox.Show("Usuário adicionado com sucesso!", "Usuário adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Erro ao Adicionar usuario. Verifique a conexão com a internet.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);


                               
                            }
                        }
        }
    }
}

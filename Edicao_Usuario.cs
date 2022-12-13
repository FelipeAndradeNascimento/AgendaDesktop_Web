using CadastroBasicoDesktop.Classe_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroBasicoDesktop
{
    public partial class Edicao_Usuario : Form
    {
        private lst_Usuario ListaUsuarios = new lst_Usuario();

        public Edicao_Usuario(lst_Usuario par_form)
        {
            InitializeComponent();
            par_form = ListaUsuarios;
        }

        private void Edicao_Usuario_Load(object sender, EventArgs e)
        {
            if ((lbl_ID.Text != "") || (lbl_ID.Text != "0"))
            {
                lblTitulo.Text = "Editar Contato";
                btnAcao.Text = "Salvar";
            }
            lblTitulo.Text = "Novo Contato";
            btnAcao.Text = "Incluir";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.ListaUsuarios.Show();
            this.Close();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();
            if (btnAcao.Text == "Salvar")
            {
                objUsuario.fnEditarUsuario(Convert.ToInt32(lbl_ID.Text),txtNome.Text, txtEmail.Text, txtCpf.Text, txtTelefone.Text, Convert.ToInt32(txtIdEndereco.Text));
                MessageBox.Show("Usuário editado com sucesso!");
            }
            else
            {
                objUsuario.fnInserirUsuario(txtNome.Text, txtEmail.Text, txtCpf.Text, txtTelefone.Text, Convert.ToInt32(txtIdEndereco.Text));
                MessageBox.Show("Novo Usuário incluido com sucesso!");
            }
        }

        private void DefineRotulos()
        {
            if ((lbl_ID.Text != "") || (lbl_ID.Text != "0"))
            {
                lblTitulo.Text = "Editar Contato";
                btnAcao.Text = "Salvar";
            }
            lblTitulo.Text = "Novo Contato";
            btnAcao.Text = "Incluir";
        }
    }
}
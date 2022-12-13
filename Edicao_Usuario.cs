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
    }
}
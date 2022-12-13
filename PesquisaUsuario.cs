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
    public partial class PesquisaUsuario : Form
    {
        private MenuPrincipal frm_menu = new MenuPrincipal();
        public PesquisaUsuario(MenuPrincipal par_form)
        {
            InitializeComponent();
            par_form = frm_menu;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frm_menu.Show();
            this.Close();
        }
    }
}

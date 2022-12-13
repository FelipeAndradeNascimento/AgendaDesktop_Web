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
    public partial class RelatorioEndereco : Form
    {
        private MenuPrincipal for_menu = new MenuPrincipal();
        public RelatorioEndereco(MenuPrincipal par_menu)
        {
            InitializeComponent();
            par_menu = for_menu;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            for_menu.Show();
            this.Close();
        }
    }
}

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
    public partial class lst_Usuario : Form
    {
        private MenuPrincipal frm_menu = new MenuPrincipal();
        
        /// <summary>
        /// Construtor com parâmetro para navegação ao menu principal
        /// </summary>
        /// <param name="par_form"></param>
        public lst_Usuario(MenuPrincipal par_form)
        {
            InitializeComponent();
            par_form = frm_menu;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public lst_Usuario()
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.frm_menu.Show();
            this.Close();
        }

        private void Cad_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_agendaDataSet.tbContatos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContatosTableAdapter.Fill(this.db_agendaDataSet.tbContatos);
            if (dgv_ListaUsuarios.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro encontrado", "Lista de Usuarios", MessageBoxButtons.OK);
            }
        }

        private void lkNovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edicao_Usuario frmEditUsuario = new Edicao_Usuario(this);
            frmEditUsuario.Show();
            this.Visible = false;
        }
    }
}
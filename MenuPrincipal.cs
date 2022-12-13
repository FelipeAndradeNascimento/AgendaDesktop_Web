using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CadastroBasicoDesktop
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        #region Eventos Click de Cada Item de Menu

        /// <summary>
        /// LISTA DE USUARIOS E PERMITE CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            lst_Usuario formCadUsuario = new lst_Usuario(this);
            Visualiza_Form(formCadUsuario);
        }

        /// <summary>
        /// PERMITE PESQUISAR POR USUÁRIOS EXISTENTES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisaUsuario_Click(object sender, EventArgs e)
        {
            PesquisaUsuario formPesqUsuario = new PesquisaUsuario(this);
            Visualiza_Form(formPesqUsuario);
        }

        /// <summary>
        /// LISTA DE ENDEREÇOS E PERMITE CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndereco_Click(object sender, EventArgs e)
        {
            Cad_Endereco formEndereco = new Cad_Endereco(this);
            Visualiza_Form(formEndereco);
        }

        /// <summary>
        /// OPÇÕES DE RELATORIOS DE USUÁRIOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelatUsuario_Click(object sender, EventArgs e)
        {
            RelatorioUsuario relatUsuario = new RelatorioUsuario(this);
            Visualiza_Form(relatUsuario);
        }

        /// <summary>
        /// OPÇÕES DE RELATORIOS DE ENDEREÇOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRelatEndereco_Click(object sender, EventArgs e)
        {
            RelatorioEndereco relatEndereco = new RelatorioEndereco(this);
            Visualiza_Form(relatEndereco);
        }

        /// <summary>
        /// PERMITE PESQUISAR POR ENDEREÇOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisaEndereco_Click(object sender, EventArgs e)
        {
            PesquisaEndereco pesquisaEndereco = new PesquisaEndereco(this);
            Visualiza_Form(pesquisaEndereco);
        }
        #endregion

        private void Visualiza_Form(Form formulario)
        {
            formulario.Show();
            this.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Window.
        }
    }
}
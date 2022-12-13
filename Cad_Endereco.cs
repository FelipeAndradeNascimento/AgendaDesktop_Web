﻿using System;
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
    public partial class Cad_Endereco : Form
    {
        private MenuPrincipal frm_menu = new MenuPrincipal();
        public Cad_Endereco(MenuPrincipal par_menu)
        {
            InitializeComponent();
            par_menu = frm_menu;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.frm_menu.Show();
            this.Close();
        }

        private void Cad_Endereco_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_agendaDataSet.tbEndereco'. Você pode movê-la ou removê-la conforme necessário.
            this.tbEnderecoTableAdapter.Fill(this.db_agendaDataSet.tbEndereco);

        }
    }
}

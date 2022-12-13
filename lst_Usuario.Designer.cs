namespace CadastroBasicoDesktop
{
    partial class lst_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgv_ListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lkNovo = new System.Windows.Forms.LinkLabel();
            this.BSdtBase = new System.Windows.Forms.BindingSource(this.components);
            this.db_agendaDataSet = new CadastroBasicoDesktop.db_agendaDataSet();
            this.tbContatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContatosTableAdapter = new CadastroBasicoDesktop.db_agendaDataSetTableAdapters.tbContatosTableAdapter();
            this.idContatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdtBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de usuários";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 413);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 25);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar Menu Principal";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgv_ListaUsuarios
            // 
            this.dgv_ListaUsuarios.AllowUserToAddRows = false;
            this.dgv_ListaUsuarios.AllowUserToOrderColumns = true;
            this.dgv_ListaUsuarios.AutoGenerateColumns = false;
            this.dgv_ListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContatoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgv_ListaUsuarios.DataSource = this.tbContatosBindingSource;
            this.dgv_ListaUsuarios.Location = new System.Drawing.Point(15, 50);
            this.dgv_ListaUsuarios.Name = "dgv_ListaUsuarios";
            this.dgv_ListaUsuarios.Size = new System.Drawing.Size(760, 342);
            this.dgv_ListaUsuarios.TabIndex = 2;
            // 
            // lkNovo
            // 
            this.lkNovo.AutoSize = true;
            this.lkNovo.Location = new System.Drawing.Point(703, 9);
            this.lkNovo.Name = "lkNovo";
            this.lkNovo.Size = new System.Drawing.Size(72, 13);
            this.lkNovo.TabIndex = 3;
            this.lkNovo.TabStop = true;
            this.lkNovo.Text = "Novo Usuário";
            this.lkNovo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkNovo_LinkClicked);
            // 
            // BSdtBase
            // 
            this.BSdtBase.DataSource = this.db_agendaDataSet;
            this.BSdtBase.Position = 0;
            // 
            // db_agendaDataSet
            // 
            this.db_agendaDataSet.DataSetName = "db_agendaDataSet";
            this.db_agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbContatosBindingSource
            // 
            this.tbContatosBindingSource.DataMember = "tbContatos";
            this.tbContatosBindingSource.DataSource = this.BSdtBase;
            // 
            // tbContatosTableAdapter
            // 
            this.tbContatosTableAdapter.ClearBeforeFill = true;
            // 
            // idContatoDataGridViewTextBoxColumn
            // 
            this.idContatoDataGridViewTextBoxColumn.DataPropertyName = "IdContato";
            this.idContatoDataGridViewTextBoxColumn.HeaderText = "IdContato";
            this.idContatoDataGridViewTextBoxColumn.Name = "idContatoDataGridViewTextBoxColumn";
            this.idContatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.MaxInputLength = 14;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MaxInputLength = 12;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lst_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lkNovo);
            this.Controls.Add(this.dgv_ListaUsuarios);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Name = "lst_Usuario";
            this.Text = "Lista de Usuários";
            this.Load += new System.EventHandler(this.Cad_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdtBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContatosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgv_ListaUsuarios;
        private System.Windows.Forms.LinkLabel lkNovo;
        private System.Windows.Forms.BindingSource BSdtBase;
        private db_agendaDataSet db_agendaDataSet;
        private System.Windows.Forms.BindingSource tbContatosBindingSource;
        private db_agendaDataSetTableAdapters.tbContatosTableAdapter tbContatosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}
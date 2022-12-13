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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgv_ListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lkNovo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaUsuarios)).BeginInit();
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
            this.dgv_ListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgv_ListaUsuarios;
        private System.Windows.Forms.LinkLabel lkNovo;
    }
}
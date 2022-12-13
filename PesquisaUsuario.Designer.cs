namespace CadastroBasicoDesktop
{
    partial class PesquisaUsuario
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_Usuarios = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(37, 409);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(149, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar Menu Principal";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa por Usuários";
            // 
            // dgw_Usuarios
            // 
            this.dgw_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Usuarios.Location = new System.Drawing.Point(35, 133);
            this.dgw_Usuarios.Name = "dgw_Usuarios";
            this.dgw_Usuarios.Size = new System.Drawing.Size(734, 252);
            this.dgw_Usuarios.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(244, 90);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Consultar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(30, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "CPF:";
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(35, 90);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(182, 20);
            this.txtPesquisarNome.TabIndex = 8;
            // 
            // PesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Usuarios);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPesquisarNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "PesquisaUsuario";
            this.Text = "PesquisaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_Usuarios;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesquisarNome;
    }
}
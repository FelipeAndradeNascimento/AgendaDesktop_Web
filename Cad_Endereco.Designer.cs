namespace CadastroBasicoDesktop
{
    partial class Cad_Endereco
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
            this.dgv_ListaEnderecos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 25);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar Menu Principal";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Endereço";
            // 
            // dgv_ListaEnderecos
            // 
            this.dgv_ListaEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaEnderecos.Location = new System.Drawing.Point(15, 50);
            this.dgv_ListaEnderecos.Name = "dgv_ListaEnderecos";
            this.dgv_ListaEnderecos.Size = new System.Drawing.Size(775, 330);
            this.dgv_ListaEnderecos.TabIndex = 2;
            // 
            // Cad_Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ListaEnderecos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Cad_Endereco";
            this.Text = "Cad_Endereco";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ListaEnderecos;
    }
}
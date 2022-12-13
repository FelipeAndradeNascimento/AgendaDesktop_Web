namespace CadastroBasicoDesktop
{
    partial class PesquisaEndereco
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
            this.txtPesquisarCep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 413);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 25);
            this.btnVoltar.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisa por Endereços";
            // 
            // txtPesquisarCep
            // 
            this.txtPesquisarCep.Location = new System.Drawing.Point(17, 83);
            this.txtPesquisarCep.Name = "txtPesquisarCep";
            this.txtPesquisarCep.Size = new System.Drawing.Size(182, 20);
            this.txtPesquisarCep.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEP:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(226, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Consultar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 252);
            this.dataGridView1.TabIndex = 6;
            // 
            // PesquisaEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisarCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "PesquisaEndereco";
            this.Text = "PesquisaEndereco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisarCep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
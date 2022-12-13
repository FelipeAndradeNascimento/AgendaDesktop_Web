namespace CadastroBasicoDesktop
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbMenuCad = new System.Windows.Forms.GroupBox();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.grbMenuPesquisas = new System.Windows.Forms.GroupBox();
            this.btnPesquisaEndereco = new System.Windows.Forms.Button();
            this.btnPesquisaUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRelatEndereco = new System.Windows.Forms.Button();
            this.btnRelatUsuario = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbMenuCad.SuspendLayout();
            this.grbMenuPesquisas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenuCad
            // 
            this.grbMenuCad.Controls.Add(this.btnEndereco);
            this.grbMenuCad.Controls.Add(this.btnCadUsuario);
            this.grbMenuCad.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMenuCad.Location = new System.Drawing.Point(10, 30);
            this.grbMenuCad.Name = "grbMenuCad";
            this.grbMenuCad.Size = new System.Drawing.Size(750, 80);
            this.grbMenuCad.TabIndex = 0;
            this.grbMenuCad.TabStop = false;
            this.grbMenuCad.Text = "CADASTROS";
            // 
            // btnEndereco
            // 
            this.btnEndereco.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndereco.ForeColor = System.Drawing.Color.Navy;
            this.btnEndereco.Location = new System.Drawing.Point(253, 29);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(181, 29);
            this.btnEndereco.TabIndex = 1;
            this.btnEndereco.Text = "Endereço";
            this.btnEndereco.UseVisualStyleBackColor = true;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btnCadUsuario.Location = new System.Drawing.Point(30, 29);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(181, 29);
            this.btnCadUsuario.TabIndex = 0;
            this.btnCadUsuario.Text = "Usuário";
            this.btnCadUsuario.UseVisualStyleBackColor = true;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // grbMenuPesquisas
            // 
            this.grbMenuPesquisas.Controls.Add(this.btnPesquisaEndereco);
            this.grbMenuPesquisas.Controls.Add(this.btnPesquisaUsuario);
            this.grbMenuPesquisas.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMenuPesquisas.Location = new System.Drawing.Point(10, 134);
            this.grbMenuPesquisas.Name = "grbMenuPesquisas";
            this.grbMenuPesquisas.Size = new System.Drawing.Size(750, 80);
            this.grbMenuPesquisas.TabIndex = 1;
            this.grbMenuPesquisas.TabStop = false;
            this.grbMenuPesquisas.Text = "PESQUISAS";
            // 
            // btnPesquisaEndereco
            // 
            this.btnPesquisaEndereco.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaEndereco.ForeColor = System.Drawing.Color.Navy;
            this.btnPesquisaEndereco.Location = new System.Drawing.Point(253, 29);
            this.btnPesquisaEndereco.Name = "btnPesquisaEndereco";
            this.btnPesquisaEndereco.Size = new System.Drawing.Size(181, 29);
            this.btnPesquisaEndereco.TabIndex = 1;
            this.btnPesquisaEndereco.Text = "Endereços";
            this.btnPesquisaEndereco.UseVisualStyleBackColor = true;
            this.btnPesquisaEndereco.Click += new System.EventHandler(this.btnPesquisaEndereco_Click);
            // 
            // btnPesquisaUsuario
            // 
            this.btnPesquisaUsuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btnPesquisaUsuario.Location = new System.Drawing.Point(30, 29);
            this.btnPesquisaUsuario.Name = "btnPesquisaUsuario";
            this.btnPesquisaUsuario.Size = new System.Drawing.Size(181, 29);
            this.btnPesquisaUsuario.TabIndex = 0;
            this.btnPesquisaUsuario.Text = "Usuários";
            this.btnPesquisaUsuario.UseVisualStyleBackColor = true;
            this.btnPesquisaUsuario.Click += new System.EventHandler(this.btnPesquisaUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRelatEndereco);
            this.groupBox1.Controls.Add(this.btnRelatUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RELATÓRIOS";
            // 
            // btnRelatEndereco
            // 
            this.btnRelatEndereco.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatEndereco.ForeColor = System.Drawing.Color.Navy;
            this.btnRelatEndereco.Location = new System.Drawing.Point(253, 29);
            this.btnRelatEndereco.Name = "btnRelatEndereco";
            this.btnRelatEndereco.Size = new System.Drawing.Size(181, 29);
            this.btnRelatEndereco.TabIndex = 1;
            this.btnRelatEndereco.Text = "Endereço";
            this.btnRelatEndereco.UseVisualStyleBackColor = true;
            this.btnRelatEndereco.Click += new System.EventHandler(this.btnRelatEndereco_Click);
            // 
            // btnRelatUsuario
            // 
            this.btnRelatUsuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btnRelatUsuario.Location = new System.Drawing.Point(30, 29);
            this.btnRelatUsuario.Name = "btnRelatUsuario";
            this.btnRelatUsuario.Size = new System.Drawing.Size(181, 29);
            this.btnRelatUsuario.TabIndex = 0;
            this.btnRelatUsuario.Text = "Usuário";
            this.btnRelatUsuario.UseVisualStyleBackColor = true;
            this.btnRelatUsuario.Click += new System.EventHandler(this.btnRelatUsuario_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(13, 415);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(121, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&Sair do Aplicativo";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbMenuPesquisas);
            this.Controls.Add(this.grbMenuCad);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.grbMenuCad.ResumeLayout(false);
            this.grbMenuPesquisas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenuCad;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.GroupBox grbMenuPesquisas;
        private System.Windows.Forms.Button btnPesquisaEndereco;
        private System.Windows.Forms.Button btnPesquisaUsuario;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRelatEndereco;
        private System.Windows.Forms.Button btnRelatUsuario;
        private System.Windows.Forms.Button btnFechar;
    }
}


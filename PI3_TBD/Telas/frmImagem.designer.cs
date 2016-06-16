namespace MVC
{
    partial class frmImagem
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.picImagem2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodImagem = new System.Windows.Forms.TextBox();
            this.picImagem1 = new System.Windows.Forms.PictureBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gravar";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(187, 77);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(138, 42);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar...";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(112, 136);
            this.lblCaminho.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(86, 24);
            this.lblCaminho.TabIndex = 7;
            this.lblCaminho.Text = "Caminho";
            // 
            // picImagem2
            // 
            this.picImagem2.Location = new System.Drawing.Point(117, 189);
            this.picImagem2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picImagem2.Name = "picImagem2";
            this.picImagem2.Size = new System.Drawing.Size(420, 334);
            this.picImagem2.TabIndex = 8;
            this.picImagem2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 555);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(187, 547);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(180, 29);
            this.txtTitulo.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(242, 614);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 42);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodImagem
            // 
            this.txtCodImagem.Location = new System.Drawing.Point(233, 131);
            this.txtCodImagem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodImagem.Name = "txtCodImagem";
            this.txtCodImagem.Size = new System.Drawing.Size(180, 29);
            this.txtCodImagem.TabIndex = 3;
            this.txtCodImagem.Visible = false;
            // 
            // picImagem1
            // 
            this.picImagem1.Location = new System.Drawing.Point(88, 273);
            this.picImagem1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picImagem1.Name = "picImagem1";
            this.picImagem1.Size = new System.Drawing.Size(420, 334);
            this.picImagem1.TabIndex = 4;
            this.picImagem1.TabStop = false;
            this.picImagem1.Visible = false;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(204, 220);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(138, 42);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Visible = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(83, 644);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 24);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Título";
            // 
            // frmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(691, 885);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picImagem2);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.picImagem1);
            this.Controls.Add(this.txtCodImagem);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmImagem";
            this.Text = "Manipular Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.PictureBox picImagem2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodImagem;
        private System.Windows.Forms.PictureBox picImagem1;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTitulo;
    }
}


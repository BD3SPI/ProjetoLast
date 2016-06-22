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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImagem));
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.picImagem2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodImagem = new System.Windows.Forms.TextBox();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(423, 15);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(6);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(138, 42);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar...";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(15, 24);
            this.lblCaminho.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(86, 24);
            this.lblCaminho.TabIndex = 7;
            this.lblCaminho.Text = "Caminho";
            // 
            // picImagem2
            // 
            this.picImagem2.Location = new System.Drawing.Point(98, 62);
            this.picImagem2.Margin = new System.Windows.Forms.Padding(6);
            this.picImagem2.Name = "picImagem2";
            this.picImagem2.Size = new System.Drawing.Size(381, 300);
            this.picImagem2.TabIndex = 8;
            this.picImagem2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(98, 374);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(381, 29);
            this.txtTitulo.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(228, 588);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 42);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodImagem
            // 
            this.txtCodImagem.Location = new System.Drawing.Point(111, 21);
            this.txtCodImagem.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodImagem.Name = "txtCodImagem";
            this.txtCodImagem.ReadOnly = true;
            this.txtCodImagem.Size = new System.Drawing.Size(300, 29);
            this.txtCodImagem.TabIndex = 3;
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar2.Image")));
            this.btnSalvar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar2.Location = new System.Drawing.Point(461, 415);
            this.btnSalvar2.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(100, 42);
            this.btnSalvar2.TabIndex = 5;
            this.btnSalvar2.Text = "Salvar";
            this.btnSalvar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar2.UseVisualStyleBackColor = true;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(576, 472);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.txtCodImagem);
            this.Controls.Add(this.picImagem2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravar Imagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.PictureBox picImagem2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodImagem;
        private System.Windows.Forms.Button btnSalvar2;
    }
}


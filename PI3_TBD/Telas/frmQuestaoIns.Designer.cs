namespace MVC.Telas
{
    partial class frmQuestaoIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestaoIns));
            this.panQuestao = new System.Windows.Forms.Panel();
            this.txtProfessor = new System.Windows.Forms.RichTextBox();
            this.cckImagem = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAssunto = new System.Windows.Forms.ComboBox();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.cmbTpQuestao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panAlternativa = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ckCorreta = new System.Windows.Forms.CheckBox();
            this.txtAlternativa = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panQuestao.SuspendLayout();
            this.panAlternativa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panQuestao
            // 
            this.panQuestao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panQuestao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panQuestao.Controls.Add(this.txtProfessor);
            this.panQuestao.Controls.Add(this.cckImagem);
            this.panQuestao.Controls.Add(this.label7);
            this.panQuestao.Controls.Add(this.label6);
            this.panQuestao.Controls.Add(this.cbxAssunto);
            this.panQuestao.Controls.Add(this.txtTexto);
            this.panQuestao.Controls.Add(this.cmbTpQuestao);
            this.panQuestao.Controls.Add(this.label5);
            this.panQuestao.Controls.Add(this.ckAtivo);
            this.panQuestao.Controls.Add(this.cmbNivel);
            this.panQuestao.Controls.Add(this.label4);
            this.panQuestao.Controls.Add(this.label3);
            this.panQuestao.Controls.Add(this.label2);
            this.panQuestao.Controls.Add(this.label1);
            this.panQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panQuestao.Location = new System.Drawing.Point(13, 18);
            this.panQuestao.Margin = new System.Windows.Forms.Padding(6);
            this.panQuestao.Name = "panQuestao";
            this.panQuestao.Size = new System.Drawing.Size(489, 291);
            this.panQuestao.TabIndex = 7;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Enabled = false;
            this.txtProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(126, 141);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(318, 31);
            this.txtProfessor.TabIndex = 69;
            this.txtProfessor.Text = "";
            // 
            // cckImagem
            // 
            this.cckImagem.AutoSize = true;
            this.cckImagem.Location = new System.Drawing.Point(321, 261);
            this.cckImagem.Name = "cckImagem";
            this.cckImagem.Size = new System.Drawing.Size(97, 28);
            this.cckImagem.TabIndex = 68;
            this.cckImagem.Text = "Imagem";
            this.cckImagem.UseVisualStyleBackColor = true;
            this.cckImagem.CheckedChanged += new System.EventHandler(this.cckImagem_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 67;
            this.label7.Text = "Questão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tipo Questão:";
            // 
            // cbxAssunto
            // 
            this.cbxAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAssunto.FormattingEnabled = true;
            this.cbxAssunto.Location = new System.Drawing.Point(126, 104);
            this.cbxAssunto.Margin = new System.Windows.Forms.Padding(6);
            this.cbxAssunto.Name = "cbxAssunto";
            this.cbxAssunto.Size = new System.Drawing.Size(318, 32);
            this.cbxAssunto.TabIndex = 65;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(126, 36);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(318, 50);
            this.txtTexto.TabIndex = 28;
            this.txtTexto.Text = "";
            // 
            // cmbTpQuestao
            // 
            this.cmbTpQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTpQuestao.FormattingEnabled = true;
            this.cmbTpQuestao.Items.AddRange(new object[] {
            "",
            "F",
            "M",
            "D"});
            this.cmbTpQuestao.Location = new System.Drawing.Point(161, 216);
            this.cmbTpQuestao.Name = "cmbTpQuestao";
            this.cmbTpQuestao.Size = new System.Drawing.Size(283, 32);
            this.cmbTpQuestao.TabIndex = 27;
            this.cmbTpQuestao.SelectedIndexChanged += new System.EventHandler(this.cmbTpQuestao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ativo:";
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAtivo.Location = new System.Drawing.Point(99, 268);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(15, 14);
            this.ckAtivo.TabIndex = 24;
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbNivel
            // 
            this.cmbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.ItemHeight = 24;
            this.cmbNivel.Items.AddRange(new object[] {
            "",
            "F",
            "M",
            "D"});
            this.cmbNivel.Location = new System.Drawing.Point(126, 178);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(318, 32);
            this.cmbNivel.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nível";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Assunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Texto:";
            // 
            // panAlternativa
            // 
            this.panAlternativa.Controls.Add(this.dataGridView1);
            this.panAlternativa.Controls.Add(this.label10);
            this.panAlternativa.Controls.Add(this.button2);
            this.panAlternativa.Controls.Add(this.button1);
            this.panAlternativa.Controls.Add(this.label9);
            this.panAlternativa.Controls.Add(this.ckCorreta);
            this.panAlternativa.Controls.Add(this.txtAlternativa);
            this.panAlternativa.Controls.Add(this.label8);
            this.panAlternativa.Enabled = false;
            this.panAlternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panAlternativa.Location = new System.Drawing.Point(522, 18);
            this.panAlternativa.Name = "panAlternativa";
            this.panAlternativa.Size = new System.Drawing.Size(498, 332);
            this.panAlternativa.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 132);
            this.dataGridView1.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 70;
            this.label10.Text = "Alternativas";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(295, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 70;
            this.button2.Text = "Finalizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(156, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 68;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 69;
            this.label9.Text = "Correta:";
            // 
            // ckCorreta
            // 
            this.ckCorreta.AutoSize = true;
            this.ckCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCorreta.Location = new System.Drawing.Point(156, 110);
            this.ckCorreta.Name = "ckCorreta";
            this.ckCorreta.Size = new System.Drawing.Size(15, 14);
            this.ckCorreta.TabIndex = 68;
            this.ckCorreta.UseVisualStyleBackColor = true;
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativa.Location = new System.Drawing.Point(156, 40);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(318, 50);
            this.txtAlternativa.TabIndex = 69;
            this.txtAlternativa.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 68;
            this.label8.Text = "Texto:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(146, 313);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 44);
            this.btnAlterar.TabIndex = 75;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(35, 313);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 44);
            this.btnConfirmar.TabIndex = 76;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(353, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 44);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(243, 313);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(104, 44);
            this.btnInserir.TabIndex = 73;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmQuestaoIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1036, 376);
            this.ControlBox = false;
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.panAlternativa);
            this.Controls.Add(this.panQuestao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmQuestaoIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "s";
            this.panQuestao.ResumeLayout(false);
            this.panQuestao.PerformLayout();
            this.panAlternativa.ResumeLayout(false);
            this.panAlternativa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panQuestao;
        private System.Windows.Forms.ComboBox cmbTpQuestao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.ComboBox cbxAssunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panAlternativa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckCorreta;
        private System.Windows.Forms.RichTextBox txtAlternativa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cckImagem;
        private System.Windows.Forms.RichTextBox txtProfessor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
    }
}
namespace MVC.Telas
{
    partial class frmQuestaoPsq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestaoPsq));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxProf = new System.Windows.Forms.ComboBox();
            this.lstQuestao = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAssunto = new System.Windows.Forms.ComboBox();
            this.cmbTpQuestao = new System.Windows.Forms.ComboBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lstAlternativas = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtAlternativa = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.ckbAddAlter = new System.Windows.Forms.CheckBox();
            this.ckbCorreta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rxtTextoAlternativa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cbxProf);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.lstQuestao);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxAssunto);
            this.panel1.Controls.Add(this.cmbTpQuestao);
            this.panel1.Controls.Add(this.cmbNivel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 506);
            this.panel1.TabIndex = 9;
            // 
            // cbxProf
            // 
            this.cbxProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProf.FormattingEnabled = true;
            this.cbxProf.Location = new System.Drawing.Point(165, 75);
            this.cbxProf.Margin = new System.Windows.Forms.Padding(6);
            this.cbxProf.Name = "cbxProf";
            this.cbxProf.Size = new System.Drawing.Size(318, 32);
            this.cbxProf.TabIndex = 84;
            // 
            // lstQuestao
            // 
            this.lstQuestao.FormattingEnabled = true;
            this.lstQuestao.ItemHeight = 24;
            this.lstQuestao.Location = new System.Drawing.Point(23, 233);
            this.lstQuestao.Name = "lstQuestao";
            this.lstQuestao.Size = new System.Drawing.Size(460, 172);
            this.lstQuestao.TabIndex = 73;
            this.lstQuestao.Click += new System.EventHandler(this.lstQuestao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(174, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Lista de questões:";
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
            this.label6.Location = new System.Drawing.Point(7, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tipo Questão:";
            // 
            // cbxAssunto
            // 
            this.cbxAssunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAssunto.FormattingEnabled = true;
            this.cbxAssunto.Location = new System.Drawing.Point(165, 39);
            this.cbxAssunto.Margin = new System.Windows.Forms.Padding(6);
            this.cbxAssunto.Name = "cbxAssunto";
            this.cbxAssunto.Size = new System.Drawing.Size(318, 32);
            this.cbxAssunto.TabIndex = 65;
            // 
            // cmbTpQuestao
            // 
            this.cmbTpQuestao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTpQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTpQuestao.FormattingEnabled = true;
            this.cmbTpQuestao.Items.AddRange(new object[] {
            "",
            "F",
            "M",
            "D"});
            this.cmbTpQuestao.Location = new System.Drawing.Point(165, 151);
            this.cmbTpQuestao.Name = "cmbTpQuestao";
            this.cmbTpQuestao.Size = new System.Drawing.Size(318, 32);
            this.cmbTpQuestao.TabIndex = 27;
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.ItemHeight = 24;
            this.cmbNivel.Items.AddRange(new object[] {
            "",
            "F",
            "M",
            "D"});
            this.cmbNivel.Location = new System.Drawing.Point(165, 113);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(318, 32);
            this.cmbNivel.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nível";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Assunto:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ckbCorreta);
            this.panel2.Controls.Add(this.rxtTextoAlternativa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ckbAddAlter);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lstAlternativas);
            this.panel2.Controls.Add(this.btnRemover);
            this.panel2.Controls.Add(this.txtAlternativa);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(513, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 506);
            this.panel2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 75;
            this.label8.Text = "Alternativas:";
            // 
            // lstAlternativas
            // 
            this.lstAlternativas.FormattingEnabled = true;
            this.lstAlternativas.ItemHeight = 24;
            this.lstAlternativas.Location = new System.Drawing.Point(146, 217);
            this.lstAlternativas.Name = "lstAlternativas";
            this.lstAlternativas.Size = new System.Drawing.Size(318, 76);
            this.lstAlternativas.TabIndex = 74;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(331, 459);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(133, 44);
            this.btnRemover.TabIndex = 72;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativa.Location = new System.Drawing.Point(146, 39);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(318, 50);
            this.txtAlternativa.TabIndex = 69;
            this.txtAlternativa.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 68;
            this.label12.Text = "Texto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 119);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusca.Location = new System.Drawing.Point(46, 411);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(108, 92);
            this.btnBusca.TabIndex = 76;
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(336, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 92);
            this.btnLimpar.TabIndex = 77;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(155, 411);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 92);
            this.btnEditar.TabIndex = 78;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(247, 411);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 92);
            this.btnExcluir.TabIndex = 79;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(146, 459);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 44);
            this.btnAdicionar.TabIndex = 69;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // ckbAddAlter
            // 
            this.ckbAddAlter.AutoSize = true;
            this.ckbAddAlter.Location = new System.Drawing.Point(146, 299);
            this.ckbAddAlter.Name = "ckbAddAlter";
            this.ckbAddAlter.Size = new System.Drawing.Size(209, 28);
            this.ckbAddAlter.TabIndex = 77;
            this.ckbAddAlter.Text = "Adicionar Alternativas";
            this.ckbAddAlter.UseVisualStyleBackColor = true;
            this.ckbAddAlter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbCorreta
            // 
            this.ckbCorreta.AutoSize = true;
            this.ckbCorreta.Enabled = false;
            this.ckbCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCorreta.Location = new System.Drawing.Point(146, 389);
            this.ckbCorreta.Name = "ckbCorreta";
            this.ckbCorreta.Size = new System.Drawing.Size(90, 28);
            this.ckbCorreta.TabIndex = 78;
            this.ckbCorreta.Text = "Correta";
            this.ckbCorreta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Texto:";
            // 
            // rxtTextoAlternativa
            // 
            this.rxtTextoAlternativa.Enabled = false;
            this.rxtTextoAlternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxtTextoAlternativa.Location = new System.Drawing.Point(146, 333);
            this.rxtTextoAlternativa.Name = "rxtTextoAlternativa";
            this.rxtTextoAlternativa.Size = new System.Drawing.Size(318, 50);
            this.rxtTextoAlternativa.TabIndex = 81;
            this.rxtTextoAlternativa.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Imagem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 24);
            this.label9.TabIndex = 83;
            this.label9.Text = "Não há imagens a serem mostradas";
            this.label9.Visible = false;
            // 
            // frmQuestaoPsq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1095, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestaoPsq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmQuestaoPsq";
            this.Load += new System.EventHandler(this.frmQuestaoPsq_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAssunto;
        private System.Windows.Forms.ComboBox cmbTpQuestao;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtAlternativa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstQuestao;
        private System.Windows.Forms.ComboBox cbxProf;
        private System.Windows.Forms.ListBox lstAlternativas;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbAddAlter;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox ckbCorreta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rxtTextoAlternativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;

    }
}
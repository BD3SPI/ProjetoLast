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
            this.panBusca = new System.Windows.Forms.Panel();
            this.cbxProf = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lstQuestao = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAssunto = new System.Windows.Forms.ComboBox();
            this.cmbTpQuestao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panAlterar = new System.Windows.Forms.Panel();
            this.txtquestao = new System.Windows.Forms.RichTextBox();
            this.dgvAlternativa = new System.Windows.Forms.DataGridView();
            this.llbImagem = new System.Windows.Forms.LinkLabel();
            this.lblImagem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlternativa = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ckbCorreta = new System.Windows.Forms.CheckBox();
            this.rxtTextoAlternativa = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbAddAlter = new System.Windows.Forms.CheckBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCadastrarimagem = new System.Windows.Forms.Button();
            this.panBusca.SuspendLayout();
            this.panAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panBusca
            // 
            this.panBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panBusca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panBusca.Controls.Add(this.cbxProf);
            this.panBusca.Controls.Add(this.btnExcluir);
            this.panBusca.Controls.Add(this.lstQuestao);
            this.panBusca.Controls.Add(this.btnEditar);
            this.panBusca.Controls.Add(this.btnLimpar);
            this.panBusca.Controls.Add(this.label10);
            this.panBusca.Controls.Add(this.btnBusca);
            this.panBusca.Controls.Add(this.label7);
            this.panBusca.Controls.Add(this.label6);
            this.panBusca.Controls.Add(this.cbxAssunto);
            this.panBusca.Controls.Add(this.cmbTpQuestao);
            this.panBusca.Controls.Add(this.label3);
            this.panBusca.Controls.Add(this.label2);
            this.panBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panBusca.Location = new System.Drawing.Point(14, 55);
            this.panBusca.Margin = new System.Windows.Forms.Padding(6);
            this.panBusca.Name = "panBusca";
            this.panBusca.Size = new System.Drawing.Size(489, 506);
            this.panBusca.TabIndex = 9;
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
            // lstQuestao
            // 
            this.lstQuestao.FormattingEnabled = true;
            this.lstQuestao.ItemHeight = 24;
            this.lstQuestao.Location = new System.Drawing.Point(11, 195);
            this.lstQuestao.Name = "lstQuestao";
            this.lstQuestao.Size = new System.Drawing.Size(472, 196);
            this.lstQuestao.TabIndex = 73;
            this.lstQuestao.Click += new System.EventHandler(this.lstQuestao_Click);
            this.lstQuestao.SelectedIndexChanged += new System.EventHandler(this.lstQuestao_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Lista de questões";
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
            this.label6.Location = new System.Drawing.Point(7, 115);
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
            this.cmbTpQuestao.Location = new System.Drawing.Point(165, 112);
            this.cmbTpQuestao.Name = "cmbTpQuestao";
            this.cmbTpQuestao.Size = new System.Drawing.Size(318, 32);
            this.cmbTpQuestao.TabIndex = 27;
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
            // panAlterar
            // 
            this.panAlterar.Controls.Add(this.btnCadastrarimagem);
            this.panAlterar.Controls.Add(this.txtquestao);
            this.panAlterar.Controls.Add(this.dgvAlternativa);
            this.panAlterar.Controls.Add(this.llbImagem);
            this.panAlterar.Controls.Add(this.lblImagem);
            this.panAlterar.Controls.Add(this.label5);
            this.panAlterar.Controls.Add(this.pictureBox1);
            this.panAlterar.Controls.Add(this.label8);
            this.panAlterar.Controls.Add(this.txtAlternativa);
            this.panAlterar.Controls.Add(this.label12);
            this.panAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panAlterar.Location = new System.Drawing.Point(513, 15);
            this.panAlterar.Name = "panAlterar";
            this.panAlterar.Size = new System.Drawing.Size(570, 413);
            this.panAlterar.TabIndex = 10;
            // 
            // txtquestao
            // 
            this.txtquestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquestao.Location = new System.Drawing.Point(146, 3);
            this.txtquestao.Name = "txtquestao";
            this.txtquestao.Size = new System.Drawing.Size(375, 56);
            this.txtquestao.TabIndex = 87;
            this.txtquestao.Text = "";
            // 
            // dgvAlternativa
            // 
            this.dgvAlternativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlternativa.Location = new System.Drawing.Point(146, 332);
            this.dgvAlternativa.Name = "dgvAlternativa";
            this.dgvAlternativa.Size = new System.Drawing.Size(375, 78);
            this.dgvAlternativa.TabIndex = 86;
            // 
            // llbImagem
            // 
            this.llbImagem.AutoSize = true;
            this.llbImagem.Location = new System.Drawing.Point(167, 206);
            this.llbImagem.Name = "llbImagem";
            this.llbImagem.Size = new System.Drawing.Size(348, 24);
            this.llbImagem.TabIndex = 85;
            this.llbImagem.TabStop = true;
            this.llbImagem.Text = "Clique aqui para cadastrar uma imagem.";
            this.llbImagem.Visible = false;
            this.llbImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbImagem_LinkClicked);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(212, 180);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(253, 24);
            this.lblImagem.TabIndex = 84;
            this.lblImagem.Text = "Não há imagens cadastradas";
            this.lblImagem.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Imagem:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 75;
            this.label8.Text = "Alternativas:";
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativa.Location = new System.Drawing.Point(94, 9);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(46, 46);
            this.txtAlternativa.TabIndex = 69;
            this.txtAlternativa.Text = "";
            this.txtAlternativa.TextChanged += new System.EventHandler(this.txtAlternativa_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 68;
            this.label12.Text = "Texto:";
            // 
            // ckbCorreta
            // 
            this.ckbCorreta.AutoSize = true;
            this.ckbCorreta.Enabled = false;
            this.ckbCorreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCorreta.Location = new System.Drawing.Point(652, 524);
            this.ckbCorreta.Name = "ckbCorreta";
            this.ckbCorreta.Size = new System.Drawing.Size(90, 28);
            this.ckbCorreta.TabIndex = 84;
            this.ckbCorreta.Text = "Correta";
            this.ckbCorreta.UseVisualStyleBackColor = true;
            // 
            // rxtTextoAlternativa
            // 
            this.rxtTextoAlternativa.Enabled = false;
            this.rxtTextoAlternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxtTextoAlternativa.Location = new System.Drawing.Point(652, 468);
            this.rxtTextoAlternativa.Name = "rxtTextoAlternativa";
            this.rxtTextoAlternativa.Size = new System.Drawing.Size(375, 50);
            this.rxtTextoAlternativa.TabIndex = 86;
            this.rxtTextoAlternativa.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "Texto:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(652, 554);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 44);
            this.btnAdicionar.TabIndex = 82;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(810, 554);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(133, 44);
            this.btnRemover.TabIndex = 83;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(949, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 44);
            this.btnCancelar.TabIndex = 87;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbAddAlter
            // 
            this.ckbAddAlter.AutoSize = true;
            this.ckbAddAlter.Location = new System.Drawing.Point(652, 434);
            this.ckbAddAlter.Name = "ckbAddAlter";
            this.ckbAddAlter.Size = new System.Drawing.Size(209, 28);
            this.ckbAddAlter.TabIndex = 88;
            this.ckbAddAlter.Text = "Adicionar Alternativas";
            this.ckbAddAlter.UseVisualStyleBackColor = true;
            this.ckbAddAlter.CheckedChanged += new System.EventHandler(this.ckbAddAlter_CheckedChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(513, 554);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(133, 44);
            this.btnFinalizar.TabIndex = 89;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarimagem
            // 
            this.btnCadastrarimagem.Enabled = false;
            this.btnCadastrarimagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarimagem.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarimagem.Image")));
            this.btnCadastrarimagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarimagem.Location = new System.Drawing.Point(170, 72);
            this.btnCadastrarimagem.Name = "btnCadastrarimagem";
            this.btnCadastrarimagem.Size = new System.Drawing.Size(97, 44);
            this.btnCadastrarimagem.TabIndex = 90;
            this.btnCadastrarimagem.Text = "Adicionar";
            this.btnCadastrarimagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarimagem.UseVisualStyleBackColor = true;
            this.btnCadastrarimagem.Click += new System.EventHandler(this.btnCadastrarimagem_Click);
            // 
            // frmQuestaoPsq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1093, 610);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.ckbAddAlter);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ckbCorreta);
            this.Controls.Add(this.rxtTextoAlternativa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.panAlterar);
            this.Controls.Add(this.panBusca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestaoPsq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestaoPsq";
            this.Load += new System.EventHandler(this.frmQuestaoPsq_Load);
            this.panBusca.ResumeLayout(false);
            this.panBusca.PerformLayout();
            this.panAlterar.ResumeLayout(false);
            this.panAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAssunto;
        private System.Windows.Forms.ComboBox cmbTpQuestao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panAlterar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtAlternativa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstQuestao;
        private System.Windows.Forms.ComboBox cbxProf;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llbImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.CheckBox ckbCorreta;
        private System.Windows.Forms.RichTextBox rxtTextoAlternativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbAddAlter;
        private System.Windows.Forms.DataGridView dgvAlternativa;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.RichTextBox txtquestao;
        private System.Windows.Forms.Button btnCadastrarimagem;
    }
}
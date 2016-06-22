namespace MVC.Telas
{
    partial class frmQuestaoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestaoEvento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbCarrega = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTira = new System.Windows.Forms.Button();
            this.btnInseri = new System.Windows.Forms.Button();
            this.txtQuestao = new System.Windows.Forms.TextBox();
            this.cbxAssunto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEvento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbCarrega);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnTira);
            this.panel1.Controls.Add(this.btnInseri);
            this.panel1.Controls.Add(this.txtQuestao);
            this.panel1.Controls.Add(this.cbxAssunto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxEvento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 625);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckbCarrega
            // 
            this.ckbCarrega.AutoSize = true;
            this.ckbCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCarrega.Location = new System.Drawing.Point(577, 27);
            this.ckbCarrega.Name = "ckbCarrega";
            this.ckbCarrega.Size = new System.Drawing.Size(268, 26);
            this.ckbCarrega.TabIndex = 39;
            this.ckbCarrega.Text = "Exibir Perguntas relacionadas";
            this.ckbCarrega.UseVisualStyleBackColor = true;
            this.ckbCarrega.CheckedChanged += new System.EventHandler(this.ckbCarrega_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(140, 109);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 27);
            this.txtID.TabIndex = 38;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(140, 201);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(562, 174);
            this.dataGridView2.TabIndex = 37;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 447);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 175);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTira
            // 
            this.btnTira.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTira.Image = ((System.Drawing.Image)(resources.GetObject("btnTira.Image")));
            this.btnTira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTira.Location = new System.Drawing.Point(471, 381);
            this.btnTira.Name = "btnTira";
            this.btnTira.Size = new System.Drawing.Size(152, 51);
            this.btnTira.TabIndex = 35;
            this.btnTira.Text = "Remover";
            this.btnTira.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTira.UseVisualStyleBackColor = true;
            this.btnTira.Click += new System.EventHandler(this.btnTira_Click_1);
            // 
            // btnInseri
            // 
            this.btnInseri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInseri.Image = ((System.Drawing.Image)(resources.GetObject("btnInseri.Image")));
            this.btnInseri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInseri.Location = new System.Drawing.Point(234, 381);
            this.btnInseri.Name = "btnInseri";
            this.btnInseri.Size = new System.Drawing.Size(152, 51);
            this.btnInseri.TabIndex = 34;
            this.btnInseri.Text = "Adicionar";
            this.btnInseri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInseri.UseVisualStyleBackColor = true;
            this.btnInseri.Click += new System.EventHandler(this.btnInseri_Click_1);
            // 
            // txtQuestao
            // 
            this.txtQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestao.Location = new System.Drawing.Point(140, 142);
            this.txtQuestao.Multiline = true;
            this.txtQuestao.Name = "txtQuestao";
            this.txtQuestao.Size = new System.Drawing.Size(562, 52);
            this.txtQuestao.TabIndex = 33;
            // 
            // cbxAssunto
            // 
            this.cbxAssunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAssunto.FormattingEnabled = true;
            this.cbxAssunto.Location = new System.Drawing.Point(140, 75);
            this.cbxAssunto.Name = "cbxAssunto";
            this.cbxAssunto.Size = new System.Drawing.Size(371, 28);
            this.cbxAssunto.TabIndex = 32;
            this.cbxAssunto.SelectedIndexChanged += new System.EventHandler(this.cbxAssunto_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Assunto";
            // 
            // cbxEvento
            // 
            this.cbxEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvento.FormattingEnabled = true;
            this.cbxEvento.Location = new System.Drawing.Point(140, 26);
            this.cbxEvento.Name = "cbxEvento";
            this.cbxEvento.Size = new System.Drawing.Size(371, 28);
            this.cbxEvento.TabIndex = 30;
            this.cbxEvento.SelectedIndexChanged += new System.EventHandler(this.cbxEvento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Evento";
            // 
            // frmQuestaoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(882, 649);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestaoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questões por Evento";
            this.Load += new System.EventHandler(this.frmQuestaoEvento_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbCarrega;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTira;
        private System.Windows.Forms.Button btnInseri;
        private System.Windows.Forms.TextBox txtQuestao;
        private System.Windows.Forms.ComboBox cbxAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEvento;
        private System.Windows.Forms.Label label1;

    }
}
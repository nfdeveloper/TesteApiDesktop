namespace TesteApiDesktop
{
    partial class DevolucaoPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txt_dataInicio = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisarDevolucao15dias = new System.Windows.Forms.Button();
            this.btn_pesquisarDevolucao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_devolucoes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_geratxt = new System.Windows.Forms.Button();
            this.btn_gerarcsv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devolucoes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dataFinal);
            this.groupBox1.Controls.Add(this.txt_dataInicio);
            this.groupBox1.Controls.Add(this.btn_pesquisarDevolucao15dias);
            this.groupBox1.Controls.Add(this.btn_pesquisarDevolucao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolução";
            // 
            // txt_dataFinal
            // 
            this.txt_dataFinal.Location = new System.Drawing.Point(35, 138);
            this.txt_dataFinal.Mask = "99-99-9999";
            this.txt_dataFinal.Name = "txt_dataFinal";
            this.txt_dataFinal.Size = new System.Drawing.Size(160, 23);
            this.txt_dataFinal.TabIndex = 13;
            // 
            // txt_dataInicio
            // 
            this.txt_dataInicio.Location = new System.Drawing.Point(35, 65);
            this.txt_dataInicio.Mask = "99-99-9999";
            this.txt_dataInicio.Name = "txt_dataInicio";
            this.txt_dataInicio.Size = new System.Drawing.Size(160, 23);
            this.txt_dataInicio.TabIndex = 12;
            // 
            // btn_pesquisarDevolucao15dias
            // 
            this.btn_pesquisarDevolucao15dias.Location = new System.Drawing.Point(383, 138);
            this.btn_pesquisarDevolucao15dias.Name = "btn_pesquisarDevolucao15dias";
            this.btn_pesquisarDevolucao15dias.Size = new System.Drawing.Size(145, 23);
            this.btn_pesquisarDevolucao15dias.TabIndex = 11;
            this.btn_pesquisarDevolucao15dias.Text = "Devolução 15 dias";
            this.btn_pesquisarDevolucao15dias.UseVisualStyleBackColor = true;
            this.btn_pesquisarDevolucao15dias.Click += new System.EventHandler(this.btn_pesquisarDevolucao15dias_Click);
            // 
            // btn_pesquisarDevolucao
            // 
            this.btn_pesquisarDevolucao.Location = new System.Drawing.Point(241, 138);
            this.btn_pesquisarDevolucao.Name = "btn_pesquisarDevolucao";
            this.btn_pesquisarDevolucao.Size = new System.Drawing.Size(99, 23);
            this.btn_pesquisarDevolucao.TabIndex = 10;
            this.btn_pesquisarDevolucao.Text = "Pesquisar";
            this.btn_pesquisarDevolucao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Inicial:";
            // 
            // dgv_devolucoes
            // 
            this.dgv_devolucoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_devolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devolucoes.Location = new System.Drawing.Point(13, 196);
            this.dgv_devolucoes.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_devolucoes.Name = "dgv_devolucoes";
            this.dgv_devolucoes.Size = new System.Drawing.Size(1112, 324);
            this.dgv_devolucoes.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_geratxt);
            this.groupBox2.Controls.Add(this.btn_gerarcsv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(13, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btn_geratxt
            // 
            this.btn_geratxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_geratxt.Location = new System.Drawing.Point(379, 33);
            this.btn_geratxt.Name = "btn_geratxt";
            this.btn_geratxt.Size = new System.Drawing.Size(174, 34);
            this.btn_geratxt.TabIndex = 3;
            this.btn_geratxt.Text = "Gerar TXT";
            this.btn_geratxt.UseVisualStyleBackColor = true;
            this.btn_geratxt.Click += new System.EventHandler(this.btn_geratxt_Click);
            // 
            // btn_gerarcsv
            // 
            this.btn_gerarcsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_gerarcsv.Location = new System.Drawing.Point(584, 33);
            this.btn_gerarcsv.Name = "btn_gerarcsv";
            this.btn_gerarcsv.Size = new System.Drawing.Size(174, 34);
            this.btn_gerarcsv.TabIndex = 4;
            this.btn_gerarcsv.Text = "Gerar CSV";
            this.btn_gerarcsv.UseVisualStyleBackColor = true;
            this.btn_gerarcsv.Click += new System.EventHandler(this.btn_gerarcsv_Click);
            // 
            // DevolucaoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_devolucoes);
            this.Controls.Add(this.groupBox1);
            this.Name = "DevolucaoPage";
            this.Text = "Devolução";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevolucaoPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devolucoes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_dataFinal;
        private System.Windows.Forms.MaskedTextBox txt_dataInicio;
        private System.Windows.Forms.Button btn_pesquisarDevolucao15dias;
        private System.Windows.Forms.Button btn_pesquisarDevolucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_devolucoes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_geratxt;
        private System.Windows.Forms.Button btn_gerarcsv;
    }
}
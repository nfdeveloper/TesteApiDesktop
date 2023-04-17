namespace TesteApiDesktop
{
    partial class VendaPage
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
            this.btn_pesquisarVendaDiaAnterior = new System.Windows.Forms.Button();
            this.btn_pesquisarVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geratxt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_vendas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_dataFinal);
            this.groupBox1.Controls.Add(this.txt_dataInicio);
            this.groupBox1.Controls.Add(this.btn_pesquisarVendaDiaAnterior);
            this.groupBox1.Controls.Add(this.btn_pesquisarVenda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_dataFinal
            // 
            this.txt_dataFinal.Location = new System.Drawing.Point(48, 132);
            this.txt_dataFinal.Mask = "99-99-9999";
            this.txt_dataFinal.Name = "txt_dataFinal";
            this.txt_dataFinal.Size = new System.Drawing.Size(160, 23);
            this.txt_dataFinal.TabIndex = 7;
            // 
            // txt_dataInicio
            // 
            this.txt_dataInicio.Location = new System.Drawing.Point(48, 59);
            this.txt_dataInicio.Mask = "99-99-9999";
            this.txt_dataInicio.Name = "txt_dataInicio";
            this.txt_dataInicio.Size = new System.Drawing.Size(160, 23);
            this.txt_dataInicio.TabIndex = 6;
            this.txt_dataInicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_dataInicio_MaskInputRejected);
            // 
            // btn_pesquisarVendaDiaAnterior
            // 
            this.btn_pesquisarVendaDiaAnterior.Location = new System.Drawing.Point(396, 132);
            this.btn_pesquisarVendaDiaAnterior.Name = "btn_pesquisarVendaDiaAnterior";
            this.btn_pesquisarVendaDiaAnterior.Size = new System.Drawing.Size(145, 23);
            this.btn_pesquisarVendaDiaAnterior.TabIndex = 5;
            this.btn_pesquisarVendaDiaAnterior.Text = "Venda Dia Anterior";
            this.btn_pesquisarVendaDiaAnterior.UseVisualStyleBackColor = true;
            this.btn_pesquisarVendaDiaAnterior.Click += new System.EventHandler(this.btn_pesquisarVendaDiaAnterior_Click);
            // 
            // btn_pesquisarVenda
            // 
            this.btn_pesquisarVenda.Location = new System.Drawing.Point(254, 132);
            this.btn_pesquisarVenda.Name = "btn_pesquisarVenda";
            this.btn_pesquisarVenda.Size = new System.Drawing.Size(99, 23);
            this.btn_pesquisarVenda.TabIndex = 4;
            this.btn_pesquisarVenda.Text = "Pesquisar";
            this.btn_pesquisarVenda.UseVisualStyleBackColor = true;
            this.btn_pesquisarVenda.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_geratxt
            // 
            this.btn_geratxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_geratxt.Location = new System.Drawing.Point(320, 35);
            this.btn_geratxt.Name = "btn_geratxt";
            this.btn_geratxt.Size = new System.Drawing.Size(174, 34);
            this.btn_geratxt.TabIndex = 3;
            this.btn_geratxt.Text = "Gerar TXT";
            this.btn_geratxt.UseVisualStyleBackColor = true;
            this.btn_geratxt.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.Location = new System.Drawing.Point(524, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gerar CSV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_vendas
            // 
            this.dgv_vendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendas.Location = new System.Drawing.Point(19, 211);
            this.dgv_vendas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_vendas.Name = "dgv_vendas";
            this.dgv_vendas.Size = new System.Drawing.Size(1032, 262);
            this.dgv_vendas.TabIndex = 0;
            this.dgv_vendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_geratxt);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(19, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // VendaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_vendas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendaPage";
            this.Text = "Pesquisa de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendaPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pesquisarVenda;
        private System.Windows.Forms.Button btn_pesquisarVendaDiaAnterior;
        private System.Windows.Forms.Button btn_geratxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_vendas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txt_dataFinal;
        private System.Windows.Forms.MaskedTextBox txt_dataInicio;
    }
}
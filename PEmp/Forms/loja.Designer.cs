namespace PEmp.Forms
{
    partial class loja
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_codProduto = new System.Windows.Forms.ComboBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lvCarrinho = new System.Windows.Forms.ListView();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Produto = new System.Windows.Forms.ColumnHeader();
            this.Quantidade = new System.Windows.Forms.ColumnHeader();
            this.Valor = new System.Windows.Forms.ColumnHeader();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(103, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Cliente: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(417, 23);
            this.txtNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data de nascimento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefone 2:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(502, 90);
            this.txtTel1.Mask = "(99) 00000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(145, 23);
            this.txtTel1.TabIndex = 11;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(502, 134);
            this.txtTel2.Mask = "(99) 00000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(145, 23);
            this.txtTel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "LOJA";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(259, 95);
            this.txtCpf.Mask = "000000000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(98, 23);
            this.txtCpf.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(800, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Carrinho";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(140, 95);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(63, 23);
            this.txtData.TabIndex = 18;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Enabled = false;
            this.btnSalvarCliente.Location = new System.Drawing.Point(572, 173);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(75, 38);
            this.btnSalvarCliente.TabIndex = 19;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "COD. Produto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nome: ";
            // 
            // cb_codProduto
            // 
            this.cb_codProduto.FormattingEnabled = true;
            this.cb_codProduto.Location = new System.Drawing.Point(114, 243);
            this.cb_codProduto.Name = "cb_codProduto";
            this.cb_codProduto.Size = new System.Drawing.Size(145, 23);
            this.cb_codProduto.TabIndex = 23;
            this.cb_codProduto.Text = "[SELECIONE]";
            this.cb_codProduto.SelectedIndexChanged += new System.EventHandler(this.cb_codProduto_SelectedIndexChanged);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(76, 276);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(355, 23);
            this.txtNomeProd.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quantidade: ";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(105, 315);
            this.txtQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(55, 23);
            this.txtQtd.TabIndex = 27;
            this.txtQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Estoque: ";
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Location = new System.Drawing.Point(227, 317);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(13, 15);
            this.lblQtdEstoque.TabIndex = 29;
            this.lblQtdEstoque.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Incluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(20, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 28);
            this.label13.TabIndex = 32;
            this.label13.Text = "Pagamento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(240, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 28);
            this.label14.TabIndex = 33;
            this.label14.Text = "Produto";
            // 
            // cbPagamento
            // 
            this.cbPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Location = new System.Drawing.Point(153, 434);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(127, 23);
            this.cbPagamento.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 437);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Forma de pagamentos: ";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(577, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 28);
            this.label16.TabIndex = 36;
            this.label16.Text = "Total:  R$";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(669, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 28);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "00,00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(302, 246);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 15);
            this.label18.TabIndex = 38;
            this.label18.Text = "Valor:  R$";
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Location = new System.Drawing.Point(363, 246);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(34, 15);
            this.lblValorProduto.TabIndex = 39;
            this.lblValorProduto.Text = "00,00";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(476, 458);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(82, 70);
            this.btnFinalizar.TabIndex = 40;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(363, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 70);
            this.button5.TabIndex = 41;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lvCarrinho
            // 
            this.lvCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCarrinho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CPF,
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.lvCarrinho.FullRowSelect = true;
            this.lvCarrinho.Location = new System.Drawing.Point(714, 52);
            this.lvCarrinho.Name = "lvCarrinho";
            this.lvCarrinho.Size = new System.Drawing.Size(312, 396);
            this.lvCarrinho.TabIndex = 42;
            this.lvCarrinho.UseCompatibleStateImageBehavior = false;
            this.lvCarrinho.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCarrinho_MouseDoubleClick);
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // Produto
            // 
            this.Produto.Text = "C.Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 43;
            this.lblData.Text = "Data";
            // 
            // loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lvCarrinho);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.cb_codProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "loja";
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.loja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private MaskedTextBox txtTel1;
        private MaskedTextBox txtTel2;
        private Label label6;
        private MaskedTextBox txtCpf;
        private Label label8;
        private MaskedTextBox txtData;
        private Button btnSalvarCliente;
        private Label label7;
        private Label label9;
        private ComboBox cb_codProduto;
        private TextBox txtNomeProd;
        private Label label10;
        private NumericUpDown txtQtd;
        private Label label11;
        private Label lblQtdEstoque;
        private Button button2;
        private Button button3;
        private Label label13;
        private Label label14;
        private ComboBox cbPagamento;
        private Label label15;
        private Label label16;
        private Label lblTotal;
        private Label label18;
        private Label lblValorProduto;
        private Button btnFinalizar;
        private Button button5;
        private ListView lvCarrinho;
        private ColumnHeader CPF;
        private ColumnHeader Produto;
        private ColumnHeader Quantidade;
        private ColumnHeader Valor;
        private Label lblData;
    }
}
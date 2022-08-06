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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 23);
            this.textBox3.TabIndex = 9;
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(259, 95);
            this.maskedTextBox1.Mask = "000000000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(98, 23);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(834, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Carrinho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(712, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(335, 287);
            this.dataGridView1.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(140, 95);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(63, 23);
            this.maskedTextBox2.TabIndex = 18;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Name = "loja";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private MaskedTextBox txtTel1;
        private MaskedTextBox txtTel2;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox2;
    }
}
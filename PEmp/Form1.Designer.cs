namespace PEmp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoja = new System.Windows.Forms.Button();
            this.ofdBanco = new System.Windows.Forms.OpenFileDialog();
            this.btnBanco = new System.Windows.Forms.Button();
            this.lblconn = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoja
            // 
            this.btnLoja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoja.Location = new System.Drawing.Point(115, 92);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(239, 220);
            this.btnLoja.TabIndex = 1;
            this.btnLoja.Text = "LOJA";
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // ofdBanco
            // 
            this.ofdBanco.FileName = "openFileDialog1";
            // 
            // btnBanco
            // 
            this.btnBanco.Location = new System.Drawing.Point(692, 415);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(75, 23);
            this.btnBanco.TabIndex = 2;
            this.btnBanco.Text = "Banco";
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // lblconn
            // 
            this.lblconn.AutoSize = true;
            this.lblconn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblconn.Location = new System.Drawing.Point(594, 419);
            this.lblconn.Name = "lblconn";
            this.lblconn.Size = new System.Drawing.Size(80, 15);
            this.lblconn.TabIndex = 3;
            this.lblconn.Text = "DESATIVADO";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(527, 419);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Conexão: ";
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstoque.Location = new System.Drawing.Point(498, 92);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(239, 220);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblconn);
            this.Controls.Add(this.btnBanco);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.btnEstoque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLoja;
        private OpenFileDialog ofdBanco;
        private Button btnBanco;
        private Label lblconn;
        private Label lblStatus;
        private Button btnEstoque;
    }
}
namespace Encrypt
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCeasar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDeCeasar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCeasar = new System.Windows.Forms.TabPage();
            this.txtDoDoi = new System.Windows.Forms.TextBox();
            this.tabVigen = new System.Windows.Forms.TabPage();
            this.txtVKey = new System.Windows.Forms.TextBox();
            this.txtVInput = new System.Windows.Forms.TextBox();
            this.txtVResult = new System.Windows.Forms.TextBox();
            this.btnVigenereEncrypt = new System.Windows.Forms.Button();
            this.btnVigenereDecrypt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCeasar.SuspendLayout();
            this.tabVigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(127, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnCeasar
            // 
            this.btnCeasar.Location = new System.Drawing.Point(6, 121);
            this.btnCeasar.Name = "btnCeasar";
            this.btnCeasar.Size = new System.Drawing.Size(100, 23);
            this.btnCeasar.TabIndex = 1;
            this.btnCeasar.Text = "Encrypt";
            this.btnCeasar.UseVisualStyleBackColor = true;
            this.btnCeasar.Click += new System.EventHandler(this.btnCeasar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(182, 72);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 20);
            this.txtResult.TabIndex = 2;
            // 
            // btnDeCeasar
            // 
            this.btnDeCeasar.Location = new System.Drawing.Point(123, 121);
            this.btnDeCeasar.Name = "btnDeCeasar";
            this.btnDeCeasar.Size = new System.Drawing.Size(100, 23);
            this.btnDeCeasar.TabIndex = 3;
            this.btnDeCeasar.Text = "Decrypt";
            this.btnDeCeasar.UseVisualStyleBackColor = true;
            this.btnDeCeasar.Click += new System.EventHandler(this.btnDeCeasar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCeasar);
            this.tabControl1.Controls.Add(this.tabVigen);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 304);
            this.tabControl1.TabIndex = 4;
            // 
            // tabCeasar
            // 
            this.tabCeasar.Controls.Add(this.txtDoDoi);
            this.tabCeasar.Controls.Add(this.btnCeasar);
            this.tabCeasar.Controls.Add(this.btnDeCeasar);
            this.tabCeasar.Controls.Add(this.txtResult);
            this.tabCeasar.Controls.Add(this.txtInput);
            this.tabCeasar.Location = new System.Drawing.Point(4, 22);
            this.tabCeasar.Name = "tabCeasar";
            this.tabCeasar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCeasar.Size = new System.Drawing.Size(768, 278);
            this.tabCeasar.TabIndex = 0;
            this.tabCeasar.Text = "Ceasar";
            this.tabCeasar.UseVisualStyleBackColor = true;
            // 
            // txtDoDoi
            // 
            this.txtDoDoi.Location = new System.Drawing.Point(6, 17);
            this.txtDoDoi.Name = "txtDoDoi";
            this.txtDoDoi.Size = new System.Drawing.Size(100, 20);
            this.txtDoDoi.TabIndex = 4;
            // 
            // tabVigen
            // 
            this.tabVigen.Controls.Add(this.btnVigenereDecrypt);
            this.tabVigen.Controls.Add(this.btnVigenereEncrypt);
            this.tabVigen.Controls.Add(this.txtVResult);
            this.tabVigen.Controls.Add(this.txtVInput);
            this.tabVigen.Controls.Add(this.txtVKey);
            this.tabVigen.Location = new System.Drawing.Point(4, 22);
            this.tabVigen.Name = "tabVigen";
            this.tabVigen.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigen.Size = new System.Drawing.Size(768, 278);
            this.tabVigen.TabIndex = 1;
            this.tabVigen.Text = "Vigenere";
            this.tabVigen.UseVisualStyleBackColor = true;
            // 
            // txtVKey
            // 
            this.txtVKey.Location = new System.Drawing.Point(7, 16);
            this.txtVKey.Name = "txtVKey";
            this.txtVKey.Size = new System.Drawing.Size(100, 20);
            this.txtVKey.TabIndex = 0;
            // 
            // txtVInput
            // 
            this.txtVInput.Location = new System.Drawing.Point(7, 62);
            this.txtVInput.Name = "txtVInput";
            this.txtVInput.Size = new System.Drawing.Size(143, 20);
            this.txtVInput.TabIndex = 1;
            // 
            // txtVResult
            // 
            this.txtVResult.Location = new System.Drawing.Point(186, 62);
            this.txtVResult.Name = "txtVResult";
            this.txtVResult.Size = new System.Drawing.Size(143, 20);
            this.txtVResult.TabIndex = 2;
            // 
            // btnVigenereEncrypt
            // 
            this.btnVigenereEncrypt.Location = new System.Drawing.Point(7, 106);
            this.btnVigenereEncrypt.Name = "btnVigenereEncrypt";
            this.btnVigenereEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnVigenereEncrypt.TabIndex = 3;
            this.btnVigenereEncrypt.Text = "Encrypt";
            this.btnVigenereEncrypt.UseVisualStyleBackColor = true;
            this.btnVigenereEncrypt.Click += new System.EventHandler(this.btnVigenereEncrypt_Click);
            // 
            // btnVigenereDecrypt
            // 
            this.btnVigenereDecrypt.Location = new System.Drawing.Point(88, 106);
            this.btnVigenereDecrypt.Name = "btnVigenereDecrypt";
            this.btnVigenereDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnVigenereDecrypt.TabIndex = 4;
            this.btnVigenereDecrypt.Text = "Decrypt";
            this.btnVigenereDecrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabCeasar.ResumeLayout(false);
            this.tabCeasar.PerformLayout();
            this.tabVigen.ResumeLayout(false);
            this.tabVigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCeasar;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDeCeasar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCeasar;
        private System.Windows.Forms.TabPage tabVigen;
        private System.Windows.Forms.TextBox txtDoDoi;
        private System.Windows.Forms.Button btnVigenereDecrypt;
        private System.Windows.Forms.Button btnVigenereEncrypt;
        private System.Windows.Forms.TextBox txtVResult;
        private System.Windows.Forms.TextBox txtVInput;
        private System.Windows.Forms.TextBox txtVKey;
    }
}


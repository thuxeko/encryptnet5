
namespace EncryptTool
{
    partial class mainForm
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRSA = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(7, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(404, 112);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(7, 23);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(404, 112);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbShowHide);
            this.groupBox3.Controls.Add(this.txtPassphrase);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rbRSA);
            this.groupBox3.Controls.Add(this.rbAES);
            this.groupBox3.Location = new System.Drawing.Point(436, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // cbShowHide
            // 
            this.cbShowHide.AutoSize = true;
            this.cbShowHide.Location = new System.Drawing.Point(262, 46);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(15, 14);
            this.cbShowHide.TabIndex = 5;
            this.cbShowHide.UseVisualStyleBackColor = true;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.cbShowHide_CheckedChanged);
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(93, 43);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.PasswordChar = '*';
            this.txtPassphrase.Size = new System.Drawing.Size(163, 23);
            this.txtPassphrase.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passphrase:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encrypt Type:";
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(144, 23);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(46, 19);
            this.rbRSA.TabIndex = 1;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Checked = true;
            this.rbAES.Location = new System.Drawing.Point(93, 23);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(45, 19);
            this.rbAES.TabIndex = 0;
            this.rbAES.TabStop = true;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(436, 99);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(284, 23);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(436, 128);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(283, 23);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(436, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note: Output auto copy to clipboard";
            // 
            // btnQr
            // 
            this.btnQr.Location = new System.Drawing.Point(580, 157);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(139, 23);
            this.btnQr.TabIndex = 6;
            this.btnQr.Text = "QR Output";
            this.btnQr.UseVisualStyleBackColor = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 308);
            this.Controls.Add(this.btnQr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Tool Encrypt - Decrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.RadioButton rbRSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.CheckBox cbShowHide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQr;
    }
}
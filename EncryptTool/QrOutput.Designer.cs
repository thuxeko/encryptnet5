
namespace EncryptTool
{
    partial class QrOutput
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
            this.pbQrCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQrCode
            // 
            this.pbQrCode.Location = new System.Drawing.Point(12, 12);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(300, 300);
            this.pbQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQrCode.TabIndex = 0;
            this.pbQrCode.TabStop = false;
            // 
            // QrOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 325);
            this.Controls.Add(this.pbQrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QrOutput";
            this.Text = "Qr Code";
            this.Load += new System.EventHandler(this.QrOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQrCode;
    }
}
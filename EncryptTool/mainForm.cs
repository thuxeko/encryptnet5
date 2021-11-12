using System;
using System.Windows.Forms;

namespace EncryptTool
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                var input_text = txtInput.Text;
                var encrypt_input = string.Empty;
                if (rbAES.Checked)
                {
                    var passphrase = txtPassphrase.Text;
                    encrypt_input = AESHelper.Encrypt(input_text, passphrase.Trim());
                }
                else if (rbRSA.Checked)
                {
                    encrypt_input = RSAHelper.Encrypt(input_text);
                }

                txtOutput.Text = encrypt_input;
                Clipboard.SetText(encrypt_input);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập input", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                var input_text = txtInput.Text;
                var encrypt_input = string.Empty;
                if (rbAES.Checked)
                {
                    var passphrase = txtPassphrase.Text;
                    encrypt_input = AESHelper.Decrypt(input_text, passphrase.Trim());
                }
                else if (rbRSA.Checked)
                {
                    encrypt_input = RSAHelper.Decrypt(input_text);
                }

                txtOutput.Text = encrypt_input;
                Clipboard.SetText(encrypt_input);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập input", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowHide.Checked) txtPassphrase.PasswordChar = '\0';
            else txtPassphrase.PasswordChar = '*';
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                QrOutput qrForm = new QrOutput(txtOutput.Text);
                qrForm.ShowDialog();
            }
        }
    }
}

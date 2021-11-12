using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptTool
{
    public partial class QrOutput : Form
    {
        private string outputData = string.Empty;
        public QrOutput(string output)
        {
            InitializeComponent();
            outputData = output;
        }

        private void QrOutput_Load(object sender, EventArgs e)
        {
            // Create qrcode
            var qrGenerator = new QRCodeGenerator();
            var qrCode = new QRCode(qrGenerator.CreateQrCode(outputData, QRCodeGenerator.ECCLevel.Q));
            //QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
            pbQrCode.Image = qrCode.GetGraphic(10, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
        }
    }
}

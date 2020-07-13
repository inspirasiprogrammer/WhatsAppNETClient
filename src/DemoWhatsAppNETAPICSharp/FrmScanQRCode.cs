using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppNETAPI;

namespace DemoWhatsAppNETAPICSharp
{
    public partial class FrmScanQRCode : Form
    {
        private IWhatsAppNETAPI _whatsAppApi;

        public FrmScanQRCode(IWhatsAppNETAPI whatsAppApi)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 189, 164);

            _whatsAppApi = whatsAppApi;
            picQRCode.Image = _whatsAppApi.GetQRCode();
        }

        private void tmrRefreshQRCode_Tick(object sender, EventArgs e)
        {
            var image = _whatsAppApi.GetQRCode();
            if (image != null)
                picQRCode.Image = image;
            else
                this.Close();
        }
    }
}

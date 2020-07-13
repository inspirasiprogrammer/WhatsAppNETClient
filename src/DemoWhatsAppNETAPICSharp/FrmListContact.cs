using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWhatsAppNETAPICSharp
{
    public partial class FrmListContact : Form
    {
        public FrmListContact(IList<string> contacts)
        {
            InitializeComponent();

            var noUrut = 1;

            foreach (var contact in contacts)
            {
                lstContact.Items.Add(string.Format("{0}. {1}", noUrut, contact));
                noUrut++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

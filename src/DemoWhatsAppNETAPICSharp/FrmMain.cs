using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using WhatsAppNETAPI;
using ConceptCave.WaitCursor;

namespace DemoWhatsAppNETAPICSharp
{
    public partial class FrmMain : Form
    {
        private IWhatsAppNETAPI _whatsAppApi;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _whatsAppApi = new WhatsAppNETAPI.WhatsAppNETAPI();

            var url = "https://web.whatsapp.com";

            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                if (_whatsAppApi.Connect(url, chkHeadless.Checked))
                {
                    while (!_whatsAppApi.OnReady())
                    {
                        if (chkHeadless.Checked)
                        {
                            if (_whatsAppApi.IsScanMe())
                            {
                                var frmScanQRCode = new FrmScanQRCode(_whatsAppApi);
                                frmScanQRCode.ShowDialog();
                            }
                        }

                        Thread.Sleep(1000);
                    }

                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    btnGrabContacts.Enabled = true;
                    btnKirim.Enabled = true;

                    chkSubscribe.Enabled = true;
                }
                else
                    _whatsAppApi.Disconnect();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                _whatsAppApi.Disconnect();

                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnGrabContacts.Enabled = false;
                btnKirim.Enabled = false;

                chkSubscribe.Checked = false;
                chkSubscribe.Enabled = false;

                chkAutoReplay.Checked = false;
                chkAutoReplay.Enabled = false;

                lstPesanMasuk.Items.Clear();
            }            
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            var jumlahPesan = int.Parse(txtJumlahPesan.Text);

            if (jumlahPesan > 1)
            {
                var list = new List<BroadcastMsgArgs>();

                var fileGambarAtauDokumen = string.Empty;

                if (chkKirimPesanDgGambar.Checked)
                {
                    // TODO: tambahkan validasi cek file gambar exist
                    fileGambarAtauDokumen = txtFileGambar.Text;
                }
                else if (chkKirimFileAja.Checked)
                {
                    // TODO: tambahkan validasi cek file dokumen exist
                    fileGambarAtauDokumen = txtFileDokumen.Text;
                }

                for (int i = 0; i < jumlahPesan; i++)
                {
                    if (!string.IsNullOrEmpty(fileGambarAtauDokumen))
                        list.Add(new BroadcastMsgArgs(txtKontak.Text, txtPesan.Text, fileGambarAtauDokumen));
                    else
                        list.Add(new BroadcastMsgArgs(txtKontak.Text, txtPesan.Text));
                }

                var delayInSeconds = 1;
                _whatsAppApi.BroadcastMessage(list, delayInSeconds);
            }
            else
            {
                var fileGambarAtauDokumen = string.Empty;

                if (chkKirimPesanDgGambar.Checked)
                {
                    // TODO: tambahkan validasi cek file gambar exist
                    fileGambarAtauDokumen = txtFileGambar.Text;
                }             
                else if (chkKirimFileAja.Checked)
                {
                    // TODO: tambahkan validasi cek file dokumen exist
                    fileGambarAtauDokumen = txtFileDokumen.Text;
                }

                if (!string.IsNullOrEmpty(fileGambarAtauDokumen))
                    _whatsAppApi.SendMessage(new MsgArgs(txtKontak.Text, txtPesan.Text, fileGambarAtauDokumen));
                else
                    _whatsAppApi.SendMessage(new MsgArgs(txtKontak.Text, txtPesan.Text));
            }                
        }

        private void chkSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubscribe.Checked)
            {
                _whatsAppApi.OnMessageRecieved += OnMessageRecievedEventHandler;
                _whatsAppApi.MessageSubscribe();
            }
            else
            {
                _whatsAppApi.OnMessageRecieved -= OnMessageRecievedEventHandler;
                _whatsAppApi.MessageUnSubscribe();

                lstPesanMasuk.Items.Clear();
            }

            chkAutoReplay.Enabled = chkSubscribe.Checked;
        }

        private void OnMessageRecievedEventHandler(MsgArgs e)
        {
            var msg = string.Format("[{0}] {1}: {2}",
                e.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss"), e.Sender, e.Msg);

            // karena pesan yang masuk beda thread, 
            // jadi harus menggunakan cara seperti ini untuk mengupdate UI
            lstPesanMasuk.Invoke(() =>
            {
                lstPesanMasuk.Items.Add(msg);
                lstPesanMasuk.SelectedIndex = lstPesanMasuk.Items.Count - 1;
            });

            if (chkAutoReplay.Checked)
            {
                var msgReplay = string.Format("Bpk/Ibu *{0}*, perintah *{1}* sudah kami terima. Silahkan ditunggu.",
                        e.Sender, e.Msg);

                _whatsAppApi.SendMessage(new MsgArgs(e.Sender, msgReplay));             
            }
        }

        private void btnCariGambar_Click(object sender, EventArgs e)
        {
            var fileName = ShowDialogOpen("Lokasi file gambar", true);
            if (!string.IsNullOrEmpty(fileName)) txtFileGambar.Text = fileName;
        }

        private void btnCariDokumen_Click(object sender, EventArgs e)
        {
            var fileName = ShowDialogOpen("Lokasi file dokumen");
            if (!string.IsNullOrEmpty(fileName)) txtFileDokumen.Text = fileName;
        }

        private string ShowDialogOpen(string title, bool fileImageOnly = false)
        {
            var fileName = string.Empty;

            using (var dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = fileImageOnly ? "File gambar (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
                                               : "File dokumen (*.*)|*.*";
                dlgOpen.Title = title;

                var result = dlgOpen.ShowDialog();
                if (result == DialogResult.OK) fileName = dlgOpen.FileName;
            }

            return fileName;
        }

        private void chkKirimPesanDgGambar_CheckedChanged(object sender, EventArgs e)
        {
            btnCariGambar.Enabled = chkKirimPesanDgGambar.Checked;
            if (chkKirimPesanDgGambar.Checked)
            {
                chkKirimFileAja.Checked = false;
                txtFileDokumen.Clear();
            }
            else
                txtFileGambar.Clear();
        }

        private void chkKirimFileAja_CheckedChanged(object sender, EventArgs e)
        {
            btnCariDokumen.Enabled = chkKirimFileAja.Checked;

            if (chkKirimFileAja.Checked)
            {
                chkKirimPesanDgGambar.Checked = false;
                txtFileGambar.Clear();
            }
            else
                txtFileDokumen.Clear();
        }

        private void btnGrabContacts_Click(object sender, EventArgs e)
        {
            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                var contacts = _whatsAppApi.GrabContacts();

                var frmContact = new FrmListContact(contacts);
                frmContact.ShowDialog();
            }
        }
    }
}

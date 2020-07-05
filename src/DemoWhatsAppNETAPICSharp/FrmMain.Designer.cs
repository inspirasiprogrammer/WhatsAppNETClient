namespace DemoWhatsAppNETAPICSharp
{
    partial class FrmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKontak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKirim = new System.Windows.Forms.Button();
            this.txtJumlahPesan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkKirimPesanDgGambar = new System.Windows.Forms.CheckBox();
            this.txtFileGambar = new System.Windows.Forms.TextBox();
            this.btnCariGambar = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkKirimFileAja = new System.Windows.Forms.CheckBox();
            this.txtFileDokumen = new System.Windows.Forms.TextBox();
            this.btnCariDokumen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.chkAutoReplay = new System.Windows.Forms.CheckBox();
            this.lstPesanMasuk = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Controls.Add(this.btnStop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(530, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(84, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " [ Kirim Pesan ] ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtKontak, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPesan, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(524, 180);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontak";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKontak
            // 
            this.txtKontak.Location = new System.Drawing.Point(50, 3);
            this.txtKontak.Name = "txtKontak";
            this.txtKontak.Size = new System.Drawing.Size(167, 20);
            this.txtKontak.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pesan";
            // 
            // txtPesan
            // 
            this.txtPesan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesan.Location = new System.Drawing.Point(50, 28);
            this.txtPesan.Multiline = true;
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(471, 58);
            this.txtPesan.TabIndex = 1;
            this.txtPesan.Text = "Tes kirim pesan dari aplikasi";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnKirim);
            this.flowLayoutPanel2.Controls.Add(this.txtJumlahPesan);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(50, 148);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(471, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnKirim
            // 
            this.btnKirim.Enabled = false;
            this.btnKirim.Location = new System.Drawing.Point(393, 3);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 2;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // txtJumlahPesan
            // 
            this.txtJumlahPesan.Location = new System.Drawing.Point(362, 3);
            this.txtJumlahPesan.Name = "txtJumlahPesan";
            this.txtJumlahPesan.Size = new System.Drawing.Size(25, 20);
            this.txtJumlahPesan.TabIndex = 1;
            this.txtJumlahPesan.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(283, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jumlah Pesan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.chkKirimPesanDgGambar);
            this.flowLayoutPanel4.Controls.Add(this.txtFileGambar);
            this.flowLayoutPanel4.Controls.Add(this.btnCariGambar);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(47, 89);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(477, 28);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // chkKirimPesanDgGambar
            // 
            this.chkKirimPesanDgGambar.AutoSize = true;
            this.chkKirimPesanDgGambar.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkKirimPesanDgGambar.Location = new System.Drawing.Point(3, 3);
            this.chkKirimPesanDgGambar.Name = "chkKirimPesanDgGambar";
            this.chkKirimPesanDgGambar.Size = new System.Drawing.Size(133, 23);
            this.chkKirimPesanDgGambar.TabIndex = 0;
            this.chkKirimPesanDgGambar.Text = "Kirim pesan dg gambar";
            this.chkKirimPesanDgGambar.UseVisualStyleBackColor = true;
            this.chkKirimPesanDgGambar.CheckedChanged += new System.EventHandler(this.chkKirimPesanDgGambar_CheckedChanged);
            // 
            // txtFileGambar
            // 
            this.txtFileGambar.Location = new System.Drawing.Point(142, 3);
            this.txtFileGambar.Name = "txtFileGambar";
            this.txtFileGambar.ReadOnly = true;
            this.txtFileGambar.Size = new System.Drawing.Size(292, 20);
            this.txtFileGambar.TabIndex = 1;
            // 
            // btnCariGambar
            // 
            this.btnCariGambar.Enabled = false;
            this.btnCariGambar.Location = new System.Drawing.Point(440, 3);
            this.btnCariGambar.Name = "btnCariGambar";
            this.btnCariGambar.Size = new System.Drawing.Size(34, 23);
            this.btnCariGambar.TabIndex = 2;
            this.btnCariGambar.Text = "...";
            this.btnCariGambar.UseVisualStyleBackColor = true;
            this.btnCariGambar.Click += new System.EventHandler(this.btnCariGambar_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.chkKirimFileAja);
            this.flowLayoutPanel5.Controls.Add(this.txtFileDokumen);
            this.flowLayoutPanel5.Controls.Add(this.btnCariDokumen);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(47, 117);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(477, 28);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // chkKirimFileAja
            // 
            this.chkKirimFileAja.AutoSize = true;
            this.chkKirimFileAja.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkKirimFileAja.Location = new System.Drawing.Point(3, 3);
            this.chkKirimFileAja.Name = "chkKirimFileAja";
            this.chkKirimFileAja.Size = new System.Drawing.Size(81, 23);
            this.chkKirimFileAja.TabIndex = 0;
            this.chkKirimFileAja.Text = "Kirim file aja";
            this.chkKirimFileAja.UseVisualStyleBackColor = true;
            this.chkKirimFileAja.CheckedChanged += new System.EventHandler(this.chkKirimFileAja_CheckedChanged);
            // 
            // txtFileDokumen
            // 
            this.txtFileDokumen.Location = new System.Drawing.Point(90, 3);
            this.txtFileDokumen.Name = "txtFileDokumen";
            this.txtFileDokumen.ReadOnly = true;
            this.txtFileDokumen.Size = new System.Drawing.Size(344, 20);
            this.txtFileDokumen.TabIndex = 1;
            // 
            // btnCariDokumen
            // 
            this.btnCariDokumen.Enabled = false;
            this.btnCariDokumen.Location = new System.Drawing.Point(440, 3);
            this.btnCariDokumen.Name = "btnCariDokumen";
            this.btnCariDokumen.Size = new System.Drawing.Size(34, 23);
            this.btnCariDokumen.TabIndex = 2;
            this.btnCariDokumen.Text = "...";
            this.btnCariDokumen.UseVisualStyleBackColor = true;
            this.btnCariDokumen.Click += new System.EventHandler(this.btnCariDokumen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " [ Pesan Masuk ] ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstPesanMasuk, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(524, 277);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chkSubscribe);
            this.flowLayoutPanel3.Controls.Add(this.chkAutoReplay);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(518, 20);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Enabled = false;
            this.chkSubscribe.Location = new System.Drawing.Point(3, 3);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(73, 17);
            this.chkSubscribe.TabIndex = 0;
            this.chkSubscribe.Text = "Subscribe";
            this.chkSubscribe.UseVisualStyleBackColor = true;
            this.chkSubscribe.CheckedChanged += new System.EventHandler(this.chkSubscribe_CheckedChanged);
            // 
            // chkAutoReplay
            // 
            this.chkAutoReplay.AutoSize = true;
            this.chkAutoReplay.Enabled = false;
            this.chkAutoReplay.Location = new System.Drawing.Point(82, 3);
            this.chkAutoReplay.Name = "chkAutoReplay";
            this.chkAutoReplay.Size = new System.Drawing.Size(84, 17);
            this.chkAutoReplay.TabIndex = 1;
            this.chkAutoReplay.Text = "Auto Replay";
            this.chkAutoReplay.UseVisualStyleBackColor = true;
            // 
            // lstPesanMasuk
            // 
            this.lstPesanMasuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPesanMasuk.FormattingEnabled = true;
            this.lstPesanMasuk.Location = new System.Drawing.Point(3, 29);
            this.lstPesanMasuk.Name = "lstPesanMasuk";
            this.lstPesanMasuk.Size = new System.Drawing.Size(518, 245);
            this.lstPesanMasuk.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo WhatsAppAPI untuk .NET Developer (C#)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKontak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.TextBox txtJumlahPesan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkSubscribe;
        private System.Windows.Forms.CheckBox chkAutoReplay;
        private System.Windows.Forms.ListBox lstPesanMasuk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.CheckBox chkKirimPesanDgGambar;
        private System.Windows.Forms.TextBox txtFileGambar;
        private System.Windows.Forms.Button btnCariGambar;
        private System.Windows.Forms.CheckBox chkKirimFileAja;
        private System.Windows.Forms.TextBox txtFileDokumen;
        private System.Windows.Forms.Button btnCariDokumen;
    }
}


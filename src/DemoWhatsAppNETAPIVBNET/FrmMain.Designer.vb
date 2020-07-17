<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.chkHeadless = New System.Windows.Forms.CheckBox()
        Me.btnGrabContacts = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtPesan = New System.Windows.Forms.TextBox()
        Me.flowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnKirim = New System.Windows.Forms.Button()
        Me.txtJumlahPesan = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkKirimPesanDgGambar = New System.Windows.Forms.CheckBox()
        Me.txtFileGambar = New System.Windows.Forms.TextBox()
        Me.btnCariGambar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkKirimFileAja = New System.Windows.Forms.CheckBox()
        Me.txtFileDokumen = New System.Windows.Forms.TextBox()
        Me.btnCariDokumen = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkSubscribe = New System.Windows.Forms.CheckBox()
        Me.chkAutoReplay = New System.Windows.Forms.CheckBox()
        Me.lstPesanMasuk = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstPesanKeluar = New System.Windows.Forms.ListBox()
        Me.chkMessageSentSubscribe = New System.Windows.Forms.CheckBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.flowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.flowLayoutPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(536, 542)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.btnStart)
        Me.flowLayoutPanel1.Controls.Add(Me.btnStop)
        Me.flowLayoutPanel1.Controls.Add(Me.chkHeadless)
        Me.flowLayoutPanel1.Controls.Add(Me.btnGrabContacts)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(530, 29)
        Me.flowLayoutPanel1.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(3, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(84, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'chkHeadless
        '
        Me.chkHeadless.AutoSize = True
        Me.chkHeadless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkHeadless.Location = New System.Drawing.Point(165, 3)
        Me.chkHeadless.Name = "chkHeadless"
        Me.chkHeadless.Size = New System.Drawing.Size(153, 23)
        Me.chkHeadless.TabIndex = 3
        Me.chkHeadless.Text = "Mode Siluman (no window)"
        Me.chkHeadless.UseVisualStyleBackColor = True
        '
        'btnGrabContacts
        '
        Me.btnGrabContacts.Enabled = False
        Me.btnGrabContacts.Location = New System.Drawing.Point(324, 3)
        Me.btnGrabContacts.Name = "btnGrabContacts"
        Me.btnGrabContacts.Size = New System.Drawing.Size(97, 23)
        Me.btnGrabContacts.TabIndex = 4
        Me.btnGrabContacts.Text = "Grab Contacts"
        Me.btnGrabContacts.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tableLayoutPanel2)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(3, 38)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(530, 197)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = " [ Kirim Pesan ] "
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.txtKontak, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.label3, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.txtPesan, 1, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.flowLayoutPanel2, 1, 4)
        Me.tableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4, 1, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel5, 1, 3)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 5
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(524, 178)
        Me.tableLayoutPanel2.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Kontak"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(50, 3)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(167, 20)
        Me.txtKontak.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label3.Location = New System.Drawing.Point(3, 25)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 64)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Pesan"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPesan
        '
        Me.txtPesan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPesan.Location = New System.Drawing.Point(50, 28)
        Me.txtPesan.Multiline = True
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.Size = New System.Drawing.Size(471, 58)
        Me.txtPesan.TabIndex = 1
        Me.txtPesan.Text = "Tes kirim pesan dari aplikasi"
        '
        'flowLayoutPanel2
        '
        Me.flowLayoutPanel2.Controls.Add(Me.btnKirim)
        Me.flowLayoutPanel2.Controls.Add(Me.txtJumlahPesan)
        Me.flowLayoutPanel2.Controls.Add(Me.label2)
        Me.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flowLayoutPanel2.Location = New System.Drawing.Point(50, 148)
        Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
        Me.flowLayoutPanel2.Size = New System.Drawing.Size(471, 27)
        Me.flowLayoutPanel2.TabIndex = 2
        '
        'btnKirim
        '
        Me.btnKirim.Enabled = False
        Me.btnKirim.Location = New System.Drawing.Point(393, 3)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(75, 23)
        Me.btnKirim.TabIndex = 2
        Me.btnKirim.Text = "Kirim"
        Me.btnKirim.UseVisualStyleBackColor = True
        '
        'txtJumlahPesan
        '
        Me.txtJumlahPesan.Location = New System.Drawing.Point(362, 3)
        Me.txtJumlahPesan.Name = "txtJumlahPesan"
        Me.txtJumlahPesan.Size = New System.Drawing.Size(25, 20)
        Me.txtJumlahPesan.TabIndex = 1
        Me.txtJumlahPesan.Text = "1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Location = New System.Drawing.Point(283, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(73, 29)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Jumlah Pesan"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.chkKirimPesanDgGambar)
        Me.FlowLayoutPanel4.Controls.Add(Me.txtFileGambar)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnCariGambar)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(47, 89)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(477, 28)
        Me.FlowLayoutPanel4.TabIndex = 3
        '
        'chkKirimPesanDgGambar
        '
        Me.chkKirimPesanDgGambar.AutoSize = True
        Me.chkKirimPesanDgGambar.Location = New System.Drawing.Point(3, 3)
        Me.chkKirimPesanDgGambar.Name = "chkKirimPesanDgGambar"
        Me.chkKirimPesanDgGambar.Size = New System.Drawing.Size(133, 17)
        Me.chkKirimPesanDgGambar.TabIndex = 0
        Me.chkKirimPesanDgGambar.Text = "Kirim pesan dg gambar"
        Me.chkKirimPesanDgGambar.UseVisualStyleBackColor = True
        '
        'txtFileGambar
        '
        Me.txtFileGambar.Location = New System.Drawing.Point(142, 3)
        Me.txtFileGambar.Name = "txtFileGambar"
        Me.txtFileGambar.ReadOnly = True
        Me.txtFileGambar.Size = New System.Drawing.Size(290, 20)
        Me.txtFileGambar.TabIndex = 1
        '
        'btnCariGambar
        '
        Me.btnCariGambar.Location = New System.Drawing.Point(438, 3)
        Me.btnCariGambar.Name = "btnCariGambar"
        Me.btnCariGambar.Size = New System.Drawing.Size(34, 23)
        Me.btnCariGambar.TabIndex = 2
        Me.btnCariGambar.Text = "..."
        Me.btnCariGambar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.chkKirimFileAja)
        Me.FlowLayoutPanel5.Controls.Add(Me.txtFileDokumen)
        Me.FlowLayoutPanel5.Controls.Add(Me.btnCariDokumen)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(47, 117)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(477, 28)
        Me.FlowLayoutPanel5.TabIndex = 3
        '
        'chkKirimFileAja
        '
        Me.chkKirimFileAja.AutoSize = True
        Me.chkKirimFileAja.Location = New System.Drawing.Point(3, 3)
        Me.chkKirimFileAja.Name = "chkKirimFileAja"
        Me.chkKirimFileAja.Size = New System.Drawing.Size(81, 17)
        Me.chkKirimFileAja.TabIndex = 0
        Me.chkKirimFileAja.Text = "Kirim file aja"
        Me.chkKirimFileAja.UseVisualStyleBackColor = True
        '
        'txtFileDokumen
        '
        Me.txtFileDokumen.Location = New System.Drawing.Point(90, 3)
        Me.txtFileDokumen.Name = "txtFileDokumen"
        Me.txtFileDokumen.ReadOnly = True
        Me.txtFileDokumen.Size = New System.Drawing.Size(342, 20)
        Me.txtFileDokumen.TabIndex = 1
        '
        'btnCariDokumen
        '
        Me.btnCariDokumen.Location = New System.Drawing.Point(438, 3)
        Me.btnCariDokumen.Name = "btnCariDokumen"
        Me.btnCariDokumen.Size = New System.Drawing.Size(34, 23)
        Me.btnCariDokumen.TabIndex = 2
        Me.btnCariDokumen.Text = "..."
        Me.btnCariDokumen.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 241)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 298)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tableLayoutPanel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 272)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pesan Masuk"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 1
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.flowLayoutPanel3, 0, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.lstPesanMasuk, 0, 1)
        Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 2
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(516, 266)
        Me.tableLayoutPanel3.TabIndex = 0
        '
        'flowLayoutPanel3
        '
        Me.flowLayoutPanel3.Controls.Add(Me.chkSubscribe)
        Me.flowLayoutPanel3.Controls.Add(Me.chkAutoReplay)
        Me.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.flowLayoutPanel3.Name = "flowLayoutPanel3"
        Me.flowLayoutPanel3.Size = New System.Drawing.Size(510, 20)
        Me.flowLayoutPanel3.TabIndex = 0
        '
        'chkSubscribe
        '
        Me.chkSubscribe.AutoSize = True
        Me.chkSubscribe.Enabled = False
        Me.chkSubscribe.Location = New System.Drawing.Point(3, 3)
        Me.chkSubscribe.Name = "chkSubscribe"
        Me.chkSubscribe.Size = New System.Drawing.Size(73, 17)
        Me.chkSubscribe.TabIndex = 0
        Me.chkSubscribe.Text = "Subscribe"
        Me.chkSubscribe.UseVisualStyleBackColor = True
        '
        'chkAutoReplay
        '
        Me.chkAutoReplay.AutoSize = True
        Me.chkAutoReplay.Enabled = False
        Me.chkAutoReplay.Location = New System.Drawing.Point(82, 3)
        Me.chkAutoReplay.Name = "chkAutoReplay"
        Me.chkAutoReplay.Size = New System.Drawing.Size(84, 17)
        Me.chkAutoReplay.TabIndex = 1
        Me.chkAutoReplay.Text = "Auto Replay"
        Me.chkAutoReplay.UseVisualStyleBackColor = True
        '
        'lstPesanMasuk
        '
        Me.lstPesanMasuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPesanMasuk.FormattingEnabled = True
        Me.lstPesanMasuk.Location = New System.Drawing.Point(3, 29)
        Me.lstPesanMasuk.Name = "lstPesanMasuk"
        Me.lstPesanMasuk.Size = New System.Drawing.Size(510, 234)
        Me.lstPesanMasuk.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 272)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pesan Keluar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lstPesanKeluar, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.chkMessageSentSubscribe, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(516, 266)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'lstPesanKeluar
        '
        Me.lstPesanKeluar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPesanKeluar.FormattingEnabled = True
        Me.lstPesanKeluar.Location = New System.Drawing.Point(3, 29)
        Me.lstPesanKeluar.Name = "lstPesanKeluar"
        Me.lstPesanKeluar.Size = New System.Drawing.Size(510, 234)
        Me.lstPesanKeluar.TabIndex = 0
        '
        'chkMessageSentSubscribe
        '
        Me.chkMessageSentSubscribe.AutoSize = True
        Me.chkMessageSentSubscribe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMessageSentSubscribe.Location = New System.Drawing.Point(3, 3)
        Me.chkMessageSentSubscribe.Name = "chkMessageSentSubscribe"
        Me.chkMessageSentSubscribe.Size = New System.Drawing.Size(510, 20)
        Me.chkMessageSentSubscribe.TabIndex = 1
        Me.chkMessageSentSubscribe.Text = "Subscribe"
        Me.chkMessageSentSubscribe.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 542)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo WhatsAppAPI untuk .NET Developer (VB.NET)"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.flowLayoutPanel2.ResumeLayout(False)
        Me.flowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.flowLayoutPanel3.ResumeLayout(False)
        Me.flowLayoutPanel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtKontak As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtPesan As System.Windows.Forms.TextBox
    Private WithEvents tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents flowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents chkSubscribe As System.Windows.Forms.CheckBox
    Private WithEvents chkAutoReplay As System.Windows.Forms.CheckBox
    Private WithEvents lstPesanMasuk As System.Windows.Forms.ListBox
    Private WithEvents flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents btnKirim As System.Windows.Forms.Button
    Private WithEvents txtJumlahPesan As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents chkKirimPesanDgGambar As System.Windows.Forms.CheckBox
    Friend WithEvents txtFileGambar As System.Windows.Forms.TextBox
    Friend WithEvents btnCariGambar As System.Windows.Forms.Button
    Friend WithEvents chkKirimFileAja As System.Windows.Forms.CheckBox
    Friend WithEvents txtFileDokumen As System.Windows.Forms.TextBox
    Friend WithEvents btnCariDokumen As System.Windows.Forms.Button
    Private WithEvents chkHeadless As System.Windows.Forms.CheckBox
    Private WithEvents btnGrabContacts As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstPesanKeluar As System.Windows.Forms.ListBox
    Friend WithEvents chkMessageSentSubscribe As System.Windows.Forms.CheckBox

End Class

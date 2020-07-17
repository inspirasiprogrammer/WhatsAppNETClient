Imports System.Collections.Generic
Imports System.Threading

Imports WhatsAppNETAPI
Imports ConceptCave.WaitCursor

Public Class FrmMain

    Private _whatsAppApi As IWhatsAppNETAPI

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        _whatsAppApi = New WhatsAppNETAPI.WhatsAppNETAPI()

        Dim url = "https://web.whatsapp.com"

        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))

            If (_whatsAppApi.Connect(url, chkHeadless.Checked)) Then

                While (Not _whatsAppApi.OnReady())

                    If chkHeadless.Checked Then
                        If _whatsAppApi.IsScanMe() Then
                            Dim frmScanQRCode = New FrmScanQRCode(_whatsAppApi)
                            frmScanQRCode.ShowDialog()
                        End If
                    End If

                    Thread.Sleep(1000)
                End While


                btnStart.Enabled = False
                btnStop.Enabled = True
                btnGrabContacts.Enabled = True
                btnKirim.Enabled = True

                chkSubscribe.Enabled = True
                chkMessageSentSubscribe.Enabled = True

            Else
                _whatsAppApi.Disconnect()
            End If

        End Using
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))
            _whatsAppApi.Disconnect()

            btnStart.Enabled = True
            btnStop.Enabled = False
            btnGrabContacts.Enabled = False
            btnKirim.Enabled = False

            chkSubscribe.Checked = False
            chkSubscribe.Enabled = False

            chkMessageSentSubscribe.Checked = False
            chkMessageSentSubscribe.Enabled = False

            chkAutoReplay.Checked = False
            chkAutoReplay.Enabled = False

            lstPesanMasuk.Items.Clear()
        End Using        
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Dim jumlahPesan = Integer.Parse(txtJumlahPesan.Text)

        If (jumlahPesan > 1) Then
            Dim list = New List(Of BroadcastMsgArgs)

            Dim fileGambarAtauDokumen = String.Empty

            If (chkKirimPesanDgGambar.Checked) Then
                ' TODO: tambahkan validasi cek file gambar exist
                fileGambarAtauDokumen = txtFileGambar.Text
            ElseIf (chkKirimFileAja.Checked) Then
                ' TODO: tambahkan validasi cek file dokumen exist
                fileGambarAtauDokumen = txtFileDokumen.Text
            End If

            For index = 1 To jumlahPesan
                If (Not String.IsNullOrEmpty(fileGambarAtauDokumen)) Then
                    list.Add(New BroadcastMsgArgs(txtKontak.Text, txtPesan.Text, fileGambarAtauDokumen))
                Else
                    list.Add(New BroadcastMsgArgs(txtKontak.Text, txtPesan.Text))
                End If
            Next

            Dim delayInSeconds = 1
            _whatsAppApi.BroadcastMessage(list, delayInSeconds)

        Else
            Dim fileGambarAtauDokumen = String.Empty

            If (chkKirimPesanDgGambar.Checked) Then
                ' TODO: tambahkan validasi cek file gambar exist
                fileGambarAtauDokumen = txtFileGambar.Text
            ElseIf (chkKirimFileAja.Checked) Then
                ' TODO: tambahkan validasi cek file dokumen exist
                fileGambarAtauDokumen = txtFileDokumen.Text
            End If

            If (Not String.IsNullOrEmpty(fileGambarAtauDokumen)) Then
                _whatsAppApi.SendMessage(New MsgArgs(txtKontak.Text, txtPesan.Text, fileGambarAtauDokumen))
            Else
                _whatsAppApi.SendMessage(New MsgArgs(txtKontak.Text, txtPesan.Text))
            End If
        End If
    End Sub

    Private Sub chkSubscribe_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubscribe.CheckedChanged

        If (chkSubscribe.Checked) Then
            AddHandler _whatsAppApi.OnMessageRecieved, AddressOf OnMessageRecievedEventHandler
            _whatsAppApi.MessageSubscribe()
        Else
            RemoveHandler _whatsAppApi.OnMessageRecieved, AddressOf OnMessageRecievedEventHandler
            _whatsAppApi.MessageUnSubscribe()

            lstPesanMasuk.Items.Clear()
            chkAutoReplay.Checked = False
        End If

        chkAutoReplay.Enabled = chkSubscribe.Checked
    End Sub

    Private Sub OnMessageRecievedEventHandler(e As MsgArgs)
        Dim msg = String.Format("[{0}] {1}: {2}",
                e.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss"), e.Sender, e.Msg)

        ' karena pesan yang masuk beda thread, 
        ' jadi harus menggunakan cara seperti ini untuk mengupdate UI
        lstPesanMasuk.Invoke(
            Sub()
                lstPesanMasuk.Items.Add(msg)
                lstPesanMasuk.SelectedIndex = lstPesanMasuk.Items.Count - 1
            End Sub
        )

        If (chkAutoReplay.Checked) Then

            Dim msgReplay = String.Format("Bpk/Ibu *{0}*, perintah *{1}* sudah kami terima. Silahkan ditunggu.",
                    e.Sender, e.Msg)

            _whatsAppApi.SendMessage(New MsgArgs(e.Sender, msgReplay))

        End If
    End Sub

    Private Sub chkKirimPesanDgGambar_CheckedChanged(sender As Object, e As EventArgs) Handles chkKirimPesanDgGambar.CheckedChanged
        btnCariGambar.Enabled = chkKirimPesanDgGambar.Checked
        If (chkKirimPesanDgGambar.Checked) Then
            chkKirimFileAja.Checked = False
            txtFileDokumen.Clear()
        Else
            txtFileGambar.Clear()
        End If
    End Sub

    Private Sub chkKirimFileAja_CheckedChanged(sender As Object, e As EventArgs) Handles chkKirimFileAja.CheckedChanged
        btnCariDokumen.Enabled = chkKirimFileAja.Checked

        If (chkKirimFileAja.Checked) Then
            chkKirimPesanDgGambar.Checked = False
            txtFileGambar.Clear()
        Else
            txtFileDokumen.Clear()
        End If
    End Sub

    Private Sub btnCariGambar_Click(sender As Object, e As EventArgs) Handles btnCariGambar.Click
        Dim fileName = ShowDialogOpen("Lokasi file gambar", True)
        If (Not String.IsNullOrEmpty(fileName)) Then txtFileGambar.Text = fileName
    End Sub

    Private Sub btnCariDokumen_Click(sender As Object, e As EventArgs) Handles btnCariDokumen.Click
        Dim fileName = ShowDialogOpen("Lokasi file dokumen", False)
        If (Not String.IsNullOrEmpty(fileName)) Then txtFileDokumen.Text = fileName
    End Sub

    Private Function ShowDialogOpen(ByVal title As String, ByVal fileImageOnly As Boolean) As String
        Dim fileName = String.Empty

        Using dlgOpen As New OpenFileDialog()
            dlgOpen.Filter = IIf(fileImageOnly, "File gambar (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png", "File dokumen (*.*)|*.*")
            dlgOpen.Title = title

            Dim result = dlgOpen.ShowDialog()
            If (result = DialogResult.OK) Then fileName = dlgOpen.FileName
        End Using

        Return fileName
    End Function

    Private Sub btnGrabContacts_Click(sender As Object, e As EventArgs) Handles btnGrabContacts.Click
        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))
            Dim contacts = _whatsAppApi.GrabContacts()

            Dim frmContact = New FrmListContact(contacts)
            frmContact.ShowDialog()
        End Using
    End Sub

    Private Sub chkMessageSentSubscribe_CheckedChanged(sender As Object, e As EventArgs) Handles chkMessageSentSubscribe.CheckedChanged
        If (chkMessageSentSubscribe.Checked) Then
            AddHandler _whatsAppApi.OnMessageSent, AddressOf OnMessageSentEventHandler
        Else
            RemoveHandler _whatsAppApi.OnMessageSent, AddressOf OnMessageSentEventHandler

            lstPesanKeluar.Items.Clear()
        End If
    End Sub

    Private Sub OnMessageSentEventHandler(e As MsgArgs)
        Dim msg = String.Format("[{0}] {1}: {2}",
                e.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss"), e.Sender, e.Msg)

        ' karena pesan yang masuk beda thread, 
        ' jadi harus menggunakan cara seperti ini untuk mengupdate UI
        lstPesanKeluar.Invoke(
            Sub()
                lstPesanKeluar.Items.Add(msg)
                lstPesanKeluar.SelectedIndex = lstPesanKeluar.Items.Count - 1
            End Sub
        )
    End Sub
End Class

Imports WhatsAppNETAPI

Public Class FrmScanQRCode

    Private _whatsAppApi As IWhatsAppNETAPI

    Public Sub New(ByRef whatsAppApi As IWhatsAppNETAPI)
        ' This call is required by the designer.
        InitializeComponent()
        Me.BackColor = Color.FromArgb(0, 189, 164)

        _whatsAppApi = whatsAppApi
        picQRCode.Image = _whatsAppApi.GetQRCode()
    End Sub

    Private Sub tmrRefreshQRCode_Tick(sender As Object, e As EventArgs) Handles tmrRefreshQRCode.Tick

        Dim image = _whatsAppApi.GetQRCode()

        If (image IsNot Nothing) Then
            picQRCode.Image = image
        Else
            Me.Close()
        End If
    End Sub

End Class
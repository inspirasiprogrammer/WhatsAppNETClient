Public Class FrmListContact

    Public Sub New(ByVal contacts As IList(Of String))
        ' This call is required by the designer.
        InitializeComponent()

        Dim noUrut = 1

        For Each contact As String In contacts

            lstContact.Items.Add(String.Format("{0}. {1}", noUrut, contact))
            noUrut += 1
        Next

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
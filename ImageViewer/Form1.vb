Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picViewer.Load(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picViewer.Image = Nothing
    End Sub

    Private Sub btnBackground_Click(sender As Object, e As EventArgs) Handles btnBackground.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            picViewer.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub chkStretch_CheckedChanged(sender As Object, e As EventArgs) Handles chkStretch.CheckedChanged
        If chkStretch.Checked Then
            picViewer.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            picViewer.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub
End Class

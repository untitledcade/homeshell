Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'The OK Button (This Closes the Dialog)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Updatehs.Show()
    End Sub

    'Opens The Update Page


End Class

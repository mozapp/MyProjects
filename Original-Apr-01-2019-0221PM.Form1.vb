Public Class Form1
  

    'Procted Overrides ReadOnly Property CreatParams() as CreateParams
    'Get
    'Dim cp As CreateParams = MyBase.CreateParams
    ' ConstCS_NOCLOSE as Integer = & H200
    'cp.ClassStyle = cp.ClassStyle or CS_NOCLOSE
    'Return cp
    'End Get
    'End Property
    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '   Application.Exit()
    'End Sub

    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Dim SelProcess As Proccess.GetProccesses

        'Me.TopMost = True
        'Me.BringToFront()
        'Me.Focus()
        'For Each SelProcess As Proccess In Proccesses.GetProccess
        'If SelProccess.proccessName = "taskmgr" Then
        'SelProcess.kill()
        'Exit For
        'End If
        'Next
        'Me.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" Then
            Application.Exit()
        Else
            MessageBox.Show("Invalid Password")
        End If
    End Sub
End Class

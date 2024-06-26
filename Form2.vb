Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Exit Sub




    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Dim sw As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim sh As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Button2.Location = New Point(sw / 2 - 91, sh / 2 - 42)
        Me.Button3.Location = New Point(sw / 2 - 91, (sh / 2 - 85))

        Me.Button1.Location = New Point(sw / 2 - 91, (sh / 2 - 128))
        Me.Button4.Location = New Point(sw / 2 - 91, (sh / 2))
        Me.Button5.Location = New Point(sw / 2 - 91, (sh / 2 + 42))

        connectiondb()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.Hide()



        Form1.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pppnam As String
        pppnam = InputBox("Enter Patient name")
        pupdate(pppnam)

        Me.Hide()




        Form6.Show()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ppname As String
        ppname = InputBox("Enter Patiend Name")
        connectiondb1(ppname)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub
End Class
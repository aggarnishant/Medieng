Module Module7
    Public Sub wht()
        Try
            Dim ms As String
            ms = "good morning"
            Dim web As New WebBrowser
            ' web.Navigate("https://wa.ma")
            'MsgBox(("whatsapp://" & TextBox1.Text & "/? text=" & ms & ""))
            web.Navigate("whatsapp://send?phone=+91" & Form6.TextBox4.Text & " &text=" & Form6.TextBox2.Text & "")

        Catch ex As Exception
        End Try
    End Sub

End Module

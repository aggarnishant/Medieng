Module Module5
    Function printt()
        Form1.BackColor = Color.White
        Form1.PictureBox3.BackColor = Color.White
        Form1.PictureBox4.BackColor = Color.White
        Form1.PictureBox5.BackColor = Color.White
        Form1.PictureBox6.BackColor = Color.White
        Form1.PictureBox7.BackColor = Color.White
        Form1.Panel1.BackColor = Color.White
        'Form1.TextBox1.Lines.vasible = True


        Form1.Panel1.BackgroundImage = Nothing

        Form1.PrintDialog1.Document = Form1.PrintDocument1
        Form1.PrintDialog1.PrinterSettings = Form1.PrintDocument1.PrinterSettings
        Form1.PrintDialog1.AllowSomePages = True
        If Form1.PrintDialog1.ShowDialog = DialogResult.OK Then
            '  Form1.PrintDocument1.PrinterSettings = Form1.PrintDialog1.PrinterSettings
            Form1.PrintPreviewDialog1.Document = Form1.PrintDocument1
            Form1.PrintPreviewDialog1.ShowDialog()
            ' Form1.PrintDocument1.Print()
        End If
        Form1.Close()
        Form2.Show()

    End Function
End Module


Public Class Form8
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = Now()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label4.Text = Now()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(dm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(dm, 0, 0)

        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
        'PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        'PrintDocument1.Print()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Picture Files (*) | *.bmp;*.png;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox5.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Picture Files (*) | *.bmp;*.png;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Picture Files (*) | *.bmp;*.png;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox7.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Picture Files (*) | *.bmp;*.png;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox6.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "Picture Files (*) | *.bmp;*.png;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox4.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim FileSize As UInt32
        'Dim mstream As New System.IO.MemoryStream()
        'Dim mstream1 As New System.IO.MemoryStream()
        'Dim mstream2 As New System.IO.MemoryStream()
        'Dim mstream3 As New System.IO.MemoryStream()
        'Dim mstream4 As New System.IO.MemoryStream()
        'PictureBox5.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        'PictureBox3.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
        'PictureBox7.Image.Save(mstream2, System.Drawing.Imaging.ImageFormat.Jpeg)
        'PictureBox6.Image.Save(mstream3, System.Drawing.Imaging.ImageFormat.Jpeg)
        'PictureBox4.Image.Save(mstream4, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Dim arrImage() As Byte = mstream.GetBuffer()
        'Dim arrImage1() As Byte = mstream1.GetBuffer()
        'Dim arrImage2() As Byte = mstream2.GetBuffer()
        'Dim arrImage3() As Byte = mstream3.GetBuffer()
        'Dim arrImage4() As Byte = mstream4.GetBuffer()
        'FileSize = mstream.Length
        'mstream.Close()
        'Dim sql As String

        ' Sql = "Insert into img([fs],[image])Values(@fs,@image)"
        'Dim ss As String
        'ss = Now()
        'con.Open()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "insert into mainfields(Pname,Page,DT,Complaint,FB,LT,Valle,VCTrue,VCFalse,VCMobility,PG,Aryte,LPW,PCS,PS,POS,Impression,Advice,img1,img2,img3,img4,img5)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ss + "','" + TextBox3.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + ComboBox4.Text + "','" + ComboBox5.Text + "','" + ComboBox6.Text + "','" + ComboBox7.Text + "','" + ComboBox8.Text + "','" + ComboBox9.Text + "','" + ComboBox10.Text + "','" + ComboBox11.Text + "','" + ComboBox12.Text + "','" + ComboBox13.Text + "','" + ComboBox14.Text + "','" + ComboBox15.Text + "',@img1,@img2,@img3,@img4,@img5)"
        'cmd.CommandText = "insert into mainfields([img1],[img2],[img3],[img4],[img5])values(@img1,@img1,@img2,@img3,@img4)"
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("@img1", arrImage)
        'cmd.Parameters.AddWithValue("@img2", arrImage1)
        'cmd.Parameters.AddWithValue("@img3", arrImage2)
        'cmd.Parameters.AddWithValue("@img4", arrImage3)
        'cmd.Parameters.AddWithValue("@img5", arrImage4)
        'cmd.ExecuteNonQuery()
        'con.Close()
        'MessageBox.Show("record saved", "vb save datbase", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' TextBox1.BorderStyle = BorderStyle.None
        'TextBox1.BackColor = Color.White
        'TextBox2.BorderStyle = BorderStyle.None
        'TextBox2.BackColor = Color.White
        'Label4.BorderStyle = BorderStyle.None
        'Label4.BackColor = Color.White
        'TextBox3.BorderStyle = BorderStyle.None
        'TextBox3.BackColor = Color.White
        'ComboBox2.FlatStyle = BorderStyle.None
        'ComboBox2.BackColor = Color.White
        'ComboBox2.BackColor = Color.White
        'ComboBox3.BackColor = Color.White
        'ComboBox4.BackColor = Color.White
        PrintPreviewDialog1.ClientSize = New Size(600, 600)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ' PictureBox5.Image = Image.FromStream(mstream)
        ' PictureBox3.Image = Image.FromStream(mstream1)
        'PictureBox7.Image = Image.FromStream(mstream2)
        'PictureBox6.Image = Image.FromStream(mstream3)
        'PictureBox4.Image = Image.FromStream(mstream4)

    End Sub

    Private Sub Button10_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click

    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class

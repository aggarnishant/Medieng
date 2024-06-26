Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As OleDb.OleDbDataAdapter
    'Dim ds As New DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\Report\MRdatabase.mdb"
        Button1.Enabled = False
        Label4.Text = Now()
        connectiondb()
        TextBox1.Focus()
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

    Private Sub Panel1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Disposed

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pt As String
        Dim pros As Process()


        OpenFileDialog1.Filter = "Picture Files (*.*) | *.bmp;*.png;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pt = OpenFileDialog1.FileName
            MsgBox(pt)
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Microsoft Office\Office12\ois", pt).WaitForExit()


            PictureBox5.Image = Image.FromFile(OpenFileDialog1.FileName)
            pros = Process.GetProcessesByName("C:\Program Files (x86)\Microsoft Office\Office12\ois")
            For Each proces As Process In pros
                proces.Kill()
            Next
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pt As String
        Dim pros As Process()


        OpenFileDialog1.Filter = "Picture Files (*.*) | *.bmp;*.png;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pt = OpenFileDialog1.FileName
            MsgBox(pt)
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Microsoft Office\Office12\ois", pt).WaitForExit()


            PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
            pros = Process.GetProcessesByName("C:\Program Files (x86)\Microsoft Office\Office12\ois")
            For Each proces As Process In pros
                proces.Kill()
            Next
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim pt As String
        Dim pros As Process()


        OpenFileDialog1.Filter = "Picture Files (*.*) | *.bmp;*.png;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pt = OpenFileDialog1.FileName
            MsgBox(pt)
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Microsoft Office\Office12\ois", pt).WaitForExit()


            PictureBox6.Image = Image.FromFile(OpenFileDialog1.FileName)
            pros = Process.GetProcessesByName("C:\Program Files (x86)\Microsoft Office\Office12\ois")
            For Each proces As Process In pros
                proces.Kill()
            Next
            Me.Refresh()

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim pt As String
        Dim pros As Process()


        OpenFileDialog1.Filter = "Picture Files (*.*) | *.bmp;*.png;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pt = OpenFileDialog1.FileName
            MsgBox(pt)
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Microsoft Office\Office12\ois", pt).WaitForExit()


            PictureBox4.Image = Image.FromFile(OpenFileDialog1.FileName)
            pros = Process.GetProcessesByName("C:\Program Files (x86)\Microsoft Office\Office12\ois")
            For Each proces As Process In pros
                proces.Kill()
            Next
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        Dim mstream1 As New System.IO.MemoryStream()
        Dim mstream2 As New System.IO.MemoryStream()
        Dim mstream3 As New System.IO.MemoryStream()
        Dim mstream4 As New System.IO.MemoryStream()
        If IsNothing(PictureBox3.Image) Or IsNothing(PictureBox5.Image) Or IsNothing(PictureBox7.Image) Or IsNothing(PictureBox6.Image) Or IsNothing(PictureBox4.Image) Then

            MsgBox("Image not Insert Please Insert Picture and try again")
        Else
            PictureBox5.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox3.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox7.Image.Save(mstream2, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox6.Image.Save(mstream3, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox4.Image.Save(mstream4, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim arrImage() As Byte = mstream.GetBuffer()
            Dim arrImage1() As Byte = mstream1.GetBuffer()
            Dim arrImage2() As Byte = mstream2.GetBuffer()
            Dim arrImage3() As Byte = mstream3.GetBuffer()
            Dim arrImage4() As Byte = mstream4.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            Dim sql As String
            Dim st1 As String
            Dim st2 As String
            Dim st3 As String
            Dim st4 As String
            Dim st5 As String


            ' Sql = "Insert into img([fs],[image])Values(@fs,@image)"
            Dim ss As String
            ss = Today()
            con.Open()
            If CheckBox2.Checked = True Then
                st1 = "True"
            Else
                st1 = "False"
            End If
            If CheckBox1.Checked = True Then
                st2 = "True"
            Else
                st2 = "False"
            End If
            If CheckBox4.Checked = True Then
                st3 = "True"
            Else
                st3 = "False"
            End If
            If CheckBox3.Checked = True Then
                st4 = "True"
            Else
                st4 = "False"
            End If
            If CheckBox5.Checked = True Then
                st5 = "True"
            Else
                st5 = "False"
            End If
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "insert into mainfields(ID,Pname,Page,DT,Complaint,FB,LT,Valle,VCTrue,VCFalse,VCMobility,PG,Aryte,LPW,PCS,PS,POS,Impression,Advice,img1,img2,img3,img4,img5,st1,st2,st3,st4,st5,Pagevalue,Mobo)values('" + Label26.Text + "','" + TextBox1.Text.ToUpper + "','" + TextBox2.Text + "','" + ss + "','" + TextBox3.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + ComboBox4.Text + "','" + ComboBox5.Text + "','" + ComboBox6.Text + "','" + ComboBox7.Text + "','" + ComboBox8.Text + "','" + ComboBox9.Text + "','" + ComboBox10.Text + "','" + ComboBox11.Text + "','" + ComboBox12.Text + "','" + ComboBox13.Text + "','" + ComboBox14.Text + "','" + ComboBox15.Text + "',@img1,@img2,@img3,@img4,@img5,'" + st1 + "','" + st2 + "','" + st3 + "','" + st4 + "','" + st5 + "','" + ComboBox1.Text + "','" + TextBox4.Text + "')"
            'cmd.CommandText = "insert into mainfields([img1],[img2],[img3],[img4],[img5])values(@img1,@img1,@img2,@img3,@img4)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@img1", arrImage)
            cmd.Parameters.AddWithValue("@img2", arrImage1)
            cmd.Parameters.AddWithValue("@img3", arrImage2)
            cmd.Parameters.AddWithValue("@img4", arrImage3)
            cmd.Parameters.AddWithValue("@img5", arrImage4)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("record saved", "vb save datbase", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button1.Enabled = True
            Button8.Enabled = False
            ' Me.Close()
            ' Form2.Show()
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintPreviewDialog1.ClientSize = New Size(600, 600)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

      Private Sub Button10_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Close()
        Me.Close()

        Form2.Show()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        printttt()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim pt As String
        Dim pros As Process()


        OpenFileDialog1.Filter = "Picture Files (*.*) | *.bmp;*.png;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pt = OpenFileDialog1.FileName
            MsgBox(pt)
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Microsoft Office\Office12\ois", pt).WaitForExit()


            PictureBox7.Image = Image.FromFile(OpenFileDialog1.FileName)
            pros = Process.GetProcessesByName("C:\Program Files (x86)\Microsoft Office\Office12\ois")
            For Each proces As Process In pros
                proces.Kill()
            Next
        End If
    End Sub
End Class

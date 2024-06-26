Imports System.Data.OleDb

Module Module3
    Dim arrimg() As Byte
    Dim arrimg1() As Byte
    Dim arrimg2() As Byte
    Dim arrimg3() As Byte
    Dim arrimg4() As Byte
    Dim st1 As String
    Dim st2 As String
    Dim st3 As String
    Dim st4 As String
    Dim st5 As String
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim pname As String
    Dim pid As Integer
    Dim ppid As Integer
    Public Sub pupdate(ByVal pname)
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\Report\MRdatabase.mdb"
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        da = New OleDb.OleDbDataAdapter("select * from mainfields where pname = '" + pname + "'", con)
        da.Fill(ds)

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                con.Close()


                Form6.TextBox1.Text = ds.Tables(0).Rows(0).Item(1)
                Form6.TextBox2.Text = ds.Tables(0).Rows(0).Item(2)
                Form6.Label4.Text = ds.Tables(0).Rows(0).Item(3)
                Form6.TextBox3.Text = ds.Tables(0).Rows(0).Item(4)
                Form6.Label26.Text = ds.Tables(0).Rows(0).Item(0)
                Form6.ComboBox2.Text = ds.Tables(0).Rows(0).Item(5)
                Form6.ComboBox3.Text = ds.Tables(0).Rows(0).Item(6)
                Form6.ComboBox4.Text = ds.Tables(0).Rows(0).Item(7)
                Form6.ComboBox5.Text = ds.Tables(0).Rows(0).Item(8)
                Form6.ComboBox6.Text = ds.Tables(0).Rows(0).Item(9)
                Form6.ComboBox7.Text = ds.Tables(0).Rows(0).Item(10)
                Form6.ComboBox8.Text = ds.Tables(0).Rows(0).Item(11)
                Form6.ComboBox9.Text = ds.Tables(0).Rows(0).Item(12)
                Form6.ComboBox10.Text = ds.Tables(0).Rows(0).Item(13)
                Form6.ComboBox11.Text = ds.Tables(0).Rows(0).Item(14)
                Form6.ComboBox12.Text = ds.Tables(0).Rows(0).Item(15)
                Form6.ComboBox13.Text = ds.Tables(0).Rows(0).Item(16)
                Form6.ComboBox14.Text = ds.Tables(0).Rows(0).Item(17)
                Form6.ComboBox15.Text = ds.Tables(0).Rows(0).Item(18)
                st1 = ds.Tables(0).Rows(0).Item(24)
                st2 = ds.Tables(0).Rows(0).Item(25)
                st3 = ds.Tables(0).Rows(0).Item(26)
                st4 = ds.Tables(0).Rows(0).Item(27)
                st5 = ds.Tables(0).Rows(0).Item(28)
                Form6.ComboBox1.Text = ds.Tables(0).Rows(0).Item(29)
                Form6.TextBox4.Text = ds.Tables(0).Rows(0).Item(30)
                If st1 = "True" Then
                    Form6.CheckBox2.Checked = True
                Else
                    Form1.CheckBox2.Checked = False
                End If
                If st2 = "True" Then
                    Form6.CheckBox1.Checked = True
                Else
                    Form6.CheckBox1.Checked = False
                End If
                If st3 = "True" Then
                    Form6.CheckBox4.Checked = True
                Else
                    Form6.CheckBox4.Checked = False
                End If
                If st4 = "True" Then
                    Form6.CheckBox3.Checked = True
                Else
                    Form6.CheckBox3.Checked = False
                End If
                If st5 = "True" Then
                    Form6.CheckBox5.Checked = True
                Else
                    Form6.CheckBox5.Checked = False
                End If


                Try
                    arrimg = ds.Tables(0).Rows(0).Item(19)
                    arrimg1 = ds.Tables(0).Rows(0).Item(20)
                    arrimg2 = ds.Tables(0).Rows(0).Item(21)
                    arrimg3 = ds.Tables(0).Rows(0).Item(22)
                    arrimg4 = ds.Tables(0).Rows(0).Item(23)
                    Dim mstream As New System.IO.MemoryStream(arrimg)
                    Dim mstream1 As New System.IO.MemoryStream(arrimg1)
                    Dim mstream2 As New System.IO.MemoryStream(arrimg2)
                    Dim mstream3 As New System.IO.MemoryStream(arrimg3)
                    Dim mstream4 As New System.IO.MemoryStream(arrimg4)
                    Form6.PictureBox5.Image = Image.FromStream(mstream)
                    Form6.PictureBox3.Image = Image.FromStream(mstream1)
                    Form6.PictureBox7.Image = Image.FromStream(mstream2)
                    Form6.PictureBox6.Image = Image.FromStream(mstream3)
                    Form6.PictureBox4.Image = Image.FromStream(mstream4)
                    MsgBox("Records has been Found", MsgBoxStyle.Information)

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    ds.Reset()
                    con.Close()

                End Try
            Else
                MsgBox("Recoud Not Found Please Check Patient Name")

            End If
        End If
        'pid = ds.Tables(0).Rows.Count - 1
        'ppid = ds.Tables(0).Rows(pid).Item(0)
        'ppid = ppid + 1
        'Form1.Label26.Text = ppid.ToString


    End Sub

End Module

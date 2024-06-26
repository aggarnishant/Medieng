Imports System.Data.OleDb
Module Module4
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
    Public Sub dgv()
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\Report\MRdatabase.mdb")
        Try
            con.Open()
            Dim sql As String
            Dim dt As New DataTable
            Dim dt1 As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Dim da1 As New OleDb.OleDbDataAdapter
            Dim ds As DataSet
            Dim ds1 As DataSet
            If con.State = ConnectionState.Open Then
                sql = "select id,pname,page,complaint,mobo,dt from mainfields where dt between #" + DateTime.Parse(Form4.TextBox2.Text) + "# and #" + DateTime.Parse(Form4.TextBox1.Text) + "#"
                'MsgBox(sql)
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(dt)
              
                ' Form1.DataGridView1.AutoSize = True
                Form4.DataGridView2.DataSource = dt
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
   

End Module

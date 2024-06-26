Imports System.Data.OleDb
Module Module1
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim pid As Integer
    Dim ppid As Integer
    Public Sub connectiondb()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\Report\MRdatabase.mdb"
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        da = New OleDb.OleDbDataAdapter("select * from mainfields", con)
        da.Fill(ds)
        pid = ds.Tables(0).Rows.Count - 1
        ppid = ds.Tables(0).Rows(pid).Item(0)
        ppid = ppid + 1
        Form1.Label26.Text = ppid.ToString
        con.Close()

    End Sub

End Module

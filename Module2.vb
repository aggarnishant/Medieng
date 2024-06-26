Imports System.Data.OleDb
Module Module2
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim pname As String
    Dim pid As Integer
    Dim ppid As Integer
    Public Sub connectiondb1(ByVal pname)
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Medical Report\MRdatabase.mdb"
        'con.Open()
        If pname = Nothing Then
            MsgBox("Enter Patient Name")

        Else
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\Report\MRdatabase.mdb"
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            da = New OleDb.OleDbDataAdapter("delete from mainfields where pname = '" + pname + "'", con)
            da.Fill(ds)
            ' cmd.ExecuteNonQuery()
            'pid = ds.Tables(0).Rows.Count - 1
            'ppid = ds.Tables(0).Rows(pid).Item(0)
            'ppid = ppid + 1
            'Form1.Label26.Text = ppid.ToString

            con.Close()
        End If

    End Sub


End Module

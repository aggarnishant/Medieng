Public Class Form4

    Private Sub MRdatabaseDataSet2BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Today()


        'TODO: This line of code loads data into the 'MRdatabaseDataSet6.mainfields' table. You can move, or remove it, as needed.
        Me.MainfieldsTableAdapter2.Fill(Me.MRdatabaseDataSet6.mainfields)
        'TODO: This line of code loads data into the 'MRdatabaseDataSet5.mainfields' table. You can move, or remove it, as needed.
        Me.MainfieldsTableAdapter1.Fill(Me.MRdatabaseDataSet5.mainfields)
        'TODO: This line of code loads data into the 'MRdatabaseDataSet4.mainfields' table. You can move, or remove it, as needed.
        Dim sw As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim sh As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Size = New Size(sw, sh)
        Me.MainfieldsTableAdapter.Fill(Me.MRdatabaseDataSet4.mainfields)
       

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        ' MsgBox(Me.MRdatabaseDataSet4.mainfields.TableName)
        Dim i As String
        Dim j As Integer
        i = DataGridView2.CurrentRow.Cells(1).Value.ToString
        Form5.TextBox4.Text = i
        Form5.Show()
        'j = DataGridView1.CurrentCell.ColumnIndex
        'MsgBox(i)
    End Sub

    Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub DataGridView2_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As String
        Dim j As Integer
        i = DataGridView2.CurrentRow.Cells(1).Value.ToString
        Form5.TextBox4.Text = i
        Form5.Show()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgv()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
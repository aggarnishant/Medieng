<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainfieldsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRdatabaseDataSet = New WindowsApplication1.MRdatabaseDataSet()
        Me.MainfieldsTableAdapter = New WindowsApplication1.MRdatabaseDataSetTableAdapters.mainfieldsTableAdapter()
        Me.ReportDatabaseDataSet = New WindowsApplication1.ReportDatabaseDataSet()
        Me.ReportDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRdatabaseDataSet1 = New WindowsApplication1.MRdatabaseDataSet1()
        Me.MainfieldsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainfieldsTableAdapter1 = New WindowsApplication1.MRdatabaseDataSet1TableAdapters.mainfieldsTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.MRdatabaseDataSet1TableAdapters.TableAdapterManager()
        Me.MainfieldsTableAdapter2 = New WindowsApplication1.MRdatabaseDataSet1TableAdapters.mainfieldsTableAdapter()
        CType(Me.MainfieldsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRdatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainfieldsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(840, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "New Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(840, 534)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(840, 471)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Search Report By Name"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(840, 599)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(183, 42)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Delete Report"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MistyRose
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(840, 659)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(183, 42)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Show All Rerecord"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(481, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        '
        'MainfieldsBindingSource
        '
        Me.MainfieldsBindingSource.DataMember = "mainfields"
        Me.MainfieldsBindingSource.DataSource = Me.MRdatabaseDataSet
        '
        'MRdatabaseDataSet
        '
        Me.MRdatabaseDataSet.DataSetName = "MRdatabaseDataSet"
        Me.MRdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainfieldsTableAdapter
        '
        Me.MainfieldsTableAdapter.ClearBeforeFill = True
        '
        'ReportDatabaseDataSet
        '
        Me.ReportDatabaseDataSet.DataSetName = "ReportDatabaseDataSet"
        Me.ReportDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportDatabaseDataSetBindingSource
        '
        Me.ReportDatabaseDataSetBindingSource.DataSource = Me.ReportDatabaseDataSet
        Me.ReportDatabaseDataSetBindingSource.Position = 0
        '
        'MRdatabaseDataSet1
        '
        Me.MRdatabaseDataSet1.DataSetName = "MRdatabaseDataSet1"
        Me.MRdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainfieldsBindingSource1
        '
        Me.MainfieldsBindingSource1.DataMember = "mainfields"
        Me.MainfieldsBindingSource1.DataSource = Me.MRdatabaseDataSet1
        '
        'MainfieldsTableAdapter1
        '
        Me.MainfieldsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.mainfieldsTableAdapter = Me.MainfieldsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.MRdatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainfieldsTableAdapter2
        '
        Me.MainfieldsTableAdapter2.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MainfieldsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRdatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainfieldsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportDatabaseDataSet As WindowsApplication1.ReportDatabaseDataSet
    Friend WithEvents ReportDatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MRdatabaseDataSet As WindowsApplication1.MRdatabaseDataSet
    Friend WithEvents MainfieldsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainfieldsTableAdapter As WindowsApplication1.MRdatabaseDataSetTableAdapters.mainfieldsTableAdapter
    Friend WithEvents MRdatabaseDataSet1 As WindowsApplication1.MRdatabaseDataSet1
    Friend WithEvents MainfieldsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MainfieldsTableAdapter1 As WindowsApplication1.MRdatabaseDataSet1TableAdapters.mainfieldsTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.MRdatabaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MainfieldsTableAdapter2 As WindowsApplication1.MRdatabaseDataSet1TableAdapters.mainfieldsTableAdapter
End Class

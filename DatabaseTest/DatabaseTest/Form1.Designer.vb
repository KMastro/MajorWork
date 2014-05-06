<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Year_ReleasedLabel As System.Windows.Forms.Label
        Dim DirectorsLabel As System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblMoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MorgansMoviesDataSet = New WindowsApplication1.MorgansMoviesDataSet()
        Me.TblMoviesTableAdapter = New WindowsApplication1.MorgansMoviesDataSetTableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MorgansMoviesDataSetTableAdapters.TableAdapterManager()
        Me.MorgansMoviesDataSet1 = New WindowsApplication1.MorgansMoviesDataSet1()
        Me.TblMoviesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMoviesTableAdapter1 = New WindowsApplication1.MorgansMoviesDataSet1TableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.MorgansMoviesDataSet1TableAdapters.TableAdapterManager()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Year_ReleasedTextBox = New System.Windows.Forms.TextBox()
        Me.DirectorsTextBox = New System.Windows.Forms.TextBox()
        TitleLabel = New System.Windows.Forms.Label()
        Year_ReleasedLabel = New System.Windows.Forms.Label()
        DirectorsLabel = New System.Windows.Forms.Label()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorgansMoviesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorgansMoviesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblMoviesBindingSource, "Year Released", True))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(367, 238)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(485, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TblMoviesBindingSource
        '
        Me.TblMoviesBindingSource.DataMember = "tblMovies"
        Me.TblMoviesBindingSource.DataSource = Me.MorgansMoviesDataSet
        '
        'MorgansMoviesDataSet
        '
        Me.MorgansMoviesDataSet.DataSetName = "MorgansMoviesDataSet"
        Me.MorgansMoviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMoviesTableAdapter
        '
        Me.TblMoviesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGenresTableAdapter = Nothing
        Me.TableAdapterManager.tblMoviesTableAdapter = Me.TblMoviesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MorgansMoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MorgansMoviesDataSet1
        '
        Me.MorgansMoviesDataSet1.DataSetName = "MorgansMoviesDataSet1"
        Me.MorgansMoviesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMoviesBindingSource1
        '
        Me.TblMoviesBindingSource1.DataMember = "tblMovies"
        Me.TblMoviesBindingSource1.DataSource = Me.MorgansMoviesDataSet1
        '
        'TblMoviesTableAdapter1
        '
        Me.TblMoviesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblMoviesTableAdapter = Me.TblMoviesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.MorgansMoviesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(349, 421)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMoviesBindingSource1, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(385, 418)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'Year_ReleasedLabel
        '
        Year_ReleasedLabel.AutoSize = True
        Year_ReleasedLabel.Location = New System.Drawing.Point(299, 455)
        Year_ReleasedLabel.Name = "Year_ReleasedLabel"
        Year_ReleasedLabel.Size = New System.Drawing.Size(80, 13)
        Year_ReleasedLabel.TabIndex = 5
        Year_ReleasedLabel.Text = "Year Released:"
        '
        'Year_ReleasedTextBox
        '
        Me.Year_ReleasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMoviesBindingSource1, "Year Released", True))
        Me.Year_ReleasedTextBox.Location = New System.Drawing.Point(385, 452)
        Me.Year_ReleasedTextBox.Name = "Year_ReleasedTextBox"
        Me.Year_ReleasedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Year_ReleasedTextBox.TabIndex = 6
        '
        'DirectorsLabel
        '
        DirectorsLabel.AutoSize = True
        DirectorsLabel.Location = New System.Drawing.Point(327, 489)
        DirectorsLabel.Name = "DirectorsLabel"
        DirectorsLabel.Size = New System.Drawing.Size(52, 13)
        DirectorsLabel.TabIndex = 7
        DirectorsLabel.Text = "Directors:"
        '
        'DirectorsTextBox
        '
        Me.DirectorsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMoviesBindingSource1, "Directors", True))
        Me.DirectorsTextBox.Location = New System.Drawing.Point(385, 486)
        Me.DirectorsTextBox.Name = "DirectorsTextBox"
        Me.DirectorsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DirectorsTextBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 578)
        Me.Controls.Add(DirectorsLabel)
        Me.Controls.Add(Me.DirectorsTextBox)
        Me.Controls.Add(Year_ReleasedLabel)
        Me.Controls.Add(Me.Year_ReleasedTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorgansMoviesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorgansMoviesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MorgansMoviesDataSet As WindowsApplication1.MorgansMoviesDataSet
    Friend WithEvents TblMoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter As WindowsApplication1.MorgansMoviesDataSetTableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MorgansMoviesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MorgansMoviesDataSet1 As WindowsApplication1.MorgansMoviesDataSet1
    Friend WithEvents TblMoviesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter1 As WindowsApplication1.MorgansMoviesDataSet1TableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.MorgansMoviesDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Year_ReleasedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirectorsTextBox As System.Windows.Forms.TextBox

End Class

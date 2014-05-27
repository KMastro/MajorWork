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
        Me.TblMoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MorgansMoviesDataSet = New WindowsApplication1.MorgansMoviesDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblMoviesTableAdapter = New WindowsApplication1.MorgansMoviesDataSetTableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MorgansMoviesDataSetTableAdapters.TableAdapterManager()
        Me.MorgansMoviesDataSet1 = New WindowsApplication1.MorgansMoviesDataSet1()
        Me.TblMoviesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMoviesTableAdapter1 = New WindowsApplication1.MorgansMoviesDataSet1TableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.MorgansMoviesDataSet1TableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Txt_Title = New System.Windows.Forms.TextBox()
        Me.Txt_Year = New System.Windows.Forms.TextBox()
        Me.Txt_Genre = New System.Windows.Forms.TextBox()
        Me.Txt_Director = New System.Windows.Forms.TextBox()
        Me.Txt_Summary = New System.Windows.Forms.TextBox()
        Me.Txt_Actors = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorgansMoviesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorgansMoviesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(467, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(819, 231)
        Me.DataGridView1.TabIndex = 9
        '
        'Txt_Title
        '
        Me.Txt_Title.Location = New System.Drawing.Point(177, 284)
        Me.Txt_Title.Name = "Txt_Title"
        Me.Txt_Title.Size = New System.Drawing.Size(169, 20)
        Me.Txt_Title.TabIndex = 10
        '
        'Txt_Year
        '
        Me.Txt_Year.Location = New System.Drawing.Point(177, 332)
        Me.Txt_Year.Name = "Txt_Year"
        Me.Txt_Year.Size = New System.Drawing.Size(169, 20)
        Me.Txt_Year.TabIndex = 11
        '
        'Txt_Genre
        '
        Me.Txt_Genre.Location = New System.Drawing.Point(177, 369)
        Me.Txt_Genre.Name = "Txt_Genre"
        Me.Txt_Genre.Size = New System.Drawing.Size(169, 20)
        Me.Txt_Genre.TabIndex = 12
        '
        'Txt_Director
        '
        Me.Txt_Director.Location = New System.Drawing.Point(177, 414)
        Me.Txt_Director.Name = "Txt_Director"
        Me.Txt_Director.Size = New System.Drawing.Size(169, 20)
        Me.Txt_Director.TabIndex = 13
        '
        'Txt_Summary
        '
        Me.Txt_Summary.Location = New System.Drawing.Point(177, 516)
        Me.Txt_Summary.Name = "Txt_Summary"
        Me.Txt_Summary.Size = New System.Drawing.Size(169, 20)
        Me.Txt_Summary.TabIndex = 15
        '
        'Txt_Actors
        '
        Me.Txt_Actors.Location = New System.Drawing.Point(177, 463)
        Me.Txt_Actors.Name = "Txt_Actors"
        Me.Txt_Actors.Size = New System.Drawing.Size(169, 20)
        Me.Txt_Actors.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 523)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Summary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Genre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Director"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 470)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "1 Actor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 578)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Summary)
        Me.Controls.Add(Me.Txt_Actors)
        Me.Controls.Add(Me.Txt_Director)
        Me.Controls.Add(Me.Txt_Genre)
        Me.Controls.Add(Me.Txt_Year)
        Me.Controls.Add(Me.Txt_Title)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorgansMoviesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorgansMoviesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MorgansMoviesDataSet As WindowsApplication1.MorgansMoviesDataSet
    Friend WithEvents TblMoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter As WindowsApplication1.MorgansMoviesDataSetTableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MorgansMoviesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MorgansMoviesDataSet1 As WindowsApplication1.MorgansMoviesDataSet1
    Friend WithEvents TblMoviesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter1 As WindowsApplication1.MorgansMoviesDataSet1TableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.MorgansMoviesDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_Title As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Year As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Genre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Director As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Summary As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Actors As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class

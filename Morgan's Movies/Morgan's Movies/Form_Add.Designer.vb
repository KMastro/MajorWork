<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Add
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
        Dim GenreLabel As System.Windows.Forms.Label
        Dim Field1Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Add))
        Me.Pic_MoviePoster = New System.Windows.Forms.PictureBox()
        Me.Btn_Finish = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Year_ReleasedTextBox = New System.Windows.Forms.TextBox()
        Me.DirectorsTextBox = New System.Windows.Forms.TextBox()
        Me.GenreTextBox = New System.Windows.Forms.TextBox()
        Me.Actor1TextBox = New System.Windows.Forms.TextBox()
        Me.Actor3TextBox = New System.Windows.Forms.TextBox()
        Me.Actor2TextBox = New System.Windows.Forms.TextBox()
        Me.SummaryRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Field1TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MorgansMoviesDataSet2 = New Morgans_Movies.MorgansMoviesDataSet2()
        Me.TblMoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMoviesTableAdapter1 = New Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager2 = New Morgans_Movies.MorgansMoviesDataSet2TableAdapters.TableAdapterManager()
        Me.TblMoviesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblMoviesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblGenresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGenresTableAdapter1 = New Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblGenresTableAdapter()
        Me.TblActorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblActorsTableAdapter = New Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblActorsTableAdapter()
        TitleLabel = New System.Windows.Forms.Label()
        Year_ReleasedLabel = New System.Windows.Forms.Label()
        DirectorsLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        Field1Label = New System.Windows.Forms.Label()
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorgansMoviesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblMoviesBindingNavigator.SuspendLayout()
        CType(Me.TblGenresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.ForeColor = System.Drawing.Color.White
        TitleLabel.Location = New System.Drawing.Point(266, 38)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(65, 25)
        TitleLabel.TabIndex = 43
        TitleLabel.Text = "Title:"
        '
        'Year_ReleasedLabel
        '
        Year_ReleasedLabel.AutoSize = True
        Year_ReleasedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Year_ReleasedLabel.ForeColor = System.Drawing.Color.White
        Year_ReleasedLabel.Location = New System.Drawing.Point(266, 91)
        Year_ReleasedLabel.Name = "Year_ReleasedLabel"
        Year_ReleasedLabel.Size = New System.Drawing.Size(175, 25)
        Year_ReleasedLabel.TabIndex = 44
        Year_ReleasedLabel.Text = "Year Released:"
        '
        'DirectorsLabel
        '
        DirectorsLabel.AutoSize = True
        DirectorsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DirectorsLabel.ForeColor = System.Drawing.Color.White
        DirectorsLabel.Location = New System.Drawing.Point(266, 193)
        DirectorsLabel.Name = "DirectorsLabel"
        DirectorsLabel.Size = New System.Drawing.Size(102, 25)
        DirectorsLabel.TabIndex = 45
        DirectorsLabel.Text = "Director:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenreLabel.ForeColor = System.Drawing.Color.White
        GenreLabel.Location = New System.Drawing.Point(266, 140)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(83, 25)
        GenreLabel.TabIndex = 46
        GenreLabel.Text = "Genre:"
        '
        'Field1Label
        '
        Field1Label.AutoSize = True
        Field1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Field1Label.ForeColor = System.Drawing.Color.White
        Field1Label.Location = New System.Drawing.Point(266, 302)
        Field1Label.Name = "Field1Label"
        Field1Label.Size = New System.Drawing.Size(170, 25)
        Field1Label.TabIndex = 47
        Field1Label.Text = "Leading Roles:"
        '
        'Pic_MoviePoster
        '
        Me.Pic_MoviePoster.Image = CType(resources.GetObject("Pic_MoviePoster.Image"), System.Drawing.Image)
        Me.Pic_MoviePoster.Location = New System.Drawing.Point(77, 34)
        Me.Pic_MoviePoster.Name = "Pic_MoviePoster"
        Me.Pic_MoviePoster.Size = New System.Drawing.Size(150, 200)
        Me.Pic_MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_MoviePoster.TabIndex = 29
        Me.Pic_MoviePoster.TabStop = False
        '
        'Btn_Finish
        '
        Me.Btn_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finish.ForeColor = System.Drawing.Color.White
        Me.Btn_Finish.Location = New System.Drawing.Point(598, 395)
        Me.Btn_Finish.Name = "Btn_Finish"
        Me.Btn_Finish.Size = New System.Drawing.Size(99, 55)
        Me.Btn_Finish.TabIndex = 28
        Me.Btn_Finish.Text = "Finish"
        Me.Btn_Finish.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancel.Location = New System.Drawing.Point(42, 395)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(99, 55)
        Me.Btn_Cancel.TabIndex = 27
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(477, 34)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(220, 29)
        Me.TitleTextBox.TabIndex = 44
        '
        'Year_ReleasedTextBox
        '
        Me.Year_ReleasedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_ReleasedTextBox.ForeColor = System.Drawing.Color.Black
        Me.Year_ReleasedTextBox.Location = New System.Drawing.Point(477, 85)
        Me.Year_ReleasedTextBox.Name = "Year_ReleasedTextBox"
        Me.Year_ReleasedTextBox.Size = New System.Drawing.Size(220, 31)
        Me.Year_ReleasedTextBox.TabIndex = 45
        '
        'DirectorsTextBox
        '
        Me.DirectorsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectorsTextBox.Location = New System.Drawing.Point(477, 187)
        Me.DirectorsTextBox.Name = "DirectorsTextBox"
        Me.DirectorsTextBox.Size = New System.Drawing.Size(220, 31)
        Me.DirectorsTextBox.TabIndex = 46
        '
        'GenreTextBox
        '
        Me.GenreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreTextBox.Location = New System.Drawing.Point(477, 136)
        Me.GenreTextBox.Name = "GenreTextBox"
        Me.GenreTextBox.Size = New System.Drawing.Size(220, 29)
        Me.GenreTextBox.TabIndex = 47
        '
        'Actor1TextBox
        '
        Me.Actor1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actor1TextBox.Location = New System.Drawing.Point(477, 298)
        Me.Actor1TextBox.Name = "Actor1TextBox"
        Me.Actor1TextBox.Size = New System.Drawing.Size(220, 29)
        Me.Actor1TextBox.TabIndex = 48
        '
        'Actor3TextBox
        '
        Me.Actor3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actor3TextBox.Location = New System.Drawing.Point(477, 341)
        Me.Actor3TextBox.Name = "Actor3TextBox"
        Me.Actor3TextBox.Size = New System.Drawing.Size(220, 29)
        Me.Actor3TextBox.TabIndex = 49
        '
        'Actor2TextBox
        '
        Me.Actor2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actor2TextBox.Location = New System.Drawing.Point(271, 341)
        Me.Actor2TextBox.Name = "Actor2TextBox"
        Me.Actor2TextBox.Size = New System.Drawing.Size(189, 29)
        Me.Actor2TextBox.TabIndex = 50
        '
        'SummaryRichTextBox
        '
        Me.SummaryRichTextBox.Location = New System.Drawing.Point(42, 240)
        Me.SummaryRichTextBox.Name = "SummaryRichTextBox"
        Me.SummaryRichTextBox.Size = New System.Drawing.Size(218, 130)
        Me.SummaryRichTextBox.TabIndex = 51
        Me.SummaryRichTextBox.Text = ""
        '
        'Field1TextBox
        '
        Me.Field1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Field1TextBox.Location = New System.Drawing.Point(477, 298)
        Me.Field1TextBox.Name = "Field1TextBox"
        Me.Field1TextBox.Size = New System.Drawing.Size(220, 29)
        Me.Field1TextBox.TabIndex = 48
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(271, 341)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(189, 29)
        Me.TextBox2.TabIndex = 50
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(477, 341)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 29)
        Me.TextBox1.TabIndex = 49
        '
        'MorgansMoviesDataSet2
        '
        Me.MorgansMoviesDataSet2.DataSetName = "MorgansMoviesDataSet2"
        Me.MorgansMoviesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMoviesBindingSource
        '
        Me.TblMoviesBindingSource.DataMember = "tblMovies"
        Me.TblMoviesBindingSource.DataSource = Me.MorgansMoviesDataSet2
        '
        'TblMoviesTableAdapter1
        '
        Me.TblMoviesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tblActorsTableAdapter = Me.TblActorsTableAdapter
        Me.TableAdapterManager2.tblGenresTableAdapter = Me.TblGenresTableAdapter1
        Me.TableAdapterManager2.tblMoviesTableAdapter = Me.TblMoviesTableAdapter1
        Me.TableAdapterManager2.UpdateOrder = Morgans_Movies.MorgansMoviesDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMoviesBindingNavigator
        '
        Me.TblMoviesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblMoviesBindingNavigator.BindingSource = Me.TblMoviesBindingSource
        Me.TblMoviesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblMoviesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblMoviesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblMoviesBindingNavigatorSaveItem})
        Me.TblMoviesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblMoviesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblMoviesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblMoviesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblMoviesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblMoviesBindingNavigator.Name = "TblMoviesBindingNavigator"
        Me.TblMoviesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblMoviesBindingNavigator.Size = New System.Drawing.Size(751, 25)
        Me.TblMoviesBindingNavigator.TabIndex = 52
        Me.TblMoviesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblMoviesBindingNavigatorSaveItem
        '
        Me.TblMoviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblMoviesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblMoviesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblMoviesBindingNavigatorSaveItem.Name = "TblMoviesBindingNavigatorSaveItem"
        Me.TblMoviesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblMoviesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblGenresBindingSource
        '
        Me.TblGenresBindingSource.DataMember = "tblGenres"
        Me.TblGenresBindingSource.DataSource = Me.MorgansMoviesDataSet2
        '
        'TblGenresTableAdapter1
        '
        Me.TblGenresTableAdapter1.ClearBeforeFill = True
        '
        'TblActorsBindingSource
        '
        Me.TblActorsBindingSource.DataMember = "tblActors"
        Me.TblActorsBindingSource.DataSource = Me.MorgansMoviesDataSet2
        '
        'TblActorsTableAdapter
        '
        Me.TblActorsTableAdapter.ClearBeforeFill = True
        '
        'Form_Add
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(751, 470)
        Me.Controls.Add(Me.TblMoviesBindingNavigator)
        Me.Controls.Add(Me.SummaryRichTextBox)
        Me.Controls.Add(Me.Actor2TextBox)
        Me.Controls.Add(Me.Actor3TextBox)
        Me.Controls.Add(Field1Label)
        Me.Controls.Add(Me.Actor1TextBox)
        Me.Controls.Add(GenreLabel)
        Me.Controls.Add(Me.GenreTextBox)
        Me.Controls.Add(DirectorsLabel)
        Me.Controls.Add(Me.DirectorsTextBox)
        Me.Controls.Add(Year_ReleasedLabel)
        Me.Controls.Add(Me.Year_ReleasedTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Pic_MoviePoster)
        Me.Controls.Add(Me.Btn_Finish)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan's Movies"
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorgansMoviesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblMoviesBindingNavigator.ResumeLayout(False)
        Me.TblMoviesBindingNavigator.PerformLayout()
        CType(Me.TblGenresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_MoviePoster As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Finish As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Year_ReleasedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirectorsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Actor1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Actor3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Actor2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SummaryRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TblGenresTableAdapter As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblGenresTableAdapter
    Friend WithEvents TableAdapterManager1 As MorgansMoviesDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents MorgansMoviesDataSet As Morgans_Movies.MorgansMoviesDataSet2
    Friend WithEvents TableAdapterManager As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents TblMoviesTableAdapter As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblMoviesTableAdapter
    Friend WithEvents Field1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MorgansMoviesDataSet2 As Morgans_Movies.MorgansMoviesDataSet2
    Friend WithEvents TblMoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter1 As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager2 As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents TblMoviesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblMoviesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblGenresTableAdapter1 As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblGenresTableAdapter
    Friend WithEvents TblGenresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblActorsTableAdapter As Morgans_Movies.MorgansMoviesDataSet2TableAdapters.tblActorsTableAdapter
    Friend WithEvents TblActorsBindingSource As System.Windows.Forms.BindingSource
End Class

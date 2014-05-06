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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Add))
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Year_ReleasedLabel As System.Windows.Forms.Label
        Me.TxtBox_Genre = New System.Windows.Forms.TextBox()
        Me.TxtBox_Director = New System.Windows.Forms.TextBox()
        Me.TxtBox_Actor1 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Actor2 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Actor3 = New System.Windows.Forms.TextBox()
        Me.Lbl_Year = New System.Windows.Forms.Label()
        Me.Lbl_Genre = New System.Windows.Forms.Label()
        Me.Lbl_Director = New System.Windows.Forms.Label()
        Me.Lbl_LeadingRoles = New System.Windows.Forms.Label()
        Me.RichTxt_Summary = New System.Windows.Forms.RichTextBox()
        Me.Pic_MoviePoster = New System.Windows.Forms.PictureBox()
        Me.Btn_Finish = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.MorgansMoviesDataSet = New Morgans_Movies.MorgansMoviesDataSet()
        Me.TblMoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMoviesTableAdapter = New Morgans_Movies.MorgansMoviesDataSetTableAdapters.tblMoviesTableAdapter()
        Me.TableAdapterManager = New Morgans_Movies.MorgansMoviesDataSetTableAdapters.TableAdapterManager()
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
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Year_ReleasedTextBox = New System.Windows.Forms.TextBox()
        TitleLabel = New System.Windows.Forms.Label()
        Year_ReleasedLabel = New System.Windows.Forms.Label()
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MorgansMoviesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMoviesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblMoviesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBox_Genre
        '
        Me.TxtBox_Genre.BackColor = System.Drawing.Color.White
        Me.TxtBox_Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Genre.Location = New System.Drawing.Point(477, 138)
        Me.TxtBox_Genre.Name = "TxtBox_Genre"
        Me.TxtBox_Genre.Size = New System.Drawing.Size(220, 29)
        Me.TxtBox_Genre.TabIndex = 41
        '
        'TxtBox_Director
        '
        Me.TxtBox_Director.BackColor = System.Drawing.Color.White
        Me.TxtBox_Director.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Director.Location = New System.Drawing.Point(477, 188)
        Me.TxtBox_Director.Name = "TxtBox_Director"
        Me.TxtBox_Director.Size = New System.Drawing.Size(220, 29)
        Me.TxtBox_Director.TabIndex = 40
        '
        'TxtBox_Actor1
        '
        Me.TxtBox_Actor1.BackColor = System.Drawing.Color.White
        Me.TxtBox_Actor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Actor1.Location = New System.Drawing.Point(477, 298)
        Me.TxtBox_Actor1.Name = "TxtBox_Actor1"
        Me.TxtBox_Actor1.Size = New System.Drawing.Size(220, 29)
        Me.TxtBox_Actor1.TabIndex = 39
        '
        'TxtBox_Actor2
        '
        Me.TxtBox_Actor2.BackColor = System.Drawing.Color.White
        Me.TxtBox_Actor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Actor2.Location = New System.Drawing.Point(271, 343)
        Me.TxtBox_Actor2.Name = "TxtBox_Actor2"
        Me.TxtBox_Actor2.Size = New System.Drawing.Size(198, 29)
        Me.TxtBox_Actor2.TabIndex = 38
        '
        'TxtBox_Actor3
        '
        Me.TxtBox_Actor3.BackColor = System.Drawing.Color.White
        Me.TxtBox_Actor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Actor3.Location = New System.Drawing.Point(477, 343)
        Me.TxtBox_Actor3.Name = "TxtBox_Actor3"
        Me.TxtBox_Actor3.Size = New System.Drawing.Size(220, 29)
        Me.TxtBox_Actor3.TabIndex = 37
        '
        'Lbl_Year
        '
        Me.Lbl_Year.AutoSize = True
        Me.Lbl_Year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMoviesBindingSource, "Year Released", True))
        Me.Lbl_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Year.ForeColor = System.Drawing.Color.White
        Me.Lbl_Year.Location = New System.Drawing.Point(266, 86)
        Me.Lbl_Year.Name = "Lbl_Year"
        Me.Lbl_Year.Size = New System.Drawing.Size(175, 25)
        Me.Lbl_Year.TabIndex = 35
        Me.Lbl_Year.Text = "Year Released:"
        '
        'Lbl_Genre
        '
        Me.Lbl_Genre.AutoSize = True
        Me.Lbl_Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Genre.ForeColor = System.Drawing.Color.White
        Me.Lbl_Genre.Location = New System.Drawing.Point(266, 140)
        Me.Lbl_Genre.Name = "Lbl_Genre"
        Me.Lbl_Genre.Size = New System.Drawing.Size(83, 25)
        Me.Lbl_Genre.TabIndex = 34
        Me.Lbl_Genre.Text = "Genre:"
        '
        'Lbl_Director
        '
        Me.Lbl_Director.AutoSize = True
        Me.Lbl_Director.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Director.ForeColor = System.Drawing.Color.White
        Me.Lbl_Director.Location = New System.Drawing.Point(266, 190)
        Me.Lbl_Director.Name = "Lbl_Director"
        Me.Lbl_Director.Size = New System.Drawing.Size(102, 25)
        Me.Lbl_Director.TabIndex = 33
        Me.Lbl_Director.Text = "Director:"
        '
        'Lbl_LeadingRoles
        '
        Me.Lbl_LeadingRoles.AutoSize = True
        Me.Lbl_LeadingRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LeadingRoles.ForeColor = System.Drawing.Color.White
        Me.Lbl_LeadingRoles.Location = New System.Drawing.Point(266, 300)
        Me.Lbl_LeadingRoles.Name = "Lbl_LeadingRoles"
        Me.Lbl_LeadingRoles.Size = New System.Drawing.Size(170, 25)
        Me.Lbl_LeadingRoles.TabIndex = 32
        Me.Lbl_LeadingRoles.Text = "Leading Roles:"
        '
        'RichTxt_Summary
        '
        Me.RichTxt_Summary.BackColor = System.Drawing.Color.White
        Me.RichTxt_Summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTxt_Summary.Location = New System.Drawing.Point(42, 240)
        Me.RichTxt_Summary.Name = "RichTxt_Summary"
        Me.RichTxt_Summary.Size = New System.Drawing.Size(218, 130)
        Me.RichTxt_Summary.TabIndex = 30
        Me.RichTxt_Summary.Text = ""
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
        'MorgansMoviesDataSet
        '
        Me.MorgansMoviesDataSet.DataSetName = "MorgansMoviesDataSet"
        Me.MorgansMoviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMoviesBindingSource
        '
        Me.TblMoviesBindingSource.DataMember = "tblMovies"
        Me.TblMoviesBindingSource.DataSource = Me.MorgansMoviesDataSet
        '
        'TblMoviesTableAdapter
        '
        Me.TblMoviesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblMoviesTableAdapter = Me.TblMoviesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Morgans_Movies.MorgansMoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TblMoviesBindingNavigator.Size = New System.Drawing.Size(742, 25)
        Me.TblMoviesBindingNavigator.TabIndex = 43
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblMoviesBindingNavigatorSaveItem
        '
        Me.TblMoviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblMoviesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblMoviesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblMoviesBindingNavigatorSaveItem.Name = "TblMoviesBindingNavigatorSaveItem"
        Me.TblMoviesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblMoviesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.ForeColor = System.Drawing.Color.White
        TitleLabel.Location = New System.Drawing.Point(267, 39)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(56, 24)
        TitleLabel.TabIndex = 43
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMoviesBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(477, 36)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(220, 29)
        Me.TitleTextBox.TabIndex = 44
        '
        'Year_ReleasedLabel
        '
        Year_ReleasedLabel.AutoSize = True
        Year_ReleasedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Year_ReleasedLabel.ForeColor = System.Drawing.Color.White
        Year_ReleasedLabel.Location = New System.Drawing.Point(267, 89)
        Year_ReleasedLabel.Name = "Year_ReleasedLabel"
        Year_ReleasedLabel.Size = New System.Drawing.Size(175, 25)
        Year_ReleasedLabel.TabIndex = 44
        Year_ReleasedLabel.Text = "Year Released:"
        '
        'Year_ReleasedTextBox
        '
        Me.Year_ReleasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMoviesBindingSource, "Year Released", True))
        Me.Year_ReleasedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_ReleasedTextBox.ForeColor = System.Drawing.Color.White
        Me.Year_ReleasedTextBox.Location = New System.Drawing.Point(477, 89)
        Me.Year_ReleasedTextBox.Name = "Year_ReleasedTextBox"
        Me.Year_ReleasedTextBox.Size = New System.Drawing.Size(220, 31)
        Me.Year_ReleasedTextBox.TabIndex = 45
        '
        'Form_Add
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(742, 470)
        Me.Controls.Add(Year_ReleasedLabel)
        Me.Controls.Add(Me.Year_ReleasedTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.TblMoviesBindingNavigator)
        Me.Controls.Add(Me.TxtBox_Genre)
        Me.Controls.Add(Me.TxtBox_Director)
        Me.Controls.Add(Me.TxtBox_Actor1)
        Me.Controls.Add(Me.TxtBox_Actor2)
        Me.Controls.Add(Me.TxtBox_Actor3)
        Me.Controls.Add(Me.Lbl_Year)
        Me.Controls.Add(Me.Lbl_Genre)
        Me.Controls.Add(Me.Lbl_Director)
        Me.Controls.Add(Me.Lbl_LeadingRoles)
        Me.Controls.Add(Me.RichTxt_Summary)
        Me.Controls.Add(Me.Pic_MoviePoster)
        Me.Controls.Add(Me.Btn_Finish)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan's Movies"
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MorgansMoviesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMoviesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblMoviesBindingNavigator.ResumeLayout(False)
        Me.TblMoviesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBox_Genre As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Director As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Actor1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Actor2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Actor3 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Year As System.Windows.Forms.Label
    Friend WithEvents Lbl_Genre As System.Windows.Forms.Label
    Friend WithEvents Lbl_Director As System.Windows.Forms.Label
    Friend WithEvents Lbl_LeadingRoles As System.Windows.Forms.Label
    Friend WithEvents RichTxt_Summary As System.Windows.Forms.RichTextBox
    Friend WithEvents Pic_MoviePoster As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Finish As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents MorgansMoviesDataSet As Morgans_Movies.MorgansMoviesDataSet
    Friend WithEvents TblMoviesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMoviesTableAdapter As Morgans_Movies.MorgansMoviesDataSetTableAdapters.tblMoviesTableAdapter
    Friend WithEvents TableAdapterManager As Morgans_Movies.MorgansMoviesDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Year_ReleasedTextBox As System.Windows.Forms.TextBox
End Class

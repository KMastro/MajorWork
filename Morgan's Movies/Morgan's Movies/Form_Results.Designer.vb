<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Results
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Results))
        Me.Btn_Watch = New System.Windows.Forms.Button()
        Me.RichListBox_Summary = New System.Windows.Forms.RichTextBox()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Lbl_Year = New System.Windows.Forms.Label()
        Me.Lbl_Director = New System.Windows.Forms.Label()
        Me.Lbl_Genre = New System.Windows.Forms.Label()
        Me.Lbl_Actor1 = New System.Windows.Forms.Label()
        Me.Lbl_Actor2 = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Pic_MoviePoster = New System.Windows.Forms.PictureBox()
        Me.Lbl_Results = New System.Windows.Forms.Label()
        Me.ListBox_Results = New System.Windows.Forms.ListBox()
        Me.Btn_Back = New System.Windows.Forms.Button()
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Watch
        '
        Me.Btn_Watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Watch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Watch.ForeColor = System.Drawing.Color.White
        Me.Btn_Watch.Location = New System.Drawing.Point(232, 398)
        Me.Btn_Watch.Name = "Btn_Watch"
        Me.Btn_Watch.Size = New System.Drawing.Size(142, 55)
        Me.Btn_Watch.TabIndex = 41
        Me.Btn_Watch.Text = "Watch"
        Me.Btn_Watch.UseVisualStyleBackColor = True
        '
        'RichListBox_Summary
        '
        Me.RichListBox_Summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichListBox_Summary.Location = New System.Drawing.Point(14, 296)
        Me.RichListBox_Summary.Name = "RichListBox_Summary"
        Me.RichListBox_Summary.ReadOnly = True
        Me.RichListBox_Summary.Size = New System.Drawing.Size(360, 81)
        Me.RichListBox_Summary.TabIndex = 40
        Me.RichListBox_Summary.Text = "Movie Summary"
        '
        'Btn_Edit
        '
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.ForeColor = System.Drawing.Color.White
        Me.Btn_Edit.Location = New System.Drawing.Point(14, 398)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(142, 55)
        Me.Btn_Edit.TabIndex = 39
        Me.Btn_Edit.Text = "Edit / Remove"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Lbl_Year
        '
        Me.Lbl_Year.AutoSize = True
        Me.Lbl_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Year.ForeColor = System.Drawing.Color.White
        Me.Lbl_Year.Location = New System.Drawing.Point(170, 101)
        Me.Lbl_Year.Name = "Lbl_Year"
        Me.Lbl_Year.Size = New System.Drawing.Size(53, 24)
        Me.Lbl_Year.TabIndex = 38
        Me.Lbl_Year.Text = "Year"
        '
        'Lbl_Director
        '
        Me.Lbl_Director.AutoSize = True
        Me.Lbl_Director.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Director.ForeColor = System.Drawing.Color.White
        Me.Lbl_Director.Location = New System.Drawing.Point(170, 217)
        Me.Lbl_Director.Name = "Lbl_Director"
        Me.Lbl_Director.Size = New System.Drawing.Size(83, 24)
        Me.Lbl_Director.TabIndex = 37
        Me.Lbl_Director.Text = "Director"
        '
        'Lbl_Genre
        '
        Me.Lbl_Genre.AutoSize = True
        Me.Lbl_Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Genre.ForeColor = System.Drawing.Color.White
        Me.Lbl_Genre.Location = New System.Drawing.Point(170, 151)
        Me.Lbl_Genre.Name = "Lbl_Genre"
        Me.Lbl_Genre.Size = New System.Drawing.Size(68, 24)
        Me.Lbl_Genre.TabIndex = 36
        Me.Lbl_Genre.Text = "Genre"
        '
        'Lbl_Actor1
        '
        Me.Lbl_Actor1.AutoSize = True
        Me.Lbl_Actor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Actor1.ForeColor = System.Drawing.Color.White
        Me.Lbl_Actor1.Location = New System.Drawing.Point(10, 269)
        Me.Lbl_Actor1.Name = "Lbl_Actor1"
        Me.Lbl_Actor1.Size = New System.Drawing.Size(76, 24)
        Me.Lbl_Actor1.TabIndex = 35
        Me.Lbl_Actor1.Text = "Actor 1"
        '
        'Lbl_Actor2
        '
        Me.Lbl_Actor2.AutoSize = True
        Me.Lbl_Actor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Actor2.ForeColor = System.Drawing.Color.White
        Me.Lbl_Actor2.Location = New System.Drawing.Point(170, 269)
        Me.Lbl_Actor2.Name = "Lbl_Actor2"
        Me.Lbl_Actor2.Size = New System.Drawing.Size(76, 24)
        Me.Lbl_Actor2.TabIndex = 34
        Me.Lbl_Actor2.Text = "Actor 2"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.White
        Me.Lbl_Title.Location = New System.Drawing.Point(170, 41)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(50, 24)
        Me.Lbl_Title.TabIndex = 33
        Me.Lbl_Title.Text = "Title"
        '
        'Pic_MoviePoster
        '
        Me.Pic_MoviePoster.Location = New System.Drawing.Point(14, 41)
        Me.Pic_MoviePoster.Name = "Pic_MoviePoster"
        Me.Pic_MoviePoster.Size = New System.Drawing.Size(150, 200)
        Me.Pic_MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_MoviePoster.TabIndex = 32
        Me.Pic_MoviePoster.TabStop = False
        '
        'Lbl_Results
        '
        Me.Lbl_Results.AutoSize = True
        Me.Lbl_Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Results.ForeColor = System.Drawing.Color.White
        Me.Lbl_Results.Location = New System.Drawing.Point(518, 14)
        Me.Lbl_Results.Name = "Lbl_Results"
        Me.Lbl_Results.Size = New System.Drawing.Size(78, 24)
        Me.Lbl_Results.TabIndex = 31
        Me.Lbl_Results.Text = "Results"
        '
        'ListBox_Results
        '
        Me.ListBox_Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Results.FormattingEnabled = True
        Me.ListBox_Results.ItemHeight = 24
        Me.ListBox_Results.Location = New System.Drawing.Point(392, 41)
        Me.ListBox_Results.Name = "ListBox_Results"
        Me.ListBox_Results.ScrollAlwaysVisible = True
        Me.ListBox_Results.Size = New System.Drawing.Size(340, 412)
        Me.ListBox_Results.Sorted = True
        Me.ListBox_Results.TabIndex = 30
        '
        'Btn_Back
        '
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Back.ForeColor = System.Drawing.Color.White
        Me.Btn_Back.Location = New System.Drawing.Point(14, 12)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(79, 24)
        Me.Btn_Back.TabIndex = 42
        Me.Btn_Back.Text = "<--"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'Form_Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(742, 466)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Btn_Watch)
        Me.Controls.Add(Me.RichListBox_Summary)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Lbl_Year)
        Me.Controls.Add(Me.Lbl_Director)
        Me.Controls.Add(Me.Lbl_Genre)
        Me.Controls.Add(Me.Lbl_Actor1)
        Me.Controls.Add(Me.Lbl_Actor2)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.Pic_MoviePoster)
        Me.Controls.Add(Me.Lbl_Results)
        Me.Controls.Add(Me.ListBox_Results)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan's Movies"
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Watch As System.Windows.Forms.Button
    Friend WithEvents RichListBox_Summary As System.Windows.Forms.RichTextBox
    Friend WithEvents Btn_Edit As System.Windows.Forms.Button
    Friend WithEvents Lbl_Year As System.Windows.Forms.Label
    Friend WithEvents Lbl_Director As System.Windows.Forms.Label
    Friend WithEvents Lbl_Genre As System.Windows.Forms.Label
    Friend WithEvents Lbl_Actor1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Actor2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Pic_MoviePoster As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Results As System.Windows.Forms.Label
    Friend WithEvents ListBox_Results As System.Windows.Forms.ListBox
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Add))
        Me.TxtBox_Year = New System.Windows.Forms.TextBox()
        Me.TxtBox_Genre = New System.Windows.Forms.TextBox()
        Me.TxtBox_Director = New System.Windows.Forms.TextBox()
        Me.TxtBox_Actor1 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Actor2 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Actor3 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Title = New System.Windows.Forms.TextBox()
        Me.Lbl_Year = New System.Windows.Forms.Label()
        Me.Lbl_Genre = New System.Windows.Forms.Label()
        Me.Lbl_Director = New System.Windows.Forms.Label()
        Me.Lbl_LeadingRoles = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.RichTxt_Summary = New System.Windows.Forms.RichTextBox()
        Me.Pic_MoviePoster = New System.Windows.Forms.PictureBox()
        Me.Btn_Finish = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        CType(Me.Pic_MoviePoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBox_Year
        '
        Me.TxtBox_Year.BackColor = System.Drawing.Color.White
        Me.TxtBox_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Year.Location = New System.Drawing.Point(477, 84)
        Me.TxtBox_Year.Name = "TxtBox_Year"
        Me.TxtBox_Year.Size = New System.Drawing.Size(220, 29)
        Me.TxtBox_Year.TabIndex = 42
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
        'TxtBox_Title
        '
        Me.TxtBox_Title.BackColor = System.Drawing.Color.White
        Me.TxtBox_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_Title.Location = New System.Drawing.Point(477, 34)
        Me.TxtBox_Title.Name = "TxtBox_Title"
        Me.TxtBox_Title.Size = New System.Drawing.Size(220, 29)
        Me.TxtBox_Title.TabIndex = 36
        '
        'Lbl_Year
        '
        Me.Lbl_Year.AutoSize = True
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
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.White
        Me.Lbl_Title.Location = New System.Drawing.Point(266, 36)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(65, 25)
        Me.Lbl_Title.TabIndex = 31
        Me.Lbl_Title.Text = "Title:"
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
        'Form_Add
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(742, 466)
        Me.Controls.Add(Me.TxtBox_Year)
        Me.Controls.Add(Me.TxtBox_Genre)
        Me.Controls.Add(Me.TxtBox_Director)
        Me.Controls.Add(Me.TxtBox_Actor1)
        Me.Controls.Add(Me.TxtBox_Actor2)
        Me.Controls.Add(Me.TxtBox_Actor3)
        Me.Controls.Add(Me.TxtBox_Title)
        Me.Controls.Add(Me.Lbl_Year)
        Me.Controls.Add(Me.Lbl_Genre)
        Me.Controls.Add(Me.Lbl_Director)
        Me.Controls.Add(Me.Lbl_LeadingRoles)
        Me.Controls.Add(Me.Lbl_Title)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBox_Year As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Genre As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Director As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Actor1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Actor2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Actor3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Title As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Year As System.Windows.Forms.Label
    Friend WithEvents Lbl_Genre As System.Windows.Forms.Label
    Friend WithEvents Lbl_Director As System.Windows.Forms.Label
    Friend WithEvents Lbl_LeadingRoles As System.Windows.Forms.Label
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents RichTxt_Summary As System.Windows.Forms.RichTextBox
    Friend WithEvents Pic_MoviePoster As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Finish As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
End Class

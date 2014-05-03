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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(266, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Year Released:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(266, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Genre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(266, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Director:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(266, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Leading Roles:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(266, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Title:"
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
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTxt_Summary As System.Windows.Forms.RichTextBox
    Friend WithEvents Pic_MoviePoster As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Finish As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
End Class

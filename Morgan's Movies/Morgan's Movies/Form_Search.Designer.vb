<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Search))
        Me.RB_Title = New System.Windows.Forms.RadioButton()
        Me.Btn_RecentlyAdded = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_ShowAll = New System.Windows.Forms.Button()
        Me.RB_Genre = New System.Windows.Forms.RadioButton()
        Me.RB_Actor = New System.Windows.Forms.RadioButton()
        Me.RB_Director = New System.Windows.Forms.RadioButton()
        Me.Lbl_SelectCatagory = New System.Windows.Forms.Label()
        Me.Label_EnterKeyword = New System.Windows.Forms.Label()
        Me.Txtbox_Keyword = New System.Windows.Forms.TextBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RB_Title
        '
        Me.RB_Title.AutoSize = True
        Me.RB_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Title.ForeColor = System.Drawing.Color.White
        Me.RB_Title.Location = New System.Drawing.Point(249, 181)
        Me.RB_Title.Name = "RB_Title"
        Me.RB_Title.Size = New System.Drawing.Size(58, 22)
        Me.RB_Title.TabIndex = 22
        Me.RB_Title.TabStop = True
        Me.RB_Title.Text = "Title"
        Me.RB_Title.UseVisualStyleBackColor = True
        '
        'Btn_RecentlyAdded
        '
        Me.Btn_RecentlyAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_RecentlyAdded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RecentlyAdded.ForeColor = System.Drawing.Color.White
        Me.Btn_RecentlyAdded.Location = New System.Drawing.Point(497, 386)
        Me.Btn_RecentlyAdded.Name = "Btn_RecentlyAdded"
        Me.Btn_RecentlyAdded.Size = New System.Drawing.Size(99, 55)
        Me.Btn_RecentlyAdded.TabIndex = 21
        Me.Btn_RecentlyAdded.Text = "Recently Added"
        Me.Btn_RecentlyAdded.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.White
        Me.Btn_Add.Location = New System.Drawing.Point(322, 386)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(99, 55)
        Me.Btn_Add.TabIndex = 20
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_ShowAll
        '
        Me.Btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ShowAll.ForeColor = System.Drawing.Color.White
        Me.Btn_ShowAll.Location = New System.Drawing.Point(146, 386)
        Me.Btn_ShowAll.Name = "Btn_ShowAll"
        Me.Btn_ShowAll.Size = New System.Drawing.Size(99, 55)
        Me.Btn_ShowAll.TabIndex = 19
        Me.Btn_ShowAll.Text = "Show All"
        Me.Btn_ShowAll.UseVisualStyleBackColor = True
        '
        'RB_Genre
        '
        Me.RB_Genre.AutoSize = True
        Me.RB_Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Genre.ForeColor = System.Drawing.Color.White
        Me.RB_Genre.Location = New System.Drawing.Point(426, 181)
        Me.RB_Genre.Name = "RB_Genre"
        Me.RB_Genre.Size = New System.Drawing.Size(72, 22)
        Me.RB_Genre.TabIndex = 18
        Me.RB_Genre.TabStop = True
        Me.RB_Genre.Text = "Genre"
        Me.RB_Genre.UseVisualStyleBackColor = True
        '
        'RB_Actor
        '
        Me.RB_Actor.AutoSize = True
        Me.RB_Actor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Actor.ForeColor = System.Drawing.Color.White
        Me.RB_Actor.Location = New System.Drawing.Point(249, 222)
        Me.RB_Actor.Name = "RB_Actor"
        Me.RB_Actor.Size = New System.Drawing.Size(66, 22)
        Me.RB_Actor.TabIndex = 17
        Me.RB_Actor.TabStop = True
        Me.RB_Actor.Text = "Actor"
        Me.RB_Actor.UseVisualStyleBackColor = True
        '
        'RB_Director
        '
        Me.RB_Director.AutoSize = True
        Me.RB_Director.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Director.ForeColor = System.Drawing.Color.White
        Me.RB_Director.Location = New System.Drawing.Point(426, 222)
        Me.RB_Director.Name = "RB_Director"
        Me.RB_Director.Size = New System.Drawing.Size(87, 22)
        Me.RB_Director.TabIndex = 16
        Me.RB_Director.TabStop = True
        Me.RB_Director.Text = "Director"
        Me.RB_Director.UseVisualStyleBackColor = True
        '
        'Lbl_SelectCatagory
        '
        Me.Lbl_SelectCatagory.AutoSize = True
        Me.Lbl_SelectCatagory.BackColor = System.Drawing.Color.Magenta
        Me.Lbl_SelectCatagory.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SelectCatagory.ForeColor = System.Drawing.Color.White
        Me.Lbl_SelectCatagory.Location = New System.Drawing.Point(244, 142)
        Me.Lbl_SelectCatagory.Name = "Lbl_SelectCatagory"
        Me.Lbl_SelectCatagory.Size = New System.Drawing.Size(265, 29)
        Me.Lbl_SelectCatagory.TabIndex = 15
        Me.Lbl_SelectCatagory.Text = "Select Search Catagory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label_EnterKeyword
        '
        Me.Label_EnterKeyword.AutoSize = True
        Me.Label_EnterKeyword.BackColor = System.Drawing.Color.Magenta
        Me.Label_EnterKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_EnterKeyword.ForeColor = System.Drawing.Color.White
        Me.Label_EnterKeyword.Location = New System.Drawing.Point(262, 26)
        Me.Label_EnterKeyword.Name = "Label_EnterKeyword"
        Me.Label_EnterKeyword.Size = New System.Drawing.Size(236, 29)
        Me.Label_EnterKeyword.TabIndex = 14
        Me.Label_EnterKeyword.Text = "Enter Keyword Here:"
        '
        'Txtbox_Keyword
        '
        Me.Txtbox_Keyword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Keyword.BackColor = System.Drawing.SystemColors.Window
        Me.Txtbox_Keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtbox_Keyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Keyword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txtbox_Keyword.Location = New System.Drawing.Point(146, 58)
        Me.Txtbox_Keyword.MaxLength = 20
        Me.Txtbox_Keyword.Name = "Txtbox_Keyword"
        Me.Txtbox_Keyword.Size = New System.Drawing.Size(450, 29)
        Me.Txtbox_Keyword.TabIndex = 13
        Me.Txtbox_Keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Search
        '
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Location = New System.Drawing.Point(249, 285)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(249, 55)
        Me.Btn_Search.TabIndex = 23
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Form_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(742, 466)
        Me.Controls.Add(Me.RB_Title)
        Me.Controls.Add(Me.Btn_RecentlyAdded)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_ShowAll)
        Me.Controls.Add(Me.RB_Genre)
        Me.Controls.Add(Me.RB_Actor)
        Me.Controls.Add(Me.RB_Director)
        Me.Controls.Add(Me.Lbl_SelectCatagory)
        Me.Controls.Add(Me.Label_EnterKeyword)
        Me.Controls.Add(Me.Txtbox_Keyword)
        Me.Controls.Add(Me.Btn_Search)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morgan's Movies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB_Title As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_RecentlyAdded As System.Windows.Forms.Button
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents Btn_ShowAll As System.Windows.Forms.Button
    Friend WithEvents RB_Genre As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Actor As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Director As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_SelectCatagory As System.Windows.Forms.Label
    Friend WithEvents Label_EnterKeyword As System.Windows.Forms.Label
    Friend WithEvents Txtbox_Keyword As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
End Class

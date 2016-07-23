<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.labelID = New System.Windows.Forms.Label()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.Exitbutton = New System.Windows.Forms.Button()
        Me.ls = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(73, 34)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 17)
        Me.labelID.TabIndex = 0
        Me.labelID.Text = "ID"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.Location = New System.Drawing.Point(25, 69)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(69, 17)
        Me.LabelPass.TabIndex = 1
        Me.LabelPass.Text = "Password"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(112, 31)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(174, 22)
        Me.txtid.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(112, 66)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(174, 22)
        Me.txtpass.TabIndex = 3
        '
        'loginbutton
        '
        Me.loginbutton.Location = New System.Drawing.Point(226, 105)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(65, 28)
        Me.loginbutton.TabIndex = 5
        Me.loginbutton.Text = "&Login"
        Me.loginbutton.UseVisualStyleBackColor = True
        '
        'Exitbutton
        '
        Me.Exitbutton.Location = New System.Drawing.Point(300, 105)
        Me.Exitbutton.Name = "Exitbutton"
        Me.Exitbutton.Size = New System.Drawing.Size(65, 28)
        Me.Exitbutton.TabIndex = 6
        Me.Exitbutton.Text = "&Exit"
        Me.Exitbutton.UseVisualStyleBackColor = True
        '
        'ls
        '
        Me.ls.AutoSize = True
        Me.ls.Location = New System.Drawing.Point(298, 33)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(62, 21)
        Me.ls.TabIndex = 4
        Me.ls.Text = "Save"
        Me.ls.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 142)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.Exitbutton)
        Me.Controls.Add(Me.loginbutton)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.LabelPass)
        Me.Controls.Add(Me.labelID)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelID As System.Windows.Forms.Label
    Friend WithEvents LabelPass As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents loginbutton As System.Windows.Forms.Button
    Friend WithEvents Exitbutton As System.Windows.Forms.Button
    Friend WithEvents ls As System.Windows.Forms.CheckBox
End Class

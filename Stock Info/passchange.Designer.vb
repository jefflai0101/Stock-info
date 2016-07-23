<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passchange
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
        Me.confirm = New System.Windows.Forms.Button()
        Me.oldpass = New System.Windows.Forms.TextBox()
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.connew = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'confirm
        '
        Me.confirm.ForeColor = System.Drawing.Color.Black
        Me.confirm.Location = New System.Drawing.Point(118, 187)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(107, 27)
        Me.confirm.TabIndex = 2
        Me.confirm.Text = "Confirm"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'oldpass
        '
        Me.oldpass.Location = New System.Drawing.Point(171, 34)
        Me.oldpass.Name = "oldpass"
        Me.oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpass.Size = New System.Drawing.Size(114, 22)
        Me.oldpass.TabIndex = 3
        '
        'newpass
        '
        Me.newpass.Location = New System.Drawing.Point(171, 82)
        Me.newpass.Name = "newpass"
        Me.newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpass.Size = New System.Drawing.Size(114, 22)
        Me.newpass.TabIndex = 4
        '
        'connew
        '
        Me.connew.Location = New System.Drawing.Point(171, 129)
        Me.connew.Name = "connew"
        Me.connew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.connew.Size = New System.Drawing.Size(114, 22)
        Me.connew.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirm New"
        '
        'passchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(344, 255)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.connew)
        Me.Controls.Add(Me.newpass)
        Me.Controls.Add(Me.oldpass)
        Me.Controls.Add(Me.confirm)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "passchange"
        Me.ShowInTaskbar = False
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents confirm As System.Windows.Forms.Button
    Friend WithEvents oldpass As System.Windows.Forms.TextBox
    Friend WithEvents newpass As System.Windows.Forms.TextBox
    Friend WithEvents connew As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

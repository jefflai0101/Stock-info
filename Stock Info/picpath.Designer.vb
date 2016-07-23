<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class picpath
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
        Me.foldname = New System.Windows.Forms.ComboBox()
        Me.confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'foldname
        '
        Me.foldname.FormattingEnabled = True
        Me.foldname.Location = New System.Drawing.Point(19, 34)
        Me.foldname.Name = "foldname"
        Me.foldname.Size = New System.Drawing.Size(226, 24)
        Me.foldname.TabIndex = 2
        '
        'confirm
        '
        Me.confirm.ForeColor = System.Drawing.Color.Black
        Me.confirm.Location = New System.Drawing.Point(76, 81)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(107, 27)
        Me.confirm.TabIndex = 3
        Me.confirm.Text = "Confirm"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'picpath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(260, 133)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.foldname)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "picpath"
        Me.ShowInTaskbar = False
        Me.Text = "Picture Folder Select"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents foldname As System.Windows.Forms.ComboBox
    Friend WithEvents confirm As System.Windows.Forms.Button
End Class

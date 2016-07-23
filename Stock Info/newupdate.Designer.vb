<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newupdate
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
        Me.sname = New System.Windows.Forms.Label()
        Me.stp = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.sno = New System.Windows.Forms.Label()
        Me.swl = New System.Windows.Forms.CheckBox()
        Me.quotetext = New System.Windows.Forms.TextBox()
        Me.nametext = New System.Windows.Forms.TextBox()
        Me.tptext = New System.Windows.Forms.TextBox()
        Me.lstext = New System.Windows.Forms.TextBox()
        Me.sls = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sname
        '
        Me.sname.AutoSize = True
        Me.sname.Location = New System.Drawing.Point(44, 72)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(45, 17)
        Me.sname.TabIndex = 0
        Me.sname.Text = "Name"
        '
        'stp
        '
        Me.stp.AutoSize = True
        Me.stp.Location = New System.Drawing.Point(44, 149)
        Me.stp.Name = "stp"
        Me.stp.Size = New System.Drawing.Size(86, 17)
        Me.stp.TabIndex = 1
        Me.stp.Text = "Target Price"
        '
        'Confirm
        '
        Me.Confirm.ForeColor = System.Drawing.Color.Black
        Me.Confirm.Location = New System.Drawing.Point(135, 226)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(90, 32)
        Me.Confirm.TabIndex = 4
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'sno
        '
        Me.sno.AutoSize = True
        Me.sno.Location = New System.Drawing.Point(44, 35)
        Me.sno.Name = "sno"
        Me.sno.Size = New System.Drawing.Size(47, 17)
        Me.sno.TabIndex = 5
        Me.sno.Text = "Quote"
        '
        'swl
        '
        Me.swl.AutoSize = True
        Me.swl.Location = New System.Drawing.Point(155, 192)
        Me.swl.Name = "swl"
        Me.swl.Size = New System.Drawing.Size(96, 21)
        Me.swl.TabIndex = 7
        Me.swl.Text = "Watch List"
        Me.swl.UseVisualStyleBackColor = True
        '
        'quotetext
        '
        Me.quotetext.Enabled = False
        Me.quotetext.Location = New System.Drawing.Point(155, 32)
        Me.quotetext.Name = "quotetext"
        Me.quotetext.Size = New System.Drawing.Size(114, 22)
        Me.quotetext.TabIndex = 8
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(155, 69)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(114, 22)
        Me.nametext.TabIndex = 9
        '
        'tptext
        '
        Me.tptext.Location = New System.Drawing.Point(155, 146)
        Me.tptext.Name = "tptext"
        Me.tptext.Size = New System.Drawing.Size(114, 22)
        Me.tptext.TabIndex = 10
        '
        'lstext
        '
        Me.lstext.Enabled = False
        Me.lstext.Location = New System.Drawing.Point(155, 107)
        Me.lstext.Name = "lstext"
        Me.lstext.Size = New System.Drawing.Size(114, 22)
        Me.lstext.TabIndex = 11
        '
        'sls
        '
        Me.sls.AutoSize = True
        Me.sls.Location = New System.Drawing.Point(44, 112)
        Me.sls.Name = "sls"
        Me.sls.Size = New System.Drawing.Size(59, 17)
        Me.sls.TabIndex = 12
        Me.sls.Text = "Lot Size"
        '
        'newupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(362, 300)
        Me.Controls.Add(Me.sls)
        Me.Controls.Add(Me.lstext)
        Me.Controls.Add(Me.tptext)
        Me.Controls.Add(Me.nametext)
        Me.Controls.Add(Me.quotetext)
        Me.Controls.Add(Me.swl)
        Me.Controls.Add(Me.sno)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.stp)
        Me.Controls.Add(Me.sname)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newupdate"
        Me.ShowInTaskbar = False
        Me.Text = "Update Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sname As System.Windows.Forms.Label
    Friend WithEvents stp As System.Windows.Forms.Label
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents sno As System.Windows.Forms.Label
    Friend WithEvents swl As System.Windows.Forms.CheckBox
    Friend WithEvents quotetext As System.Windows.Forms.TextBox
    Friend WithEvents nametext As System.Windows.Forms.TextBox
    Friend WithEvents tptext As System.Windows.Forms.TextBox
    Friend WithEvents lstext As System.Windows.Forms.TextBox
    Friend WithEvents sls As System.Windows.Forms.Label
End Class

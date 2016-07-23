<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Portfolio
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
        Me.fieldpanel = New System.Windows.Forms.Panel()
        Me.sname0 = New System.Windows.Forms.Label()
        Me.spc0 = New System.Windows.Forms.Label()
        Me.svolume0 = New System.Windows.Forms.Label()
        Me.slow0 = New System.Windows.Forms.Label()
        Me.shigh0 = New System.Windows.Forms.Label()
        Me.sprice0 = New System.Windows.Forms.Label()
        Me.squote0 = New System.Windows.Forms.Label()
        Me.schange0 = New System.Windows.Forms.Label()
        Me.sln0 = New System.Windows.Forms.Label()
        Me.sample1 = New System.Windows.Forms.Label()
        Me.sample2 = New System.Windows.Forms.Label()
        Me.sample3 = New System.Windows.Forms.Label()
        Me.sample4 = New System.Windows.Forms.Label()
        Me.sample5 = New System.Windows.Forms.Label()
        Me.sample6 = New System.Windows.Forms.Label()
        Me.sample7 = New System.Windows.Forms.Label()
        Me.sample8 = New System.Windows.Forms.Label()
        Me.sample9 = New System.Windows.Forms.Label()
        Me.infopanel = New System.Windows.Forms.Panel()
        Me.line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.WebBrowserRead = New System.Windows.Forms.WebBrowser()
        Me.changevalue = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.ow = New System.Windows.Forms.Label()
        Me.owvalue = New System.Windows.Forms.Label()
        Me.pwvalue = New System.Windows.Forms.Label()
        Me.pw = New System.Windows.Forms.Label()
        Me.addnew = New System.Windows.Forms.Label()
        Me.fieldpanel.SuspendLayout()
        Me.infopanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'fieldpanel
        '
        Me.fieldpanel.Controls.Add(Me.sname0)
        Me.fieldpanel.Controls.Add(Me.spc0)
        Me.fieldpanel.Controls.Add(Me.svolume0)
        Me.fieldpanel.Controls.Add(Me.slow0)
        Me.fieldpanel.Controls.Add(Me.shigh0)
        Me.fieldpanel.Controls.Add(Me.sprice0)
        Me.fieldpanel.Controls.Add(Me.squote0)
        Me.fieldpanel.Controls.Add(Me.schange0)
        Me.fieldpanel.Controls.Add(Me.sln0)
        Me.fieldpanel.Location = New System.Drawing.Point(54, 92)
        Me.fieldpanel.Name = "fieldpanel"
        Me.fieldpanel.Size = New System.Drawing.Size(988, 40)
        Me.fieldpanel.TabIndex = 31
        '
        'sname0
        '
        Me.sname0.AutoSize = True
        Me.sname0.Location = New System.Drawing.Point(127, 12)
        Me.sname0.Name = "sname0"
        Me.sname0.Size = New System.Drawing.Size(45, 17)
        Me.sname0.TabIndex = 38
        Me.sname0.Text = "Name"
        '
        'spc0
        '
        Me.spc0.AutoSize = True
        Me.spc0.Location = New System.Drawing.Point(579, 12)
        Me.spc0.Name = "spc0"
        Me.spc0.Size = New System.Drawing.Size(102, 17)
        Me.spc0.TabIndex = 37
        Me.spc0.Text = "Previous Close"
        '
        'svolume0
        '
        Me.svolume0.AutoSize = True
        Me.svolume0.Location = New System.Drawing.Point(910, 12)
        Me.svolume0.Name = "svolume0"
        Me.svolume0.Size = New System.Drawing.Size(55, 17)
        Me.svolume0.TabIndex = 36
        Me.svolume0.Text = "Volume"
        '
        'slow0
        '
        Me.slow0.AutoSize = True
        Me.slow0.Location = New System.Drawing.Point(821, 12)
        Me.slow0.Name = "slow0"
        Me.slow0.Size = New System.Drawing.Size(33, 17)
        Me.slow0.TabIndex = 35
        Me.slow0.Text = "Low"
        '
        'shigh0
        '
        Me.shigh0.AutoSize = True
        Me.shigh0.Location = New System.Drawing.Point(729, 12)
        Me.shigh0.Name = "shigh0"
        Me.shigh0.Size = New System.Drawing.Size(37, 17)
        Me.shigh0.TabIndex = 34
        Me.shigh0.Text = "High"
        '
        'sprice0
        '
        Me.sprice0.AutoSize = True
        Me.sprice0.Location = New System.Drawing.Point(248, 12)
        Me.sprice0.Name = "sprice0"
        Me.sprice0.Size = New System.Drawing.Size(40, 17)
        Me.sprice0.TabIndex = 33
        Me.sprice0.Text = "Price"
        '
        'squote0
        '
        Me.squote0.AutoSize = True
        Me.squote0.Location = New System.Drawing.Point(24, 12)
        Me.squote0.Name = "squote0"
        Me.squote0.Size = New System.Drawing.Size(47, 17)
        Me.squote0.TabIndex = 32
        Me.squote0.Text = "Quote"
        '
        'schange0
        '
        Me.schange0.AutoSize = True
        Me.schange0.Location = New System.Drawing.Point(470, 12)
        Me.schange0.Name = "schange0"
        Me.schange0.Size = New System.Drawing.Size(79, 17)
        Me.schange0.TabIndex = 31
        Me.schange0.Text = "Change(%)"
        '
        'sln0
        '
        Me.sln0.AutoSize = True
        Me.sln0.Location = New System.Drawing.Point(338, 12)
        Me.sln0.Name = "sln0"
        Me.sln0.Size = New System.Drawing.Size(83, 17)
        Me.sln0.TabIndex = 30
        Me.sln0.Text = "Net Change"
        '
        'sample1
        '
        Me.sample1.AutoSize = True
        Me.sample1.Location = New System.Drawing.Point(24, 12)
        Me.sample1.Name = "sample1"
        Me.sample1.Size = New System.Drawing.Size(51, 17)
        Me.sample1.TabIndex = 0
        Me.sample1.Text = "Label1"
        Me.sample1.Visible = False
        '
        'sample2
        '
        Me.sample2.AutoSize = True
        Me.sample2.Location = New System.Drawing.Point(127, 12)
        Me.sample2.Name = "sample2"
        Me.sample2.Size = New System.Drawing.Size(51, 17)
        Me.sample2.TabIndex = 1
        Me.sample2.Text = "Label1"
        Me.sample2.Visible = False
        '
        'sample3
        '
        Me.sample3.AutoSize = True
        Me.sample3.Location = New System.Drawing.Point(248, 12)
        Me.sample3.Name = "sample3"
        Me.sample3.Size = New System.Drawing.Size(51, 17)
        Me.sample3.TabIndex = 2
        Me.sample3.Text = "Label1"
        Me.sample3.Visible = False
        '
        'sample4
        '
        Me.sample4.AutoSize = True
        Me.sample4.Location = New System.Drawing.Point(338, 12)
        Me.sample4.Name = "sample4"
        Me.sample4.Size = New System.Drawing.Size(51, 17)
        Me.sample4.TabIndex = 3
        Me.sample4.Text = "Label1"
        Me.sample4.Visible = False
        '
        'sample5
        '
        Me.sample5.AutoSize = True
        Me.sample5.Location = New System.Drawing.Point(470, 12)
        Me.sample5.Name = "sample5"
        Me.sample5.Size = New System.Drawing.Size(51, 17)
        Me.sample5.TabIndex = 4
        Me.sample5.Text = "Label1"
        Me.sample5.Visible = False
        '
        'sample6
        '
        Me.sample6.AutoSize = True
        Me.sample6.Location = New System.Drawing.Point(579, 12)
        Me.sample6.Name = "sample6"
        Me.sample6.Size = New System.Drawing.Size(51, 17)
        Me.sample6.TabIndex = 5
        Me.sample6.Text = "Label1"
        Me.sample6.Visible = False
        '
        'sample7
        '
        Me.sample7.AutoSize = True
        Me.sample7.Location = New System.Drawing.Point(729, 12)
        Me.sample7.Name = "sample7"
        Me.sample7.Size = New System.Drawing.Size(51, 17)
        Me.sample7.TabIndex = 6
        Me.sample7.Text = "Label1"
        Me.sample7.Visible = False
        '
        'sample8
        '
        Me.sample8.AutoSize = True
        Me.sample8.Location = New System.Drawing.Point(821, 12)
        Me.sample8.Name = "sample8"
        Me.sample8.Size = New System.Drawing.Size(51, 17)
        Me.sample8.TabIndex = 7
        Me.sample8.Text = "Label1"
        Me.sample8.Visible = False
        '
        'sample9
        '
        Me.sample9.AutoSize = True
        Me.sample9.Location = New System.Drawing.Point(910, 12)
        Me.sample9.Name = "sample9"
        Me.sample9.Size = New System.Drawing.Size(51, 17)
        Me.sample9.TabIndex = 8
        Me.sample9.Text = "Label1"
        Me.sample9.Visible = False
        '
        'infopanel
        '
        Me.infopanel.Controls.Add(Me.sample9)
        Me.infopanel.Controls.Add(Me.sample8)
        Me.infopanel.Controls.Add(Me.sample7)
        Me.infopanel.Controls.Add(Me.sample6)
        Me.infopanel.Controls.Add(Me.sample5)
        Me.infopanel.Controls.Add(Me.sample4)
        Me.infopanel.Controls.Add(Me.sample3)
        Me.infopanel.Controls.Add(Me.sample2)
        Me.infopanel.Controls.Add(Me.sample1)
        Me.infopanel.Location = New System.Drawing.Point(54, 149)
        Me.infopanel.Name = "infopanel"
        Me.infopanel.Size = New System.Drawing.Size(988, 373)
        Me.infopanel.TabIndex = 39
        '
        'line1
        '
        Me.line1.BorderColor = System.Drawing.Color.White
        Me.line1.Name = "line1"
        Me.line1.X1 = 36
        Me.line1.X2 = 1069
        Me.line1.Y1 = 140
        Me.line1.Y2 = 140
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1121, 622)
        Me.ShapeContainer1.TabIndex = 40
        Me.ShapeContainer1.TabStop = False
        '
        'WebBrowserRead
        '
        Me.WebBrowserRead.Location = New System.Drawing.Point(1034, 528)
        Me.WebBrowserRead.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserRead.Name = "WebBrowserRead"
        Me.WebBrowserRead.Size = New System.Drawing.Size(36, 44)
        Me.WebBrowserRead.TabIndex = 41
        Me.WebBrowserRead.Visible = False
        '
        'changevalue
        '
        Me.changevalue.AutoSize = True
        Me.changevalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changevalue.Location = New System.Drawing.Point(755, 35)
        Me.changevalue.Name = "changevalue"
        Me.changevalue.Size = New System.Drawing.Size(0, 25)
        Me.changevalue.TabIndex = 48
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(662, 35)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(82, 25)
        Me.change.TabIndex = 47
        Me.change.Text = "Change"
        '
        'ow
        '
        Me.ow.AutoSize = True
        Me.ow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ow.Location = New System.Drawing.Point(410, 35)
        Me.ow.Name = "ow"
        Me.ow.Size = New System.Drawing.Size(137, 25)
        Me.ow.TabIndex = 46
        Me.ow.Text = "Original Worth"
        '
        'owvalue
        '
        Me.owvalue.AutoSize = True
        Me.owvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.owvalue.Location = New System.Drawing.Point(558, 35)
        Me.owvalue.Name = "owvalue"
        Me.owvalue.Size = New System.Drawing.Size(0, 25)
        Me.owvalue.TabIndex = 45
        '
        'pwvalue
        '
        Me.pwvalue.AutoSize = True
        Me.pwvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwvalue.Location = New System.Drawing.Point(313, 35)
        Me.pwvalue.Name = "pwvalue"
        Me.pwvalue.Size = New System.Drawing.Size(0, 25)
        Me.pwvalue.TabIndex = 44
        '
        'pw
        '
        Me.pw.AutoSize = True
        Me.pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.Location = New System.Drawing.Point(156, 35)
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(140, 25)
        Me.pw.TabIndex = 43
        Me.pw.Text = "Portfolio Worth"
        '
        'addnew
        '
        Me.addnew.AutoSize = True
        Me.addnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnew.Location = New System.Drawing.Point(833, 35)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(92, 25)
        Me.addnew.TabIndex = 49
        Me.addnew.Text = "Add New"
        '
        'Portfolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1121, 622)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.changevalue)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.ow)
        Me.Controls.Add(Me.owvalue)
        Me.Controls.Add(Me.pwvalue)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.WebBrowserRead)
        Me.Controls.Add(Me.infopanel)
        Me.Controls.Add(Me.fieldpanel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Portfolio"
        Me.Text = "Portfolio"
        Me.fieldpanel.ResumeLayout(False)
        Me.fieldpanel.PerformLayout()
        Me.infopanel.ResumeLayout(False)
        Me.infopanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fieldpanel As System.Windows.Forms.Panel
    Friend WithEvents sname0 As System.Windows.Forms.Label
    Friend WithEvents spc0 As System.Windows.Forms.Label
    Friend WithEvents svolume0 As System.Windows.Forms.Label
    Friend WithEvents slow0 As System.Windows.Forms.Label
    Friend WithEvents shigh0 As System.Windows.Forms.Label
    Friend WithEvents sprice0 As System.Windows.Forms.Label
    Friend WithEvents squote0 As System.Windows.Forms.Label
    Friend WithEvents schange0 As System.Windows.Forms.Label
    Friend WithEvents sln0 As System.Windows.Forms.Label
    Friend WithEvents sample1 As System.Windows.Forms.Label
    Friend WithEvents sample2 As System.Windows.Forms.Label
    Friend WithEvents sample3 As System.Windows.Forms.Label
    Friend WithEvents sample4 As System.Windows.Forms.Label
    Friend WithEvents sample5 As System.Windows.Forms.Label
    Friend WithEvents sample6 As System.Windows.Forms.Label
    Friend WithEvents sample7 As System.Windows.Forms.Label
    Friend WithEvents sample8 As System.Windows.Forms.Label
    Friend WithEvents sample9 As System.Windows.Forms.Label
    Friend WithEvents infopanel As System.Windows.Forms.Panel
    Friend WithEvents line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents WebBrowserRead As System.Windows.Forms.WebBrowser
    Friend WithEvents changevalue As System.Windows.Forms.Label
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents ow As System.Windows.Forms.Label
    Friend WithEvents owvalue As System.Windows.Forms.Label
    Friend WithEvents pwvalue As System.Windows.Forms.Label
    Friend WithEvents pw As System.Windows.Forms.Label
    Friend WithEvents addnew As System.Windows.Forms.Label
End Class

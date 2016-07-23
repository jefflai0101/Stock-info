<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainmenu
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
        Me.optionpanel = New System.Windows.Forms.Panel()
        Me.Labello = New System.Windows.Forms.Label()
        Me.Labelanalysis = New System.Windows.Forms.Label()
        Me.labelsq = New System.Windows.Forms.Label()
        Me.WebBrowserRead = New System.Windows.Forms.WebBrowser()
        Me.line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.fieldpanel = New System.Windows.Forms.Panel()
        Me.sname0 = New System.Windows.Forms.Label()
        Me.spc0 = New System.Windows.Forms.Label()
        Me.svolume0 = New System.Windows.Forms.Label()
        Me.slow0 = New System.Windows.Forms.Label()
        Me.shigh0 = New System.Windows.Forms.Label()
        Me.sprice0 = New System.Windows.Forms.Label()
        Me.squote0 = New System.Windows.Forms.Label()
        Me.schange0 = New System.Windows.Forms.Label()
        Me.snc0 = New System.Windows.Forms.Label()
        Me.infopanel = New System.Windows.Forms.Panel()
        Me.sample9 = New System.Windows.Forms.Label()
        Me.sample8 = New System.Windows.Forms.Label()
        Me.sample7 = New System.Windows.Forms.Label()
        Me.sample6 = New System.Windows.Forms.Label()
        Me.sample5 = New System.Windows.Forms.Label()
        Me.sample4 = New System.Windows.Forms.Label()
        Me.sample3 = New System.Windows.Forms.Label()
        Me.sample2 = New System.Windows.Forms.Label()
        Me.sample1 = New System.Windows.Forms.Label()
        Me.refreshlist = New System.Windows.Forms.Timer(Me.components)
        Me.Collect = New System.Windows.Forms.Timer(Me.components)
        Me.counttime = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.optionpanel.SuspendLayout()
        Me.fieldpanel.SuspendLayout()
        Me.infopanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'optionpanel
        '
        Me.optionpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optionpanel.Controls.Add(Me.Labello)
        Me.optionpanel.Controls.Add(Me.Labelanalysis)
        Me.optionpanel.Controls.Add(Me.labelsq)
        Me.optionpanel.Location = New System.Drawing.Point(254, 46)
        Me.optionpanel.Name = "optionpanel"
        Me.optionpanel.Size = New System.Drawing.Size(691, 74)
        Me.optionpanel.TabIndex = 5
        '
        'Labello
        '
        Me.Labello.AutoSize = True
        Me.Labello.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labello.Location = New System.Drawing.Point(555, 23)
        Me.Labello.Name = "Labello"
        Me.Labello.Size = New System.Drawing.Size(109, 29)
        Me.Labello.TabIndex = 9
        Me.Labello.Text = "Log Out"
        '
        'Labelanalysis
        '
        Me.Labelanalysis.AutoSize = True
        Me.Labelanalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelanalysis.Location = New System.Drawing.Point(295, 23)
        Me.Labelanalysis.Name = "Labelanalysis"
        Me.Labelanalysis.Size = New System.Drawing.Size(117, 29)
        Me.Labelanalysis.TabIndex = 7
        Me.Labelanalysis.Text = "Analysis"
        '
        'labelsq
        '
        Me.labelsq.AutoSize = True
        Me.labelsq.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelsq.Location = New System.Drawing.Point(27, 23)
        Me.labelsq.Name = "labelsq"
        Me.labelsq.Size = New System.Drawing.Size(163, 29)
        Me.labelsq.TabIndex = 5
        Me.labelsq.Text = "Stock Quote"
        '
        'WebBrowserRead
        '
        Me.WebBrowserRead.Location = New System.Drawing.Point(1132, 617)
        Me.WebBrowserRead.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserRead.Name = "WebBrowserRead"
        Me.WebBrowserRead.Size = New System.Drawing.Size(20, 23)
        Me.WebBrowserRead.TabIndex = 7
        Me.WebBrowserRead.Visible = False
        '
        'line1
        '
        Me.line1.BorderColor = System.Drawing.Color.White
        Me.line1.Name = "line1"
        Me.line1.X1 = 92
        Me.line1.X2 = 1125
        Me.line1.Y1 = 205
        Me.line1.Y2 = 205
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1190, 693)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
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
        Me.fieldpanel.Controls.Add(Me.snc0)
        Me.fieldpanel.Location = New System.Drawing.Point(107, 162)
        Me.fieldpanel.Name = "fieldpanel"
        Me.fieldpanel.Size = New System.Drawing.Size(988, 40)
        Me.fieldpanel.TabIndex = 30
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
        'snc0
        '
        Me.snc0.AutoSize = True
        Me.snc0.Location = New System.Drawing.Point(338, 12)
        Me.snc0.Name = "snc0"
        Me.snc0.Size = New System.Drawing.Size(83, 17)
        Me.snc0.TabIndex = 30
        Me.snc0.Text = "Net Change"
        '
        'infopanel
        '
        Me.infopanel.AutoScroll = True
        Me.infopanel.Controls.Add(Me.sample9)
        Me.infopanel.Controls.Add(Me.sample8)
        Me.infopanel.Controls.Add(Me.sample7)
        Me.infopanel.Controls.Add(Me.sample6)
        Me.infopanel.Controls.Add(Me.sample5)
        Me.infopanel.Controls.Add(Me.sample4)
        Me.infopanel.Controls.Add(Me.sample3)
        Me.infopanel.Controls.Add(Me.sample2)
        Me.infopanel.Controls.Add(Me.sample1)
        Me.infopanel.Location = New System.Drawing.Point(38, 211)
        Me.infopanel.Name = "infopanel"
        Me.infopanel.Size = New System.Drawing.Size(1129, 425)
        Me.infopanel.TabIndex = 31
        '
        'sample9
        '
        Me.sample9.AutoSize = True
        Me.sample9.Location = New System.Drawing.Point(979, 12)
        Me.sample9.Name = "sample9"
        Me.sample9.Size = New System.Drawing.Size(51, 17)
        Me.sample9.TabIndex = 8
        Me.sample9.Text = "Label1"
        Me.sample9.Visible = False
        '
        'sample8
        '
        Me.sample8.AutoSize = True
        Me.sample8.Location = New System.Drawing.Point(890, 12)
        Me.sample8.Name = "sample8"
        Me.sample8.Size = New System.Drawing.Size(51, 17)
        Me.sample8.TabIndex = 7
        Me.sample8.Text = "Label1"
        Me.sample8.Visible = False
        '
        'sample7
        '
        Me.sample7.AutoSize = True
        Me.sample7.Location = New System.Drawing.Point(798, 12)
        Me.sample7.Name = "sample7"
        Me.sample7.Size = New System.Drawing.Size(51, 17)
        Me.sample7.TabIndex = 6
        Me.sample7.Text = "Label1"
        Me.sample7.Visible = False
        '
        'sample6
        '
        Me.sample6.AutoSize = True
        Me.sample6.Location = New System.Drawing.Point(648, 12)
        Me.sample6.Name = "sample6"
        Me.sample6.Size = New System.Drawing.Size(51, 17)
        Me.sample6.TabIndex = 5
        Me.sample6.Text = "Label1"
        Me.sample6.Visible = False
        '
        'sample5
        '
        Me.sample5.AutoSize = True
        Me.sample5.Location = New System.Drawing.Point(539, 12)
        Me.sample5.Name = "sample5"
        Me.sample5.Size = New System.Drawing.Size(51, 17)
        Me.sample5.TabIndex = 4
        Me.sample5.Text = "Label1"
        Me.sample5.Visible = False
        '
        'sample4
        '
        Me.sample4.AutoSize = True
        Me.sample4.Location = New System.Drawing.Point(407, 12)
        Me.sample4.Name = "sample4"
        Me.sample4.Size = New System.Drawing.Size(51, 17)
        Me.sample4.TabIndex = 3
        Me.sample4.Text = "Label1"
        Me.sample4.Visible = False
        '
        'sample3
        '
        Me.sample3.AutoSize = True
        Me.sample3.Location = New System.Drawing.Point(317, 12)
        Me.sample3.Name = "sample3"
        Me.sample3.Size = New System.Drawing.Size(51, 17)
        Me.sample3.TabIndex = 2
        Me.sample3.Text = "Label1"
        Me.sample3.Visible = False
        '
        'sample2
        '
        Me.sample2.AutoSize = True
        Me.sample2.Location = New System.Drawing.Point(196, 12)
        Me.sample2.Name = "sample2"
        Me.sample2.Size = New System.Drawing.Size(51, 17)
        Me.sample2.TabIndex = 1
        Me.sample2.Text = "Label1"
        Me.sample2.Visible = False
        '
        'sample1
        '
        Me.sample1.AutoSize = True
        Me.sample1.Location = New System.Drawing.Point(93, 12)
        Me.sample1.Name = "sample1"
        Me.sample1.Size = New System.Drawing.Size(51, 17)
        Me.sample1.TabIndex = 0
        Me.sample1.Text = "Label1"
        Me.sample1.Visible = False
        '
        'refreshlist
        '
        Me.refreshlist.Interval = 30000
        '
        'Collect
        '
        Me.Collect.Interval = 30000
        '
        'counttime
        '
        Me.counttime.Enabled = True
        Me.counttime.Interval = 15000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 639)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 639)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(477, 639)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(552, 639)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1190, 693)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.infopanel)
        Me.Controls.Add(Me.fieldpanel)
        Me.Controls.Add(Me.WebBrowserRead)
        Me.Controls.Add(Me.optionpanel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Mainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Manager"
        Me.optionpanel.ResumeLayout(False)
        Me.optionpanel.PerformLayout()
        Me.fieldpanel.ResumeLayout(False)
        Me.fieldpanel.PerformLayout()
        Me.infopanel.ResumeLayout(False)
        Me.infopanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optionpanel As System.Windows.Forms.Panel
    Friend WithEvents Labello As System.Windows.Forms.Label
    Friend WithEvents Labelanalysis As System.Windows.Forms.Label
    Friend WithEvents labelsq As System.Windows.Forms.Label
    Friend WithEvents WebBrowserRead As System.Windows.Forms.WebBrowser
    Friend WithEvents line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents fieldpanel As System.Windows.Forms.Panel
    Friend WithEvents sname0 As System.Windows.Forms.Label
    Friend WithEvents spc0 As System.Windows.Forms.Label
    Friend WithEvents svolume0 As System.Windows.Forms.Label
    Friend WithEvents slow0 As System.Windows.Forms.Label
    Friend WithEvents shigh0 As System.Windows.Forms.Label
    Friend WithEvents sprice0 As System.Windows.Forms.Label
    Friend WithEvents squote0 As System.Windows.Forms.Label
    Friend WithEvents schange0 As System.Windows.Forms.Label
    Friend WithEvents snc0 As System.Windows.Forms.Label
    Friend WithEvents infopanel As System.Windows.Forms.Panel
    Friend WithEvents sample9 As System.Windows.Forms.Label
    Friend WithEvents sample8 As System.Windows.Forms.Label
    Friend WithEvents sample7 As System.Windows.Forms.Label
    Friend WithEvents sample6 As System.Windows.Forms.Label
    Friend WithEvents sample5 As System.Windows.Forms.Label
    Friend WithEvents sample4 As System.Windows.Forms.Label
    Friend WithEvents sample3 As System.Windows.Forms.Label
    Friend WithEvents sample2 As System.Windows.Forms.Label
    Friend WithEvents sample1 As System.Windows.Forms.Label
    Friend WithEvents refreshlist As System.Windows.Forms.Timer
    Friend WithEvents Collect As System.Windows.Forms.Timer
    Friend WithEvents counttime As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Background
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Background))
        Me.setbg = New System.Windows.Forms.Timer(Me.components)
        Me.submenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemmain = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemsq = New System.Windows.Forms.ToolStripMenuItem()
        Me.itema = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemset = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemcp = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemcb = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemlo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemend = New System.Windows.Forms.ToolStripMenuItem()
        Me.Notifyicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.submenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'setbg
        '
        Me.setbg.Enabled = True
        Me.setbg.Interval = 5000
        '
        'submenu
        '
        Me.submenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemmain, Me.itemsq, Me.itema, Me.itemset, Me.itemlo, Me.itemend})
        Me.submenu.Name = "submenu"
        Me.submenu.Size = New System.Drawing.Size(160, 170)
        '
        'itemmain
        '
        Me.itemmain.Name = "itemmain"
        Me.itemmain.Size = New System.Drawing.Size(159, 24)
        Me.itemmain.Text = "&Main"
        '
        'itemsq
        '
        Me.itemsq.Name = "itemsq"
        Me.itemsq.Size = New System.Drawing.Size(159, 24)
        Me.itemsq.Text = "&Stock Quote"
        '
        'itema
        '
        Me.itema.Name = "itema"
        Me.itema.Size = New System.Drawing.Size(159, 24)
        Me.itema.Text = "&Analysis"
        '
        'itemset
        '
        Me.itemset.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemcp, Me.itemcb})
        Me.itemset.Name = "itemset"
        Me.itemset.Size = New System.Drawing.Size(159, 24)
        Me.itemset.Text = "&Settings"
        '
        'itemcp
        '
        Me.itemcp.Name = "itemcp"
        Me.itemcp.Size = New System.Drawing.Size(211, 24)
        Me.itemcp.Text = "Change &Password"
        '
        'itemcb
        '
        Me.itemcb.Name = "itemcb"
        Me.itemcb.Size = New System.Drawing.Size(211, 24)
        Me.itemcb.Text = "Change &Background"
        '
        'itemlo
        '
        Me.itemlo.Name = "itemlo"
        Me.itemlo.Size = New System.Drawing.Size(159, 24)
        Me.itemlo.Text = "&Log out"
        '
        'itemend
        '
        Me.itemend.Name = "itemend"
        Me.itemend.Size = New System.Drawing.Size(159, 24)
        Me.itemend.Text = "&End"
        '
        'Notifyicon
        '
        Me.Notifyicon.BalloonTipText = "Stock Manager"
        Me.Notifyicon.ContextMenuStrip = Me.submenu
        Me.Notifyicon.Icon = CType(resources.GetObject("Notifyicon.Icon"), System.Drawing.Icon)
        Me.Notifyicon.Tag = ""
        Me.Notifyicon.Text = "Stock Manager"
        Me.Notifyicon.Visible = True
        '
        'Background
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 765)
        Me.ControlBox = False
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Background"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Manager"
        Me.submenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents setbg As System.Windows.Forms.Timer
    Friend WithEvents submenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itemmain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemsq As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemcp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemcb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemlo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Notifyicon As System.Windows.Forms.NotifyIcon
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockQuote
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
        Me.stockno = New System.Windows.Forms.TextBox()
        Me.searchbutton = New System.Windows.Forms.Button()
        Me.WebBrowserBox = New System.Windows.Forms.WebBrowser()
        Me.saveinfo = New System.Windows.Forms.Button()
        Me.stocksinfo = New System.Windows.Forms.Panel()
        Me.stockquotename = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lotsize = New System.Windows.Forms.Label()
        Me.turnover = New System.Windows.Forms.Label()
        Me.volume = New System.Windows.Forms.Label()
        Me.prec = New System.Windows.Forms.Label()
        Me.low = New System.Windows.Forms.Label()
        Me.high = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pe = New System.Windows.Forms.Label()
        Me.ask = New System.Windows.Forms.Label()
        Me.bid = New System.Windows.Forms.Label()
        Me.ncp = New System.Windows.Forms.Label()
        Me.nc = New System.Windows.Forms.Label()
        Me.nprice = New System.Windows.Forms.Label()
        Me.stocksinfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'stockno
        '
        Me.stockno.Location = New System.Drawing.Point(171, 32)
        Me.stockno.Name = "stockno"
        Me.stockno.Size = New System.Drawing.Size(138, 22)
        Me.stockno.TabIndex = 0
        '
        'searchbutton
        '
        Me.searchbutton.ForeColor = System.Drawing.Color.Black
        Me.searchbutton.Location = New System.Drawing.Point(347, 29)
        Me.searchbutton.Name = "searchbutton"
        Me.searchbutton.Size = New System.Drawing.Size(72, 28)
        Me.searchbutton.TabIndex = 1
        Me.searchbutton.Text = "&Search"
        Me.searchbutton.UseVisualStyleBackColor = True
        '
        'WebBrowserBox
        '
        Me.WebBrowserBox.Location = New System.Drawing.Point(43, 646)
        Me.WebBrowserBox.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserBox.Name = "WebBrowserBox"
        Me.WebBrowserBox.Size = New System.Drawing.Size(22, 24)
        Me.WebBrowserBox.TabIndex = 26
        '
        'saveinfo
        '
        Me.saveinfo.ForeColor = System.Drawing.Color.Black
        Me.saveinfo.Location = New System.Drawing.Point(445, 29)
        Me.saveinfo.Name = "saveinfo"
        Me.saveinfo.Size = New System.Drawing.Size(127, 28)
        Me.saveinfo.TabIndex = 27
        Me.saveinfo.Text = "Update/Add New"
        Me.saveinfo.UseVisualStyleBackColor = True
        '
        'stocksinfo
        '
        Me.stocksinfo.Controls.Add(Me.stockquotename)
        Me.stocksinfo.Controls.Add(Me.Label12)
        Me.stocksinfo.Controls.Add(Me.Label11)
        Me.stocksinfo.Controls.Add(Me.Label10)
        Me.stocksinfo.Controls.Add(Me.Label9)
        Me.stocksinfo.Controls.Add(Me.Label8)
        Me.stocksinfo.Controls.Add(Me.Label7)
        Me.stocksinfo.Controls.Add(Me.lotsize)
        Me.stocksinfo.Controls.Add(Me.turnover)
        Me.stocksinfo.Controls.Add(Me.volume)
        Me.stocksinfo.Controls.Add(Me.prec)
        Me.stocksinfo.Controls.Add(Me.low)
        Me.stocksinfo.Controls.Add(Me.high)
        Me.stocksinfo.Controls.Add(Me.Label6)
        Me.stocksinfo.Controls.Add(Me.Label5)
        Me.stocksinfo.Controls.Add(Me.Label4)
        Me.stocksinfo.Controls.Add(Me.Label3)
        Me.stocksinfo.Controls.Add(Me.Label1)
        Me.stocksinfo.Controls.Add(Me.Label2)
        Me.stocksinfo.Controls.Add(Me.pe)
        Me.stocksinfo.Controls.Add(Me.ask)
        Me.stocksinfo.Controls.Add(Me.bid)
        Me.stocksinfo.Controls.Add(Me.ncp)
        Me.stocksinfo.Controls.Add(Me.nc)
        Me.stocksinfo.Controls.Add(Me.nprice)
        Me.stocksinfo.Location = New System.Drawing.Point(41, 74)
        Me.stocksinfo.Name = "stocksinfo"
        Me.stocksinfo.Size = New System.Drawing.Size(603, 256)
        Me.stocksinfo.TabIndex = 28
        '
        'stockquotename
        '
        Me.stockquotename.AutoSize = True
        Me.stockquotename.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockquotename.Location = New System.Drawing.Point(139, 20)
        Me.stockquotename.Name = "stockquotename"
        Me.stockquotename.Size = New System.Drawing.Size(0, 38)
        Me.stockquotename.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(407, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 17)
        Me.Label12.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(309, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 17)
        Me.Label11.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(221, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(531, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(469, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 44
        '
        'lotsize
        '
        Me.lotsize.AutoSize = True
        Me.lotsize.Location = New System.Drawing.Point(394, 184)
        Me.lotsize.Name = "lotsize"
        Me.lotsize.Size = New System.Drawing.Size(59, 17)
        Me.lotsize.TabIndex = 43
        Me.lotsize.Text = "Lot Size"
        '
        'turnover
        '
        Me.turnover.AutoSize = True
        Me.turnover.Location = New System.Drawing.Point(304, 184)
        Me.turnover.Name = "turnover"
        Me.turnover.Size = New System.Drawing.Size(66, 17)
        Me.turnover.TabIndex = 42
        Me.turnover.Text = "Turnover"
        '
        'volume
        '
        Me.volume.AutoSize = True
        Me.volume.Location = New System.Drawing.Point(219, 184)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(55, 17)
        Me.volume.TabIndex = 41
        Me.volume.Text = "Volume"
        '
        'prec
        '
        Me.prec.AutoSize = True
        Me.prec.Location = New System.Drawing.Point(82, 184)
        Me.prec.Name = "prec"
        Me.prec.Size = New System.Drawing.Size(102, 17)
        Me.prec.TabIndex = 40
        Me.prec.Text = "Previous Close"
        '
        'low
        '
        Me.low.AutoSize = True
        Me.low.Location = New System.Drawing.Point(533, 87)
        Me.low.Name = "low"
        Me.low.Size = New System.Drawing.Size(33, 17)
        Me.low.TabIndex = 39
        Me.low.Text = "Low"
        '
        'high
        '
        Me.high.AutoSize = True
        Me.high.Location = New System.Drawing.Point(469, 87)
        Me.high.Name = "high"
        Me.high.Size = New System.Drawing.Size(37, 17)
        Me.high.TabIndex = 38
        Me.high.Text = "High"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(485, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(387, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 32
        '
        'pe
        '
        Me.pe.AutoSize = True
        Me.pe.Location = New System.Drawing.Point(485, 184)
        Me.pe.Name = "pe"
        Me.pe.Size = New System.Drawing.Size(30, 17)
        Me.pe.TabIndex = 31
        Me.pe.Text = "P/E"
        '
        'ask
        '
        Me.ask.AutoSize = True
        Me.ask.Location = New System.Drawing.Point(390, 87)
        Me.ask.Name = "ask"
        Me.ask.Size = New System.Drawing.Size(31, 17)
        Me.ask.TabIndex = 30
        Me.ask.Text = "Ask"
        '
        'bid
        '
        Me.bid.AutoSize = True
        Me.bid.Location = New System.Drawing.Point(325, 87)
        Me.bid.Name = "bid"
        Me.bid.Size = New System.Drawing.Size(28, 17)
        Me.bid.TabIndex = 29
        Me.bid.Text = "Bid"
        '
        'ncp
        '
        Me.ncp.AutoSize = True
        Me.ncp.Location = New System.Drawing.Point(224, 87)
        Me.ncp.Name = "ncp"
        Me.ncp.Size = New System.Drawing.Size(83, 17)
        Me.ncp.TabIndex = 28
        Me.ncp.Text = "Change (%)"
        '
        'nc
        '
        Me.nc.AutoSize = True
        Me.nc.Location = New System.Drawing.Point(127, 87)
        Me.nc.Name = "nc"
        Me.nc.Size = New System.Drawing.Size(83, 17)
        Me.nc.TabIndex = 27
        Me.nc.Text = "Net Change"
        '
        'nprice
        '
        Me.nprice.AutoSize = True
        Me.nprice.Location = New System.Drawing.Point(19, 87)
        Me.nprice.Name = "nprice"
        Me.nprice.Size = New System.Drawing.Size(95, 17)
        Me.nprice.TabIndex = 26
        Me.nprice.Text = "Nominal Price"
        '
        'StockQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(684, 360)
        Me.Controls.Add(Me.stocksinfo)
        Me.Controls.Add(Me.saveinfo)
        Me.Controls.Add(Me.WebBrowserBox)
        Me.Controls.Add(Me.searchbutton)
        Me.Controls.Add(Me.stockno)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StockQuote"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Quote"
        Me.stocksinfo.ResumeLayout(False)
        Me.stocksinfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stockno As System.Windows.Forms.TextBox
    Friend WithEvents searchbutton As System.Windows.Forms.Button
    Friend WithEvents WebBrowserBox As System.Windows.Forms.WebBrowser
    Friend WithEvents saveinfo As System.Windows.Forms.Button
    Friend WithEvents stocksinfo As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lotsize As System.Windows.Forms.Label
    Friend WithEvents turnover As System.Windows.Forms.Label
    Friend WithEvents volume As System.Windows.Forms.Label
    Friend WithEvents prec As System.Windows.Forms.Label
    Friend WithEvents low As System.Windows.Forms.Label
    Friend WithEvents high As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pe As System.Windows.Forms.Label
    Friend WithEvents ask As System.Windows.Forms.Label
    Friend WithEvents bid As System.Windows.Forms.Label
    Friend WithEvents ncp As System.Windows.Forms.Label
    Friend WithEvents nc As System.Windows.Forms.Label
    Friend WithEvents nprice As System.Windows.Forms.Label
    Friend WithEvents stockquotename As System.Windows.Forms.Label

End Class

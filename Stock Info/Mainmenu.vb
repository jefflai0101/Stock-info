'Option Strict On
Imports System.Drawing

Public Class Mainmenu

    'Public declaration of new labels
    Public recorduptodate As Boolean = False
    Public lastobjno As Integer
    Public j As Integer = 0
    Public squote As Label() = New Label(j) {}
    Public sname As Label() = New Label(j) {}
    Public sprice As Label() = New Label(j) {}
    Public snc As Label() = New Label(j) {}
    Public schange As Label() = New Label(j) {}
    Public spc As Label() = New Label(j) {}
    Public shigh As Label() = New Label(j) {}
    Public slow As Label() = New Label(j) {}
    Public svolume As Label() = New Label(j) {}

    'Form Load
    Public Sub mainmenu_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        infopanel.Focus()
        dbread(0)
        Checktime()
        checkeach()
        clearlabel()
    End Sub

    'Clear label 1~5
    Private Sub clearlabel()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
    End Sub

    'Check with database
    Public Sub dbread(ByVal iod As Integer)
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim n As Integer
        Me.AutoScroll = True

        stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
        'stockdb.ConnectionString = "C:\Users\Jeff\Documents\Programs\VB.net\Stock info\Stock Info\stockinfo.mdb"
        stockdb.ConnectionString = dblocation
        stockdb.Open()
        rs.Open("Select * from companyinfo where Watchlist = true order by Stocknumber", stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 1)

        j = rs.RecordCount
        createnew(j)

        With rs
            For n = 0 To .RecordCount - 1
                LoadData(.Fields(0).Value, n, 1)
                squote(n).Text = .Fields(0).Value
                sname(n).Text = .Fields(1).Value
                .MoveNext()
            Next n
            .Close()
        End With
        stockdb.Close()
        infopanel.Focus()
    End Sub

    'Focus on mainmenu
    Private Sub Mainmenu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        infopanel.Focus()
    End Sub

    'Create new objects
    Private Sub createnew(ByVal i As Integer)
        Dim n As Integer = 0
        'Redimension the number of labels required
        If lastobjno <> 0 Then
            If lastobjno > i Then
                i = lastobjno - 1
                For n = 0 To i
                    squote(n).Dispose()
                    sname(n).Dispose()
                    sprice(n).Dispose()
                    snc(n).Dispose()
                    schange(n).Dispose()
                    spc(n).Dispose()
                    shigh(n).Dispose()
                    slow(n).Dispose()
                    svolume(n).Dispose()
                Next n
            End If

            If lastobjno < i Then
                i = lastobjno + 1
                For n = 0 To i - 2
                    squote(n).Dispose()
                    sname(n).Dispose()
                    sprice(n).Dispose()
                    snc(n).Dispose()
                    schange(n).Dispose()
                    spc(n).Dispose()
                    shigh(n).Dispose()
                    slow(n).Dispose()
                    svolume(n).Dispose()
                Next n
            End If

            If lastobjno = i Then
                For n = 0 To i - 1
                    squote(n).Dispose()
                    sname(n).Dispose()
                    sprice(n).Dispose()
                    snc(n).Dispose()
                    schange(n).Dispose()
                    spc(n).Dispose()
                    shigh(n).Dispose()
                    slow(n).Dispose()
                    svolume(n).Dispose()
                Next n
            End If
        End If

        ReDim squote(i - 1)
        ReDim sname(i - 1)
        ReDim sprice(i - 1)
        ReDim snc(i - 1)
        ReDim schange(i - 1)
        ReDim spc(i - 1)
        ReDim shigh(i - 1)
        ReDim slow(i - 1)
        ReDim svolume(i - 1)

        For n = 0 To i - 1

            squote(n) = New Label
            squote(n).SetBounds(sample1.Location.X, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(squote(n))

            sname(n) = New Label
            sname(n).SetBounds(sample2.Location.X, 12 + 35 * n, 120, 30)
            infopanel.Controls.Add(sname(n))

            sprice(n) = New Label
            sprice(n).SetBounds(sample3.Location.X, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(sprice(n))

            snc(n) = New Label
            snc(n).SetBounds(sample4.Location.X, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(snc(n))

            schange(n) = New Label
            schange(n).SetBounds(sample5.Left, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(schange(n))

            spc(n) = New Label
            spc(n).SetBounds(sample6.Location.X, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(spc(n))

            shigh(n) = New Label
            shigh(n).SetBounds(sample7.Location.X, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(shigh(n))

            slow(n) = New Label
            slow(n).SetBounds(sample8.Location.X, 12 + 35 * n, 50, 30)
            infopanel.Controls.Add(slow(n))

            svolume(n) = New Label
            svolume(n).SetBounds(sample9.Location.X, 12 + 35 * n, 110, 30)
            infopanel.Controls.Add(svolume(n))

        Next

        lastobjno = i
    End Sub

    'Collect Information from internet
    Private Sub LoadData(ByVal stockno As Integer, ByVal n As Integer, ByVal getmode As Integer)
        '載入網頁
        WebBrowserRead.Navigate("http://www.hkex.com.hk/eng/invest/company/quote_page_e.asp?WidCoID=" & Val(stockno) & "&WidCoAbbName=&Month=1&langcode=e")
        '等待網頁載入完成
        Loading(WebBrowserRead)
        '抓資料
        GetData(n, getmode)
    End Sub

    'Load the website
    Sub Loading(ByRef [web] As WebBrowser)
        Do Until WebBrowserRead.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
    End Sub

    'Filter Information
    Private Sub GetData(ByVal i As Integer, ByVal getmode As Integer)
        Dim countinfo As Integer = 0

        'Search HTML tag that matches FONT and count specific no. to fill info
        For Each [HtmlElement] As HtmlElement In WebBrowserRead.Document.All
            If [HtmlElement].TagName = "FONT" Then
                countinfo = countinfo + 1
                If getmode = 1 Then
                    Select Case countinfo
                        Case 19
                            sprice(i).Text = ([HtmlElement].OuterText)
                        Case 20
                            If [HtmlElement].OuterText = "N/A" Then
                                snc(i).Text = 0
                            Else
                                snc(i).Text = ([HtmlElement].OuterText)
                            End If
                        Case 21
                            If [HtmlElement].OuterText = "N/A" Then
                                schange(i).Text = 0
                            Else
                                schange(i).Text = ([HtmlElement].OuterText)
                            End If
                        Case 31
                            shigh(i).Text = ([HtmlElement].OuterText)
                        Case 32
                            slow(i).Text = ([HtmlElement].OuterText)
                        Case 33
                            spc(i).Text = ([HtmlElement].OuterText)
                        Case 34
                            svolume(i).Text = ([HtmlElement].OuterText) & ",000"
                    End Select
                Else
                    Select Case countinfo
                        Case 19
                            Label1.Text = FormatNumber([HtmlElement].OuterText, 2, , , TriState.False)
                        Case 20
                            If [HtmlElement].OuterText = "N/A" Then
                                Label2.Text = 0
                            Else
                                Label2.Text = FormatNumber([HtmlElement].OuterText, 2, , , TriState.False)
                            End If
                        Case 21
                            If [HtmlElement].OuterText = "N/A" Then
                                Label3.Text = 0
                            Else
                                Label3.Text = FormatNumber([HtmlElement].OuterText, 2, , , TriState.False)
                            End If
                        Case 31
                            Label4.Text = FormatNumber([HtmlElement].OuterText, 2, , , TriState.False)
                        Case 32
                            Label5.Text = FormatNumber([HtmlElement].OuterText, 2, , , TriState.False)
                    End Select
                End If
            End If
        Next

        If Val(sprice(i).Text) > Val(spc(i).Text) Then
            snc(i).ForeColor = Color.Green
            schange(i).ForeColor = Color.Green
        End If

        If Val(sprice(i).Text) < Val(spc(i).Text) Then
            snc(i).ForeColor = Color.Red
            schange(i).ForeColor = Color.Red
        End If

        If Val(sprice(i).Text) = Val(spc(i).Text) Then
            snc(i).ForeColor = Color.White
            schange(i).ForeColor = Color.White
        End If

        If spc(i).Text = "N/A" Then
            snc(i).ForeColor = Color.White
            schange(i).ForeColor = Color.White
            spc(i).Text = sprice(i).Text
        End If
    End Sub

    'Check Application path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    'Ends operation when close
    Private Sub mainmenu_formclosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed, Labello.Click
        Background.itemmain.Enabled = False
        Background.itema.Enabled = False
        Background.itemsq.Enabled = False
        Background.itemset.Enabled = False
        Background.itemcb.Enabled = False
        Background.itemcp.Enabled = False
        Background.itemlo.Enabled = False
        Background.itemend.Enabled = True
        Me.Hide()
        Background.Show()
        Background.setbg.Enabled = True
    End Sub

    'Open Stock Quote window
    Private Sub labelsq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelsq.Click
        StockQuote.Show()
        StockQuote.Focus()
        'SetBackGroundColorOfMDIForm()
    End Sub

    'Adjust the position of objects when size change, Invisible the form when minimise
    Private Sub mainmenu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
        End If
        line1.X1 = 0
        line1.X2 = Me.Right
        optionpanel.Left = (Me.Width - optionpanel.Width) / 2
        fieldpanel.Left = (Me.Width - fieldpanel.Width) / 2
        infopanel.Left = (Me.Width - infopanel.Width) / 2
    End Sub

    'Set Form colour
    Private Sub SetBackGroundColorOfMDIForm()
        Dim ctl As Control
        ' Loop through controls,  
        ' looking for controls of MdiClient type. 
        For Each ctl In Me.Controls
            If TypeOf (ctl) Is MdiClient Then
                ' If the control is the correct type,
                ' change the color.
                ctl.BackColor = System.Drawing.Color.Black
            End If
        Next
    End Sub

    'Show Analysis window
    Private Sub Labelanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labelanalysis.Click
        Analysis.Show()
        Analysis.Focus()
    End Sub

    'Through each stock
    Public Sub checkeach()
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim stno() As String
        Dim i As Integer = 0
        Dim reno As Integer = 0

        stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
        stockdb.ConnectionString = dblocation
        stockdb.Open()
        rs.Open("Select * from companyinfo", stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        reno = rs.RecordCount
        ReDim stno(reno)
        For i = 0 To reno - 1
            If checkdl(rs.Fields(0).Value) = False Then collectdata(rs.Fields(0).Value)
            rs.MoveNext()
        Next
        rs.Close()
        stockdb.Close()

        recorduptodate = True
        Collect.Enabled = False
    End Sub

    'Check is the record downloaded
    Private Function checkdl(ByVal sn As Integer) As Boolean
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim datevar As String = " "

        checkdl = True
        If TimeOfDay.Hour >= 16 Then datevar = Format(Date.Today, "MM/dd/yyyy")
        If TimeOfDay.Hour < 10 Then datevar = Format(Date.Today.AddDays(-1), "MM/dd/yyyy")
        datevar = "#" & datevar & "#"

        If datevar <> "# #" Then
            stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
            stockdb.ConnectionString = dblocation
            stockdb.Open()
            rs.Open("Select * from " & sn & " where RecordDate = " & datevar, stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 1)
            If rs.RecordCount = 0 Then
                checkdl = False
                recorduptodate = False
            End If
            rs.Close()
            stockdb.Close()
        End If
        Return checkdl

    End Function

    'Collects data for the day
    Private Sub collectdata(ByVal stno As String)
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim i As Integer = 0
        Dim reno As Integer = 0
        Dim datevar As String = " "

        If TimeOfDay.Hour >= 16 Then datevar = Format(Date.Today, "dd/MM/yyyy")
        If TimeOfDay.Hour < 10 Then datevar = Format(Date.Today.AddDays(-1), "dd/MM/yyyy")

        'Check number of stock needed to record into database
        If datevar <> " " Then
            LoadData(stno, 0, 0)
            stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
            stockdb.ConnectionString = dblocation
            stockdb.Open()
            rs.Open("Select * from " & stno, stockdb, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            rs.AddNew()
            rs.Fields(0).Value = datevar
            rs.Fields(1).Value = Label1.Text
            rs.Fields(2).Value = Label2.Text
            rs.Fields(3).Value = Format(Val(Label3.Text), "0.00")
            rs.Fields(4).Value = Label4.Text
            rs.Fields(5).Value = Label5.Text
            rs.Update()
            rs.Close()
            stockdb.Close()
        End If

    End Sub

    'Checks the time for 2 different timer functions
    Private Sub Checktime()
        If TimeOfDay.Hour >= 16 Then recorduptodate = False
        If TimeOfDay.Hour >= 10 Then
            If TimeOfDay.Hour <= 16 And TimeOfDay.Minute < 10 Then
                If Date.Today.DayOfWeek <> DayOfWeek.Saturday Then
                    If Date.Today.DayOfWeek <> DayOfWeek.Sunday Then
                        refreshlist.Enabled = True
                        Collect.Enabled = False
                    End If
                End If
            End If
        Else
            If recorduptodate = False Then
                refreshlist.Enabled = False
                Collect.Enabled = True
            End If
        End If
    End Sub

    'Refresh every 30 seconds if enabled
    Private Sub refreshlist_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshlist.Tick
        dbread(False)
    End Sub

    'Collects data if not yet do so if enabled
    Private Sub collect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Collect.Tick
        checkeach()
    End Sub

    'Checks the time to enable which timer
    Private Sub counttime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles counttime.Tick
        Checktime()
    End Sub

End Class
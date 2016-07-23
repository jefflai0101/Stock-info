Public Class Portfolio

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
    Private Sub mainmenu_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        dbread()
    End Sub

    'Check with database
    Private Sub dbread()
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim n As Integer
        Me.AutoScroll = True

        stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
        'stockdb.ConnectionString = "C:\Users\Jeff\Documents\Programs\VB.net\Stock info\Stock Info\stockinfo.mdb"
        stockdb.ConnectionString = dblocation
        stockdb.Open()
        rs.Open("Select * from companyinfo order by [Stocknumber]", stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 1)

        j = rs.RecordCount
        createnew(j)

        With rs
            For n = 0 To .RecordCount - 1
                LoadData(.Fields(0).Value, n)
                squote(n).Text = .Fields(0).Value
                sname(n).Text = .Fields(1).Value
                .MoveNext()
            Next n
            .Close()
        End With
        stockdb.Close()
    End Sub

    'Create new objects
    Private Sub createnew(ByVal i As Integer)
        Dim n As Integer = 0
        'Redimension the number of labels required
        ReDim squote(i)
        ReDim sname(i)
        ReDim sprice(i)
        ReDim snc(i)
        ReDim schange(i)
        ReDim spc(i)
        ReDim shigh(i)
        ReDim slow(i)
        ReDim svolume(i)

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
    End Sub

    'Collect Information from internet
    Private Sub LoadData(ByVal stockno As Integer, ByVal n As Integer)
        '載入網頁
        WebBrowserRead.Navigate("http://www.hkex.com.hk/eng/invest/company/quote_page_e.asp?WidCoID=" & Val(stockno) & "&WidCoAbbName=&Month=1&langcode=e")
        '等待網頁載入完成
        Loading(WebBrowserRead)
        '抓資料
        GetData(n)
    End Sub

    'Load the website
    Sub Loading(ByRef [web] As WebBrowser)
        Do Until WebBrowserRead.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
    End Sub

    'Filter Information
    Private Sub GetData(ByVal i As Integer)
        Dim countinfo As Integer = 0

        'Search HTML tag that matches FONT and count specific no. to fill info
        For Each [HtmlElement] As HtmlElement In WebBrowserRead.Document.All
            If [HtmlElement].TagName = "FONT" Then
                countinfo = countinfo + 1

                Select Case countinfo
                    Case 19
                        sprice(i).Text = ([HtmlElement].OuterText)
                    Case 20
                        snc(i).Text = ([HtmlElement].OuterText)
                    Case 21
                        schange(i).Text = ([HtmlElement].OuterText)
                    Case 31
                        shigh(i).Text = ([HtmlElement].OuterText)
                    Case 32
                        slow(i).Text = ([HtmlElement].OuterText)
                    Case 33
                        spc(i).Text = ([HtmlElement].OuterText)
                    Case 34
                        svolume(i).Text = ([HtmlElement].OuterText) & ",000"
                End Select
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
    End Sub

    'Check Application path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    'Adjust the position of objects when size change, Invisible the form when minimise
    Private Sub mainmenu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            'Mainmenu.itempf.Enabled = True
        End If
        line1.X1 = 0
        line1.X2 = Me.Right
        fieldpanel.Left = (Me.Width - fieldpanel.Width) / 2
        infopanel.Left = (Me.Width - infopanel.Width) / 2
    End Sub

End Class
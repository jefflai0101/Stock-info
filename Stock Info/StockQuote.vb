'Required to import for ADODB
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports ADODB
'Brings Mid function
Imports vb = Microsoft.VisualBasic

Public Class StockQuote

    Public lastsq As Integer
    Protected Friend WebBrowserRead As New WebBrowser

    'Hide this form when close and enable the context menu
    Private Sub StockQuote_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    'Form Load
    Private Sub stockquote_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'Background.itemsq.Enabled = False
    End Sub

    'Search with number entered
    Private Sub searchbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbutton.Click
        If searchvalid() = True Then
            LoadData()
        Else
            MsgBox("Only Numbers are Allowed!")
        End If
    End Sub

    'Press enter after entered stock quote
    Private Sub stockno_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles stockno.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If searchvalid() = True Then
                LoadData()
            Else
                MsgBox("Only Numbers are Allowed!")
            End If
        End If
    End Sub

    'Validation for number only stock quote
    Private Function searchvalid() As Boolean
        Dim validcheck As Boolean = True
        For checkno = 1 To Len(stockno.Text)
            If Asc(Mid(stockno.Text, checkno, 1)) < 48 Or Asc(Mid(stockno.Text, checkno, 1)) > 57 Then
                validcheck = False
                checkno = Len(stockno.Text)
            End If
        Next checkno
        Return validcheck
    End Function

    'Collect Information from internet
    Private Sub LoadData()
        '載入網頁
        WebBrowserRead.Navigate("http://www.hkex.com.hk/eng/invest/company/quote_page_e.asp?WidCoID=" & Val(stockno.Text) & "&WidCoAbbName=&Month=1&langcode=e")
        '等待網頁載入完成
        Loading(WebBrowserRead)
        '抓資料
        GetData()
        lastsq = Val(stockno.Text)
    End Sub

    'Load the website
    Sub Loading(ByRef [web] As WebBrowser)
        Do Until WebBrowserRead.ReadyState = WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
    End Sub

    'Filter Information
    Private Sub GetData()
        Dim i As Integer = 0
        Dim LabelArray(11) As Label
        Dim countinfo As Integer = 0
        Dim infoarray(i) As String
        LabelArray(0) = Label1
        LabelArray(1) = Label2
        LabelArray(2) = Label3
        LabelArray(3) = Label4
        LabelArray(4) = Label5
        LabelArray(5) = Label6
        LabelArray(6) = Label7
        LabelArray(7) = Label8
        LabelArray(8) = Label9
        LabelArray(9) = Label10
        LabelArray(10) = Label11
        LabelArray(11) = Label12
        'Search HTML tag that matches FONT and count specific no. to fill info
        For Each [HtmlElement] As HtmlElement In WebBrowserRead.Document.All
            If [HtmlElement].TagName = "FONT" Then
                countinfo = countinfo + 1
                If countinfo = 3 And [HtmlElement].OuterText = "8003 : Price record not found/No stocks matched with your selection criteria." Then
                    countinfo = 37
                    MsgBox("Invalid Stock Quote")
                End If
                If countinfo = 10 Then stockquotename.Text = [HtmlElement].OuterText
                If countinfo = 19 Or countinfo = 20 Or countinfo = 21 Or countinfo = 22 Or countinfo = 23 Or countinfo = 24 Or countinfo = 31 Or countinfo = 32 Or countinfo = 33 Or countinfo = 34 Or countinfo = 35 Or countinfo = 36 Then
                    LabelArray(i).Text = [HtmlElement].OuterText
                    i = i + 1
                End If
            End If
        Next
        Pricecolour()
        If countinfo = 4 Then MsgBox("Invalid Stock Quote")
        stockquotename.Left = (stocksinfo.Width - stockquotename.Width) / 2
    End Sub

    'Change the colour depend on rise or fall of price
    Private Sub pricecolour()
        If Label1.Text < Label9.Text Then
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
        End If
        If Label1.Text = Label9.Text Then
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
        If Label1.Text > Label9.Text Then
            Label2.ForeColor = Color.Green
            Label3.ForeColor = Color.Green
        End If
    End Sub

    'App Path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function


    Private Sub saveinfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveinfo.Click
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim ofvalid As Boolean = True
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim rc As Integer = 0

        If stockno.Text <> "" Then
            stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
            stockdb.ConnectionString = dblocation
            stockdb.Open()
            rs.Open("Select * from Companyinfo where stocknumber = " & lastsq, stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 1)
            rc = rs.RecordCount
            rs.Close()
            stockdb.Close()

            If stockquotename.Text <> "" Then
                If rc = 1 Then
                    newupdate.Text = "Edit"
                Else
                    newupdate.Text = "Add New Record"
                End If
                newupdate.quotetext.Text = lastsq
                newupdate.lstext.Text = Label12.Text
                Call newupdate.initial()
                newupdate.Focus()
                newupdate.Show()
            Else
                MsgBox("Please Search for a quote first")
            End If
        Else
            MsgBox("Please enter stock quote!")
        End If
    End Sub

    'Clear text when click
    Private Sub stockno_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stockno.Click
        stockno.Clear()
    End Sub
End Class

'Bits and pieces from the original code
'Private Sub ListBoxTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxTitle.SelectedIndexChanged
'叫出網頁
'WebBrowserUser.Navigate(ListBoxLinkStore.Items.Item(ListBoxTitle.SelectedIndex))
'等待網頁載入完成
'Loading(WebBrowserUser)
'End Sub

'讀取網頁內容
'Private Sub ButtonReadAnnouncement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadAnnouncement.Click
'   LoadData()
'End Sub
'Private ListBoxLinkStore As New ListBox
'Private DataDate As Date = Nothing, DataTitle As String = Nothing, DataLink As System.Uri = Nothing
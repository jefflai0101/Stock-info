Public Class newupdate

    'Set up form with 2 different settings
    Private Sub newupdate_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        nametext.Text = ""
        swl.Checked = False
        tptext.Text = ""

        initial()
    End Sub

    Public Sub initial()
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim ofvalid As Boolean = True
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset

        If Me.Text = "Edit" Then
            stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
            stockdb.ConnectionString = dblocation
            stockdb.Open()
            rs.Open("Select * from Companyinfo where stocknumber = " & Val(quotetext.Text), stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 1)
            nametext.Text = rs.Fields(1).Value
            nametext.Enabled = False
            swl.Checked = rs.Fields(3).Value
            tptext.Text = rs.Fields(4).Value
            rs.Close()
            stockdb.Close()
        Else
            nametext.Focus()
            nametext.Enabled = True
            swl.Checked = True
        End If
    End Sub

    'App Path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    'Confirm button for 2 different functions
    Private Sub Confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirm.Click
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim ofvalid As Boolean = True
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim checkvalid As Boolean = False

        checkvalid = searchvalid()
        If checkvalid = True Then
            If Me.Text = "Edit" Then
                stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
                stockdb.ConnectionString = dblocation
                stockdb.Open()
                rs.Open("Select * from Companyinfo where stocknumber = " & Val(quotetext.Text), stockdb, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                rs.Fields(0).Value = quotetext.Text
                rs.Fields(1).Value = nametext.Text
                rs.Fields(2).Value = lstext.Text
                rs.Fields(4).Value = Int(Val(tptext.Text))
                rs.Fields(3).Value = swl.Checked
                rs.Update()
                rs.MoveNext()
                rs.Close()
                stockdb.Close()
                MsgBox("Record Updated!")
                If swl.Checked = False Then Mainmenu.dbread(1)
                If swl.Checked = True Then Mainmenu.dbread(2)
                Mainmenu.checkeach()
            Else
                stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
                stockdb.ConnectionString = dblocation
                stockdb.Open()
                rs.Open("Select * from Companyinfo", stockdb, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                rs.AddNew()
                rs.Fields(0).Value = quotetext.Text
                rs.Fields(1).Value = nametext.Text
                rs.Fields(2).Value = lstext.Text
                rs.Fields(3).Value = swl.Checked
                rs.Fields(4).Value = Int(Val(tptext.Text))
                rs.Update()
                rs.MoveNext()
                rs.Close()
                stockdb.Close()
                MsgBox("Record Added!")
                createtable(Int(Val((quotetext.Text))))
                If swl.Checked = False Then Mainmenu.dbread(0)
                If swl.Checked = True Then Mainmenu.dbread(2)
                Mainmenu.checkeach()
            End If
        Else
            MsgBox("Invalid field!")
        End If
        quotetext.Text = ""
        nametext.Text = ""
        lstext.Text = ""
        tptext.Text = ""
        swl.Checked = False
        Me.Hide()
        StockQuote.Focus()
    End Sub

    'Validation for number only stock quote
    Private Function searchvalid() As Boolean
        Dim validcheck As Boolean = True
        For checkno = 1 To Len(tptext.Text)
            If Asc(Mid(tptext.Text, checkno, 1)) < 48 Or Asc(Mid(tptext.Text, checkno, 1)) > 57 Then
                validcheck = False
                checkno = Len(tptext.Text)
            End If
        Next checkno
        If nametext.Text = "" Then validcheck = False
        If tptext.Text = "" Then tptext.Text = 0
        Return validcheck
    End Function

    'Create Table for the new stock
    Private Sub createtable(ByVal sn As Integer)
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim ofvalid As Boolean = True
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset

        stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
        stockdb.ConnectionString = dblocation
        stockdb.Open()

        stockdb.Execute _
                    ("CREATE TABLE " & sn & "(RecordDate   DATE, Price   DECIMAL(8, 2), Netchange   DECIMAL(8, 2), Change   DECIMAL(8, 2), High   DECIMAL(8, 2),Low   DECIMAL(8, 2))")
        stockdb.Close()
    End Sub

End Class
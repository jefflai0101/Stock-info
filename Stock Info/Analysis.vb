Imports System.IO

Public Class Analysis

    'Form load
    Private Sub Analysis_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        updatebox()
    End Sub

    'Clear text when user try to change the text
    Private Sub stockno_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Stockno.TextUpdate
        Stockno.Items.Clear()
        updatebox()
        Stockno.Text = ""
        MsgBox("Only folds in the option are allowed")
    End Sub

    'Action when end is pressed
    Private Sub stockno_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles confirm.KeyPress, Stockno.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then quoteno()
    End Sub

    'When clicked the analyse button
    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        quoteno()
    End Sub

    'Action when closing the window
    Private Sub analysis_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    '===============================================Procedures and Functions===============================================

    'Calculates price averages
    Private Sub calprices(ByVal squote As String)
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim i As Integer = 0
        Dim reno As Integer = 0

        stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
        stockdb.ConnectionString = dblocation
        stockdb.Open()
        rs.Open("Select * from " & squote & "'", stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)

        For i = 1 To rs.RecordCount
            reno = reno + Val(rs.Fields(1).Value)
            rs.MoveNext()
        Next
        reno = reno / rs.RecordCount
        Label2.Text = reno
        rs.Close()
        stockdb.Close()
    End Sub

    'Get quote number
    Private Sub quoteno()
        Dim squote As String = " "
        Dim i As Integer = 0
        For i = 1 To InStr(Stockno.Text, " - ", CompareMethod.Text) - 1
            squote = squote & Mid(Stockno.Text, i, 1)
        Next i
        calprices(squote)
    End Sub

    'Update combo box procedure
    Private Sub updatebox()
        Dim dblocation As String = App_Path() & "\Files\stockinfo.mdb"
        Dim stockdb As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim i As Integer = 0
        Dim reno As Integer = 0

        stockdb.Provider = "Microsoft.JET.OLEDB.4.0"
        stockdb.ConnectionString = dblocation
        stockdb.Open()
        rs.Open("Select * from companyinfo", stockdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        For i = 1 To rs.RecordCount
            Stockno.Items.Add(rs.Fields(0).Value & " - " & rs.Fields(1).Value)
            rs.MoveNext()
        Next i
        rs.Close()
        stockdb.Close()
    End Sub

    'Check Application path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

End Class
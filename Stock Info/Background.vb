Imports System.IO

Public Class Background

    Dim bgpath As String
    Dim app_path As String = System.AppDomain.CurrentDomain.BaseDirectory()

    'Form Load, gets background directory and calls the function that randomly choose picture in that directory
    Private Sub Background_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown


        Me.IsMdiContainer = True
        Login.MdiParent = Me
        Login.Show()

        itemmain.Enabled = False
        itema.Enabled = False
        itemsq.Enabled = False
        itemset.Enabled = False
        itemcb.Enabled = False
        itemcp.Enabled = False
        itemlo.Enabled = False
        itemend.Enabled = True

        resetbg()

    End Sub

    'Regularly change random picture in the directory
    Private Sub setbg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setbg.Tick
        setbg.Interval = 5000
        resetbg()
    End Sub

    'Randomly choose a picture in the directory
    Private Sub resetbg()
        Dim a As Integer = 0
        Dim filename As String = app_path & "\Files\users.dat"
        Dim objReader As New System.IO.StreamReader(filename)
        Dim textarray() As String
        Dim folderpath As String = objReader.ReadLine
        'Dim ofolder As System.IO.Directory

        textarray = folderpath.Split(",")
        If textarray(0) = "bgpath" Then
            bgpath = textarray(1)
        End If
        objReader.Close()

        a = Directory.GetFiles(app_path & "Files\" & bgpath & "\").Length
        Randomize()
        a = Int(Rnd() * (a - 1))
        Me.BackgroundImage = Image.FromFile(app_path & "Files\" & bgpath & "\" & a & ".jpg")

    End Sub

    '=================================================================================================================================
    '======================================================Context Menu Items=========================================================
    '=================================================================================================================================

    Private Sub itemmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemmain.Click
        Mainmenu.Show()
        Mainmenu.Focus()
        Mainmenu.WindowState = FormWindowState.Normal
        'itemmain.Enabled = False
    End Sub

    Private Sub itemsq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemsq.Click
        StockQuote.Show()
        StockQuote.Focus()
        'itemsq.Enabled = False
    End Sub

    Private Sub itema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itema.Click
        Analysis.Show()
        Analysis.Focus()
        'Me.itema.Enabled = False
    End Sub

    Private Sub itemcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemcp.Click
        passchange.Show()
        passchange.Focus()
        itemcp.Enabled = False
    End Sub

    Private Sub itemcb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemcb.Click
        picpath.Show()
        picpath.Focus()
        itemcb.Enabled = False
    End Sub

    Private Sub itemlo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemlo.Click
        Analysis.Hide()
        Mainmenu.Hide()
        passchange.Hide()
        picpath.Hide()
        itemmain.Enabled = False
        itema.Enabled = False
        itemsq.Enabled = False
        itemset.Enabled = False
        itemcb.Enabled = False
        itemcp.Enabled = False
        itemlo.Enabled = False
        itemend.Enabled = True
        setbg.Enabled = True
        Me.Show()
    End Sub

    Private Sub itemend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemend.Click
        Notifyicon.Dispose()
        End
    End Sub

End Class
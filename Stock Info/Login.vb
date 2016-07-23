Imports System.IO


Public Class Login

    Dim app_path As String = System.AppDomain.CurrentDomain.BaseDirectory()

    'Load usersetting see did user checker save last time and load the username if it was true
    Private Sub login_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filename As String = app_path & "Files\users.dat"
        Dim objReader As New System.IO.StreamReader(filename)
        ls.Checked = False
        Dim textarray() As String
        Dim folderpath As String
        While Not objReader.EndOfStream
            folderpath = objReader.ReadLine()
            textarray = folderpath.Split(",")
            If textarray(0) = "loginsave" Then
                If textarray(1) = 1 Then ls.Checked = True
            End If
        End While
        objReader.Close()
        Dim uid As String = textarray(0)
        Dim upass As String = textarray(1)
        If ls.Checked = True Then txtid.Text = uid
        txtpass.Select()
    End Sub

    'Ends application when exit button was pressed
    Private Sub Exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitbutton.Click
        Background.Notifyicon.Dispose()
        End
    End Sub

    'Check login when enter is pressed
    Private Sub txtid_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress, txtpass.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then logincheck()
    End Sub

    'Check login when button is pressed
    Private Sub loginbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbutton.Click
        logincheck()
    End Sub

    'Checks username and password from the file and update username save if correctly login
    Private Sub logincheck()
        Dim filename As String = app_path & "Files\users.dat"
        Dim objReader As New System.IO.StreamReader(filename)
        Dim i As Integer
        Dim textarray() As String
        Dim buff(3) As String
        Dim filetxt As String
        Dim idcheck As String = " "
        Dim passcheck As String = " "

        For i = 1 To 3
            filetxt = objReader.ReadLine()
            textarray = filetxt.Split(",")
            If textarray(0) <> "bgpath" And textarray(0) <> "loginsave" Then
                idcheck = textarray(0)
                passcheck = textarray(1)
            End If
        Next i
        objReader.Close()

        If idcheck = txtid.Text And passcheck = txtpass.Text Then
            objReader = New System.IO.StreamReader(filename)
            For i = 1 To 3
                filetxt = objReader.ReadLine()
                textarray = filetxt.Split(",")
                If textarray(0) = "loginsave" Then
                    If ls.Checked = True Then buff(i) = "loginsave,1"
                    If ls.Checked = False Then buff(i) = "loginsave,0"
                Else
                    buff(i) = filetxt
                End If
            Next i
            objReader.Close()

            Dim objwriter As New System.IO.StreamWriter(filename)
            For i = 1 To 3
                objwriter.WriteLine(buff(i))
            Next
            objwriter.Close()
            Background.itemmain.Enabled = True
            Background.itema.Enabled = True
            Background.itemsq.Enabled = True
            Background.itemset.Enabled = True
            Background.itemcb.Enabled = True
            Background.itemcp.Enabled = True
            Background.itemlo.Enabled = True
            Background.Hide()
            Background.setbg.Enabled = False
            Mainmenu.Show()
        Else
            MsgBox("Incorrect Username or Password")
        End If
        If ls.Checked = False Then txtid.Clear()
        txtpass.Clear()
    End Sub

End Class
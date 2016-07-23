Imports System.IO

Public Class picpath

    'Form load
    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        foldname.Items.Clear()
        foldname.Text = ""
        cbupdate()
    End Sub

    'Update the combo box
    Private Sub cbupdate()
        Dim filename As String = App_Path() & "Files\"
        Dim myinfo As New DirectoryInfo(filename)
        Dim foldername() As String
        Dim i As Integer = 0
        Dim n As Integer = 0

        foldname.Items.Clear()
        i = Directory.GetDirectories(filename).Length
        ReDim foldername(i)

        For Each myinfo In myinfo.GetDirectories
            foldername(n) = myinfo.Name
            n = n + 1
        Next

        For n = 0 To i - 1
            foldname.Items.Add(foldername(n))
        Next n
    End Sub

    'Check Application path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    'Clear text when user try to change the text
    Private Sub foldname_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        cbupdate()
        foldname.Text = ""
        MsgBox("Only folds in the option are allowed")
    End Sub

    'Update changed folder
    Private Sub foldchange()
        Dim filename As String = App_Path() & "Files\users.dat"
        Dim objReader As New System.IO.StreamReader(filename)

        Dim i As Integer
        Dim textarray() As String
        Dim buff(3) As String
        Dim filetxt As String

        If foldname.Text <> "" Then
            For i = 1 To 3
                filetxt = objReader.ReadLine()
                textarray = filetxt.Split(",")
                If textarray(0) = "bgpath" Then
                    buff(i) = "bgpath," & foldname.Text
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
            MsgBox("Folder Changed!")
            Background.setbg.Interval = 100
            Background.itemcb.Enabled = True
            Me.Hide()
        End If

    End Sub

    'Confirm when enter is pressed
    Private Sub foldname_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles confirm.KeyPress, foldname.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then foldchange()
    End Sub

    'Confirm when confirm button is clicked
    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        foldchange()
    End Sub

    'Hide this form when close and enable the context menu
    Private Sub picpath_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Background.itemcb.Enabled = True
        Me.Hide()
    End Sub

End Class
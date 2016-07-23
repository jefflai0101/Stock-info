Imports System.IO

Public Class passchange

    'Form load
    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cleanform()
    End Sub

    'Update changed password
    Private Sub passchange()
        Dim filename As String = App_Path() & "Files\users.dat"
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

        If validcheck() = True Then
            If passcheck = oldpass.Text Then
                objReader = New System.IO.StreamReader(filename)
                For i = 1 To 3
                    filetxt = objReader.ReadLine()
                    textarray = filetxt.Split(",")
                    If textarray(0) = idcheck Then
                        buff(i) = idcheck & "," & newpass.Text
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

                MsgBox("Password updated!")
                cleanform()
                Background.itemcp.Enabled = True
                Me.Hide()
            Else
                MsgBox("Incorrect old password!")
            End If
        End If
    End Sub

    'Validation check
    Private Function validcheck() As Boolean
        validcheck = True
        If newpass.Text <> connew.Text Then
            MsgBox("The new passwords doesn't match, please try again")
            validcheck = False
        Else
            If oldpass.Text = newpass.Text Then
                MsgBox("New password cannot be the same as old password!")
                validcheck = False
            End If
        End If
        Return validcheck
    End Function

    'Check Application path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    'Resets the password boxes
    Private Sub cleanform()
        oldpass.Text = ""
        newpass.Text = ""
        connew.Text = ""
    End Sub

    'Confirm button
    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        passchange()
    End Sub

    'Confirm when enter is pressed
    Private Sub oldpass_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles oldpass.KeyPress, newpass.KeyPress, connew.KeyPress, confirm.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then passchange()
    End Sub

    'Hide this form when close and enable the context menu
    Private Sub passchange_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Background.itemcp.Enabled = True
        Me.Hide()
    End Sub

End Class
﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        General.LaunchCommunications()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Forms.Form2.Show()

    End Sub
End Class

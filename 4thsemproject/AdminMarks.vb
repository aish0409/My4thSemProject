Public Class AdminMarks
    Private Sub AdminMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckAdmin.IsAdmin Then
            Dim viewForm As New ViewMarks(CheckAdmin.CurrentStudentID)
            viewForm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub ViewMarksButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim studentID As String = StudentIDTextBox.Text
        Dim adminView As New ViewMarks(studentID)
        adminView.Show()
    End Sub

    Private Sub UpdateMarksButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim updateForm As New UpdateMarks()
        updateForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
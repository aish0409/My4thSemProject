Public Class AdminCourse
    Private Sub AdminCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckAdmin.IsAdmin Then
            Dim viewForm As New ViewCourse(CheckAdmin.CurrentStudentID)
            viewForm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub ViewCourseButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim studentID As String = StudentIDTextBox.Text
        Dim adminView As New ViewCourse(studentID)
        adminView.Show()
    End Sub

    Private Sub UpdateCourseButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim updateCourse As New UpdateCourse()
        updateCourse.Show()
    End Sub
End Class
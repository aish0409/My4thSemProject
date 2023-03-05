Public Class AdminAttendance
    Private Sub AdminAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckAdmin.IsAdmin Then
            Dim viewForm As New ViewAttendance(CheckAdmin.CurrentStudentID)
            viewForm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub ViewAttendanceButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim studentID As String = StudentIDTextBox.Text
        Dim adminView As New ViewAttendance(studentID)
        adminView.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
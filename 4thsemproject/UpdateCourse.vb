Imports System.Data.SqlClient

Public Class UpdateCourse
    Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Controls.Remove(CourseIdDeleteTextBox)
        If ValidateAllTextBoxes(Me) Then
            Dim query As String = "INSERT INTO MARKS(STUDENT_ID, COURSE_ID, MARKS) VALUES (@stdID, @courseID, @marks)"
            Try
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@courseID", CourseIDTextBox.Text)
                        command.Parameters.AddWithValue("@courseName", CourseNameTextBox.Text)
                        command.Parameters.AddWithValue("@dept", DepartmentTextBox.Text)
                        command.Parameters.AddWithValue("@courseYear", CourseYearTextBox.Text)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show($"New Course has been inserted for Course ID {CourseIDTextBox.Text} with Course Name {CourseNameTextBox.Text} under Department {DepartmentTextBox.Text} for Year {CourseYearTextBox.Text}.")
            Catch ex As Exception
                If ex.Message.Contains("PRIMARY KEY") Then
                    query = "UPDATE COURSE_DETAILS SET COURSE_NAME = @courseName, DEPT = @dept, COURSE_YEAR = @courseYear WHERE COURSE_ID = @courseID"
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@courseID", CourseIDTextBox.Text)
                            command.Parameters.AddWithValue("@courseName", CourseNameTextBox.Text)
                            command.Parameters.AddWithValue("@dept", DepartmentTextBox.Text)
                            command.Parameters.AddWithValue("@courseYear", CourseYearTextBox.Text)
                            connection.Open()
                            command.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show($"Course has been updated for Course ID {CourseIDTextBox.Text} with Course Name {CourseNameTextBox.Text} under Department {DepartmentTextBox.Text} for Year {CourseYearTextBox.Text}.")
                End If
            End Try
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim query As String = "DELETE FROM COURSE_DETAILS WHERE COURSE_ID = @courseID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@courseID", CourseIdDeleteTextBox.Text)
                connection.Open()
                If command.ExecuteNonQuery() = 0 Then
                    MessageBox.Show($"Course with Course ID {CourseIdDeleteTextBox.Text} does not exist")
                    Return
                Else
                    MessageBox.Show($"Course ID {CourseIdDeleteTextBox.Text} has been deleted.")
                End If
            End Using
        End Using
    End Sub
End Class

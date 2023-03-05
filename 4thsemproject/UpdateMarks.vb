Imports System.Data.SqlClient

Public Class UpdateMarks
    Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Controls.Remove(CourseIdDeleteTextBox)
        Me.Controls.Remove(StudentIdDeleteTextBox)
        Me.Controls.Remove(RemoveButton)
        If ValidateAllTextBoxes(Me) Then
            Dim query As String = "INSERT INTO MARKS(STUDENT_ID, COURSE_ID, MARKS) VALUES (@stdID, @courseID, @marks)"
            Try
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@stdID", StudentIDTextBox.Text)
                        command.Parameters.AddWithValue("@courseID", CourseIDTextBox.Text)
                        command.Parameters.AddWithValue("@marks", MarksTextBox.Text)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show($"Marks has been inserted.")
            Catch ex As Exception
                If ex.Message.Contains("UC_StudentCourse") Then
                    query = "UPDATE MARKS SET MARKS = @marks WHERE STUDENT_ID = @stdID AND COURSE_ID = @courseID"
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@stdID", StudentIDTextBox.Text)
                            command.Parameters.AddWithValue("@courseID", CourseIDTextBox.Text)
                            command.Parameters.AddWithValue("@marks", MarksTextBox.Text)
                            connection.Open()
                            command.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show($"Marks has been updated.")
                End If
            End Try
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim query As String = "DELETE FROM MARKS WHERE STUDENT_ID = @stdID AND COURSE_ID = @courseID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@stdID", StudentIDTextBox.Text)
                command.Parameters.AddWithValue("@courseID", CourseIdDeleteTextBox.Text)
                connection.Open()
                If command.ExecuteNonQuery() = 0 Then
                    MessageBox.Show($"Entry with corresponding ID does not exist")
                    Return
                Else
                    MessageBox.Show($"Marks has been deleted.")
                End If
            End Using
        End Using
    End Sub
End Class

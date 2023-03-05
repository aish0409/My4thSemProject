Imports System.Data.SqlClient
Imports System.DirectoryServices

Public Class UpdateProfile
    Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"

    Private Sub UpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckAdmin.IsAdmin Then
            Dim query = "SELECT * FROM studentreg where StudentId = @stdid"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    StudentIDTextBox.Text = CheckAdmin.CurrentStudentID
                    StudentIDTextBox.ReadOnly = True
                    command.Parameters.AddWithValue("@stdid", StudentIDTextBox.Text)
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    Do While reader.Read()
                        DepartmentTextBox.Text = reader.Item("Dept").ToString()
                        DepartmentTextBox.ReadOnly = True
                        CourseYearTextBox.Text = reader.Item("Course_Year").ToString()
                        CourseYearTextBox.ReadOnly = True
                    Loop
                    reader.Close()
                End Using
            End Using
            Me.Controls.Remove(DeleteButton)
        Else
            Me.Controls.Remove(ViewButton)
        End If
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim query As String = "INSERT INTO studentreg(FirstName, LastName, StudentId, Dept, Password, Course_Year, DOB, Email) VALUES (@firstname, @lastname, @stdid, @dept, @pwd, @year, @dob, @email)"
            If String.IsNullOrEmpty(FirstNameTextBox.Text) OrElse String.IsNullOrEmpty(LastNameTextBox.Text) OrElse String.IsNullOrEmpty(DepartmentTextBox.Text) OrElse String.IsNullOrEmpty(CourseYearTextBox.Text) OrElse String.IsNullOrEmpty(EmailTextBox.Text) OrElse String.IsNullOrEmpty(StudentIDTextBox.Text) OrElse String.IsNullOrEmpty(PasswordTextBox.Text) Then
                MessageBox.Show("Fill all the fields before Insertion/Updation.")
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@firstname", FirstNameTextBox.Text)
                    command.Parameters.AddWithValue("@lastname", LastNameTextBox.Text)
                    command.Parameters.AddWithValue("@dept", DepartmentTextBox.Text)
                    command.Parameters.AddWithValue("@year", CourseYearTextBox.Text)
                    command.Parameters.AddWithValue("@dob", DOBPicker.Value.Date)
                    command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                    command.Parameters.AddWithValue("@stdid", StudentIDTextBox.Text)
                    command.Parameters.AddWithValue("@pwd", PasswordTextBox.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show($"Student with Student ID {StudentIDTextBox.Text} has been inserted.")
        Catch ex As Exception
            If ex.Message.Contains("PRIMARY KEY") Then
                Dim query = "UPDATE studentreg SET FirstName = @firstname, LastName = @lastname, Password = @pwd, Dept = @dept, Course_Year = @year, DOB = @dob, Email = @email WHERE StudentId = @stdid"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@firstname", FirstNameTextBox.Text)
                        command.Parameters.AddWithValue("@lastname", LastNameTextBox.Text)
                        command.Parameters.AddWithValue("@dept", DepartmentTextBox.Text)
                        command.Parameters.AddWithValue("@year", CourseYearTextBox.Text)
                        command.Parameters.AddWithValue("@dob", DOBPicker.Value.Date)
                        command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                        command.Parameters.AddWithValue("@stdid", StudentIDTextBox.Text)
                        command.Parameters.AddWithValue("@pwd", PasswordTextBox.Text)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show($"Student with Student ID {StudentIDTextBox.Text} has been updated.")
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim query As String = "DELETE FROM studentreg WHERE StudentId = @stdID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@stdID", StudentIDTextBox.Text)
                connection.Open()
                If command.ExecuteNonQuery() = 0 Then
                    MessageBox.Show($"Student with Student ID {StudentIDTextBox.Text} does not exist")
                    Return
                Else
                    MessageBox.Show($"Student ID {StudentIDTextBox.Text} has been deleted.")
                End If
            End Using
        End Using
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim viewProfile As New ViewProfile(StudentIDTextBox.Text)
        viewProfile.Show()
    End Sub
End Class
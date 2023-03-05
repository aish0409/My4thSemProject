Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class StudentRegistrationForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ' Get the values from the textboxes
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim StudentId As String = txtStudentId.Text
        Dim dob As String = DOBPicker.Value.Date
        Dim email As String = EmailTextBox.Text
        Dim Dept As String = txtDept.SelectedItem.ToString()
        Dim courseYear = CourseYearListBox.SelectedItem.ToString()
        Dim Password As String = txtPassword.Text
        Dim ConfirmPassword As String = txtConfirmPassword.Text


        ' Connect to the database
        Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"

        Using connection As SqlConnection = New SqlConnection(connectionString)

            connection.Open()

            ' Create a SQL command to insert the data
            Dim commandText As String = "INSERT INTO studentreg (FirstName, LastName, StudentID , Dept, Password, Course_Year, DOB, Email) VALUES (@FirstName, @LastName, @StudentID, @Dept, @Password, @crsYr, @dob, @email);"
            Using command As SqlCommand = New SqlCommand(commandText, connection)


                ' Set the parameters
                If ValidateAllTextBoxes(Me) AndAlso String.IsNullOrEmpty(Dept) AndAlso String.IsNullOrEmpty(courseYear) Then
                    command.Parameters.AddWithValue("@FirstName", FirstName)
                    command.Parameters.AddWithValue("@LastName", LastName)
                    command.Parameters.AddWithValue("@StudentId", StudentId)
                    command.Parameters.AddWithValue("@Dept", Dept)
                    command.Parameters.AddWithValue("@Password", Password)
                    command.Parameters.AddWithValue("@crsYr", courseYear)
                    command.Parameters.AddWithValue("@dob", dob)
                    command.Parameters.AddWithValue("@email", email)
                    command.ExecuteNonQuery()
                    ' Check if all fields are filled
                    MessageBox.Show("Registration successful! You will now be redirected To the login page.")
                    Me.Hide()
                    Dim StudentloginForm As New StudentLoginForm()
                    StudentloginForm.Show()
                Else
                    ' Display error message
                    MessageBox.Show("Please fill in all fields.")
                End If


            End Using
        End Using


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'Validation


    Private Sub txtFirstName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFirstName.Validating
        If txtFirstName.Text.Trim() = "" OrElse Not Regex.IsMatch(txtFirstName.Text.Trim(), "^[a-zA-Z]+$") Then
            MessageBox.Show(txtFirstName, "Please enter a valid first name.")
            e.Cancel = True

        End If
    End Sub

    Private Sub txtLastName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLastName.Validating
        If txtLastName.Text.Trim() = "" OrElse Not Regex.IsMatch(txtLastName.Text.Trim(), "^[a-zA-Z]+$") Then
            MessageBox.Show(txtLastName, "Please enter a valid last name.")
            e.Cancel = True

        End If
    End Sub

    Private Sub txtConfirmPassword_Validating(sender As Object, e As CancelEventArgs) Handles txtConfirmPassword.Validating
        If String.IsNullOrEmpty(txtConfirmPassword.Text) Then
            MessageBox.Show("Please confirm your password.")
            txtConfirmPassword.Focus()
            txtConfirmPassword.SelectAll()
            e.Cancel = True
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match. Please enter the same password in both fields.")
            txtConfirmPassword.Focus()
            txtConfirmPassword.SelectAll()
            e.Cancel = True
        End If
    End Sub

    Private Sub txtStudentId_TextChanged(sender As Object, e As EventArgs) Handles txtStudentId.Validating
        CheckAdmin.ValidateStudentID(txtStudentId.Text)
    End Sub


End Class
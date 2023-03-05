Imports System.Data.SqlClient
Imports System.Windows.Input

Public Class AdminProfile
    Private Sub AdminProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckAdmin.IsAdmin Then
            Dim updateForm As New UpdateProfile()
            updateForm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub ViewProfileButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim studentID As String = StudentIDTextBox.Text
        Dim adminView As New ViewProfile(studentID)
        adminView.Show()
        'Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
        'Dim query As String = "SELECT * FROM COURSE_DETAILS WHERE DEPT = @dept"
        'Dim dataTable As New DataTable()
        'Using connection As New SqlConnection(connectionString)
        '    Dim dataAdapter As New SqlDataAdapter(query, connection)
        '    dataAdapter.SelectCommand.Parameters.AddWithValue("@dept", DepartmentListBox.SelectedItem.ToString())
        '    connection.Open()
        '    dataAdapter.Fill(dataTable)
        'End Using
        'If dataTable.Rows.Count > 0 Then
        '    For Each ctrl As Control In Me.Controls
        '        Me.Controls.Remove(ctrl)
        '        ctrl.Dispose()
        '    Next
        '    DepartmentListBox.Visible = False
        '    OkButton.Visible = False
        '    Dim courseDetails As New DataGridView()
        '    With courseDetails
        '        .DataSource = dataTable
        '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '        .Size = Me.Size
        '        With .ColumnHeadersDefaultCellStyle
        '            .BackColor = Color.Navy
        '            .ForeColor = Color.White
        '            .Font = New Font(courseDetails.Font, FontStyle.Bold)
        '        End With
        '    End With
        '    Me.Controls.Add(courseDetails)
        'End If
    End Sub

    Private Sub UpdateProfileButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim updateProfile As New UpdateProfile()
        updateProfile.Show()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class ViewAttendance
    Private ReadOnly _studentId As String
    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _studentId = studentID

    End Sub
    Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
    Private Sub ViewCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM ATTENDANCE WHERE STUDENT_ID = @stdID"
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@stdID", _studentId)
            connection.Open()
            dataAdapter.Fill(dataTable)
        End Using
        With AttendanceDataGrid
            .DataSource = dataTable
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            If IsAdmin Then
                .ReadOnly = False
            End If
        End With
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If IsAdmin Then
            Try
                Dim changes As DataTable = CType(AttendanceDataGrid.DataSource, DataTable).GetChanges()

                ' Create a new DataAdapter to update the changes to the database
                Using connection As New SqlConnection(connectionString)
                    Dim adapter As New SqlDataAdapter("SELECT * FROM ATTENDANCE", connection)
                    Dim builder As New SqlCommandBuilder(adapter)

                    ' Update the database with the changes made to the DataTable
                    adapter.UpdateCommand = builder.GetUpdateCommand()
                    adapter.InsertCommand = builder.GetInsertCommand()
                    adapter.DeleteCommand = builder.GetDeleteCommand()
                    adapter.Update(changes)

                    ' Update the original DataTable with the changes from the database
                    CType(AttendanceDataGrid.DataSource, DataTable).AcceptChanges()
                End Using
                MessageBox.Show("Updated the Table")
            Catch ex As Exception
                MessageBox.Show("Invalid Data was provided.")
            End Try
        End If
        Close()
    End Sub
End Class
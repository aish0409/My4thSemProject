Imports System.Data.SqlClient
Public Class ViewMarks
    Private ReadOnly _studentId As String
    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _studentId = studentID

    End Sub

    Private Sub ViewMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
        Dim query As String = "SELECT * FROM STUDENT_MARKS WHERE studentid = @stdid"
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@stdID", _studentId)
            connection.Open()
            dataAdapter.Fill(dataTable)
        End Using
        With MarksDataGrid
            .DataSource = dataTable
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Close()
    End Sub
End Class
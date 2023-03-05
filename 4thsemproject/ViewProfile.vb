Imports System.Data.SqlClient
Public Class ViewProfile
    Private ReadOnly _studentId As String
    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _studentId = studentID

    End Sub

    Private Sub ViewProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
        Dim query As String = "SELECT * FROM studentreg WHERE StudentId = @stdId"
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@stdID", _studentId)
            connection.Open()
            dataAdapter.Fill(dataTable)
        End Using
        With ProfileDataGrid
            .DataSource = dataTable
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With
    End Sub
End Class
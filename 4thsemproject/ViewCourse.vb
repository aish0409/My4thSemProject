Imports System.Data.SqlClient
Public Class ViewCourse
    Private ReadOnly _studentId As String
    Public Sub New(studentID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _studentId = studentID

    End Sub

    Private Sub ViewCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-JI8QG4T\SQLSERVER2022;Initial Catalog=collegestudent;Integrated Security=True"
        Dim query As String = "SELECT cd.* From COURSE_DETAILS cd INNER Join studentreg sr ON cd.DEPT = sr.DEPT WHERE SR.StudentId = @stdID AND cd.COURSE_YEAR = sr.Course_Year"
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@stdID", _studentId)
            connection.Open()
            dataAdapter.Fill(dataTable)
        End Using
        With CourseDataGrid
            .DataSource = dataTable
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
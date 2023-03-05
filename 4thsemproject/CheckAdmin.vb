Public Module CheckAdmin
    Public IsAdmin As Boolean
    Public CurrentStudentID As String
    Public Sub ValidateStudentID(ByVal studentID As String)
        If Not IsNumeric(studentID) Then
            MessageBox.Show("Student ID should be a numeric value.")
            Return
        Else
            If studentID.Length <> 6 Then
                MessageBox.Show("Student ID should be 6 characters long.")
                Return
            Else
                Dim dept As String = studentID.Substring(3, 3)
                If dept <> "100" AndAlso dept <> "200" AndAlso dept <> "300" Then
                    MessageBox.Show("Invalid Student ID.")
                    Return
                End If
            End If
        End If
    End Sub

    Public Function ValidateAllTextBoxes(form As Form) As Boolean
        For Each textBox As TextBox In form.Controls.OfType(Of TextBox)()
            If String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Please fill in all the required fields.")
                Return False
            End If
        Next
        Return True
    End Function

End Module

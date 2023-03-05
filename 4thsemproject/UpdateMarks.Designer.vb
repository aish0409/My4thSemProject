<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMarks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.CourseIDTextBox = New System.Windows.Forms.TextBox()
        Me.MarksTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.StudentIdDeleteTextBox = New System.Windows.Forms.TextBox()
        Me.CourseIdDeleteTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.Location = New System.Drawing.Point(123, 40)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.PlaceholderText = "Student ID"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(125, 27)
        Me.StudentIDTextBox.TabIndex = 0
        '
        'CourseIDTextBox
        '
        Me.CourseIDTextBox.Location = New System.Drawing.Point(123, 125)
        Me.CourseIDTextBox.Name = "CourseIDTextBox"
        Me.CourseIDTextBox.PlaceholderText = "Course ID"
        Me.CourseIDTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseIDTextBox.TabIndex = 1
        '
        'MarksTextBox
        '
        Me.MarksTextBox.Location = New System.Drawing.Point(123, 241)
        Me.MarksTextBox.Name = "MarksTextBox"
        Me.MarksTextBox.PlaceholderText = "Marks"
        Me.MarksTextBox.Size = New System.Drawing.Size(125, 27)
        Me.MarksTextBox.TabIndex = 2
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(164, 335)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 29)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(525, 338)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(94, 29)
        Me.RemoveButton.TabIndex = 4
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'StudentIdDeleteTextBox
        '
        Me.StudentIdDeleteTextBox.Location = New System.Drawing.Point(525, 40)
        Me.StudentIdDeleteTextBox.Name = "StudentIdDeleteTextBox"
        Me.StudentIdDeleteTextBox.PlaceholderText = "Student ID"
        Me.StudentIdDeleteTextBox.Size = New System.Drawing.Size(125, 27)
        Me.StudentIdDeleteTextBox.TabIndex = 5
        '
        'CourseIdDeleteTextBox
        '
        Me.CourseIdDeleteTextBox.Location = New System.Drawing.Point(525, 115)
        Me.CourseIdDeleteTextBox.Name = "CourseIdDeleteTextBox"
        Me.CourseIdDeleteTextBox.PlaceholderText = "Course ID"
        Me.CourseIdDeleteTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseIdDeleteTextBox.TabIndex = 6
        '
        'UpdateMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CourseIdDeleteTextBox)
        Me.Controls.Add(Me.StudentIdDeleteTextBox)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.MarksTextBox)
        Me.Controls.Add(Me.CourseIDTextBox)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Name = "UpdateMarks"
        Me.Text = "UpdateMarks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents CourseIDTextBox As TextBox
    Friend WithEvents MarksTextBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents StudentIdDeleteTextBox As TextBox
    Friend WithEvents CourseIdDeleteTextBox As TextBox
End Class

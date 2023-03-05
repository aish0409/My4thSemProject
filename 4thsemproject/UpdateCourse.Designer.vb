<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCourse
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
        Me.CourseIDTextBox = New System.Windows.Forms.TextBox()
        Me.CourseNameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CourseYearTextBox = New System.Windows.Forms.TextBox()
        Me.CourseIdDeleteTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CourseIDTextBox
        '
        Me.CourseIDTextBox.Location = New System.Drawing.Point(130, 54)
        Me.CourseIDTextBox.Name = "CourseIDTextBox"
        Me.CourseIDTextBox.PlaceholderText = "Course ID"
        Me.CourseIDTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseIDTextBox.TabIndex = 0
        '
        'CourseNameTextBox
        '
        Me.CourseNameTextBox.Location = New System.Drawing.Point(130, 139)
        Me.CourseNameTextBox.Name = "CourseNameTextBox"
        Me.CourseNameTextBox.PlaceholderText = "Course Name"
        Me.CourseNameTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseNameTextBox.TabIndex = 1
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(130, 232)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.PlaceholderText = "Department"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(125, 27)
        Me.DepartmentTextBox.TabIndex = 2
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(130, 361)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(94, 29)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Course ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Course Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Course Year"
        '
        'CourseYearTextBox
        '
        Me.CourseYearTextBox.Location = New System.Drawing.Point(130, 304)
        Me.CourseYearTextBox.Name = "CourseYearTextBox"
        Me.CourseYearTextBox.PlaceholderText = "Course Year"
        Me.CourseYearTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseYearTextBox.TabIndex = 8
        '
        'CourseIdDeleteTextBox
        '
        Me.CourseIdDeleteTextBox.Location = New System.Drawing.Point(564, 57)
        Me.CourseIdDeleteTextBox.Name = "CourseIdDeleteTextBox"
        Me.CourseIdDeleteTextBox.PlaceholderText = "Course ID"
        Me.CourseIdDeleteTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CourseIdDeleteTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Course ID"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(564, 139)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(94, 29)
        Me.RemoveButton.TabIndex = 11
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'UpdateCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CourseIdDeleteTextBox)
        Me.Controls.Add(Me.CourseYearTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.CourseNameTextBox)
        Me.Controls.Add(Me.CourseIDTextBox)
        Me.Name = "UpdateCourse"
        Me.Text = "UpdateCourse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CourseIDTextBox As TextBox
    Friend WithEvents CourseNameTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CourseYearTextBox As TextBox
    Friend WithEvents CourseIdDeleteTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RemoveButton As Button
End Class

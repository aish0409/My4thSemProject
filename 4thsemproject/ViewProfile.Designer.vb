﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProfile
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
        Me.ProfileDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.ProfileDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileDataGrid
        '
        Me.ProfileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProfileDataGrid.Location = New System.Drawing.Point(12, 90)
        Me.ProfileDataGrid.Name = "ProfileDataGrid"
        Me.ProfileDataGrid.RowHeadersWidth = 51
        Me.ProfileDataGrid.RowTemplate.Height = 29
        Me.ProfileDataGrid.Size = New System.Drawing.Size(776, 269)
        Me.ProfileDataGrid.TabIndex = 0
        '
        'ViewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProfileDataGrid)
        Me.Name = "ViewProfile"
        Me.Text = "ViewProfile"
        CType(Me.ProfileDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProfileDataGrid As DataGridView
End Class

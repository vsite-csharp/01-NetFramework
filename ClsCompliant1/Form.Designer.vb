<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.ButtonGetTime = New System.Windows.Forms.Button()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonGetTime
        '
        Me.ButtonGetTime.Location = New System.Drawing.Point(12, 12)
        Me.ButtonGetTime.Name = "ButtonGetTime"
        Me.ButtonGetTime.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGetTime.TabIndex = 0
        Me.ButtonGetTime.Text = "&Get Time"
        Me.ButtonGetTime.UseVisualStyleBackColor = True
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Location = New System.Drawing.Point(102, 14)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.ReadOnly = True
        Me.TextBoxTime.Size = New System.Drawing.Size(178, 20)
        Me.TextBoxTime.TabIndex = 1
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.ButtonGetTime)
        Me.Name = "Form"
        Me.Text = "VB Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGetTime As System.Windows.Forms.Button
    Friend WithEvents TextBoxTime As System.Windows.Forms.TextBox

End Class

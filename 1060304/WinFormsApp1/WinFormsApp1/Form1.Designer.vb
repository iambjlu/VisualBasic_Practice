<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(286, 39)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(134, 60)
        Me.btn.TabIndex = 0
        Me.btn.Text = "第四題"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(208, 122)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(311, 193)
        Me.txt.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents txt As TextBox
End Class

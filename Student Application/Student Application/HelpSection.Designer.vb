<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpSection
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 34)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(362, 38)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "In order to use this program simply use the rask bar on the homepage, it offers f" &
    "eature to save the database/delete records and add new ones."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 88)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(362, 43)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "In order to search through the records simply use the arrows on the task bar, it " &
    "will show all details about a student including their Next of Kin details."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 154)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(362, 55)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "To exit the program use the File tab on the homepage and click exit, this will cl" &
    "ode all open windows of the application. If you just wish to close the help wind" &
    "ow use the Close button above,"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 229)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(362, 55)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Use the arrows button above to move the window"
        '
        'cmdReturn
        '
        Me.cmdReturn.Location = New System.Drawing.Point(59, 305)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(75, 23)
        Me.cmdReturn.TabIndex = 4
        Me.cmdReturn.Text = "Return Back"
        Me.cmdReturn.UseVisualStyleBackColor = True
        '
        'HelpSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 350)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "HelpSection"
        Me.Text = "HelpSection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cmdReturn As Button
End Class

Public Class MainMenu
    Public PassportDate As Date
    Public MainDate As DateTime = #5/9/2019#
    Dim TestString As String = FormatDateTime(MainDate, DateFormat.LongDate)
    Dim AmountLeft As Integer
    Dim Age As Integer



    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DatabaseDataSet.Table1)

    End Sub

    Private Sub NoK_ForenameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MainMenu.ActiveForm.Show()
    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        If AgeTextBox.Text < 18 Then
            Label1.Text = "NextofKin Details Are Required!"
            MsgBox("A letter will be sent to your parents, asking for confirmation")
        ElseIf AgeTextBox.Text = "" Then

        End If
        If AgeTextBox.Text > 17 Then
            Label1.Text = ""
        ElseIf AgeTextBox.Text = "" Then

        End If

    End Sub
End Class

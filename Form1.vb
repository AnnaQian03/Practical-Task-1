Public Class Form1
    ' Boon Sze Qian 20DDT21F1004 

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        About.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.Click
        Dim salary As Double = Val(txtSalary.Text)
        Dim overtime As Double = Val(txtOvertime.Text)

        Dim workhour As Integer = Val(txtWorkHour.Text)
        Dim ratehour As Double = Val(txtRateHour.Text)
        Dim finaltotal As Double = Val(txtFinalTotal.Text)

        salary = workhour * ratehour
        finaltotal = salary + overtime

        txtOvertime.Text = workhour.ToString
        txtRateHour.Text = ratehour.ToString
        txtFinalTotal.Text = finaltotal.ToString("c2")
        txtSalary.Text = salary.ToString("c2")
        txtOvertime.Text = overtime.ToString("c2")


        ' Allow user to enter the value of their salary and calculate the total salary
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTNClear.Click
        Controls.Clear()
        InitializeComponent()
        ' Allow user to clear all the input
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenRecentToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BTNBrowse_Click(sender As Object, e As EventArgs) Handles BTNBrowse.Click
        Dim opf As New OpenFileDialog()

        opf.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All Files (*.*)|*.*"

        If opf.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If

        ' Allow the user to browse for images
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFolder As String = folderBrowserDialog.SelectedPath
            ' Allow user to browse folder 
        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog.FileName
            ' Allow the user to save the file
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
        ' Allow the user to exit the application
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtFinalTotal.Click
        Dim salary As Double = Val(txtSalary.Text)
        Dim overtime As Double = Val(txtOvertime.Text)

        Dim workhour As Double = Val(txtWorkHour.Text)
        Dim ratehour As Double = Val(txtRateHour.Text)
        Dim finaltotal As Double = Val(txtFinalTotal.Text)

        salary = workhour * ratehour
        finaltotal = salary + overtime

        txtOvertime.Text = workhour.ToString
        txtRateHour.Text = ratehour.ToString
        txtFinalTotal.Text = finaltotal.ToString("c2")
        txtSalary.Text = salary.ToString("c2")
        txtOvertime.Text = overtime.ToString("c2")


        ' Allow user to enter the value of their salary and calculate the total salary

    End Sub
End Class

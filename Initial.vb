Public Class Initial



    Private Sub Initial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 445
        Me.Height = 345
        Me.CenterToScreen()
        Step2.Location = Step1.Location
        Step2.Size = Step1.Size
        Step3.Location = Step1.Location
        Step3.Size = Step1.Size
        Step4.Location = Step1.Location
        Step4.Size = Step1.Size
        Step5.Location = Step1.Location
        Step5.Size = Step1.Size
        Step6.Location = Step1.Location
        Step6.Size = Step1.Size
        BBack.Enabled = False

    End Sub

    Dim i = 1
    Sub svitcher(ByVal count)
        Select Case count
            Case 1
                Step1.Visible = True
                Step2.Visible = False
                Step6.Visible = False
                BNext.Text = "Вперед"
                BBack.Enabled = False
            Case 2
                Step2.Visible = True
                Step3.Visible = False
                Step1.Visible = False
                BBack.Enabled = True
            Case 3
                Step3.Visible = True
                Step4.Visible = False
                Step2.Visible = False
            Case 4
                Step4.Visible = True
                Step5.Visible = False
                Step3.Visible = False
            Case 5
                Step5.Visible = True
                Step6.Visible = False
                Step4.Visible = False
                BNext.Text = "Вперед"
            Case 6
                Step6.Visible = True
                Step1.Visible = False
                Step5.Visible = False
                BNext.Text = "Сначала"
        End Select
    End Sub
    Sub formReset()
        ChoiseOfFirm.ResetText()
        ChoiseTET.ResetText()
        Completeness.CheckState = CheckState.Unchecked
        GoodCondition.CheckState = CheckState.Unchecked
        U.Text = ""
        Umax.Text = ""
        Hourse.Text = ""
        Minut.Text = ""
        Log.Text = ""
        AutoStepVer.CheckState = CheckState.Unchecked
    End Sub
    Private Sub BNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNext.Click
        i += 1
        If i > 6 Then
            i = 1
            formReset()
        End If
        svitcher(i)

    End Sub

    Private Sub BBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBack.Click
        i -= 1
        svitcher(i)
    End Sub
    Sub checkingProcess()
        Dim counter = 0
        While counter < 500
            Log.Text += "-||-"
            counter += 1
        End While
    End Sub
    Private Sub PlayPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayPause.Click
        checkingProcess()
    End Sub


End Class

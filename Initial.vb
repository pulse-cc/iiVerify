Public Class Initial
    Public Function LSplit(ByVal Source As String, ByVal Split As String, _
                           ByRef Head As String, ByRef Tail As String)
        Dim ix As Long = InStr(Source, Split)
        If ix = 0 Then Return False
        Head = Trim(Mid(Source, 1, ix - 1))
        Tail = Trim(Mid(Source, ix + Len(Split)))
        Return True
    End Function

    Private Function InvokeProcess(ByVal ProcessName As String, ByVal Arguments As String, _
        ByRef StdOutStr As String, ByRef StdErrStr As String) As Integer
        Dim p As Process = New Process
        ' this is the name of the process we want to execute 
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.FileName = ProcessName
        p.StartInfo.Arguments = Arguments
        ' need to set this to false to redirect output
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True
        ' start the process 
        p.Start()
        ' read all the output
        StdOutStr += p.StandardOutput.ReadToEnd
        StdErrStr += p.StandardError.ReadToEnd()
        ' wait for the process to terminate 
        p.WaitForExit()
        Return p.ExitCode
    End Function


    Private Sub Initial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 445
        Me.Height = 345
        Me.CenterToScreen()
        CtrlStep1.Location = Step1.Location
        CtrlStep1.Size = Step1.Size
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
        LogErr.Visible = False
        Log.Height = 205
        lblPIN.Visible = False
        PINbox.Visible = False
        source.Text = "suka is yana"
        Splitter.Text = "is"
    End Sub

    Dim i = 1
    Sub svitcher(ByVal count)
        Select Case count
            Case 1
                Step1.Visible = True
                Step2.Visible = False
                Step6.Visible = False
                BNext.Text = "Вперед >"
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
                BNext.Text = "Вперед >"
            Case 6
                Step6.Visible = True
                Step1.Visible = False
                Step5.Visible = False
                BNext.Text = "Заново"
        End Select
    End Sub

    Sub formReset()
        ChoiseOfFirm.ResetText()
        ChoiseTET.ResetText()
        Completeness.CheckState = CheckState.Unchecked
        GoodCondition.CheckState = CheckState.Unchecked
        U.Text = ""
        T.Text = ""
        Hourse.Text = ""
        Minut.Text = ""
        Log.Text = ""
        AutoStepVer.CheckState = CheckState.Unchecked
    End Sub

    Private Sub BNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNext.Click
        If CtrlStep1.Visible Then
            'tblEnterprize.Data()
            My.Settings.Save()
            Me.Close()
        End If
        i += 1
        If i > 6 Then
            i = 1
            formReset()
        End If
        svitcher(i)
        'Calibrator.
    End Sub

    Private Sub BBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBack.Click
        If CtrlStep1.Visible Then Me.Close()
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
        Me.PlayPause.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim cmd As String = My.Settings.ExePath + "\Inspector.exe"
        Dim arg As String = "fix U=2 F=0 Umax=20"
        If TimeOfDay.Minute Mod 2 = 0 Then
            arg = "suka " + arg
        End If
        InvokeProcess(cmd, arg, Log.Text, LogErr.Text)
        If LogErr.Text <> "" Then
            LogErr.Visible = True
            Log.Height = 134
        End If
        PlayPause.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub split_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles split.Click
        Head.Text = "?"
        Tail.Text = "?"
        LSplit(source.Text, Splitter.Text, Head.Text, Tail.Text)
    End Sub

    Private Sub ToolBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBox.Click
        ToolBox.Visible = False
        lblPIN.Visible = True
        PINbox.Visible = True
        PINbox.Select()
    End Sub

    Private Sub PINbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PINbox.KeyPress
        If e.KeyChar = Chr(13) Then
            If My.Settings.PIN = PINbox.Text Then
                CtrlStep1.Visible = True
                Step1.Visible = False
                Step2.Visible = False
                Step3.Visible = False
                Step4.Visible = False
                Step5.Visible = False
                Step6.Visible = False
                BNext.Text = "Сохранить"
                BNext.Enabled = False
                BBack.Text = "Отменить"
                BBack.Enabled = True
            Else
                ToolBox.Visible = True
            End If
            lblPIN.Visible = False
            PINbox.Visible = False
        End If
    End Sub

    Private Sub tblEnterprize_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblEnterprize.CellContentClick

    End Sub

    Private Sub tblEnterprize_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblEnterprize.CellValueChanged
        BNext.Enabled = True
    End Sub
End Class

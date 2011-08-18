Public Class Initial
    Public Function LSplit(ByVal Source As String, ByVal Split As String, _
                           ByRef Head As String, ByRef Tail As String)
        Dim ix As Long = InStr(Source, Split)
        If ix = 0 Then Return False
        Head = Trim(Mid(Source, 1, ix - 1))
        Tail = Trim(Mid(Source, ix + Len(Split)))
        Return True
    End Function

    Public Function StrToDouble(ByVal value As String) As Double
        Dim Result As Double = 0
        Dim Separator As String = System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
        Double.TryParse(System.Text.RegularExpressions.Regex.Replace(value.Trim, ",|\.", Separator), System.Globalization.NumberStyles.Any, System.Threading.Thread.CurrentThread.CurrentCulture, Result)
        Return Result
    End Function

    Private Function InvokeProcess(ByVal ProcessName As String, ByVal Arguments As String, _
        ByRef StdOutStr As String, ByRef StdErrStr As String) As Integer
        Dim p As Process = New Process
        ' this is the name of the process we want to execute 
        p.StartInfo.CreateNoWindow = True
        ' MsgBox(ProcessName)
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
        'TODO: данная строка кода позволяет загрузить данные в таблицу "MetrologyDataSet.Enterprize". При необходимости она может быть перемещена или удалена.
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
        lblPIN.Visible = False
        PINbox.Visible = False
        BBack.Enabled = False
        LogErr.Visible = False
        Log.Height = 205
        'ReDim Preserve frencyList(frencyList.Length + 1)
        ReDim frencyList(0)
        ReDim EMFlist(0)
        ReDim frencyList(5)
        frencyList(0) = 1000
        frencyList(1) = 20
        frencyList(2) = 400
        frencyList(3) = 10000
        frencyList(4) = 100000

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
                BNext.Enabled = True
            Case 5
                Step5.Visible = True
                Step6.Visible = False
                Step4.Visible = False
                BNext.Enabled = False
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
            'Me.EnterprizeTableAdapter.NewEnterprize()
            '(Me.MetrologyDataSet.Enterprize)
            'Me.EnterprizeBindingSource.S
            'Me.EnterprizeTableAdapter.Update(Me.MetrologyDataSet.Enterprize)
            My.Settings.Save()
            Me.Close()
        End If
        i += 1
        If i > 6 Then
            i = 1
            formReset()
        End If
        svitcher(i)

    End Sub

    Private Sub BBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBack.Click
        If CtrlStep1.Visible Then Me.Close()
        i -= 1
        svitcher(i)
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

    Structure EMF
        Dim value As Double
        Dim nameOfDimension As String
    End Structure

    Sub showErr()
        If LogErr.Text <> "" Then
            LogErr.Visible = True
            Log.Height = 134
        End If
    End Sub

    Sub getEMF(ByVal EMFnum As Int16, ByVal EMFname As String, ByVal refVer As Boolean)
        Dim Head As String = ""
        Dim Tail As String = ""
        'послать команду испектору получить значения ЭДС эталона
        'сохранить значение ЭДС эталона
        If refVer = 0 Then
            arg = "ref"
        Else
            arg = "ver"
        End If

        If InvokeProcess(cmd, arg, Log.Text, LogErr.Text) = 0 Then
            LSplit(LogErr.Text, "=", Head, Tail)
            LogErr.Text = ""
            If Head = "Eref" Then
                If EMFlist.Length < (EMFnum + 1) Then
                    ReDim Preserve EMFlist(EMFnum)
                End If
                EMFlist(EMFnum).value = StrToDouble(Tail)
                EMFlist(EMFnum).nameOfDimension = EMFname
                Log.Text += EMFlist(EMFnum).nameOfDimension + "=" + CStr(EMFlist(EMFnum).value) + Chr(13)
            Else
                LogErr.Text += "reurned unknown value"
                showErr()
            End If
        Else
            showErr()
        End If
    End Sub
    Dim cmd As String = My.Settings.ExePath + "\Inspector.exe"
    Dim arg As String = ""
    Dim loops As Int32 = 4
    Dim loopsF As Int32 = 7
    Dim EMFlist() As EMF
    'Dim Ename() As String
    Dim frencyList() As Int32 ' заполнить при выборе калибратора
    Dim stepVer = 0

    Private Sub PlayPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayPause.Click
        Label16.Text = "Запущен процесс поверки ..."
        'PlayPause.Text = "Продолжить"

        Dim Head As String = ""
        Dim Tail As String = ""
        Dim Umax As Double = 20
        'If TimeOfDay.Minute Mod 2 = 0 Then
        'rg = "suka " + arg
        'End If

        Select Case stepVer
            Case 0
                Me.PlayPause.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                If PlayPause.Text = "Прервать" Then
                    'Послать команду сброса калибратора
                    getEMF(0, "E~01", 0)
                    arg = "res"
                    InvokeProcess(cmd, arg, Log.Text, LogErr.Text)
                    Log.Text += "процесс прогрева прерван" + Chr(13)
                    PlayPause.Text = "Продолжить"
                    stepVer += 1
                    tmrHeatUp.Stop()
                Else
                    Log.Text += "запущен процесс прогрева" + Chr(13)
                    arg = "fix" + " U=" + U.Text + " F=1000" + " Umax=" + CStr(Umax)
                    If InvokeProcess(cmd, arg, Log.Text, LogErr.Text) = 0 Then
                        LSplit(LogErr.Text, "=", Head, Tail)
                        LogErr.Text = ""
                        PlayPause.Text = "Прервать"
                        tmrHeatUp.Interval = ((1000 * 120) * Convert.ToInt16(Hourse.Text)) + ((1000 * 60) * Convert.ToInt16(Minut.Text)) + 1
                        tmrHeatUp.Start()
                    Else
                        showErr()
                    End If
                End If
        End Select
        'LSplit(source.Text, Splitter.Text, Head.Text, Tail.Text)
        PlayPause.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHeatUp.Tick

        stepVer += 1
        tmrHeatUp.Stop()
        'послать команду испектору получить значения ЭДС эталона
        'сохранить значение ЭДС эталона
        getEMF(0, "E~01", 0)

        PlayPause.Text = "Продолжить"
        Log.Text += "процесс прогрева завершен" + Chr(13)
    End Sub

    Private Sub tblEnterprize_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblEnterprize.CellValueChanged
        BNext.Enabled = True
    End Sub

End Class

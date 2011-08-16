<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Initial
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Initial))
        Me.Buttons = New System.Windows.Forms.Panel()
        Me.BBack = New System.Windows.Forms.Button()
        Me.BNext = New System.Windows.Forms.Button()
        Me.Step1 = New System.Windows.Forms.Panel()
        Me.ChoiseTET = New System.Windows.Forms.ComboBox()
        Me.ChoiseOfFirm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Step2 = New System.Windows.Forms.Panel()
        Me.GoodCondition = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Completeness = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Step3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Step4 = New System.Windows.Forms.Panel()
        Me.lblP = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.TextBox()
        Me.lblG = New System.Windows.Forms.Label()
        Me.G = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Minut = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Hourse = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.U = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Step6 = New System.Windows.Forms.Panel()
        Me.Step5 = New System.Windows.Forms.Panel()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.AutoStepVer = New System.Windows.Forms.CheckBox()
        Me.PlayPause = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LogErr = New System.Windows.Forms.RichTextBox()
        Me.Buttons.SuspendLayout()
        Me.Step1.SuspendLayout()
        Me.Step2.SuspendLayout()
        Me.Step3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Step4.SuspendLayout()
        Me.Step5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buttons
        '
        Me.Buttons.Controls.Add(Me.BBack)
        Me.Buttons.Controls.Add(Me.BNext)
        Me.Buttons.Location = New System.Drawing.Point(257, 282)
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Size = New System.Drawing.Size(175, 36)
        Me.Buttons.TabIndex = 0
        '
        'BBack
        '
        Me.BBack.Location = New System.Drawing.Point(4, 4)
        Me.BBack.Name = "BBack"
        Me.BBack.Size = New System.Drawing.Size(75, 23)
        Me.BBack.TabIndex = 1
        Me.BBack.Text = "< Назад"
        Me.BBack.UseVisualStyleBackColor = True
        '
        'BNext
        '
        Me.BNext.Location = New System.Drawing.Point(86, 4)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(75, 23)
        Me.BNext.TabIndex = 0
        Me.BNext.Text = "Вперед >"
        Me.BNext.UseVisualStyleBackColor = True
        '
        'Step1
        '
        Me.Step1.Controls.Add(Me.ChoiseTET)
        Me.Step1.Controls.Add(Me.ChoiseOfFirm)
        Me.Step1.Controls.Add(Me.Label3)
        Me.Step1.Controls.Add(Me.Label2)
        Me.Step1.Controls.Add(Me.Label1)
        Me.Step1.Controls.Add(Me.ShapeContainer1)
        Me.Step1.Location = New System.Drawing.Point(3, 4)
        Me.Step1.Name = "Step1"
        Me.Step1.Size = New System.Drawing.Size(428, 278)
        Me.Step1.TabIndex = 1
        '
        'ChoiseTET
        '
        Me.ChoiseTET.FormattingEnabled = True
        Me.ChoiseTET.Items.AddRange(New Object() {"преобразователь 1", "преобразователь 2", "преобразователь 3"})
        Me.ChoiseTET.Location = New System.Drawing.Point(11, 201)
        Me.ChoiseTET.Name = "ChoiseTET"
        Me.ChoiseTET.Size = New System.Drawing.Size(402, 21)
        Me.ChoiseTET.TabIndex = 4
        '
        'ChoiseOfFirm
        '
        Me.ChoiseOfFirm.FormattingEnabled = True
        Me.ChoiseOfFirm.Items.AddRange(New Object() {"фирма 1", "фирма 2", "фирма 3"})
        Me.ChoiseOfFirm.Location = New System.Drawing.Point(11, 116)
        Me.ChoiseOfFirm.Name = "ChoiseOfFirm"
        Me.ChoiseOfFirm.Size = New System.Drawing.Size(402, 21)
        Me.ChoiseOfFirm.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Уточните наименование поверяемого термоэлектрического преобразователя"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Укажите производителя поверяемого термоэлектрического преобразователя" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Для начала проведения поверки термоэлектрического преобразователя необходимо выбр" & _
            "ать исходные данные"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(428, 278)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 427
        Me.LineShape1.Y1 = 64
        Me.LineShape1.Y2 = 64
        '
        'Step2
        '
        Me.Step2.Controls.Add(Me.GoodCondition)
        Me.Step2.Controls.Add(Me.Label6)
        Me.Step2.Controls.Add(Me.Completeness)
        Me.Step2.Controls.Add(Me.Label5)
        Me.Step2.Controls.Add(Me.Label4)
        Me.Step2.Controls.Add(Me.ShapeContainer2)
        Me.Step2.Location = New System.Drawing.Point(438, 4)
        Me.Step2.Name = "Step2"
        Me.Step2.Size = New System.Drawing.Size(428, 278)
        Me.Step2.TabIndex = 2
        Me.Step2.Visible = False
        '
        'GoodCondition
        '
        Me.GoodCondition.AutoSize = True
        Me.GoodCondition.ForeColor = System.Drawing.Color.Crimson
        Me.GoodCondition.Location = New System.Drawing.Point(158, 201)
        Me.GoodCondition.Name = "GoodCondition"
        Me.GoodCondition.Size = New System.Drawing.Size(97, 17)
        Me.GoodCondition.TabIndex = 5
        Me.GoodCondition.Text = "Подтверждаю"
        Me.GoodCondition.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(422, 46)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Преобразователь  не имеет механических повреждений и неисправностей соединительны" & _
            "х элементов, влияющих на его нормальную работу"
        '
        'Completeness
        '
        Me.Completeness.AutoSize = True
        Me.Completeness.ForeColor = System.Drawing.Color.Crimson
        Me.Completeness.Location = New System.Drawing.Point(158, 116)
        Me.Completeness.Name = "Completeness"
        Me.Completeness.Size = New System.Drawing.Size(97, 17)
        Me.Completeness.TabIndex = 3
        Me.Completeness.Text = "Подтверждаю"
        Me.Completeness.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(422, 40)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Преобразователь укомплектован согласно НТД на преобразователи данного типа и имее" & _
            "т свидетельство о предыдущей поверке"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(421, 54)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Произведите внешний осмотр. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Подтвердите соответствие преобразователя следующим " & _
            "требованиям:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(428, 278)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 427
        Me.LineShape2.Y1 = 64
        Me.LineShape2.Y2 = 64
        '
        'Step3
        '
        Me.Step3.Controls.Add(Me.PictureBox1)
        Me.Step3.Controls.Add(Me.Label7)
        Me.Step3.Controls.Add(Me.ShapeContainer3)
        Me.Step3.Location = New System.Drawing.Point(4, 321)
        Me.Step3.Name = "Step3"
        Me.Step3.Size = New System.Drawing.Size(428, 278)
        Me.Step3.TabIndex = 3
        Me.Step3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 222)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Соедините приборы согласно схеме"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(428, 278)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1
        Me.LineShape3.X2 = 428
        Me.LineShape3.Y1 = 37
        Me.LineShape3.Y2 = 37
        '
        'Step4
        '
        Me.Step4.Controls.Add(Me.lblP)
        Me.Step4.Controls.Add(Me.P)
        Me.Step4.Controls.Add(Me.lblG)
        Me.Step4.Controls.Add(Me.G)
        Me.Step4.Controls.Add(Me.Label15)
        Me.Step4.Controls.Add(Me.Minut)
        Me.Step4.Controls.Add(Me.Label14)
        Me.Step4.Controls.Add(Me.Hourse)
        Me.Step4.Controls.Add(Me.Label13)
        Me.Step4.Controls.Add(Me.Label12)
        Me.Step4.Controls.Add(Me.T)
        Me.Step4.Controls.Add(Me.Label11)
        Me.Step4.Controls.Add(Me.Label10)
        Me.Step4.Controls.Add(Me.U)
        Me.Step4.Controls.Add(Me.Label9)
        Me.Step4.Controls.Add(Me.Label8)
        Me.Step4.Controls.Add(Me.ShapeContainer4)
        Me.Step4.Location = New System.Drawing.Point(438, 321)
        Me.Step4.Name = "Step4"
        Me.Step4.Size = New System.Drawing.Size(428, 278)
        Me.Step4.TabIndex = 2
        Me.Step4.Visible = False
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(296, 166)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(107, 13)
        Me.lblP.TabIndex = 21
        Me.lblP.Text = "Атм. давление, кПа"
        '
        'P
        '
        Me.P.Location = New System.Drawing.Point(299, 182)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(104, 20)
        Me.P.TabIndex = 20
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Location = New System.Drawing.Point(155, 166)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(77, 13)
        Me.lblG.TabIndex = 19
        Me.lblG.Text = "Влажность, %" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'G
        '
        Me.G.Location = New System.Drawing.Point(158, 182)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(84, 20)
        Me.G.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(180, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Минут"
        '
        'Minut
        '
        Me.Minut.Location = New System.Drawing.Point(122, 242)
        Me.Minut.Name = "Minut"
        Me.Minut.Size = New System.Drawing.Size(53, 20)
        Me.Minut.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(68, 247)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Часов"
        '
        'Hourse
        '
        Me.Hourse.Location = New System.Drawing.Point(10, 242)
        Me.Hourse.Name = "Hourse"
        Me.Hourse.Size = New System.Drawing.Size(53, 20)
        Me.Hourse.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(10, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(415, 22)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Укажите время прогрева термоэлектрического преобразователя"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Температура, С" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'T
        '
        Me.T.Location = New System.Drawing.Point(10, 182)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(84, 20)
        Me.T.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(406, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Укажите условия поверки"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Напряжение, В"
        '
        'U
        '
        Me.U.Location = New System.Drawing.Point(10, 111)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(84, 20)
        Me.U.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(406, 26)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Укажите напряжение при котором будет производиться поверка"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(422, 60)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Для начала процессов определения погрешности компарирования напряжения введите на" & _
            "чальные данные"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer4.Size = New System.Drawing.Size(428, 278)
        Me.ShapeContainer4.TabIndex = 5
        Me.ShapeContainer4.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 1
        Me.LineShape4.X2 = 428
        Me.LineShape4.Y1 = 62
        Me.LineShape4.Y2 = 62
        '
        'Step6
        '
        Me.Step6.Location = New System.Drawing.Point(438, 605)
        Me.Step6.Name = "Step6"
        Me.Step6.Size = New System.Drawing.Size(428, 278)
        Me.Step6.TabIndex = 4
        Me.Step6.Visible = False
        '
        'Step5
        '
        Me.Step5.Controls.Add(Me.LogErr)
        Me.Step5.Controls.Add(Me.Log)
        Me.Step5.Controls.Add(Me.AutoStepVer)
        Me.Step5.Controls.Add(Me.PlayPause)
        Me.Step5.Controls.Add(Me.Label16)
        Me.Step5.Location = New System.Drawing.Point(4, 605)
        Me.Step5.Name = "Step5"
        Me.Step5.Size = New System.Drawing.Size(428, 278)
        Me.Step5.TabIndex = 5
        Me.Step5.Visible = False
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Log.Location = New System.Drawing.Point(5, 37)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(420, 134)
        Me.Log.TabIndex = 7
        Me.Log.Text = ""
        '
        'AutoStepVer
        '
        Me.AutoStepVer.AutoSize = True
        Me.AutoStepVer.Location = New System.Drawing.Point(100, 253)
        Me.AutoStepVer.Name = "AutoStepVer"
        Me.AutoStepVer.Size = New System.Drawing.Size(165, 17)
        Me.AutoStepVer.TabIndex = 6
        Me.AutoStepVer.Text = "Далее не останавливаться"
        Me.AutoStepVer.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.AutoStepVer.UseVisualStyleBackColor = True
        '
        'PlayPause
        '
        Me.PlayPause.Location = New System.Drawing.Point(10, 249)
        Me.PlayPause.Name = "PlayPause"
        Me.PlayPause.Size = New System.Drawing.Size(84, 23)
        Me.PlayPause.TabIndex = 5
        Me.PlayPause.Text = "Продолжить"
        Me.PlayPause.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(106, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(226, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Запущен процесс поверки ..."
        '
        'LogErr
        '
        Me.LogErr.BackColor = System.Drawing.SystemColors.WindowText
        Me.LogErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LogErr.ForeColor = System.Drawing.Color.Red
        Me.LogErr.Location = New System.Drawing.Point(5, 173)
        Me.LogErr.Name = "LogErr"
        Me.LogErr.Size = New System.Drawing.Size(420, 70)
        Me.LogErr.TabIndex = 8
        Me.LogErr.Text = ""
        '
        'Initial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(918, 920)
        Me.Controls.Add(Me.Step6)
        Me.Controls.Add(Me.Step5)
        Me.Controls.Add(Me.Step4)
        Me.Controls.Add(Me.Step3)
        Me.Controls.Add(Me.Step2)
        Me.Controls.Add(Me.Step1)
        Me.Controls.Add(Me.Buttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Initial"
        Me.Text = "iVerify"
        Me.Buttons.ResumeLayout(False)
        Me.Step1.ResumeLayout(False)
        Me.Step2.ResumeLayout(False)
        Me.Step2.PerformLayout()
        Me.Step3.ResumeLayout(False)
        Me.Step3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Step4.ResumeLayout(False)
        Me.Step4.PerformLayout()
        Me.Step5.ResumeLayout(False)
        Me.Step5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttons As System.Windows.Forms.Panel
    Friend WithEvents BBack As System.Windows.Forms.Button
    Friend WithEvents BNext As System.Windows.Forms.Button
    Friend WithEvents Step1 As System.Windows.Forms.Panel
    Friend WithEvents ChoiseTET As System.Windows.Forms.ComboBox
    Friend WithEvents ChoiseOfFirm As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Step2 As System.Windows.Forms.Panel
    Friend WithEvents Step3 As System.Windows.Forms.Panel
    Friend WithEvents Step4 As System.Windows.Forms.Panel
    Friend WithEvents GoodCondition As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Completeness As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Step6 As System.Windows.Forms.Panel
    Friend WithEvents Step5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Minut As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Hourse As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents T As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents U As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents AutoStepVer As System.Windows.Forms.CheckBox
    Friend WithEvents PlayPause As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents P As System.Windows.Forms.TextBox
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents G As System.Windows.Forms.TextBox
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents LogErr As System.Windows.Forms.RichTextBox

End Class

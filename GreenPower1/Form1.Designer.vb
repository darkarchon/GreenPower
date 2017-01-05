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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.RadioButton5 = New System.Windows.Forms.RadioButton()
		Me.RadioButton6 = New System.Windows.Forms.RadioButton()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.notifyTimer3 = New System.Windows.Forms.Timer(Me.components)
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.Panel2.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ToolTip1
		'
		Me.ToolTip1.BackColor = System.Drawing.SystemColors.Window
		Me.ToolTip1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Location = New System.Drawing.Point(13, 35)
		Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(112, 21)
		Me.RadioButton1.TabIndex = 7
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Глубокий сон"
		Me.ToolTip1.SetToolTip(Me.RadioButton1, "Режим Гибернации." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Сохранение открытых приложений с полным выключением компьютера" &
		"." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Данные с памяти переностятся временно на диск и при пробужении восстанавливаю" &
		"тся.")
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame
		Me.MaskedTextBox1.BeepOnError = True
		Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MaskedTextBox1.Font = New System.Drawing.Font("Ubuntu", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.MaskedTextBox1.ForeColor = System.Drawing.Color.Transparent
		Me.MaskedTextBox1.HidePromptOnLeave = True
		Me.MaskedTextBox1.HideSelection = False
		Me.MaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
		Me.MaskedTextBox1.Location = New System.Drawing.Point(148, 67)
		Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.MaskedTextBox1.Mask = "00:00"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox1.Size = New System.Drawing.Size(166, 74)
		Me.MaskedTextBox1.TabIndex = 1
		Me.MaskedTextBox1.Text = "0100"
		Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.MaskedTextBox1, "Формат - часы : минуты" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Двоеточие не надо")
		Me.MaskedTextBox1.ValidatingType = GetType(Date)
		'
		'Button4
		'
		Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Location = New System.Drawing.Point(475, 12)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(32, 32)
		Me.Button4.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.Button4, "Свернуть")
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackgroundImage = Global.GreenPower1.My.Resources.Resources.close_32_b24_w
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(518, 12)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(32, 32)
		Me.Button3.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.Button3, "Закрыть")
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.Panel2.Controls.Add(Me.Button4)
		Me.Panel2.Controls.Add(Me.Button3)
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(562, 53)
		Me.Panel2.TabIndex = 20
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Ubuntu", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(155, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(239, 53)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Green Power"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Timer1
		'
		'
		'StatusStrip1
		'
		Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 307)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
		Me.StatusStrip1.Size = New System.Drawing.Size(233, 22)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 5
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
		Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.HighlightText
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(4, 0, 5, 0)
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(125, 17)
		Me.ToolStripStatusLabel1.Text = "Таймер не запущен"
		'
		'ToolStripStatusLabel2
		'
		Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
		Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
		Me.ToolStripStatusLabel2.Padding = New System.Windows.Forms.Padding(1, 0, 8, 0)
		Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 17)
		Me.ToolStripStatusLabel2.Text = "Тип таймера"
		'
		'ToolStripStatusLabel3
		'
		Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
		Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(13, 66)
		Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(105, 21)
		Me.RadioButton2.TabIndex = 8
		Me.RadioButton2.Text = "Простой сон"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Enabled = False
		Me.RadioButton3.Location = New System.Drawing.Point(13, 96)
		Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(109, 21)
		Me.RadioButton3.TabIndex = 9
		Me.RadioButton3.Text = "Выключение"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.RadioButton4)
		Me.GroupBox2.Controls.Add(Me.RadioButton1)
		Me.GroupBox2.Controls.Add(Me.RadioButton3)
		Me.GroupBox2.Controls.Add(Me.CheckBox2)
		Me.GroupBox2.Controls.Add(Me.RadioButton2)
		Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBox2.Location = New System.Drawing.Point(338, 68)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Size = New System.Drawing.Size(203, 194)
		Me.GroupBox2.TabIndex = 12
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Событие таймера"
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(13, 126)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(131, 21)
		Me.RadioButton4.TabIndex = 10
		Me.RadioButton4.TabStop = True
		Me.RadioButton4.Text = "Звуковой сигнал"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Checked = True
		Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox2.Location = New System.Drawing.Point(13, 157)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(182, 21)
		Me.CheckBox2.TabIndex = 17
		Me.CheckBox2.Text = "Предупредить за минуту"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.CheckBox1.Location = New System.Drawing.Point(404, 269)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox1.Size = New System.Drawing.Size(129, 21)
		Me.CheckBox1.TabIndex = 13
		Me.CheckBox1.Text = "Скрывать в трей"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.BalloonTipText = "Green Power"
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "Green Power"
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Checked = True
		Me.RadioButton5.Location = New System.Drawing.Point(16, 17)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(102, 21)
		Me.RadioButton5.TabIndex = 14
		Me.RadioButton5.TabStop = True
		Me.RadioButton5.Text = "По времени"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton6
		'
		Me.RadioButton6.AutoSize = True
		Me.RadioButton6.Location = New System.Drawing.Point(16, 44)
		Me.RadioButton6.Name = "RadioButton6"
		Me.RadioButton6.Size = New System.Drawing.Size(64, 21)
		Me.RadioButton6.TabIndex = 15
		Me.RadioButton6.Text = "Через"
		Me.RadioButton6.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.RadioButton6)
		Me.Panel1.Controls.Add(Me.RadioButton5)
		Me.Panel1.Location = New System.Drawing.Point(14, 68)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(116, 79)
		Me.Panel1.TabIndex = 16
		'
		'CheckBox3
		'
		Me.CheckBox3.AutoSize = True
		Me.CheckBox3.Location = New System.Drawing.Point(32, 269)
		Me.CheckBox3.Name = "CheckBox3"
		Me.CheckBox3.Size = New System.Drawing.Size(156, 21)
		Me.CheckBox3.TabIndex = 18
		Me.CheckBox3.Text = "Ежедневный таймер"
		Me.CheckBox3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Tomato
		Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button2.ForeColor = System.Drawing.SystemColors.Window
		Me.Button2.Image = Global.GreenPower1.My.Resources.Resources.audio_stop_24b_bor_w
		Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button2.Location = New System.Drawing.Point(182, 185)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Padding = New System.Windows.Forms.Padding(18, 0, 15, 0)
		Me.Button2.Size = New System.Drawing.Size(120, 46)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Стоп"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Tomato
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button1.ForeColor = System.Drawing.SystemColors.Window
		Me.Button1.Image = Global.GreenPower1.My.Resources.Resources.shutdown_24b_bor_w
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.Location = New System.Drawing.Point(32, 185)
		Me.Button1.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Padding = New System.Windows.Forms.Padding(18, 0, 15, 0)
		Me.Button1.Size = New System.Drawing.Size(120, 46)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Старт"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.UseVisualStyleBackColor = False
		'
		'notifyTimer3
		'
		Me.notifyTimer3.Tag = "countdown"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.WindowFrame
		Me.CancelButton = Me.Button2
		Me.ClientSize = New System.Drawing.Size(562, 331)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.CheckBox3)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.MaskedTextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Таймер сна"
		Me.Panel2.ResumeLayout(False)
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents Timer1 As Timer
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents NotifyIcon1 As NotifyIcon
	Friend WithEvents Button2 As Button
	Friend WithEvents MaskedTextBox1 As MaskedTextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents RadioButton5 As RadioButton
	Friend WithEvents RadioButton6 As RadioButton
	Friend WithEvents Panel1 As Panel
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
	Friend WithEvents notifyTimer3 As Timer
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class

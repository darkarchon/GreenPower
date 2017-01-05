'Imports System.ComponentModel

Public Class Form1

	Public Ttime, Tleft As TimeSpan

	Public Function hideControl(hideOrshow As Boolean) As Boolean   ' manipulating controls
		If hideOrshow = True Then
			Button1.Enabled = False
			RadioButton1.Enabled = False
			RadioButton2.Enabled = False
			RadioButton3.Enabled = False
			RadioButton4.Enabled = False
			RadioButton5.Enabled = False
			RadioButton6.Enabled = False
			MaskedTextBox1.Enabled = False
			CheckBox2.Enabled = False
		Else
			Button1.Enabled = True
			RadioButton1.Enabled = True
			RadioButton2.Enabled = True
			RadioButton3.Enabled = True
			RadioButton4.Enabled = True
			RadioButton5.Enabled = True
			RadioButton6.Enabled = True
			MaskedTextBox1.Enabled = True
			CheckBox2.Enabled = True
		End If
	End Function

	Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim Tnow As TimeSpan = Date.Now.TimeOfDay

		Try
			Ttime = TimeSpan.Parse(MaskedTextBox1.Text.ToString)
		Catch
			MessageBox.Show(MaskedTextBox1.Text + "Не правильно введено время. Необходимы все 4 цифры.", "Некоректное время!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			MaskedTextBox1.Focus()
			MaskedTextBox1.SelectAll()
			Exit Sub
		End Try

		' condition if time out of current time, then compute rest of time to next day
		If RadioButton5.Checked = True Then
			If (Ttime > Tnow) Then
				Tleft = Ttime.Subtract(Tnow)
			Else
				Tleft = New TimeSpan(1, 0, 0, 0).Subtract(Tnow).Add(Ttime)
				ToolStripStatusLabel3.Text = String.Format("Дата срабатывания: {0} {1:hh\:mm}", WeekdayName(Date.Now.AddDays(1).DayOfWeek), Tleft)
			End If
			Timer1.Interval = Tleft.TotalMilliseconds
			ToolStripStatusLabel1.Text = String.Format("Осталось: {0:hh}ч {0:mm}м", Tleft)
		Else
			Timer1.Interval = Ttime.TotalMilliseconds
			ToolStripStatusLabel1.Text = String.Format("Осталось: {0:hh}ч {0:mm}м", Ttime)
			ToolStripStatusLabel3.Text = String.Format("Запланировано на: {0:MMM dd\, HH\:mm}", Date.Now + Ttime)
		End If

		' notify before 1 minute, dimmer on statuslabel1
		notifyTimer3.Interval = TimeSpan.FromSeconds(60).TotalMilliseconds
		notifyTimer3.Enabled = True
		notifyTimer3.Start()

		Timer1.Enabled = True
		Timer1.Start()

		hideControl(True)

		'GroupBox2. (Of CheckBox).SingleOrDefault(Function(rc) rc.Checked = True).Text
		For Each chkd In GroupBox2.Controls
			If chkd.Checked = True And chkd.GetType Is GetType(RadioButton) Then  ' System.Windows.Forms.CheckBox .Checked
				ToolStripStatusLabel2.Text = "Режим: " + chkd.Text
			End If
		Next

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Timer1.Interval = 100
		' Timer1.Enabled = False
		Timer1.Stop()
		notifyTimer3.Stop()
		My.Computer.Audio.Stop()
		hideControl(False)
		ToolStripStatusLabel1.Text = "Таймер остановлен"
		ToolStripStatusLabel3.Text = ""
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		'MaskedTextBox1.Select(0, 1)
		'MaskedTextBox1.Focus()

		ToolStripStatusLabel2.Text = "Выбран: " + RadioButton1.Text
		GroupBoxRenderer.RenderMatchingApplicationState = False
	End Sub

	Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
		If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
			Button1_Click(sender, e)
			e.Handled = True
		End If
	End Sub

	Private Sub MaskedTextBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles MaskedTextBox1.MouseWheel
		If e.Delta > 0 Then
			MaskedTextBox1.Text = TimeSpan.Parse(MaskedTextBox1.Text).Add(TimeSpan.FromMinutes(5)).ToString
		Else
			MaskedTextBox1.Text = TimeSpan.Parse(MaskedTextBox1.Text).Subtract(TimeSpan.FromMinutes(5)).ToString
		End If
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Timer1.Stop()
		' Timer1.Enabled = False

		If RadioButton1.Checked = True Then
			Application.SetSuspendState(PowerState.Hibernate, False, False)
		ElseIf RadioButton2.Checked = True Then
			Application.SetSuspendState(PowerState.Suspend, False, False)
		ElseIf RadioButton3.Checked = True Then
			Process.Start("shutdown", "-s")
		Else
			My.Computer.Audio.Play(My.Resources.Calendar_mono_8k, AudioPlayMode.BackgroundLoop)
		End If
		If CheckBox3.Checked = True And RadioButton5.Checked = True Then
			Timer1.Interval = 24 * 60 * 60 * 1000  ' 24h
			Timer1.Start()
			ToolStripStatusLabel3.Text = "Дата: " + WeekdayName(Date.Now.AddDays(1).DayOfWeek) + " " + Ttime.ToString("h\:mm")
		End If
	End Sub

	Private Sub Panel2_DoubleClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseDoubleClick, Button4.MouseClick
		If e.Button = MouseButtons.Left Then
			If CheckBox1.Checked = True Then
				NotifyIcon1.Visible = True
				ShowInTaskbar = False
			End If
			WindowState = FormWindowState.Minimized
		End If
	End Sub

	Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
		WindowState = FormWindowState.Normal
		NotifyIcon1.Visible = False
		ShowInTaskbar = True
	End Sub

	Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
		If RadioButton4.Checked = True Then
			CheckBox2.Enabled = False
		ElseIf CheckBox2.Enabled = False Then
			CheckBox2.Enabled = True
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If Timer1.Interval > 100 Then
			Dim AppQuit As String = MessageBox.Show("Таймер запущен, в случае зактрытия он будет остановлен", "Вы уверены?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
			If AppQuit = DialogResult.OK Then
				Timer1.Enabled = False
				Timer1.Stop()
				If notifyTimer3.Enabled Then
					notifyTimer3.Enabled = False
					notifyTimer3.Stop()
				End If
				My.Computer.Audio.Stop()
				Close()
			End If
		Else
			NotifyIcon1.Visible = False
			Close()
		End If
	End Sub

	' drag and move borderless form
	Dim allowdrag As Boolean = False
	Dim posX, posY As Integer

	Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown, Panel2.MouseDown
		If e.Button = MouseButtons.Left Then
			allowdrag = True
			posX = e.X
			posY = e.Y
		End If
	End Sub

	Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, Panel2.MouseUp
		If e.Button = MouseButtons.Left Then
			allowdrag = False
		End If
	End Sub

	Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove, Panel2.MouseMove
		If allowdrag = True Then
			' because of coordinates gets from event object, we need to additionally count from top-left object and top-left form(me.top, me.left)
			' if event object doesn't start from top-left of form, then we need to subtrack a difference
			If sender Is Label1 Then
				Me.Left = Cursor.Position.X - posX - (Label1.Location.X) ' e.Location.X 
			Else
				Me.Left = Cursor.Position.X - posX
			End If
			Me.Top = Cursor.Position.Y - posY
		End If
	End Sub

	Private Sub notifyTimer3_Tick(sender As Object, e As EventArgs) Handles notifyTimer3.Tick
		Tleft = Tleft - TimeSpan.FromSeconds(60)

		' don't forget this timer is 1 minute cycle, but the remaining part of time is allways been less than a 1 minute
		If Tleft < TimeSpan.FromSeconds(45) And CheckBox2.Checked = True Then
			My.Computer.Audio.Play(My.Resources.Calendar_mono_8k, AudioPlayMode.Background)
		End If
		ToolStripStatusLabel1.Text = String.Format("Осталось: {0:hh}ч {0:mm}м", Tleft)
	End Sub

	'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
	'	posX = Cursor.Position.X - posX
	'	posY = Cursor.Position.Y - posY
	'End Sub

End Class
Namespace WindowsApplication1
	' Token: 0x0200000A RID: 10
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000031 RID: 49 RVA: 0x0001DDBC File Offset: 0x0001C1BC
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x0001DE0C File Offset: 0x0001C20C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.WindowsApplication1.Form1))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(3, 9)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(84, 13)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "EmRe SağdiLek"
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(12, 67)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 39)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Aktif"
			Me.Button1.UseVisualStyleBackColor = True
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(112, 67)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(75, 39)
			button4.Size = size
			Me.Button2.TabIndex = 2
			Me.Button2.Text = "Pasif"
			Me.Button2.UseVisualStyleBackColor = True
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			location = New Global.System.Drawing.Point(210, 67)
			button5.Location = location
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(75, 39)
			button6.Size = size
			Me.Button3.TabIndex = 3
			Me.Button3.Text = "Çıkış"
			Me.Button3.UseVisualStyleBackColor = True
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(12, 41)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(273, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 4
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(290, 120)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Form1"
			Me.Text = "FLOOD Atma"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400000E RID: 14
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace

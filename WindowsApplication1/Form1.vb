Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x0600002F RID: 47 RVA: 0x0001DC94 File Offset: 0x0001C094
		<DebuggerNonUserCode()>
		Public Sub New()
			Form1.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x0001DCAC File Offset: 0x0001C0AC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = Form1.__ENCList.Count = Form1.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Form1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Form1.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								Form1.__ENCList(num) = Form1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num)
					Form1.__ENCList.Capacity = Form1.__ENCList.Count
				End If
				Form1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000033 RID: 51 RVA: 0x0001E170 File Offset: 0x0001C570
		' (set) Token: 0x06000034 RID: 52 RVA: 0x0001E188 File Offset: 0x0001C588
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Label1_Click
				Dim flag As Boolean = Me._Label1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Label1.Click, value2
				End If
				Me._Label1 = value
				flag = (Me._Label1 IsNot Nothing)
				If flag Then
					AddHandler Me._Label1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000035 RID: 53 RVA: 0x0001E1E8 File Offset: 0x0001C5E8
		' (set) Token: 0x06000036 RID: 54 RVA: 0x0001E200 File Offset: 0x0001C600
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				flag = (Me._Button1 IsNot Nothing)
				If flag Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000037 RID: 55 RVA: 0x0001E260 File Offset: 0x0001C660
		' (set) Token: 0x06000038 RID: 56 RVA: 0x0001E278 File Offset: 0x0001C678
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				flag = (Me._Button2 IsNot Nothing)
				If flag Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000039 RID: 57 RVA: 0x0001E2D8 File Offset: 0x0001C6D8
		' (set) Token: 0x0600003A RID: 58 RVA: 0x0001E2F0 File Offset: 0x0001C6F0
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button3_Click
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, value2
				End If
				Me._Button3 = value
				flag = (Me._Button3 IsNot Nothing)
				If flag Then
					AddHandler Me._Button3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x0600003B RID: 59 RVA: 0x0001E350 File Offset: 0x0001C750
		' (set) Token: 0x0600003C RID: 60 RVA: 0x0001E368 File Offset: 0x0001C768
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x0600003D RID: 61 RVA: 0x0001E374 File Offset: 0x0001C774
		' (set) Token: 0x0600003E RID: 62 RVA: 0x0001E38C File Offset: 0x0001C78C
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._Timer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				flag = (Me._Timer1 IsNot Nothing)
				If flag Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x0600003F RID: 63 RVA: 0x0001E3EC File Offset: 0x0001C7EC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Timer1.Enabled = True
		End Sub

		' Token: 0x06000040 RID: 64 RVA: 0x0001E400 File Offset: 0x0001C800
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Timer1.Enabled = False
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x0001E414 File Offset: 0x0001C814
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000042 RID: 66 RVA: 0x0001E420 File Offset: 0x0001C820
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			SendKeys.Send("{Enter}")
			SendKeys.Send(Me.TextBox1.Text)
		End Sub

		' Token: 0x06000043 RID: 67 RVA: 0x0001E440 File Offset: 0x0001C840
		Private Sub Label1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400000D RID: 13
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400000F RID: 15
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000010 RID: 16
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000011 RID: 17
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000012 RID: 18
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000013 RID: 19
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000014 RID: 20
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer
	End Class
End Namespace

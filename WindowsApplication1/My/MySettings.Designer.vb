Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.My
	' Token: 0x0200000C RID: 12
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x06000049 RID: 73 RVA: 0x0001D5EC File Offset: 0x0001B9EC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerNonUserCode()>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			Dim saveMySettingsOnExit As Boolean = MyProject.Application.SaveMySettingsOnExit
			If saveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x0600004A RID: 74 RVA: 0x0001D618 File Offset: 0x0001BA18
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Dim flag As Boolean = Not MySettings.addedHandler
				If flag Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					Dim flag2 As Boolean = False
					Try
						Monitor.Enter(obj, flag2)
						flag = Not MySettings.addedHandler
						If flag Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					Finally
						flag = flag2
						If flag Then
							Monitor.[Exit](obj)
						End If
					End Try
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x04000017 RID: 23
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x04000018 RID: 24
		Private Shared addedHandler As Boolean

		' Token: 0x04000019 RID: 25
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace

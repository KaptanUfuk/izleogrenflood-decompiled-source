Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.My
	' Token: 0x0200000D RID: 13
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	<HideModuleName()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600004B RID: 75 RVA: 0x0001D6A4 File Offset: 0x0001BAA4
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace

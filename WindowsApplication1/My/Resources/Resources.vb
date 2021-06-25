Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.My.Resources
	' Token: 0x0200000B RID: 11
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module Resources
		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000044 RID: 68 RVA: 0x0001D54C File Offset: 0x0001B94C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("WindowsApplication1.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000045 RID: 69 RVA: 0x0001D594 File Offset: 0x0001B994
		' (set) Token: 0x06000046 RID: 70 RVA: 0x0001D5AC File Offset: 0x0001B9AC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x04000015 RID: 21
		Private resourceMan As ResourceManager

		' Token: 0x04000016 RID: 22
		Private resourceCulture As CultureInfo
	End Module
End Namespace

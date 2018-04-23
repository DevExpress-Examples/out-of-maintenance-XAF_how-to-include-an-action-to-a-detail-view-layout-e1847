Imports Microsoft.VisualBasic
Imports System
Namespace MySolution.Module.Controllers
	Partial Public Class MyViewController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.MySimpleAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' MySimpleAction
			' 
			Me.MySimpleAction.Caption = "My Simple Action"
			Me.MySimpleAction.Category = "MyCategory"
			Me.MySimpleAction.ConfirmationMessage = Nothing
			Me.MySimpleAction.Id = "MySimpleAction"
			Me.MySimpleAction.ToolTip = Nothing
'			Me.MySimpleAction.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.MySimpleAction_Execute);

		End Sub

		#End Region

		Private WithEvents MySimpleAction As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace

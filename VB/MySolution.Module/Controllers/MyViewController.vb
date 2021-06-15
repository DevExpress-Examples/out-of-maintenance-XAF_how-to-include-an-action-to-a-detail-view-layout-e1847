﻿Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Layout
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Model.NodeGenerators

Namespace MySolution.Module.Controllers
	' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppViewControllertopic.
	Partial Public Class MyViewController
		Inherits ViewController

		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			' Target required Views (via the TargetXXX properties) and create their Actions.
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			' Perform various tasks depending on the target View.
		End Sub
		Protected Overrides Sub OnViewControlsCreated()
			MyBase.OnViewControlsCreated()
			' Access and customize the target View control.
		End Sub
		Protected Overrides Sub OnDeactivated()
			' Unsubscribe from previously subscribed events and release other references and resources.
			MyBase.OnDeactivated()
		End Sub

		Private Sub MySimpleAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles MySimpleAction.Execute
			Throw New UserFriendlyException("Action from Detail View was executed!")
		End Sub
	End Class
End Namespace

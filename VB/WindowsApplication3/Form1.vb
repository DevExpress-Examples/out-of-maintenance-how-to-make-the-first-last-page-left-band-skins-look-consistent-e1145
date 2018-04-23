Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim s As Skin = DevExpress.Skins.CommonSkins.GetSkin(wizardControl1.LookAndFeel)
			wizardControl1.Image = s(DevExpress.Skins.CommonSkins.SkinGroupPanelCaptionLeft).Image.GetImages().Images(0)
		End Sub
	End Class
End Namespace
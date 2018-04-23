' Developer Express Code Central Example:
' How to implement the basic idea of the Microsoft Word "Format Painter" feature for RichEditControl
' 
' This example demonstrates how to copy the characters and paragraphs properties
' and apply formatting to the selected text. Try the Format Painter button on the
' ribbon Home tab.
' 
' To obtain the selected text range, the
' RichEditDocument.Document.Selection property is used. The characters and
' paragraphs properties are obtained in the BarCheckItem.CheckedChanged event
' handler. Then, they are stored in the CharacterPropertiesObject and
' ParagraphPropertiesObject object containers.
' 
' In order to change the current
' RichEditControl cursor, a MouseCursorCalculator descendant is implemented. Check
' the custom MouseCursorCalculator class Calculate method for clarification.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5223


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Reflection


Namespace DXApplication9
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
			InitSkinGallery()
			InitializeRichEditControl()
			ribbonControl.SelectedPage = homeRibbonPage1
			Dim path As String = "DemoDoc.docx"

		   richEditControl.LoadDocument(path,DocumentFormat.OpenXml)
		End Sub

		Private Sub richEditControl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles richEditControl.MouseUp
			If barCheckItem1.Checked Then
				ApplyFormatToSelectedText()
				barCheckItem1.Checked = False
			End If
		End Sub


		Private Sub InitSkinGallery()
			SkinHelper.InitSkinGallery(rgbiSkins, True)
		End Sub
		Private Sub InitializeRichEditControl()
			AddHandler richEditControl.StartHeaderFooterEditing, AddressOf richEditControl_StartHeaderFooterEditing
			AddHandler richEditControl.SelectionChanged, AddressOf richEditControl_SelectionChanged
			AddHandler richEditControl.FinishHeaderFooterEditing, AddressOf richEditControl_FinishHeaderFooterEditing
		End Sub

		Private Sub richEditControl_StartHeaderFooterEditing(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.HeaderFooterEditingEventArgs)
			headerFooterToolsRibbonPageCategory1.Visible = True
			ribbonControl.SelectedPage = headerFooterToolsDesignRibbonPage1
		End Sub
		Private Sub richEditControl_FinishHeaderFooterEditing(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.HeaderFooterEditingEventArgs)
			headerFooterToolsRibbonPageCategory1.Visible = False
		End Sub
		Private Sub richEditControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable()
			floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected
		End Sub



		Private Sub CopyObject(ByVal o As Object, ByVal targetObject As Object, ByVal t As Type)
			Dim properties() As PropertyInfo = t.GetProperties()
			For Each pi As PropertyInfo In properties
				If pi.CanWrite Then
					pi.SetValue(targetObject, pi.GetValue(o, Nothing), Nothing)
				End If

			Next pi

		End Sub

		Private sourceCharactersProperties As CharacterPropertiesObject = Nothing
		Private sourceParagraphProperties As ParagraphPropertiesObject = Nothing
		Private Sub CopyFormatOfSelectedText()
			Dim selection As DocumentRange = richEditControl.Document.Selection
			Dim subDocument As SubDocument = selection.BeginUpdateDocument()
			Dim charactersProperties As DevExpress.XtraRichEdit.API.Native.CharacterProperties = subDocument.BeginUpdateCharacters(selection)
			Dim paragraphProperties As DevExpress.XtraRichEdit.API.Native.ParagraphProperties = subDocument.BeginUpdateParagraphs(selection)

			If charactersProperties IsNot Nothing Then
				sourceCharactersProperties = New CharacterPropertiesObject()
				CopyObject(charactersProperties, sourceCharactersProperties, GetType(CharacterPropertiesBase))
			End If

			If paragraphProperties IsNot Nothing Then
				sourceParagraphProperties = New ParagraphPropertiesObject()
				CopyObject(paragraphProperties, sourceParagraphProperties, GetType(ParagraphPropertiesBase))

			End If

			subDocument.EndUpdateParagraphs(paragraphProperties)
			subDocument.EndUpdateCharacters(charactersProperties)
			selection.EndUpdateDocument(subDocument)
		End Sub
		Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barCheckItem1.CheckedChanged
			If barCheckItem1.Checked Then
				CopyFormatOfSelectedText()
				richEditControl.FormatCalculatorEnabled = True
			Else
				richEditControl.FormatCalculatorEnabled = False
			End If

		End Sub

		Private Sub ApplyFormatToSelectedText()
			Dim currentSelection As DocumentRange = richEditControl.Document.Selection
			richEditControl.BeginUpdate()
			Dim targetSubDocument As SubDocument = currentSelection.BeginUpdateDocument()

			Dim targetCharactersProperties As DevExpress.XtraRichEdit.API.Native.CharacterProperties = targetSubDocument.BeginUpdateCharacters(currentSelection)

			If sourceCharactersProperties IsNot Nothing Then
				CopyObject(sourceCharactersProperties, targetCharactersProperties, GetType(CharacterPropertiesBase))
				sourceCharactersProperties = Nothing
			End If

			targetSubDocument.EndUpdateCharacters(targetCharactersProperties)

			Dim targetParagraphProperties As DevExpress.XtraRichEdit.API.Native.ParagraphProperties = targetSubDocument.BeginUpdateParagraphs(currentSelection)

			If sourceParagraphProperties IsNot Nothing Then

				CopyObject(sourceParagraphProperties, targetParagraphProperties, GetType(ParagraphPropertiesBase))
				sourceParagraphProperties = Nothing
			End If

			targetSubDocument.EndUpdateParagraphs(targetParagraphProperties)
			currentSelection.EndUpdateDocument(targetSubDocument)
			richEditControl.EndUpdate()
		End Sub



	End Class

End Namespace
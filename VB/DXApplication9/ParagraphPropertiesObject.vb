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
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraRichEdit.API.Native

Namespace DXApplication9
	Public Class ParagraphPropertiesObject
        Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties

		Public Sub New()

		End Sub

        Public Property Style() As DevExpress.XtraRichEdit.API.Native.ParagraphStyle Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.Style

        Public Function BeginUpdateTabs(ByVal onlyOwnTabs As Boolean) As TabInfoCollection Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.BeginUpdateTabs
            Throw New NotImplementedException()
        End Function

        Public Sub EndUpdateTabs(ByVal tabs As TabInfoCollection) Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.EndUpdateTabs
            Throw New NotImplementedException()
        End Sub

        Public Property Alignment() As DevExpress.XtraRichEdit.API.Native.ParagraphAlignment? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.Alignment

        Public Property BackColor() As Color? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.BackColor

        Public Property ContextualSpacing() As Boolean? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.ContextualSpacing

        Public Property FirstLineIndent() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.FirstLineIndent

        Public Property FirstLineIndentType() As DevExpress.XtraRichEdit.API.Native.ParagraphFirstLineIndent? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.FirstLineIndentType

        Public Property KeepLinesTogether() As Boolean? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.KeepLinesTogether

        Public Property LeftIndent() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.LeftIndent

        Public Property LineSpacing() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.LineSpacing

        Public Property OutlineLevel() As Integer? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.OutlineLevel

        Public Property PageBreakBefore() As Boolean? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.PageBreakBefore

        Public Sub Reset() Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.Reset
            Throw New NotImplementedException()
        End Sub
        Public Sub Reset(ByVal prop As ParagraphPropertiesMask) Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.Reset
            Throw New NotImplementedException()
        End Sub
        Public Property RightIndent() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.RightIndent

        Public Property SpacingAfter() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.SpacingAfter

        Public Property SpacingBefore() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.SpacingBefore

        Public Property SuppressHyphenation() As Boolean? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.SuppressHyphenation

        Public Property SuppressLineNumbers() As Boolean? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.SuppressLineNumbers

        Private _LineSpacingMultiplier? As Single
        Public Property LineSpacingMultiplier() As Single? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.LineSpacingMultiplier
            Get
                Return _LineSpacingMultiplier
            End Get
            Set(ByVal value As Single?)
                If LineSpacingType IsNot Nothing AndAlso LineSpacingType = ParagraphLineSpacing.Multiple Then
                    _LineSpacingMultiplier = value
                End If
            End Set
        End Property

		Private privateLineSpacingType? As DevExpress.XtraRichEdit.API.Native.ParagraphLineSpacing
        Public Property LineSpacingType() As DevExpress.XtraRichEdit.API.Native.ParagraphLineSpacing? Implements DevExpress.XtraRichEdit.API.Native.ParagraphProperties.LineSpacingType
            Get
                Return privateLineSpacingType
            End Get
            Set(ByVal value As DevExpress.XtraRichEdit.API.Native.ParagraphLineSpacing?)
                privateLineSpacingType = value
            End Set
        End Property

		
	End Class


End Namespace

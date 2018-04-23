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
Imports DevExpress.XtraRichEdit.Model

Namespace DXApplication9
	Public Class CharacterPropertiesObject
        Implements DevExpress.XtraRichEdit.API.Native.CharacterProperties

		Public Sub New()

		End Sub

        Public Property AllCaps() As Boolean? Implements CharacterPropertiesBase.AllCaps

        Public Property BackColor() As Color? Implements CharacterPropertiesBase.BackColor

        Public Property Bold() As Boolean? Implements CharacterPropertiesBase.Bold

        Public Property FontName() As String Implements CharacterPropertiesBase.FontName

        Public Property FontSize() As Single? Implements CharacterPropertiesBase.FontSize

        Public Property ForeColor() As Color? Implements CharacterPropertiesBase.ForeColor

        Public Property Hidden() As Boolean? Implements CharacterPropertiesBase.Hidden

        Public Property Italic() As Boolean? Implements CharacterPropertiesBase.Italic

        Public Property Language() As LangInfo? Implements CharacterPropertiesBase.Language

        Public Property NoProof() As Boolean? Implements CharacterPropertiesBase.NoProof

        Public Sub Reset() Implements CharacterPropertiesBase.Reset
            Throw New NotImplementedException()
        End Sub
        Public Sub Reset(ByVal prop As CharacterPropertiesMask) Implements CharacterPropertiesBase.Reset
            Throw New NotImplementedException()
        End Sub


        Private privateStrikeout? As DevExpress.XtraRichEdit.API.Native.StrikeoutType
        Public Property Strikeout() As DevExpress.XtraRichEdit.API.Native.StrikeoutType? Implements CharacterPropertiesBase.Strikeout
            Get
                Return privateStrikeout
            End Get
            Set(ByVal value As DevExpress.XtraRichEdit.API.Native.StrikeoutType?)
                privateStrikeout = value
            End Set
        End Property

		Private _Superscript? As Boolean
        Private _Subscript? As Boolean
        Public Property Subscript() As Boolean? Implements CharacterPropertiesBase.Subscript
            Get
                Return _Subscript
            End Get
            Set(ByVal value As Boolean?)
                If (Not Convert.ToBoolean(_Superscript)) Then
                    _Subscript = value
                End If
            End Set
        End Property

        Public Property Superscript() As Boolean? Implements CharacterPropertiesBase.Superscript
            Get
                Return _Superscript
            End Get
            Set(ByVal value As Boolean?)
                If (Not Convert.ToBoolean(_Subscript)) Then
                    _Superscript = value
                End If
            End Set
        End Property

        Public Property Underline() As DevExpress.XtraRichEdit.API.Native.UnderlineType? Implements CharacterPropertiesBase.Underline

        Public Property UnderlineColor() As Color? Implements CharacterPropertiesBase.UnderlineColor

        Public Property Style() As DevExpress.XtraRichEdit.API.Native.CharacterStyle Implements DevExpress.XtraRichEdit.API.Native.CharacterProperties.Style
    End Class
End Namespace

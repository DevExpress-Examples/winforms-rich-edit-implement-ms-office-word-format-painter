# Rich Text Editor for WinForms - How to Implement the Basic Idea of the MS Office Word "Format Painter"

This example demonstrates how to copy the character and paragraph properties and apply formatting to the selected text. Try the Format Painter button on the ribbon Home tab.

## Implementation Details

Use the [Document.Selection](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.Selection) property to obtain the selected text range. The [CharacterPropertiesBase.Assign](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.CharacterPropertiesBase.Assign(DevExpress.XtraRichEdit.API.Native.CharacterPropertiesBase)) and [ParagraphPropertiesBase.Assign](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.ParagraphPropertiesBase.Assign(DevExpress.XtraRichEdit.API.Native.ParagraphPropertiesBase)) methods copy character and paragraph format options.</p>

A `DevExpress.XtraRichEdit.Mouse.MouseCursorCalculator` implementation is used to manage the RichEditControl cursor.

## Files to Review

* [Form1.cs](./CS/DXApplication9/Form1.cs) (VB: [Form1.vb](./VB/DXApplication9/Form1.vb))
* [MyRichEditControl.cs](./CS/DXApplication9/MyRichEditControl.cs) (VB: [MyRichEditControl.vb](./VB/DXApplication9/MyRichEditControl.vb))

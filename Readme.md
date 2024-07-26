<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610546/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5223)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Rich Text Editor for WinForms - How to Implement the Basic Idea of the MS Office Word "Format Painter"

This example demonstrates how to copy the character and paragraph properties and apply formatting to the selected text. Try the Format Painter button on the ribbon Home tab.

## Implementation Details

Use the [Document.Selection](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.Selection) property to obtain the selected text range. The [CharacterPropertiesBase.Assign](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.CharacterPropertiesBase.Assign(DevExpress.XtraRichEdit.API.Native.CharacterPropertiesBase)) and [ParagraphPropertiesBase.Assign](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.ParagraphPropertiesBase.Assign(DevExpress.XtraRichEdit.API.Native.ParagraphPropertiesBase)) methods copy character and paragraph format options.</p>

A `DevExpress.XtraRichEdit.Mouse.MouseCursorCalculator` implementation is used to manage the RichEditControl cursor.

## Files to Review

* [Form1.cs](./CS/DXApplication9/Form1.cs) (VB: [Form1.vb](./VB/DXApplication9/Form1.vb))
* [MyRichEditControl.cs](./CS/DXApplication9/MyRichEditControl.cs) (VB: [MyRichEditControl.vb](./VB/DXApplication9/MyRichEditControl.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-rich-edit-implement-ms-office-word-format-painter&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-rich-edit-implement-ms-office-word-format-painter&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

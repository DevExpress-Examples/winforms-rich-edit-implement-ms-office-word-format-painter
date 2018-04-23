# How to implement the basic idea of the MS Office Word "Format Painter" for RichEditControl


<p>This example demonstrates how to copy the characters and paragraphs properties and apply formatting to the selected text. Try the Format Painter button on the ribbon Home tab. </p>


<h3>Description</h3>

<p>To obtain the selected text range, the RichEditDocument.Document.Selection property is used. The characters and paragraphs properties are obtained in the BarCheckItem.CheckedChanged event handler. Then, they are stored in the CharacterPropertiesObject and ParagraphPropertiesObject object containers.</p>
<br>
<p>In order to change the current RichEditControl cursor, a MouseCursorCalculator descendant is implemented. Check the custom MouseCursorCalculator class Calculate method for clarification.</p>

<br/>



// Developer Express Code Central Example:
// How to implement the basic idea of the Microsoft Word "Format Painter" feature for RichEditControl
// 
// This example demonstrates how to copy the characters and paragraphs properties
// and apply formatting to the selected text. Try the Format Painter button on the
// ribbon Home tab.
// 
// To obtain the selected text range, the
// RichEditDocument.Document.Selection property is used. The characters and
// paragraphs properties are obtained in the BarCheckItem.CheckedChanged event
// handler. Then, they are stored in the CharacterPropertiesObject and
// ParagraphPropertiesObject object containers.
// 
// In order to change the current
// RichEditControl cursor, a MouseCursorCalculator descendant is implemented. Check
// the custom MouseCursorCalculator class Calculate method for clarification.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5223

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraRichEdit.API.Native;

namespace DXApplication9
{
    public class ParagraphPropertiesObject : DevExpress.XtraRichEdit.API.Native.ParagraphProperties
    {

        public ParagraphPropertiesObject()
        {

        }

        public DevExpress.XtraRichEdit.API.Native.ParagraphStyle Style { get; set; }

        public TabInfoCollection BeginUpdateTabs(bool onlyOwnTabs)
        {
            throw new NotImplementedException();
        }

        public void EndUpdateTabs(TabInfoCollection tabs)
        {
            throw new NotImplementedException();
        }

        public DevExpress.XtraRichEdit.API.Native.ParagraphAlignment? Alignment { get; set; }

        public Color? BackColor { get; set; }

        public bool? ContextualSpacing { get; set; }
        
        public float? FirstLineIndent { get; set; }
        
        public DevExpress.XtraRichEdit.API.Native.ParagraphFirstLineIndent? FirstLineIndentType { get; set; }

        public bool? KeepLinesTogether { get; set; }

        public float? LeftIndent { get; set; }
        public float? LineSpacing { get;set;}

        private float? _LineSpacingMultiplier;
        public float? LineSpacingMultiplier {
            get {
                return _LineSpacingMultiplier;
            }
            set {
                if(LineSpacingType != null && LineSpacingType == ParagraphLineSpacing.Multiple)
                    _LineSpacingMultiplier = value;
            }
        }

        public DevExpress.XtraRichEdit.API.Native.ParagraphLineSpacing? LineSpacingType { get;set;}

        public int? OutlineLevel { get; set; }

        public bool? PageBreakBefore { get; set; }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        public void Reset(ParagraphPropertiesMask prop) {
            throw new NotImplementedException();
        }
        public float? RightIndent { get; set; }

        public float? SpacingAfter { get; set; }

        public float? SpacingBefore { get; set; }

        public bool? SuppressHyphenation { get; set; }

        public bool? SuppressLineNumbers { get; set; }
    }

   
}

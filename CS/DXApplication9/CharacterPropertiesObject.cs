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
using DevExpress.XtraRichEdit.Model;

namespace DXApplication9
{
    public class CharacterPropertiesObject : DevExpress.XtraRichEdit.API.Native.CharacterProperties
    {

        public CharacterPropertiesObject()
        {

        }

        public bool? AllCaps { get; set; }

        public Color? BackColor { get; set; }

        public bool? Bold { get; set; }

        public string FontName { get; set; }

        public float? FontSize { get; set; }

        public Color? ForeColor { get; set; }

        public bool? Hidden { get; set; }

        public bool? Italic { get; set; }

        public LangInfo? Language { get; set; }

        public bool? NoProof { get; set; }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        public void Reset(CharacterPropertiesMask prop) {
            throw new NotImplementedException();
        }

        public DevExpress.XtraRichEdit.API.Native.StrikeoutType? Strikeout { get; set; }

        private bool? _Superscript;
        private bool? _Subscript;
        public bool? Subscript {
            get {
                return _Subscript;
            }
            set {
                if(!Convert.ToBoolean(_Superscript))
                    _Subscript = value;
            }
        }

        public bool? Superscript {
            get {
                return _Superscript;
            }
            set {
                if(!Convert.ToBoolean(_Subscript))
                    _Superscript = value;
            }
        }

        public DevExpress.XtraRichEdit.API.Native.UnderlineType? Underline { get; set; }

        public Color? UnderlineColor { get; set; }

        public DevExpress.XtraRichEdit.API.Native.CharacterStyle Style { get; set; }




     
    }
}

﻿// Developer Express Code Central Example:
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
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace DXApplication9
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run(new Form1());
        }
    }
}
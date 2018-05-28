﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital.Helper
{
   public class ComponentsSetting
    {
        public void TextBoxDefaultSetting(TextBox textBox, string text)
        {
            textBox.ForeColor = Color.DimGray;
            textBox.Text = text;
        }

        public void TextBoxEnterSetting(TextBox textBox)
        {
            textBox.Text = String.Empty;
            textBox.ForeColor = Color.Black;
        }

    }
}

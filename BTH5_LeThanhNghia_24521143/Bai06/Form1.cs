using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        InstalledFontCollection fonts;
        private Dictionary<string, Font> fontCache;
        public Form1()
        {
            InitializeComponent();
            fonts = new InstalledFontCollection();
            fontCache = new Dictionary<string, Font>();
            lsbFontFamily.Items.Clear();
            lsbFontFamily.ItemHeight = 35;

            // Them item cho lsbfontFamily
            foreach (System.Drawing.FontFamily font in fonts.Families)
            {
                string fontName = font.Name;
                lsbFontFamily.Items.Add(fontName);
            }
        }

        private void lsbFontFamily_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // lsb ko co font nao thi return
            string fontName = lsbFontFamily.Items[e.Index].ToString();
            Font fontToDraw;
            if (!fontCache.TryGetValue(fontName, out fontToDraw)) // Ko co thi ve
            {
                try
                {
                    fontToDraw = new Font(fontName, 16);
                    fontCache[fontName] = fontToDraw;
                }
                catch (Exception ex)
                {
                    fontToDraw = e.Font;
                }
            }
            e.DrawBackground();
            e.Graphics.DrawString(fontName, fontToDraw, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top);
            e.DrawFocusRectangle();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var font in fontCache.Values)
            {
                font.Dispose();
            }
            fontCache.Clear();
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        InstalledFontCollection fonts;
        ColorDialog colorDlg;
        public Form1()
        {
            InitializeComponent();
            fonts = new InstalledFontCollection();
            colorDlg = new ColorDialog();
            cbFont.Items.Clear();

            foreach(System.Drawing.FontFamily font in fonts.Families)
            {
                cbFont.Items.Add(font.Name);
            }
            // Gan font mac dinh cho cbFont
            if (cbFont.Items.Count > 0)
            {
                cbFont.SelectedIndex = 0;
            }
        }

        private void chbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBold.Checked)
            {
                rtbText.Font = new Font(rtbText.Font, rtbText.Font.Style | FontStyle.Bold);
            }
            else
            {
                rtbText.Font = new Font(rtbText.Font, rtbText.Font.Style & ~FontStyle.Bold);
            }
        }

        private void chbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chbItalic.Checked)
            {
                rtbText.Font = new Font(rtbText.Font, rtbText.Font.Style | FontStyle.Italic);
            }
            else
            {
                rtbText.Font = new Font(rtbText.Font, rtbText.Font.Style & ~FontStyle.Italic);
            }
        }

        private void chbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUnderline.Checked)
            {
                rtbText.Font = new Font(rtbText.Font, rtbText.Font.Style | FontStyle.Underline);
            }
            else
            {
                rtbText.Font = new Font(rtbText.Font, rtbText.Font.Style & ~FontStyle.Underline);
            }
        }

        private void cbFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Co it nhat 1 item
            string fontName = cbFont.Items[e.Index].ToString();
            e.DrawBackground(); // Ve nen cho item

            try
            {
                using (Font fontToDraw = new Font(fontName, e.Font.Size))
                {
                    e.Graphics.DrawString(
                        fontName,
                        fontToDraw,
                        new SolidBrush(e.ForeColor), // Màu chữ
                        e.Bounds.Left,
                        e.Bounds.Top);
                }
            }
            catch
            { // Ko tim thay font thi ve bang font mac dinh
                e.Graphics.DrawString(
                    fontName,
                    e.Font,
                    new SolidBrush(e.ForeColor),
                    e.Bounds.Left,
                    e.Bounds.Top);
            }
            e.DrawFocusRectangle(); // Ve vung focus cho item
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFont.SelectedIndex > -1) // Co item duoc chon
            {
                string fontName = cbFont.SelectedItem.ToString();
                try
                {   // Doi font, giu nguyen size va style
                    rtbText.Font = new Font(fontName, rtbText.Font.Size, rtbText.Font.Style);
                }
                catch(Exception ex) // Neu co loi
                {
                    MessageBox.Show("Xay ra loi khi doi font: " + ex.Message);
                }
            }
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSize.SelectedIndex > -1)
            {
                float newSize;
                if (float.TryParse(cbSize.Text, out newSize) && newSize > 0)
                {
                    try
                    {
                        rtbText.Font = new Font(rtbText.Font.FontFamily, newSize, rtbText.Font.Style);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Xay ra loi", ex.Message);
                    }
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDlg.Color;
                rtbText.ForeColor = colorDlg.Color;
            }
        }

        #region Align Text
        private void rbtnLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLeft.Checked)
            {
                rtbText.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void rbtnCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCenter.Checked)
            {
                rtbText.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void rbtnRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRight.Checked)
            {
                rtbText.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
        #endregion
    }
}

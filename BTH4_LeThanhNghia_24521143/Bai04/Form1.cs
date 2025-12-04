using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        // Biến dùng để theo dõi đường dẫn tệp tin
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ban đầu cho form
            LoadSystemFonts(); // Load font
            LoadFontSizes(); // Load font size
            SetDefaultFormat(); // Load định dạng ban đầu
        }

        private void LoadSystemFonts()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }
        }

        private void LoadFontSizes()
        {
            float[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (float size in sizes)
            {
                cbFontSize.Items.Add(size.ToString());
            }
        }
        private void SetDefaultFormat()
        {
            cbFont.Text = "Tahoma";
            cbFontSize.Text = "14";

            rtbInput.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        // Hàm tạo file mởi
        private void NewFile(object sender, EventArgs e)
        {
            rtbInput.Clear();
            currentFilePath = string.Empty;
            SetDefaultFormat();
        }
        // Hàm mở file
        private void OpenFile(object sender, EventArgs e) 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp Văn Bản (RTF)|*.rtf|Tệp Văn Bản (TXT)|*.txt";
                openFileDialog.Title = "Chọn tệp văn bản để mở";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string extension = Path.GetExtension(openFileDialog.FileName).ToLower();

                        if (extension == ".rtf")
                        {
                            rtbInput.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        }
                        else if (extension == ".txt")
                        {
                            rtbInput.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }

                        currentFilePath = openFileDialog.FileName;
                        UpdateFormatControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi mở tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Hàm lưu file
        private void SaveFile(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    saveFileDialog.Title = "Lưu tệp văn bản";
                    saveFileDialog.DefaultExt = "rtf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            rtbInput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                            currentFilePath = saveFileDialog.FileName;
                            MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    rtbInput.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm xử lí Bold, Italic, Underline

        private void Bold_Click(object sender, EventArgs e) { ToggleFontStyle(FontStyle.Bold); }
        private void Italic_Click(object sender, EventArgs e) { ToggleFontStyle(FontStyle.Italic); }
        private void Underline_Click(object sender, EventArgs e) { ToggleFontStyle(FontStyle.Underline); }

        private void ToggleFontStyle(FontStyle style)
        {
            Font currentFont = rtbInput.SelectionFont ?? rtbInput.Font;
            FontStyle newStyle = currentFont.Style;

            // Kiểm tra và thay đổi Style
            if (currentFont.Style.HasFlag(style))
            {
                newStyle &= ~style;
            }
            else
            {
                newStyle |= style;
            }
            rtbInput.SelectionFont = new Font(currentFont, newStyle);
            UpdateFormatControls(); // Cập nhật trạng thái nút sau khi thay đổi
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e) { ApplyFormat(); }
        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e) { ApplyFormat(); }
        private void rtbInput_SelectionChanged(object sender, EventArgs e) { UpdateFormatControls(); }


        private void ApplyFormat()
        {
            string fontName = cbFont.Text;
            float fontSize;

            if (!float.TryParse(cbFontSize.Text, out fontSize))
            {
                fontSize = rtbInput.SelectionFont?.Size ?? rtbInput.Font.Size;
            }

            Font selectionFont = rtbInput.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = rtbInput.Font;
            }

            FontStyle currentStyle = selectionFont.Style;

            try
            {
                Font newFont = new Font(fontName, fontSize, currentStyle);
                rtbInput.SelectionFont = newFont;
                UpdateFormatControls();
            }
            catch
            {
                // Bỏ qua nếu không hợp lệ
            }
        }
        // Hàm mở hộp thoại chỉnh sửa format cho văn bản
        private void mtsFormat_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDlg = new FontDialog())
            {
                fontDlg.Font = rtbInput.SelectionFont ?? rtbInput.Font;
                fontDlg.ShowColor = true;

                if (fontDlg.ShowDialog() == DialogResult.OK)
                {
                    rtbInput.SelectionFont = fontDlg.Font;
                    rtbInput.SelectionColor = fontDlg.Color;
                    UpdateFormatControls();
                }
            }
        }

        private void UpdateFormatControls()
        {
            Font currentFont = rtbInput.SelectionFont ?? rtbInput.Font;
            float roundedSize = (float)Math.Round(currentFont.Size); // Làm tròn size

            if (cbFont.Items.Contains(currentFont.Name))
            {
                cbFont.Text = currentFont.Name;
            }

            cbFontSize.Text = roundedSize.ToString();
        }
    }
}
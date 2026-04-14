using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OOPlab21s
{
    public partial class blank : Form
    {
        public string DocName = "";
        public bool IsSaved = false;

        public blank()
        {
            InitializeComponent();
            sbTime.Text = DateTime.Now.ToLongTimeString();
            sbTime.ToolTipText = DateTime.Today.ToLongDateString();
        }


        public void Open(string openFileName)
        {
            if (string.IsNullOrEmpty(openFileName)) return;

            string ext = Path.GetExtension(openFileName).ToLower();
            if (ext == ".rtf")
            {
                richTextBox1.LoadFile(openFileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.LoadFile(openFileName, RichTextBoxStreamType.PlainText);
            }
            DocName = openFileName;
        }

        public void Save(string saveFileName)
        {
            if (string.IsNullOrEmpty(saveFileName)) return;

            string ext = Path.GetExtension(saveFileName).ToLower();
            if (ext == ".rtf")
            {
                richTextBox1.SaveFile(saveFileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.SaveFile(saveFileName, RichTextBoxStreamType.PlainText);
            }
            DocName = saveFileName;
        }

        public void Cut()
        {
            richTextBox1.Cut();
        }

        public void Copy()
        {
            richTextBox1.Copy();
        }

        public void PasteText()
        {
            richTextBox1.Paste();
        }

        public void SelectAllText()
        {
            richTextBox1.SelectAll();
        }

        public void Delete()
        {
            richTextBox1.SelectedText = "";
        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAllText();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sbAmount.Text = "Кількість символів: " + richTextBox1.Text.Length.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sbTime.Text = DateTime.Now.ToLongTimeString();
            sbTime.ToolTipText = DateTime.Today.ToLongDateString();
        }

        private void blank_Load(object sender, EventArgs e)
        {

        }
    }
}

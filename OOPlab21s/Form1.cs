using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OOPlab21s
{
    public partial class Form1 : Form
    {
        private int openDocuments = 0;
        private string currentLang = "uk";

        private static readonly Dictionary<string, Dictionary<string, string>> Locales = new()
        {
            ["uk"] = new Dictionary<string, string>
            {
                ["Title"] = "Блокнот",
                ["File"] = "Файл",
                ["New"] = "Новий",
                ["Open"] = "Відкрити",
                ["Save"] = "Зберегти",
                ["SaveAs"] = "Зберегти як...",
                ["Exit"] = "Вихід",
                ["Edit"] = "Редагування",
                ["Cut"] = "Вирізати",
                ["Copy"] = "Копіювати",
                ["Paste"] = "Вставити",
                ["Delete"] = "Видалити",
                ["SelectAll"] = "Виділити все",
                ["Find"] = "Знайти...",
                ["Format"] = "Формат",
                ["Font"] = "Шрифт...",
                ["Color"] = "Колір...",
                ["AlignLeft"] = "За лівим краєм",
                ["AlignCenter"] = "По центру",
                ["AlignRight"] = "За правим краєм",
                ["InsertImage"] = "Вставити зображення...",
                ["Window"] = "Вікно",
                ["Cascade"] = "Каскадом",
                ["TileH"] = "Плиткою горизонтально",
                ["TileV"] = "Плиткою вертикально",
                ["Arrange"] = "Впорядкувати значки",
                ["Language"] = "Мова",
                ["Help"] = "Довідка",
                ["About"] = "Про програму...",
                ["AboutText"] = "Блокнот C#\nВерсія 1.0\n\nЛабораторна робота",
                ["AboutTitle"] = "Про програму",
                ["Untitled"] = "Без назви",
                ["SymbolCount"] = "Кількість символів: ",
                ["FindLabel"] = "Знайти:",
                ["FindNext"] = "Знайти далі",
                ["MatchCase"] = "Враховувати регістр",
                ["WholeWord"] = "Слово цілком",
                ["Close"] = "Закрити",
                ["NotFound"] = "Текст не знайдено.",
                ["SearchTitle"] = "Пошук",
                ["NewDoc"] = "Новий документ",
                ["OpenFile"] = "Відкрити файл",
                ["SaveFile"] = "Зберегти файл",
                ["SyntaxHL"] = "Підсвічування синтаксису C#",
                ["InsertImg"] = "Вставити зображення",
                ["AlignLeftTip"] = "За лівим краєм",
                ["AlignCenterTip"] = "По центру",
                ["AlignRightTip"] = "За правим краєм",
                ["FilterOpen"] = "RTF файли (*.rtf)|*.rtf|Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*",
                ["FilterSave"] = "RTF файли (*.rtf)|*.rtf|Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*",
                ["FilterImage"] = "Зображення (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Усі файли (*.*)|*.*"
            },
            ["en"] = new Dictionary<string, string>
            {
                ["Title"] = "Notepad",
                ["File"] = "File",
                ["New"] = "New",
                ["Open"] = "Open",
                ["Save"] = "Save",
                ["SaveAs"] = "Save as...",
                ["Exit"] = "Exit",
                ["Edit"] = "Edit",
                ["Cut"] = "Cut",
                ["Copy"] = "Copy",
                ["Paste"] = "Paste",
                ["Delete"] = "Delete",
                ["SelectAll"] = "Select all",
                ["Find"] = "Find...",
                ["Format"] = "Format",
                ["Font"] = "Font...",
                ["Color"] = "Color...",
                ["AlignLeft"] = "Align left",
                ["AlignCenter"] = "Align center",
                ["AlignRight"] = "Align right",
                ["InsertImage"] = "Insert image...",
                ["Window"] = "Window",
                ["Cascade"] = "Cascade",
                ["TileH"] = "Tile horizontally",
                ["TileV"] = "Tile vertically",
                ["Arrange"] = "Arrange icons",
                ["Language"] = "Language",
                ["Help"] = "Help",
                ["About"] = "About...",
                ["AboutText"] = "Notepad C#\nVersion 1.0\n\nLab work",
                ["AboutTitle"] = "About",
                ["Untitled"] = "Untitled",
                ["SymbolCount"] = "Character count: ",
                ["FindLabel"] = "Find:",
                ["FindNext"] = "Find next",
                ["MatchCase"] = "Match case",
                ["WholeWord"] = "Whole word",
                ["Close"] = "Close",
                ["NotFound"] = "Text not found.",
                ["SearchTitle"] = "Search",
                ["NewDoc"] = "New document",
                ["OpenFile"] = "Open file",
                ["SaveFile"] = "Save file",
                ["SyntaxHL"] = "C# syntax highlighting",
                ["InsertImg"] = "Insert image",
                ["AlignLeftTip"] = "Align left",
                ["AlignCenterTip"] = "Align center",
                ["AlignRightTip"] = "Align right",
                ["FilterOpen"] = "RTF files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                ["FilterSave"] = "RTF files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                ["FilterImage"] = "Images (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files (*.*)|*.*"
            },
            ["de"] = new Dictionary<string, string>
            {
                ["Title"] = "Notizblock",
                ["File"] = "Datei",
                ["New"] = "Neu",
                ["Open"] = "Öffnen",
                ["Save"] = "Speichern",
                ["SaveAs"] = "Speichern unter...",
                ["Exit"] = "Beenden",
                ["Edit"] = "Bearbeiten",
                ["Cut"] = "Ausschneiden",
                ["Copy"] = "Kopieren",
                ["Paste"] = "Einfügen",
                ["Delete"] = "Löschen",
                ["SelectAll"] = "Alles auswählen",
                ["Find"] = "Suchen...",
                ["Format"] = "Format",
                ["Font"] = "Schriftart...",
                ["Color"] = "Farbe...",
                ["AlignLeft"] = "Linksbündig",
                ["AlignCenter"] = "Zentriert",
                ["AlignRight"] = "Rechtsbündig",
                ["InsertImage"] = "Bild einfügen...",
                ["Window"] = "Fenster",
                ["Cascade"] = "Kaskade",
                ["TileH"] = "Nebeneinander horizontal",
                ["TileV"] = "Nebeneinander vertikal",
                ["Arrange"] = "Symbole anordnen",
                ["Language"] = "Sprache",
                ["Help"] = "Hilfe",
                ["About"] = "Über...",
                ["AboutText"] = "Notizblock C#\nVersion 1.0\n\nLaborarbeit",
                ["AboutTitle"] = "Über das Programm",
                ["Untitled"] = "Unbenannt",
                ["SymbolCount"] = "Zeichenanzahl: ",
                ["FindLabel"] = "Suchen:",
                ["FindNext"] = "Weitersuchen",
                ["MatchCase"] = "Groß-/Kleinschreibung",
                ["WholeWord"] = "Ganzes Wort",
                ["Close"] = "Schließen",
                ["NotFound"] = "Text nicht gefunden.",
                ["SearchTitle"] = "Suche",
                ["NewDoc"] = "Neues Dokument",
                ["OpenFile"] = "Datei öffnen",
                ["SaveFile"] = "Datei speichern",
                ["SyntaxHL"] = "C# Syntaxhervorhebung",
                ["InsertImg"] = "Bild einfügen",
                ["AlignLeftTip"] = "Linksbündig",
                ["AlignCenterTip"] = "Zentriert",
                ["AlignRightTip"] = "Rechtsbündig",
                ["FilterOpen"] = "RTF-Dateien (*.rtf)|*.rtf|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*",
                ["FilterSave"] = "RTF-Dateien (*.rtf)|*.rtf|Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*",
                ["FilterImage"] = "Bilder (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Alle Dateien (*.*)|*.*"
            }
        };

        private static readonly string[] CSharpKeywords = new[]
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch",
            "char", "checked", "class", "const", "continue", "decimal", "default",
            "delegate", "do", "double", "else", "enum", "event", "explicit",
            "extern", "false", "finally", "fixed", "float", "for", "foreach",
            "goto", "if", "implicit", "in", "int", "interface", "internal", "is",
            "lock", "long", "namespace", "new", "null", "object", "operator",
            "out", "override", "params", "private", "protected", "public",
            "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
            "stackalloc", "static", "string", "struct", "switch", "this", "throw",
            "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe",
            "ushort", "using", "virtual", "void", "volatile", "while", "var",
            "async", "await", "record", "init", "required", "yield"
        };

        private static readonly string[] CSharpTypes = new[]
        {
            "String", "Int32", "Int64", "Boolean", "Double", "Float", "Decimal",
            "Object", "Byte", "Char", "Console", "Math", "Array", "List",
            "Dictionary", "Exception", "Task", "Action", "Func", "IEnumerable",
            "IList", "IDisposable", "EventArgs", "EventHandler"
        };

        public Form1()
        {
            InitializeComponent();
            mnuSave.Enabled = false;
            tbSave.Enabled = false;
        }

        private string L(string key)
        {
            if (Locales.ContainsKey(currentLang) && Locales[currentLang].ContainsKey(key))
                return Locales[currentLang][key];
            return Locales["uk"][key];
        }

        // Получаем активную дочернюю форму blank
        private blank GetActiveBlank()
        {
            return this.ActiveMdiChild as blank;
        }

        // Получаем RichTextBox из активной дочерней формы
        private RichTextBox GetActiveRichTextBox()
        {
            blank frm = GetActiveBlank();
            if (frm != null) return frm.richTextBox1;
            return null;
        }

        private void ApplyLanguage()
        {
            this.Text = L("Title");
            mnuFile.Text = L("File");
            mnuNew.Text = L("New");
            mnuOpen.Text = L("Open");
            mnuSave.Text = L("Save");
            mnuSaveAs.Text = L("SaveAs");
            mnuExit.Text = L("Exit");
            mnuEdit.Text = L("Edit");
            mnuCut.Text = L("Cut");
            mnuCopy.Text = L("Copy");
            mnuPaste.Text = L("Paste");
            mnuDelete.Text = L("Delete");
            mnuSelectAll.Text = L("SelectAll");
            mnuFind.Text = L("Find");
            mnuFormat.Text = L("Format");
            mnuFont.Text = L("Font");
            mnuColor.Text = L("Color");
            mnuAlignLeft.Text = L("AlignLeft");
            mnuAlignCenter.Text = L("AlignCenter");
            mnuAlignRight.Text = L("AlignRight");
            mnuInsertImage.Text = L("InsertImage");
            mnuWindow.Text = L("Window");
            mnuCascade.Text = L("Cascade");
            mnuTileHorizontal.Text = L("TileH");
            mnuTileVertical.Text = L("TileV");
            mnuArrangeIcons.Text = L("Arrange");
            mnuLanguage.Text = L("Language");
            mnuHelp.Text = L("Help");
            mnuAbout.Text = L("About");

            tbNew.Text = L("New");
            tbNew.ToolTipText = L("NewDoc");
            tbOpen.Text = L("Open");
            tbOpen.ToolTipText = L("OpenFile");
            tbSave.Text = L("Save");
            tbSave.ToolTipText = L("SaveFile");
            tbCut.Text = L("Cut");
            tbCut.ToolTipText = L("Cut");
            tbCopy.Text = L("Copy");
            tbCopy.ToolTipText = L("Copy");
            tbPaste.Text = L("Paste");
            tbPaste.ToolTipText = L("Paste");
            tbAlignLeft.ToolTipText = L("AlignLeftTip");
            tbAlignCenter.ToolTipText = L("AlignCenterTip");
            tbAlignRight.ToolTipText = L("AlignRightTip");
            tbInsertImage.ToolTipText = L("InsertImg");
            tbSyntaxHighlight.ToolTipText = L("SyntaxHL");

            lblFind.Text = L("FindLabel");
            btnFindNext.Text = L("FindNext");
            chkMatchCase.Text = L("MatchCase");
            chkWholeWord.Text = L("WholeWord");
            btnFindClose.Text = L("Close");

            openFileDialog1.Filter = L("FilterOpen");
            saveFileDialog1.Filter = L("FilterSave");
            openFileDialogImage.Filter = L("FilterImage");

            mnuLangUk.Checked = currentLang == "uk";
            mnuLangEn.Checked = currentLang == "en";
            mnuLangDe.Checked = currentLang == "de";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        // --- File menu ---

        private void mnuNew_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр формы blank
            blank frm = new blank();
            frm.DocName = L("Untitled") + " " + ++openDocuments;
            // Указываем, что родительским контейнером является эта главная форма
            frm.MdiParent = this;
            frm.Text = frm.DocName;
            // Показываем форму
            frm.Show();
            UpdateSaveState();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Создаем новый документ
                blank frm = new blank();
                // Вызываем метод Open формы blank
                frm.Open(openFileDialog1.FileName);
                // Указываем родительскую форму
                frm.MdiParent = this;
                // Присваиваем имя файла
                frm.DocName = openFileDialog1.FileName;
                frm.Text = Path.GetFileName(frm.DocName);
                // Показываем форму
                frm.Show();
                mnuSave.Enabled = true;
                tbSave.Enabled = true;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm == null) return;

            if (frm.DocName.StartsWith(L("Untitled")))
            {
                mnuSaveAs_Click(sender, e);
                return;
            }

            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm == null) return;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.Save(saveFileDialog1.FileName);
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = Path.GetFileName(frm.DocName);
                frm.IsSaved = true;
                mnuSave.Enabled = true;
                tbSave.Enabled = true;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Edit menu ---

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm != null) frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm != null) frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm != null) frm.PasteText();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm != null) frm.Delete();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = GetActiveBlank();
            if (frm != null) frm.SelectAllText();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            panelFind.Visible = true;
            txtFind.Focus();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb == null || string.IsNullOrEmpty(txtFind.Text)) return;

            RichTextBoxFinds options = RichTextBoxFinds.None;
            if (chkMatchCase.Checked) options |= RichTextBoxFinds.MatchCase;
            if (chkWholeWord.Checked) options |= RichTextBoxFinds.WholeWord;

            int start = rtb.SelectionStart + rtb.SelectionLength;
            int index = rtb.Find(txtFind.Text, start, options);

            if (index == -1)
            {
                index = rtb.Find(txtFind.Text, 0, options);
                if (index == -1)
                {
                    MessageBox.Show(L("NotFound"), L("SearchTitle"),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFindClose_Click(object sender, EventArgs e)
        {
            panelFind.Visible = false;
        }

        // --- Format menu ---

        private void mnuFont_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb == null) return;

            fontDialog1.ShowColor = true;
            fontDialog1.Font = rtb.SelectionFont ?? rtb.Font;
            fontDialog1.Color = rtb.SelectionColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fontDialog1.Font;
                rtb.SelectionColor = fontDialog1.Color;
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb == null) return;

            colorDialog1.Color = rtb.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionColor = colorDialog1.Color;
            }
        }

        private void mnuAlignLeft_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb != null) rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mnuAlignCenter_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb != null) rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mnuAlignRight_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb != null) rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mnuInsertImage_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb == null) return;

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialogImage.FileName);
                Clipboard.SetImage(img);
                rtb.Paste();
            }
        }

        // --- Window menu (MDI layout) ---

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        // --- Language menu ---

        private void mnuLangUk_Click(object sender, EventArgs e)
        {
            currentLang = "uk";
            ApplyLanguage();
        }

        private void mnuLangEn_Click(object sender, EventArgs e)
        {
            currentLang = "en";
            ApplyLanguage();
        }

        private void mnuLangDe_Click(object sender, EventArgs e)
        {
            currentLang = "de";
            ApplyLanguage();
        }

        // --- Help menu ---

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(L("AboutText"), L("AboutTitle"),
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Syntax highlighting ---

        private void tbSyntaxHighlight_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetActiveRichTextBox();
            if (rtb == null) return;

            if (tbSyntaxHighlight.Checked)
            {
                ApplySyntaxHighlighting(rtb);
            }
            else
            {
                ClearSyntaxHighlighting(rtb);
            }
        }

        private void ApplySyntaxHighlighting(RichTextBox rtb)
        {
            int selStart = rtb.SelectionStart;
            int selLength = rtb.SelectionLength;

            rtb.SuspendLayout();

            rtb.SelectAll();
            rtb.SelectionColor = Color.Black;
            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);

            string text = rtb.Text;

            MatchCollection singleLineComments = Regex.Matches(text, @"//[^\r\n]*");
            foreach (Match m in singleLineComments)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.FromArgb(0, 128, 0);
            }

            MatchCollection multiLineComments = Regex.Matches(text, @"/\*[\s\S]*?\*/");
            foreach (Match m in multiLineComments)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.FromArgb(0, 128, 0);
            }

            MatchCollection strings = Regex.Matches(text, @"""([^""\\]|\\.)*""");
            foreach (Match m in strings)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.FromArgb(163, 21, 21);
            }

            MatchCollection charLiterals = Regex.Matches(text, @"'([^'\\]|\\.)'");
            foreach (Match m in charLiterals)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.FromArgb(163, 21, 21);
            }

            foreach (string keyword in CSharpKeywords)
            {
                string pattern = @"\b" + keyword + @"\b";
                MatchCollection matches = Regex.Matches(text, pattern);
                foreach (Match m in matches)
                {
                    if (IsInsideCommentOrString(text, m.Index)) continue;
                    rtb.Select(m.Index, m.Length);
                    rtb.SelectionColor = Color.FromArgb(0, 0, 255);
                    rtb.SelectionFont = new Font(rtb.Font, FontStyle.Bold);
                }
            }

            foreach (string type in CSharpTypes)
            {
                string pattern = @"\b" + type + @"\b";
                MatchCollection matches = Regex.Matches(text, pattern);
                foreach (Match m in matches)
                {
                    if (IsInsideCommentOrString(text, m.Index)) continue;
                    rtb.Select(m.Index, m.Length);
                    rtb.SelectionColor = Color.FromArgb(43, 145, 175);
                }
            }

            MatchCollection numbers = Regex.Matches(text, @"\b\d+(\.\d+)?\b");
            foreach (Match m in numbers)
            {
                if (IsInsideCommentOrString(text, m.Index)) continue;
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.FromArgb(9, 134, 88);
            }

            MatchCollection preprocessor = Regex.Matches(text, @"^\s*#\w+[^\r\n]*", RegexOptions.Multiline);
            foreach (Match m in preprocessor)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = Color.FromArgb(128, 128, 128);
            }

            rtb.SelectionStart = selStart;
            rtb.SelectionLength = selLength;
            rtb.SelectionColor = Color.Black;
            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);
            rtb.ResumeLayout();
        }

        private bool IsInsideCommentOrString(string text, int position)
        {
            bool inSingleLineComment = false;
            bool inMultiLineComment = false;
            bool inString = false;

            for (int i = 0; i < position && i < text.Length; i++)
            {
                if (inSingleLineComment)
                {
                    if (text[i] == '\n') inSingleLineComment = false;
                    continue;
                }
                if (inMultiLineComment)
                {
                    if (i + 1 < text.Length && text[i] == '*' && text[i + 1] == '/')
                    {
                        inMultiLineComment = false;
                        i++;
                    }
                    continue;
                }
                if (inString)
                {
                    if (text[i] == '\\') { i++; continue; }
                    if (text[i] == '"') inString = false;
                    continue;
                }

                if (i + 1 < text.Length && text[i] == '/' && text[i + 1] == '/')
                {
                    inSingleLineComment = true;
                    i++;
                    continue;
                }
                if (i + 1 < text.Length && text[i] == '/' && text[i + 1] == '*')
                {
                    inMultiLineComment = true;
                    i++;
                    continue;
                }
                if (text[i] == '"')
                {
                    inString = true;
                    continue;
                }
            }

            return inSingleLineComment || inMultiLineComment || inString;
        }

        private void ClearSyntaxHighlighting(RichTextBox rtb)
        {
            int selStart = rtb.SelectionStart;
            int selLength = rtb.SelectionLength;

            rtb.SuspendLayout();
            rtb.SelectAll();
            rtb.SelectionColor = Color.Black;
            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);
            rtb.SelectionStart = selStart;
            rtb.SelectionLength = selLength;
            rtb.ResumeLayout();
        }

        private void UpdateSaveState()
        {
            bool hasChild = this.ActiveMdiChild != null;
            mnuSave.Enabled = hasChild;
            tbSave.Enabled = hasChild;
            mnuSaveAs.Enabled = hasChild;
        }
    }
}
